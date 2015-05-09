<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8" %>
<%@ include file="../../layout/header.jspf" %>
<%@ include file="../../layout/nav.jspf" %>
<c:set var="pagination" value="${volumeFilter.pagination }"/>
<script type="text/javascript">
    /* <![CDATA[ */
    var currentPage = <c:out value='${pagination.currentPage}'/>;
    var numPages = <c:out value='${pagination.numPages}'/>;

    function goToNextPages() {
        if(currentPage == numPages){
            return;
        }
        goToPage(Math.min(numPages, currentPage));
    }

    function goToPage(page) {
        var form = document.forms['volumeFilter'];
        var url = contextPath + '/volume/list/json'
        var volumeFilter = {
            page : page+1,
            username : form.username.value,
            title : form.title.value,
            from : form.from.value,
            to : form.to.value
        };

        $.postJSON(url, volumeFilter, function(data){
            var volumes = data.volumes;
            var volumeFilter = data.volumeFilter;
            numPages = volumeFilter.pagination.numPages;
            currentPage+=1;
            makeSliderList(volumes);
        });
    }
    /* ]]> */

    function makeSliderList(volumes){
        var list = $('.volumeListArticle>.list');
        var html = '';
        for(var i=0; i<volumes.length; i++){
            var volume = volumes[i];
            html+='<li class="one" data-pn="'+volume.pn+'">';
            html+='<figure>';
            html+=' <div class="thumbnailSlider" id="slider_'+volume.pn+'">';
            html+='     <a href="#" class="sliderControl controlNext" data-pn="'+volume.pn+'">&gt;</a>';
            html+='     <a href="#" class="sliderControl controlPrev" data-pn="'+volume.pn+'">&lt;</a>';
            html+='     <ul>';
            html+='         <li><img src="'+contextPath+'/data/thumbnail/'+volume.thumbnailPnList[3]+'"/></li>';
            for(var j=0; j<volume.thumbnailPnList.length-1; j++){
                var thumbnailPn = volume.thumbnailPnList[j];
                html+='     <li><img src="'+contextPath+'/data/thumbnail/'+thumbnailPn+'"/></li>';
            }
            html+='     </ul>';
            html+=' </div>'

            html+=' <figcaption>';
            html+='     <a href="'+contextPath+'/volume/pn/'+volume.pn+'" class="name">'+volume.title+'</a> <a href="'+contextPath+'/volume/page/'+volume.pn+'" class="volumeUpdateBtn">수정</a><br/>';
            html+='     <span class="number">'+volume.width+' x '+volume.height+' x '+volume.depth+'</span> <span class="date">'+volume.inputDate+'</span>';
            html+=' </figcaption>';
            html+='</figure>';
            html+='</li>';
        }
        list.append(html);

        sliderEventListener();

    }

    var slider = {
        width : null,
        height : null,
        count : null,
        ulWidth : null
    }

    $(function(){

        slider.width = $('.thumbnailSlider ul li').width();
        slider.height = $('.thumbnailSlider ul li').height();
        slider.count = $('.thumbnailSlider ul li').length;
        slider.ulWidth = slider.count * slider.width;

        sliderEventListener();

        $('#volumeFilterBtn').on('click', function(){
            $('.volumeListArticle>.list').html('');
            currentPage = 0;
            goToPage(currentPage);
        });
    });

    function sliderEventListener(){

        $('.thumbnailSlider').css({ width: slider.width, height: slider.height });

        $('.thumbnailSlider ul').css({ width: slider.ulWidth, marginLeft: -slider.width });

        $('a.controlPrev').off('click').on('click', function () {
            var volumePn = $(this).attr('data-pn');
            moveLeft(volumePn);
        });

        $('a.controlNext').off('click').on('click', function () {
            var volumePn = $(this).attr('data-pn');
            moveRight(volumePn);
        });

        $('.thumbnailSlider').off('mouseover').on('mouseover', function(){
            $(this).find('a.sliderControl').show();
        });

        $('.thumbnailSlider').off('mouseout').on('mouseout', function(){
            $(this).find('a.sliderControl').hide();
        });

    };


    function moveLeft(volumePn) {
        $('#slider_'+volumePn+' ul').animate({
            left: + slider.width
        }, 200, function () {
            $('#slider_'+volumePn+' ul li:last-child').prependTo('#slider_'+volumePn+' ul');
            $('#slider_'+volumePn+' ul').css('left', '');
        });
    };

    function moveRight(volumePn) {
        $('#slider_'+volumePn+' ul').animate({
            left: - slider.width
        }, 200, function () {
            $('#slider_'+volumePn+' ul li:first-child').appendTo('#slider_'+volumePn+' ul');
            $('#slider_'+volumePn+' ul').css('left', '');
        });
    };


</script>

<style type="text/css">


    .thumbnailSlider {
        position: relative;
        overflow: hidden;
    }

    .thumbnailSlider ul {
        position: relative;
        margin: 0;
        padding: 0;
        height: 200px;
        list-style: none;
    }

    .thumbnailSlider ul li {
        position: relative;
        display: block;
        float: left;
        margin: 0;
        padding: 0;
        width: 300px;
        height: 300px;
        background: #ccc;
        text-align: center;
        line-height: 300px;
    }

    .thumbnailSlider ul li img{
        width: 100%;
    }

    a.controlPrev, a.controlNext {
        position: absolute;
        top: 40%;
        z-index: 999;
        display: block;
        padding: 4% 3%;
        width: auto;
        height: auto;
        background: #2a2a2a;
        color: #fff;
        text-decoration: none;
        font-weight: 600;
        font-size: 18px;
        opacity: 0.8;
        cursor: pointer;
    }

    a.controlPrev:hover, a.controlNext:hover {
        opacity: 1;
        -webkit-transition: all 0.2s ease;
    }

    a.controlPrev {
        border-radius: 0 2px 2px 0;
    }

    a.controlNext {
        right: 0;
        border-radius: 2px 0 0 2px;
    }

    a.sliderControl{
        display: none;
    }

</style>

<section class="layoutContentSectionWrap">
    
    <section class="layoutContentSection">

        <form:form commandName="volumeFilter" htmlEscape="true" cssClass="volumeFilterForm">
            <form:hidden path="username"/>
            <ul>
                <li class="searchIcon">
                    <img src="${cp}/resources/image/icon/search.png"/>
                </li>
                <li>
                    <form:input path="title" cssClass="search" placeholder="검색"/>
                </li>
                <li class="dateIcon">
                    <img src="${cp}/resources/image/icon/calendar.png"/>
                </li>
                <li>
                    <form:input path="from" readonly="true" cssClass="date"/>
                </li>
                <li>
                    <form:input path="to" readonly="true" cssClass="date"/>
                </li>
                <li>
                    <button type="button" id="volumeFilterBtn" class="orangeButton">조회</button>
                </li>
            </ul>
            
        </form:form>
        
        <article class="volumeListArticle">
            
            <ul class="list">
                <c:forEach items="${volumes}" var="volume" varStatus="loop">
                <li class="one" data-pn="<c:out value="${volume.pn}"/>">
                    <figure>
                        <div class="thumbnailSlider" id="slider_<c:out value="${volume.pn}"/>">
                            <a href="#" class="sliderControl controlNext" data-pn="<c:out value="${volume.pn}"/>">&gt;</a>
                            <a href="#" class="sliderControl controlPrev" data-pn="<c:out value="${volume.pn}"/>">&lt;</a>
                            <ul>
                                <li><img src="${cp}/data/thumbnail/${volume.thumbnailPnList[3]}" /></li>
                                <c:forEach items="${volume.thumbnailPnList}" var="thumbnailPn" varStatus="loop" end="2">
                                    <li><img src="${cp}/data/thumbnail/${thumbnailPn}" /></li>
                                </c:forEach>
                            </ul>
                        </div>
                        
                        <figcaption>
                            <a href="${cp}/volume/pn/${volume.pn}" class="name"><c:out value="${volume.title}"/></a> <a href="${cp}/volume/page/${volume.pn}" class="volumeUpdateBtn">수정</a><br/>
                            <span class="number"><c:out value="${volume.width}"/> x <c:out value="${volume.height}"/> x <c:out value="${volume.depth}"/></span> <span class="date"><c:out value="${volume.inputDate}"/></span>
                        </figcaption>
                    </figure>
                </li>
                </c:forEach>
            </ul>
            
        </article>
            
    </section>
    
</section>

<%@ include file="../../layout/footer.jspf" %>