$(document).ready(function () {
    $('.loading').show();
    $.getJSON("https://localhost:44373/api/room")
    .done(function (data) { 
        var _room = data;
        console.log(_room)
        _room.forEach(function (arritem) {
            var idRoom = arritem.idRoom
            var rStatus = arritem.rStatus
            if(idRoom.startsWith("L")==false && idRoom.startsWith("V")==false && rStatus.startsWith("T")==true || rStatus.startsWith("Đ")==true)
            {
                $('.posstandarroom').append('<div class="col mb-4 "><div class="rcard card shadow" data-toggle="tooltip" data-placement="bottom" title=""> <div class="text-center"><img src="Resource/image/bed.svg" style="width: 100px;height: 100px";" class="card-img-top" alt="..."></div> <div class="card-body"> <h5 class="card-title">Mã phòng: <span id="idRoom">'+arritem.idRoom+'</span></h5> <h5 class="card-title">Loại: <span id="rType">'+arritem.rType+'</span></h5> <h5 class="card-title">Giá: <span id="rPrice">'+arritem.rPrice+'</span> VND</h5> <h5 class="card-title">Trạng thái: <span id="rStatus">'+arritem.rStatus+'</span></h5> </div> </div></div>');
            }
            if(idRoom.startsWith("L")==false && idRoom.startsWith("T")==false && rStatus.startsWith("T")==true || rStatus.startsWith("Đ")==true)
            {
                $('.posviproom').append('<div class="col mb-4 "><div class="rcard card shadow"> <div class="text-center"><img src="Resource/image/bed.svg" style="width: 100px;height: 100px";" class="card-img-top" alt="..."></div> <div class="card-body"> <h5 class="card-title">Mã phòng: <span id="idRoom">'+arritem.idRoom+'</span></h5> <h5 class="card-title">Loại: <span id="rType">'+arritem.rType+'</span></h5> <h5 class="card-title">Giá: <span id="rPrice">'+arritem.rPrice+'</span> VND</h5> <h5 class="card-title">Trạng thái: <span id="rStatus">'+arritem.rStatus+'</span></h5> </div> </div></div>');
            }
            if(idRoom.startsWith("T")==false && idRoom.startsWith("V")==false && rStatus.startsWith("T")==true || rStatus.startsWith("Đ")==true)
            {
                $('.posluxuryroom').append('<div class="col mb-4 "><div class="rcard card shadow"> <div class="text-center"><img src="Resource/image/bed.svg" style="width: 100px;height: 100px";" class="card-img-top" alt="..."></div> <div class="card-body"> <h5 class="card-title">Mã phòng: <span id="idRoom">'+arritem.idRoom+'</span></h5> <h5 class="card-title">Loại: <span id="rType">'+arritem.rType+'</span></h5> <h5 class="card-title">Giá: <span id="rPrice">'+arritem.rPrice+'</span> VND</h5> <h5 class="card-title">Trạng thái: <span id="rStatus">'+arritem.rStatus+'</span></h5> </div> </div></div>');
            }
        });
    })
    .always(function () { $(".loading").hide(); });

/* #region  btn add to booking */
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
/* #endregion */
    $.getJSON("https://localhost:44373/api/room",
        function (data) {
            var _room2 = data;
            console.log(_room2[9].tbl_roombook[0].startDate.substring(0,10))
        }
    );
/* #region  Frontend */
    $(function () {
        $('[data-toggle="tooltip"]').tooltip()
    })
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
    $('#startdayStandar').datepicker({
        uiLibrary: 'bootstrap4'
    });
    $('#enddayStandar').datepicker({
        uiLibrary: 'bootstrap4'
    });
    $('#startdayVIP').datepicker({
        uiLibrary: 'bootstrap4'
    });
    $('#enddayVIP').datepicker({
        uiLibrary: 'bootstrap4'
    });
    $('#startdayLuxury').datepicker({
        uiLibrary: 'bootstrap4'
    });
    $('#enddayLuxury').datepicker({
        uiLibrary: 'bootstrap4'
    });
    $('#startdayfilter').datepicker({
        uiLibrary: 'bootstrap4'
    });
    $('#enddayfilter').datepicker({
        uiLibrary: 'bootstrap4'
    });
/* #endregion */
});