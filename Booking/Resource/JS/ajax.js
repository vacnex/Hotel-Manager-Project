$(document).ready(function () {
    $('.loading').show();
    $.getJSON("https://localhost:44373/api/room")
    .done(function (data) { 
        var _room = data;
        // console.log(_room)
        _room.forEach(function (arritem) {
            var idRoom = arritem.idRoom
            var rStatus = arritem.rStatus
            if(idRoom.startsWith("L")==false && idRoom.startsWith("V")==false && rStatus.startsWith("T")==true || rStatus.startsWith("Đ")==true)
            {
                if (arritem.tbl_roombook != 0) {
                    var _roomBookDate = arritem.tbl_roombook
                    var start,end
                    _roomBookDate.forEach(function (roombookarritem) {
                        start = roombookarritem.startDate.substring(0,10).match(/([^T]+)/)[0].split("-").reverse().join("-")
                        end = roombookarritem.endDate.substring(0,10).match(/([^T]+)/)[0].split("-").reverse().join("-")
                    });
                    console.log(start,"||",end)
                    $('.posstandarroom').append('<div class="col mb-4 "><div class="rcard card shadow" data-placement="bottom" title="Ngày đặt: '+start+' Hết hạn: '+end+'"> <div class="text-center"><img src="Resource/image/bed.svg" style="width: 100px;height: 100px";" class="card-img-top" alt="..."></div> <div class="card-body"> <h5 class="card-title">Mã phòng: <span id="idRoom">'+arritem.idRoom+'</span></h5> <h5 class="card-title">Loại: <span id="rType">'+arritem.rType+'</span></h5> <h5 class="card-title">Giá: <span id="rPrice">'+arritem.rPrice+'</span> VND</h5> <h5 class="card-title">Trạng thái: <span id="rStatus">'+arritem.rStatus+'</span></h5> </div> </div></div>');
                }
                else{
                    $('.posstandarroom').append('<div class="col mb-4 "><div class="rcard card shadow"> <div class="text-center"><img src="Resource/image/bed.svg" style="width: 100px;height: 100px";" class="card-img-top" alt="..."></div> <div class="card-body"> <h5 class="card-title">Mã phòng: <span id="idRoom">'+arritem.idRoom+'</span></h5> <h5 class="card-title">Loại: <span id="rType">'+arritem.rType+'</span></h5> <h5 class="card-title">Giá: <span id="rPrice">'+arritem.rPrice+'</span> VND</h5> <h5 class="card-title">Trạng thái: <span id="rStatus">'+arritem.rStatus+'</span></h5> </div> </div></div>');
                }
                
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
    $('#Standarstartday').datepicker({
        uiLibrary: 'bootstrap4'
    });
    $('#Standarendday').datepicker({
        uiLibrary: 'bootstrap4'
    });
    $('#VIPstartday').datepicker({
        uiLibrary: 'bootstrap4'
    });
    $('#VIPendday').datepicker({
        uiLibrary: 'bootstrap4'
    });
    $('#Luxurystartday').datepicker({
        uiLibrary: 'bootstrap4'
    });
    $('#Luxuryendday').datepicker({
        uiLibrary: 'bootstrap4'
    });
    $('#Sfilterstartday').datepicker({
        uiLibrary: 'bootstrap4'
    });
    $('#Sfilterendday').datepicker({
        uiLibrary: 'bootstrap4'
    });
/* #endregion */
});