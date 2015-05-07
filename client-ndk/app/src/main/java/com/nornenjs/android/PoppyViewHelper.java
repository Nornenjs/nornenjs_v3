package com.nornenjs.android;

import android.app.Activity;
import android.view.*;
import android.view.ViewGroup.LayoutParams;
import android.widget.AbsListView;
import android.widget.AbsListView.OnScrollListener;
import android.widget.EditText;
import android.widget.FrameLayout;
import android.widget.ListView;
import com.nineoldandroids.view.ViewPropertyAnimator;


public class PoppyViewHelper {

	public enum PoppyViewPosition {
		TOP, BOTTOM
	};

	private static final int SCROLL_TO_TOP = - 1;

	private static final int SCROLL_TO_BOTTOM = 1;

	private static final int SCROLL_DIRECTION_CHANGE_THRESHOLD = 5;

	private Activity mActivity;

	private LayoutInflater mLayoutInflater;

	private View mPoppyView;

	private EditText editView;

	private int mScrollDirection = 0;

	private int mPoppyViewHeight = - 1;

	private PoppyViewPosition mPoppyViewPosition;

	public PoppyViewHelper(Activity activity, PoppyViewPosition position) {
		mActivity = activity;
		mLayoutInflater = LayoutInflater.from(activity);
		mPoppyViewPosition = position;
	}

	public PoppyViewHelper(Activity activity) {
		this(activity, PoppyViewPosition.TOP);
	}


	//for searchbar
		public View createPoppyViewOnListView(int editViewId, int listViewId, int poppyViewResId, OnScrollListener onScrollListener) {
		editView = (EditText)mActivity.findViewById(editViewId);
		final ListView listView = (ListView)mActivity.findViewById(listViewId);

		if(listView.getHeaderViewsCount() != 0) {
			throw new IllegalArgumentException("use createPoppyViewOnListView with headerResId parameter");
		}
		if(listView.getFooterViewsCount() != 0) {
			throw new IllegalArgumentException("poppyview library doesn't support listview with footer");
		}

		mPoppyView = mLayoutInflater.inflate(poppyViewResId, null);
		initPoppyViewOnListView(editView, listView, onScrollListener);

		return mPoppyView;
	}

	public View createPoppyViewOnListView(int editViewId,int listViewId, int poppyViewResId) {
		return createPoppyViewOnListView(editViewId,listViewId, poppyViewResId, null);
	}

	private void setPoppyViewOnView(View Editview, View Listview) {
		LayoutParams lp = Editview.getLayoutParams();
		ViewParent parent = Editview.getParent();
		ViewGroup group = (ViewGroup)parent;
		int index = group.indexOfChild(Editview);

		final FrameLayout newContainer = new FrameLayout(mActivity);//FrameLayout
		//newContainer.setLayoutDirection(View.LAYOUT_DIRECTION_INHERIT);

		group.removeView(Editview);
		group.removeView(Listview);

		group.addView(newContainer, index, lp);

		newContainer.addView(Listview);
		newContainer.addView(Editview);

		final FrameLayout.LayoutParams layoutParams = new FrameLayout.LayoutParams(LayoutParams.MATCH_PARENT, LayoutParams.WRAP_CONTENT);
		layoutParams.gravity = mPoppyViewPosition == PoppyViewPosition.BOTTOM ? Gravity.BOTTOM : Gravity.TOP;
		newContainer.addView(mPoppyView, layoutParams);

		group.invalidate();
	}

	private void onScrollPositionChanged(int oldScrollPosition, int newScrollPosition) {
		int newScrollDirection;
		int ScrollDirection = newScrollPosition;
		System.out.println(oldScrollPosition + " ->" + newScrollPosition);

		if(newScrollPosition < oldScrollPosition) {
			newScrollDirection = SCROLL_TO_BOTTOM;
		} else {
			newScrollDirection = SCROLL_TO_TOP;
		}
		if(newScrollDirection != mScrollDirection) {
			mScrollDirection = newScrollDirection;
			translateYPoppyView(ScrollDirection);
		}
	}

	private void translateYPoppyView(int ScrollLocation) {
		final int a = ScrollLocation;
		System.out.println("in translateYPoppyView : " + ScrollLocation);
		mPoppyView.post(new Runnable() {

			//@Override
			public void run() {
				if (mPoppyViewHeight <= 0) {
					mPoppyViewHeight = mPoppyView.getHeight();
				}

				int translationY = 0;
				switch (mPoppyViewPosition) {
					case BOTTOM:
						translationY = mScrollDirection == SCROLL_TO_TOP ? 0 : mPoppyViewHeight;
						break;
					case TOP:
						translationY = mScrollDirection == SCROLL_TO_TOP ? -mPoppyViewHeight : 0;
						break;
				}

				ViewPropertyAnimator.animate(mPoppyView).setDuration(300).translationY(translationY);
			}
		});
	}

	private void translateYSearchView() {
		mPoppyView.post(new Runnable() {

			//@Override
			public void run() {
				if(mPoppyViewHeight <= 0) {
					mPoppyViewHeight = mPoppyView.getHeight();
				}

				int translationY = 0;
				switch (mPoppyViewPosition) {
					case BOTTOM:
						translationY = mScrollDirection == SCROLL_TO_TOP ? 0 : mPoppyViewHeight;
						break;
					case TOP:
						translationY = mScrollDirection == SCROLL_TO_TOP ? -mPoppyViewHeight : 0;
						break;
				}

				ViewPropertyAnimator.animate(mPoppyView).setDuration(300).translationY(translationY);
			}
		});
	}

	// for ListView

	private void initPoppyViewOnListView(EditText editView, ListView listView, final OnScrollListener onScrollListener) {
		setPoppyViewOnView(editView, listView);
		//setPoppyViewOnView(listView);
		listView.setOnScrollListener(new OnScrollListener() {

			int mScrollPosition;

			//@Override
			public void onScroll(AbsListView view, int firstVisibleItem, int visibleItemCount, int totalItemCount) {
				if(onScrollListener != null) {
					onScrollListener.onScroll(view, firstVisibleItem, visibleItemCount, totalItemCount);
				}
				View topChild = view.getChildAt(0);

				int newScrollPosition = 0;
				if(topChild == null) {
					newScrollPosition = 0;
				} else {
					newScrollPosition = - topChild.getTop() + view.getFirstVisiblePosition() * topChild.getHeight();
				}

				if(Math.abs(newScrollPosition - mScrollPosition) >= SCROLL_DIRECTION_CHANGE_THRESHOLD) {
					onScrollPositionChanged(mScrollPosition, newScrollPosition);
				}

				mScrollPosition = newScrollPosition;
			}

			//@Override
			public void onScrollStateChanged(AbsListView view, int scrollState) {
				if(onScrollListener != null) {
					onScrollListener.onScrollStateChanged(view, scrollState);
				}
			}
		});
	}
}
