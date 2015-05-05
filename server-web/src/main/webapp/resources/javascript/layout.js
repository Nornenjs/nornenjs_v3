function LayoutFunction(){
    this.isSignInFull = this.isSignInFull();
    this.isJoinFull = this.isJoinFull();
    this.isForgotFull  = this.isForgotFull();
    this.isNaigation = this.isNavigation();
    this.isRenderingPage = this.isRenderingPage();
    this.isRenderingBig = true;
};

LayoutFunction.prototype.isSignInFull = function(){
    return $('.layoutSignInArticle').html() != undefined;
};

LayoutFunction.prototype.signInResize = function(){
    var windowHeight = $(window).height();
    var articleHeight = $('.layoutSignInArticle').height();
    var margin = (windowHeight - articleHeight)/2;
    $('.layoutSignInArticle').css({
        'margin-top' : margin-30,
        'margin-bottom' : margin+30
    });
};

LayoutFunction.prototype.isJoinFull = function(){
    return $('.layoutJoinArticle').html() != undefined;
};

LayoutFunction.prototype.joinResize = function(){
    var windowHeight = $(window).height();
    var articleHeight = $('.layoutJoinArticle').height();
    var margin = (windowHeight - articleHeight)/2;
    $('.layoutJoinArticle').css({
        'margin-top' : margin-30,
        'margin-bottom' : margin+30
    });
};

LayoutFunction.prototype.isForgotFull = function(){
    return $('.layoutForgotArticle').html() != undefined;
};

LayoutFunction.prototype.forgotResize = function(){
    var windowHeight = $(window).height();
    var articleHeight = $('.layoutForgotArticle').height();
    var margin = (windowHeight - articleHeight)/2;
    $('.layoutForgotArticle').css({
        'margin-top' : margin-30,
        'margin-bottom' : margin+30
    });
};

LayoutFunction.prototype.isNavigation = function(){
    return $('.navigation').html() != undefined;
};

LayoutFunction.prototype.menuEventListener = function(){
    $('.menu>.title>a').off('click').on('click', function(){
        var menu = $(this).parents('ul.menu'),
            submenu = menu.find('ul.submenu');
        submenu.toggle('blind', { }, 500 );
    });
};

LayoutFunction.prototype.isRenderingPage = function(){
    return $('.volumeRenderingOne').html() != undefined;
};

LayoutFunction.prototype.renderingPageResize = function(){
    $('.layoutContentSection').css({
        'overflow-y' : 'hidden'
    });
    
    if(this.isRenderingBig) {
        var windowHeight = $(window).height(),
            height = windowHeight / 2 - 3;

        var windowWidth = $(window).width(),
            navWidth = $('.navigation').width(),
            width = (windowWidth - navWidth) / 2 - 3;

        $('.volumeRenderingOne').width(width).height(height);
        $('.volumeRenderingOne>img').width(height).height(height);
        $('.volumeRenderingOne>canvas').attr('width', height).attr('height', height);
    }else{
        var windowHeight = $(window).height(),
            height = windowHeight - 250;

        var windowWidth = $(window).width(),
            navWidth = $('.navigation').width(),
            width = windowWidth - navWidth - 4;

        $('#volumeRendering').width(width).height(height);
        $('#volumeRendering>img').width(height).height(height);
        $('#volumeRendering>canvas').attr('width', height).attr('height', height);

        $('.volumeRenderingOTF').width(width-20);
        $('.volumeRenderingOTF>svg').attr('width', width-20);
    }
};

LayoutFunction.prototype.expandEventListener = function(){
    if(this.isRenderingBig) {
        this.isRenderingBig = false;
        var windowHeight = $(window).height(),
            height = windowHeight - 250;

        var windowWidth = $(window).width(),
            navWidth = $('.navigation').width(),
            width = windowWidth - navWidth - 4;

        $('.volumeRenderingMpr').hide();
        $('.volumeRenderingOTF').show().width(width-20);
        $('.volumeRenderingOTF>svg').attr('width', width-20);
        
        $('#volumeRendering').removeClass('volumeRenderingOne').addClass('volumeRenderingBig').width(width).height(height);
        $('#volumeRendering>img').width(height).height(height);
        $('#volumeRendering>canvas').attr('width', height).attr('height', height);
        $('#renderingSizeBtn').removeClass('renderingExpandBtn').addClass('renderingReduceBtn');

    }else{
        this.isRenderingBig = true;
        var windowHeight = $(window).height(),
            height = windowHeight/2-3;

        var windowWidth = $(window).width(),
            navWidth = $('.navigation').width(),
            width = (windowWidth - navWidth)/2 - 3;
        
        $('.volumeRenderingMpr').show();
        $('.volumeRenderingOTF').hide();
        $('#volumeRendering').addClass('volumeRenderingOne').removeClass('volumeRenderingBig');
        $('#renderingSizeBtn').addClass('renderingExpandBtn').removeClass('renderingReduceBtn');
        
        $('.volumeRenderingOne').width(width).height(height);
        $('.volumeRenderingOne>img').width(height).height(height);
        $('.volumeRenderingOne>canvas').attr('width', height).attr('height', height);
    }
    socket.emit('webPng');
};

$(function(){
    var layoutFunction = new LayoutFunction();
    
    if(layoutFunction.isSignInFull) {
        layoutFunction.signInResize();
        $(window).resize(function () {
            layoutFunction.signInResize();
        });
    }

    if(layoutFunction.isJoinFull) {
        layoutFunction.joinResize();
        $(window).resize(function () {
            layoutFunction.joinResize();
        });
    }
    
    if(layoutFunction.isForgotFull){
        layoutFunction.forgotResize();
        $(window).resize(function(){
            layoutFunction.forgotResize();
        });
    }
    
    if(layoutFunction.isNaigation){
        layoutFunction.menuEventListener();
    }
    
    if(layoutFunction.isRenderingPage){
        layoutFunction.renderingPageResize();
        $(window).resize(function(){
            layoutFunction.renderingPageResize();
        });
    }
    

    $('#volumeFilter #from').datepicker({
        changeMonth: true,
        numberOfMonths: 1,
        dateFormat: 'yy-mm-dd',
        onClose: function( selectedDate ) {
            $('#volumeFilter #to').datepicker('option', 'minDate', selectedDate);
        },
        onSelect : function(){
        }
    });

    $('#volumeFilter #to').datepicker({
        changeMonth: true,
        numberOfMonths: 1,
        dateFormat : 'yy-mm-dd',
        onClose: function( selectedDate ) {
            $('#volumeFilter #from').datepicker('option', 'maxDate', selectedDate );
        },
        onSelect : function(){
        }
    });

    var volumeListSlider = $('.volumeListSlider').bxSlider({
        'pager' : false
    });

    $('.volumeListSlider').css({
        'max-height' : $('.volumeListSlider>li>img').height(),
        'border-top' : 0
    });

    $('.layoutContentSection').scroll( function() {
        var section = $('.layoutContentSection');
        if(section[0].scrollHeight - section.scrollTop() == section.outerHeight()) {
            for(var i=0; i<4; i++) {
                var one = $('<li>').addClass('one').append($('.volumeListArticle>.list>.one').html());
                $('.volumeListArticle>ul').append(one);
            }
        }
    });

    // ~ STEP 01 볼륨을 업로드한다.
    $('#dataUpload').uploadify({
        'buttonText' : '파일선택',
        'buttonClass' : 'volumeDataBtn',
        'fileTypeDesc' : 'Volume Data',
        'fileTypeExts' : '*.den; *.data',
        'swf': contextPath + '/resources/javascript/uploadify.swf',
        'uploader' : contextPath+'/data/upload',
        'onUploadStart' : function(){
            //console.log('On Upload Start');
        },
        'onUploadSuccess' : function(file, data, response){
            //console.log('On Upload Success');
            if(response){
                // ~ STEP 02 섬네일 생성 요청을 한다.
                var data = JSON.parse(data)
                $('#volume #volumeDataPn').val(data.pn);
                $('#volumeUploadBtn').html('<span class="success">파일업로드 : '+data.name+'</span>');

                var url = contextPath + '/data/thumbnail';
                var json = {
                    volumeDataPn : data.pn,
                    width : $('#width').val(),
                    height : $('#height').val(),
                    depth : $('#depth').val()
                }

                $.postJSON(url, json, function(result){
                    // ~ STEP 03 Thumbnail 이 모두 생성되었는지 폴링한다. 비교값은 result 랑 연동
                    var pollingFunc = function() {
                        var polling = contextPath + '/data/polling/' + data.pn;
                        console.log('polling')
                        $.getJSON(polling, function (list) {
                            if(list.length != result.thumbnailOptionList.length){
                                setTimeout(pollingFunc, 1000);
                            }else{
                                console.log(list);
                                $('#thumbnailMPRx').attr('src', contextPath+'/data/thumbnail/'+list[1]);
                                $('#thumbnailMPRy').attr('src', contextPath+'/data/thumbnail/'+list[2]);
                                $('#thumbnailMPRz').attr('src', contextPath+'/data/thumbnail/'+list[3]);
                                $('#thumbnailMPRvolume').attr('src', contextPath+'/data/thumbnail/'+list[0]);
                            }
                        });
                    }
                    setTimeout(pollingFunc, 1000);
                });
            }
        }
    });
    
    $('#renderingSizeBtn').off('click').on('click', function(){
        layoutFunction.expandEventListener();
    });


    // ~ Left OTF EVENT

    var isLeftTopCircle = false;
    var isLeftBottomCircle = false;
    var isLeftDashLine = false;
    var leftBeforeX;

    var otfOption = {
        transferStart : 65,
        transferMiddle1 : 80,
        transferMiddle2 : 100,
        transferEnd : 120
    };

    
    $('#otfLeftTopCircle').on('mousedown',function(event){
        isLeftTopCircle = true;
        leftBeforeX = event.pageX;
    });
    
    $('#otfLeftTopCircle').on('mousemove',function(event){
        var circle = event.target;
        if(isLeftTopCircle){
            if(event.pageX >= leftBeforeX){ // +
                var cx = Number(circle.getAttribute('cx'))+2;
                circle.setAttribute('cx', cx);
                $('#otfTopLine').attr('x1', cx);
                $('#otfLeftDashLine').attr('x2', cx);

                otfOption.transferMiddle1 = Math.round(cx/3);
                socket.emit('otfEvent', otfOption);
            } else{ // -
                var cx = Number(circle.getAttribute('cx'))-2;
                circle.setAttribute('cx', cx);
                $('#otfTopLine').attr('x1', cx);
                $('#otfLeftDashLine').attr('x2', cx);

                otfOption.transferMiddle1 = Math.round(cx/3);
                socket.emit('otfEvent', otfOption);
            }
        }
        leftBeforeX = event.pageX;
    });

    $('#otfLeftBottomCircle').on('mousedown',function(event){
        isLeftBottomCircle = true;otfOption.transferStart = Math.round(cx/3);
                socket.emit('otfL', otfOption)
        leftBeforeX = event.pageX;
    });
    
    $('#otfLeftBottomCircle').on('mousemove',function(event){
        var circle = event.target;
        if(isLeftBottomCircle){
            if(event.pageX >= leftBeforeX){ // +
                var cx = Number(circle.getAttribute('cx'))+2;
                circle.setAttribute('cx', cx);
                $('#otfLeftDashLine').attr('x1', cx);

                otfOption.transferStart = Math.round(cx/3);
                socket.emit('otfEvent', otfOption);
            } else{ // -
                var cx = Number(circle.getAttribute('cx'))-2;
                circle.setAttribute('cx', cx);
                $('#otfLeftDashLine').attr('x1', cx);

                otfOption.transferStart = Math.round(cx/3);
                socket.emit('otfEvent', otfOption);
            }
        }
        leftBeforeX = event.pageX;
    });

    $('#otfLeftDashLine').on('mousedown',function(event){
        isLeftDashLine = true;
        leftBeforeX = event.pageX;
    });

    $('#otfLeftDashLine').on('mousemove',function(event){

        if(isLeftDashLine){
            if(event.pageX >= leftBeforeX){ // +
                var cxTop = Number($('#otfLeftTopCircle').attr('cx'))+2;
                var cxBottom = Number($('#otfLeftBottomCircle').attr('cx'))+2

                $('#otfTopLine').attr('x1', cxTop);
                $('#otfLeftTopCircle').attr('cx', cxTop);
                $('#otfLeftBottomCircle').attr('cx', cxBottom);
                
                $('#otfLeftDashLine').attr('x1', cxBottom);
                $('#otfLeftDashLine').attr('x2', cxTop);


                otfOption.transferMiddle1 = Math.round(cxTop/3);
                otfOption.transferStart = Math.round(cxBottom/3);
                socket.emit('otfEvent', otfOption);
            } else{ // -
                var cxTop = Number($('#otfLeftTopCircle').attr('cx'))-2;
                var cxBottom = Number($('#otfLeftBottomCircle').attr('cx'))-2

                $('#otfTopLine').attr('x1', cxTop);
                $('#otfLeftTopCircle').attr('cx', cxTop);
                $('#otfLeftBottomCircle').attr('cx', cxBottom);

                $('#otfLeftDashLine').attr('x1', cxBottom);
                $('#otfLeftDashLine').attr('x2', cxTop);

                otfOption.transferMiddle1 = Math.round(cxTop/3);
                otfOption.transferStart = Math.round(cxBottom/3);
                socket.emit('otfEvent', otfOption);
            }
        }
        leftBeforeX = event.pageX;
    });

    // ~ RightEvent

    var isRightTopCircle = false;
    var isRightBottomCircle = false;
    var isRightDashLine = false;
    var rightBeforeX;

    $('#otfRightTopCircle').on('mousedown',function(event){
        isRightTopCircle = true;
        rightBeforeX = event.pageX;
    });

    $('#otfRightTopCircle').on('mousemove',function(event){
        var circle = event.target;
        if(isRightTopCircle){
            if(event.pageX >= beforeX){ // +
                var cx = Number(circle.getAttribute('cx'))+2;
                circle.setAttribute('cx', cx);
                $('#otfTopLine').attr('x2', cx);
                $('#otfRightDashLine').attr('x1', cx);

                otfOption.transferMiddle2 = Math.round(cx/3);
                socket.emit('otfEvent', otfOption);
            } else{ // -
                var cx = Number(circle.getAttribute('cx'))-2;
                circle.setAttribute('cx', cx);
                $('#otfTopLine').attr('x2', cx);
                $('#otfRightDashLine').attr('x1', cx);

                otfOption.transferMiddle2 = Math.round(cx/3);
                socket.emit('otfEvent', otfOption);
            }
        }
        beforeX = event.pageX;
    });

    $('#otfRightBottomCircle').on('mousedown',function(event){
        isRightBottomCircle = true;
        rightBeforeX = event.pageX;
    });

    $('#otfRightBottomCircle').on('mousemove',function(event){
        var circle = event.target;
        if(isRightBottomCircle){
            if(event.pageX >= beforeX){ // +
                var cx = Number(circle.getAttribute('cx'))+2;
                circle.setAttribute('cx', cx);
                $('#otfRightDashLine').attr('x2', cx);

                otfOption.transferEnd = Math.round(cx/3);
                socket.emit('otfEvent', otfOption);
            } else{ // -
                var cx = Number(circle.getAttribute('cx'))-2;
                circle.setAttribute('cx', cx);
                $('#otfRightDashLine').attr('x2', cx);

                otfOption.transferEnd = Math.round(cx/3);
                socket.emit('otfEvent', otfOption);
            }
        }
        beforeX = event.pageX;
    });

    $('#otfRightDashLine').on('mousedown',function(event){
        isRightDashLine = true;
        rightBeforeX = event.pageX;
    });

    $('#otfRightDashLine').on('mousemove',function(event){

        if(isRightDashLine){
            if(event.pageX >= rightBeforeX){ // +
                var cxTop = Number($('#otfRightTopCircle').attr('cx'))+2;
                var cxBottom = Number($('#otfRightBottomCircle').attr('cx'))+2

                $('#otfTopLine').attr('x2', cxTop);
                $('#otfRightTopCircle').attr('cx', cxTop);
                $('#otfRightBottomCircle').attr('cx', cxBottom);

                $('#otfRightDashLine').attr('x2', cxBottom);
                $('#otfRightDashLine').attr('x1', cxTop);

                otfOption.transferMiddle2 = Math.round(cxTop/3);
                otfOption.transferEnd = Math.round(cxBottom/3);
                socket.emit('otfEvent', otfOption);
            } else{ // -
                var cxTop = Number($('#otfRightTopCircle').attr('cx'))-2;
                var cxBottom = Number($('#otfRightBottomCircle').attr('cx'))-2

                $('#otfTopLine').attr('x2', cxTop);
                $('#otfRightTopCircle').attr('cx', cxTop);
                $('#otfRightBottomCircle').attr('cx', cxBottom);

                $('#otfRightDashLine').attr('x2', cxBottom);
                $('#otfRightDashLine').attr('x1', cxTop);
                otfOption.transferMiddle2 = Math.round(cxTop/3);
                otfOption.transferEnd = Math.round(cxBottom/3);
                socket.emit('otfEvent', otfOption);
            }
        }
        rightBeforeX = event.pageX;
    });

    
    $(window).on('mouseup', function(event){
        isLeftTopCircle = false;
        isLeftBottomCircle = false;
        isLeftDashLine = false;

        isRightTopCircle = false;
        isRightBottomCircle = false;
        isRightDashLine = false;
    })
    
});