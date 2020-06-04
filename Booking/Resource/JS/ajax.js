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
                $('.posstandarroom').append('<div class="col mb-4 "><div class="rcard card shadow"> <div class="text-center"><img src="Resource/image/bed.svg" style="width: 100px;height: 100px";" class="card-img-top" alt="..."></div> <div class="card-body"> <h5 class="card-title">Mã phòng: <span id="idRoom">'+arritem.idRoom+'</span></h5> <h5 class="card-title">Loại: <span id="rType">'+arritem.rType+'</span></h5> <h5 class="card-title">Giá: <span id="rPrice">'+arritem.rPrice+'</span> VND</h5> </div> </div></div>');
            }
            if(idRoom.startsWith("L")==false && idRoom.startsWith("T")==false && rStatus.startsWith("T")==true)
            {
                $('.posviproom').append('<div class="col mb-4 "><div class="rcard card shadow"> <div class="text-center"><img src="Resource/image/bed.svg" style="width: 100px;height: 100px";" class="card-img-top" alt="..."></div> <div class="card-body"> <h5 class="card-title">Mã phòng: <span id="idRoom">'+arritem.idRoom+'</span></h5> <h5 class="card-title">Loại: <span id="rType">'+arritem.rType+'</span></h5> <h5 class="card-title">Giá: <span id="rPrice">'+arritem.rPrice+'</span> VND</h5> </div> </div></div>');
            }
            if(idRoom.startsWith("T")==false && idRoom.startsWith("V")==false && rStatus.startsWith("T")==true)
            {
                $('.posluxuryroom').append('<div class="col mb-4 "><div class="rcard card shadow"> <div class="text-center"><img src="Resource/image/bed.svg" style="width: 100px;height: 100px";" class="card-img-top" alt="..."></div> <div class="card-body"> <h5 class="card-title">Mã phòng: <span id="idRoom">'+arritem.idRoom+'</span></h5> <h5 class="card-title">Loại: <span id="rType">'+arritem.rType+'</span></h5> <h5 class="card-title">Giá: <span id="rPrice">'+arritem.rPrice+'</span> VND</h5> </div> </div></div>');
            }
        });
    })
    .always(function () { $(".loading").hide(); });

    $('.posstandarroom').on('click', '.rcard', function (){
        $('#inputIdRoomS').val($( this ).find( '#idRoom' ).text());
        $('#inputRoomTypeS').val($( this ).find( '#rType' ).text());
        $('#inputRoomPriceS').val($( this ).find( '#rPrice' ).text());
    });
    $('.posviproom').on('click', '.rcard', function (){
        $('#inputIdRoomV').val($( this ).find( '#idRoom' ).text());
        $('#inputRoomTypeV').val($( this ).find( '#rType' ).text());
        $('#inputRoomPriceV').val($( this ).find( '#rPrice' ).text());
    });
    $('.posluxuryroom').on('click', '.rcard', function (){
        $('#inputIdRoomL').val($( this ).find( '#idRoom' ).text());
        $('#inputRoomTypeL').val($( this ).find( '#rType' ).text());
        $('#inputRoomPriceL').val($( this ).find( '#rPrice' ).text());
    });

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