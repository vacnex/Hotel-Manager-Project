$(document).ready(function () {
    $('.loading').show();
    $.getJSON("https://localhost:44373/api/room")
    .done(function (data) { 
        var _room = data;
        console.log(_room)
        _room.forEach(function (arritem) {
            var idRoom = arritem.idRoom
            var rStatus = arritem.rStatus
            if(idRoom.startsWith("L")==false && idRoom.startsWith("V")==false && rStatus.startsWith("T")==true)
            {
                $('.posstandarroom').append('<div class="chkex col mb-4"><div class="card"> <div class="text-center"><img src="Resource/image/bed.svg" style="width: 100px;height: 100px";" class="card-img-top" alt="..."></div> <div class="card-body"> <h5 class="card-title">Mã phòng: '+arritem.idRoom+'</h5> <h5 class="card-title">Loại: '+arritem.rType+'</h5> <h5 class="card-title">Giá: '+arritem.rPrice+' VND</h5> </div> </div></div>');
            }
            if(idRoom.startsWith("L")==false && idRoom.startsWith("T")==false && rStatus.startsWith("T")==true)
            {
                $('.posviproom').append('<div class="chkex col mb-4"><div class="card"> <div class="text-center"><img src="Resource/image/bed.svg" style="width: 100px;height: 100px";" class="card-img-top" alt="..."></div> <div class="card-body"> <h5 class="card-title">Mã phòng: '+arritem.idRoom+'</h5> <h5 class="card-title">Loại: '+arritem.rType+'</h5> <h5 class="card-title">Giá: '+arritem.rPrice+' VND</h5> </div> </div></div>');
            }
            if(idRoom.startsWith("T")==false && idRoom.startsWith("V")==false && rStatus.startsWith("T")==true)
            {
                $('.posluxuryroom').append('<div class="chkex col mb-4"><div class="card"> <div class="text-center"><img src="Resource/image/bed.svg" style="width: 100px;height: 100px";" class="card-img-top" alt="..."></div> <div class="card-body"> <h5 class="card-title">Mã phòng: '+arritem.idRoom+'</h5> <h5 class="card-title">Loại: '+arritem.rType+'</h5> <h5 class="card-title">Giá: '+arritem.rPrice+' VND</h5> </div> </div></div>');
            }
        });
    })
    .always(function () { $(".loading").hide(); });

    /* #region  Frontend */
    $('.card').hover(function () {
        $(this).animate({
            marginTop : "-=1%",
            marginBottom :"1%",
        },150);
    }, function () {
        $(this).animate({
            marginTop : "0%",
            marginBottom :"0%",
        },150);
    });

    $('#startday').datepicker({
        uiLibrary: 'bootstrap4'
    });
    $('#endday').datepicker({
        uiLibrary: 'bootstrap4'
    });
    $('#startday1').datepicker({
        uiLibrary: 'bootstrap4'
    });
    $('#endday1').datepicker({
        uiLibrary: 'bootstrap4'
    });
    $('#startday2').datepicker({
        uiLibrary: 'bootstrap4'
    });
    $('#endday2').datepicker({
        uiLibrary: 'bootstrap4'
    });
/* #endregion */
});