package com.nornenjs.android;

/**
 * Created by pi on 15. 3. 20.
 */
public interface MyEventListener {
    void RotationEvent(float rotationX, float rotationY);
    void TranslationEvent(float translationX, float translationY);
    void PinchZoomEvent(float div);
    void GetPng();
    void BackToPreview();
    void OtfEvent(int start, int middle1, int middle2, int end, int flag);
    void BrightnessEvent(float brightness);
}
