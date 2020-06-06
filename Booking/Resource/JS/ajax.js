$(document).ready(function () {
    $('.loading').show();
    function datefm(date) { 
        return date.match(/([^T]+)/)[0].split("-").reverse().join("-")
    }
    $.getJSON("https://localhost:44373/api/room")
    .done(function (data) { 
        var _room = data;
        // console.log(_room)
        _room.forEach(function (arritem) {
            var idRoom = arritem.idRoom
            var rStatus = arritem.rStatus
            if(idRoom.startsWith("L")==false && idRoom.startsWith("V")==false)
            {
                if (rStatus.startsWith("Đ")==true || rStatus.startsWith("T")==true) {
                    if (arritem.tbl_roombook != 0) {
                        var _roomBookDate = arritem.tbl_roombook
                        var start,end
                        _roomBookDate.forEach(function (roombookarritem) {
                            start = roombookarritem.startDate.substring(0,10)
                            end = roombookarritem.endDate.substring(0,10)
                        });
                        $('.posstandarroom').append('<div class="col mb-4 "><div class="rcard card shadow" data-placement="bottom" title="Từ: '+datefm(start)+' Đến: '+datefm(end)+'"> <div class="text-center"><img src="Resource/image/bed.svg" style="width: 100px;height: 100px";" class="card-img-top" alt="..."></div> <div class="card-body"> <h5 class="card-title">Mã phòng: <span id="idRoom">'+arritem.idRoom+'</span></h5> <h5 class="card-title">Loại: <span id="rType">'+arritem.rType+'</span></h5> <h5 class="card-title">Giá: <span id="rPrice">'+arritem.rPrice+'</span> VND</h5> <h5 class="card-title">Trạng thái: <span id="rStatus">'+arritem.rStatus+'</span></h5> </div> </div></div>');
                    }
                    else{
                        $('.posstandarroom').append('<div class="col mb-4 "><div class="rcard card shadow"> <div class="text-center"><img src="Resource/image/bed.svg" style="width: 100px;height: 100px";" class="card-img-top" alt="..."></div> <div class="card-body"> <h5 class="card-title">Mã phòng: <span id="idRoom">'+arritem.idRoom+'</span></h5> <h5 class="card-title">Loại: <span id="rType">'+arritem.rType+'</span></h5> <h5 class="card-title">Giá: <span id="rPrice">'+arritem.rPrice+'</span> VND</h5> <h5 class="card-title">Trạng thái: <span id="rStatus">'+arritem.rStatus+'</span></h5> </div> </div></div>');
                    }
                }
            }
            if(idRoom.startsWith("L")==false && idRoom.startsWith("T")==false)
            {
                if (rStatus.startsWith("Đ")==true || rStatus.startsWith("T")==true) {
                    if (arritem.tbl_roombook != 0) {
                        var _roomBookDate = arritem.tbl_roombook
                        var start,end
                        _roomBookDate.forEach(function (roombookarritem) {
                            start = roombookarritem.startDate.substring(0,10)
                            end = roombookarritem.endDate.substring(0,10)
                        });
                        $('.posviproom').append('<div class="col mb-4 "><div class="rcard card shadow" data-placement="bottom" title="Từ: '+datefm(start)+' Đến: '+datefm(end)+'"> <div class="text-center"><img src="Resource/image/bed.svg" style="width: 100px;height: 100px";" class="card-img-top" alt="..."></div> <div class="card-body"> <h5 class="card-title">Mã phòng: <span id="idRoom">'+arritem.idRoom+'</span></h5> <h5 class="card-title">Loại: <span id="rType">'+arritem.rType+'</span></h5> <h5 class="card-title">Giá: <span id="rPrice">'+arritem.rPrice+'</span> VND</h5> <h5 class="card-title">Trạng thái: <span id="rStatus">'+arritem.rStatus+'</span></h5> </div> </div></div>');
                    } else {
                        $('.posviproom').append('<div class="col mb-4 "><div class="rcard card shadow"> <div class="text-center"><img src="Resource/image/bed.svg" style="width: 100px;height: 100px";" class="card-img-top" alt="..."></div> <div class="card-body"> <h5 class="card-title">Mã phòng: <span id="idRoom">'+arritem.idRoom+'</span></h5> <h5 class="card-title">Loại: <span id="rType">'+arritem.rType+'</span></h5> <h5 class="card-title">Giá: <span id="rPrice">'+arritem.rPrice+'</span> VND</h5> <h5 class="card-title">Trạng thái: <span id="rStatus">'+arritem.rStatus+'</span></h5> </div> </div></div>');
                    }
                }
            }
            if(idRoom.startsWith("T")==false && idRoom.startsWith("V")==false)
            {
                if (rStatus.startsWith("Đ")==true || rStatus.startsWith("T")==true) {
                    if (arritem.tbl_roombook != 0) {
                        var _roomBookDate = arritem.tbl_roombook
                        var start,end
                        _roomBookDate.forEach(function (roombookarritem) {
                            start = roombookarritem.startDate.substring(0,10)
                            end = roombookarritem.endDate.substring(0,10)
                        });
                        $('.posluxuryroom').append('<div class="col mb-4 "><div class="rcard card shadow" data-placement="bottom" title="Từ: '+datefm(start)+' Đến: '+datefm(end)+'"> <div class="text-center"><img src="Resource/image/bed.svg" style="width: 100px;height: 100px";" class="card-img-top" alt="..."></div> <div class="card-body"> <h5 class="card-title">Mã phòng: <span id="idRoom">'+arritem.idRoom+'</span></h5> <h5 class="card-title">Loại: <span id="rType">'+arritem.rType+'</span></h5> <h5 class="card-title">Giá: <span id="rPrice">'+arritem.rPrice+'</span> VND</h5> <h5 class="card-title">Trạng thái: <span id="rStatus">'+arritem.rStatus+'</span></h5> </div> </div></div>');
                    } else {
                        $('.posluxuryroom').append('<div class="col mb-4 "><div class="rcard card shadow"> <div class="text-center"><img src="Resource/image/bed.svg" style="width: 100px;height: 100px";" class="card-img-top" alt="..."></div> <div class="card-body"> <h5 class="card-title">Mã phòng: <span id="idRoom">'+arritem.idRoom+'</span></h5> <h5 class="card-title">Loại: <span id="rType">'+arritem.rType+'</span></h5> <h5 class="card-title">Giá: <span id="rPrice">'+arritem.rPrice+'</span> VND</h5> <h5 class="card-title">Trạng thái: <span id="rStatus">'+arritem.rStatus+'</span></h5> </div> </div></div>');
                    }
                }
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

/* #region  Frontend */
    $(function () {
        $('.rcard').tooltip()
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
    var today = new Date();
    var date = today.getFullYear()+'-'+(today.getMonth()+1)+'-'+today.getDate();
    console.log(datefm(date))
    $('#Standarstartday').datepicker({
        value: datefm(date),
        format: 'dd-mm-yyyy',
        uiLibrary: 'bootstrap4'
    });
    $('#Standarendday').datepicker({
        format: 'dd-mm-yyyy',
        uiLibrary: 'bootstrap4'
    });
    $('#VIPstartday').datepicker({
        value: datefm(date),
        format: 'dd-mm-yyyy',
        uiLibrary: 'bootstrap4'
    });
    $('#VIPendday').datepicker({
        format: 'dd-mm-yyyy',
        uiLibrary: 'bootstrap4'
    });
    $('#Luxurystartday').datepicker({
        value: datefm(date),
        format: 'dd-mm-yyyy',
        uiLibrary: 'bootstrap4'
    });
    $('#Luxuryendday').datepicker({
        format: 'dd-mm-yyyy',
        uiLibrary: 'bootstrap4'
    });
    $('#Sfilterstartday').datepicker({
        value: datefm(date),
        format: 'dd-mm-yyyy',
        uiLibrary: 'bootstrap4'
    });
    $('#Sfilterendday').datepicker({
        format: 'dd-mm-yyyy',
        uiLibrary: 'bootstrap4'
    });
/* #endregion */
});