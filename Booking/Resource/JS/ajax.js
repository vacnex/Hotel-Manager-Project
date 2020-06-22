$(document).ready(function () {
    /* #region  Load First */
    LoadRoomList();
    $('.loading').show();
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
/* #region  Alert */
    $("#success-alertS").hide();
    $("#danger-alertS").hide();
    $("#warning-alertS").hide();
    $("#success-alertV").hide();
    $("#danger-alertV").hide();
    $("#warning-alertV").hide();
    $("#success-alertL").hide();
    $("#danger-alertL").hide();
    $("#warning-alertL").hide();
    $('.wrn').click(function (e) { 
        $("#warning-alertS").hide();
    });
    $('.scs').click(function (e) { 
        $("#success-alertS").hide();
    });
    $('.dngr').click(function (e) { 
        $("#danger-alertS").hide();
    });
    $('.wrn').click(function (e) { 
        $("#warning-alertV").hide();
    });
    $('.scs').click(function (e) { 
        $("#success-alertV").hide();
    });
    $('.dngr').click(function (e) { 
        $("#danger-alertV").hide();
    });
    $('.wrn').click(function (e) { 
        $("#warning-alertL").hide();
    });
    $('.scs').click(function (e) { 
        $("#success-alertL").hide();
    });
    $('.dngr').click(function (e) { 
        $("#danger-alertL").hide();
    });
/* #endregion */

/* #region  Datepicker */
    var today = new Date();
    var date = today.getFullYear()+'-'+(today.getMonth()+1)+'-'+today.getDate();
    $('#startdayS').datepicker({
        value: datefm(date),
        format: 'dd-mm-yyyy',
        uiLibrary: 'bootstrap4'
    });
    $('#enddayS').datepicker({
        format: 'dd-mm-yyyy',
        uiLibrary: 'bootstrap4'
    });
    $('#startdayV').datepicker({
        value: datefm(date),
        format: 'dd-mm-yyyy',
        uiLibrary: 'bootstrap4'
    });
    $('#enddayV').datepicker({
        format: 'dd-mm-yyyy',
        uiLibrary: 'bootstrap4'
    });
    $('#startdayL').datepicker({
        value: datefm(date),
        format: 'dd-mm-yyyy',
        uiLibrary: 'bootstrap4'
    });
    $('#enddayL').datepicker({
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
        uiLibrary: 'bootstrap4',
        close: function (e) {
            startRange= $('#Sfilterstartday').datepicker().value()
            endRange= $('#Sfilterendday').datepicker().value()
        }
    });
    $('#Vfilterstartday').datepicker({
        value: datefm(date),
        format: 'dd-mm-yyyy',
        uiLibrary: 'bootstrap4'
    });

    $('#Vfilterendday').datepicker({
        format: 'dd-mm-yyyy',
        uiLibrary: 'bootstrap4',
        close: function (e) {
            startRange= $('#Vfilterstartday').datepicker().value()
            endRange= $('#Vfilterendday').datepicker().value()
        }
    });
    $('#Lfilterstartday').datepicker({
        value: datefm(date),
        format: 'dd-mm-yyyy',
        uiLibrary: 'bootstrap4'
    });

    $('#Lfilterendday').datepicker({
        format: 'dd-mm-yyyy',
        uiLibrary: 'bootstrap4',
        close: function (e) {
            startRange= $('#Lfilterstartday').datepicker().value()
            endRange= $('#Lfilterendday').datepicker().value()
        }
    });
/* #endregion */
    
/* #endregion */
    /* #region  Funtion */
    function datefm(date) { 
        if (!date) {
            $("#warning-alertS").show()
        }
        else{
            return date.match(/([^T]+)/)[0].split("-").reverse().join("-")
        }
    }
    function datefmyyyymmdd(date) {
        if (!date) {
            $("#warning-alertS").show()
        }
        else{
            return date.match(/([^T]+)/)[0].split("-").reverse().join("-")
        }
    }
    function appendString(className,idRoom,rType,rStatus,rPrice,dayStart = 0,dayEnd = 0) {
        if (dayStart != 0 && dayEnd != 0) {
            return $(className).append('<div class="col mb-4 room"><div class="rcard card shadow" data-placement="bottom" title="Từ: '+datefm(dayStart)+' Đến: '+datefm(dayEnd)+'"> <div class="text-center"><img src="Resource/image/bed.svg" style="width: 100px;height: 100px";" class="card-img-top" alt="..."></div> <div class="card-body"> <h5 class="card-title">Mã phòng: <span id="idRoom">'+idRoom+'</span></h5> <h5 class="card-title">Loại: <span id="rType">'+rType+'</span></h5> <h5 class="card-title">Giá: <span id="rPrice">'+rPrice+'</span> VND</h5> <h5 class="card-title">Trạng thái: <span id="rStatus">'+rStatus+'</span></h5> </div> </div></div>');
        } else {
            return $(className).append('<div class="col mb-4 room"><div class="rcard card shadow"> <div class="text-center"><img src="Resource/image/bed.svg" style="width: 100px;height: 100px";" class="card-img-top" alt="..."></div> <div class="card-body"> <h5 class="card-title">Mã phòng: <span id="idRoom">'+idRoom+'</span></h5> <h5 class="card-title">Loại: <span id="rType">'+rType+'</span></h5> <h5 class="card-title">Giá: <span id="rPrice">'+rPrice+'</span> VND</h5> <h5 class="card-title">Trạng thái: <span id="rStatus">'+rStatus+'</span></h5> </div> </div></div>');
        }
    }
    function LoadRoomList() {
        $.getJSON("https://hotelmanagerapi.azurewebsites.net/api/room")
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
                            appendString('.posstandarroom',idRoom,arritem.rType,rStatus,arritem.rPrice,start,end);
                        }
                        else{
                            appendString('.posstandarroom',idRoom,arritem.rType,rStatus,arritem.rPrice);
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
                            appendString('.posviproom',idRoom,arritem.rType,rStatus,arritem.rPrice,start,end);
                        } else {
                            appendString('.posviproom',idRoom,arritem.rType,rStatus,arritem.rPrice);
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
                            appendString('.posluxuryroom',idRoom,arritem.rType,rStatus,arritem.rPrice,start,end);
                        } else {
                            appendString('.posluxuryroom',idRoom,arritem.rType,rStatus,arritem.rPrice);
                        }
                    }
                }
            });
            console.log("Loaded")
        })
        // .done(function () {
        //     $('.posstandarroom .room').find('.rcard').each(function() {
        //         $.each(this.attributes, function (i, attrib) { 
        //             var value = attrib.value.startsWith("T");   
        //             if (value  === true) {
        //                 console.log(attrib.value)
        //             }             
                    
        //         });
        //     });
        // })
        .always(function () { $(".loading").hide(); });
    }
    /* #endregion */

    var idRoomB,idCardB,$startDateB,$endDateB,cusNameB,cusAddressB,cusGenderB,cusPhoneB
/* #region  Check existed cusomter*/

/* #region  Click event on ajax element for room card */
    $('.posbooking').on('click', '#sBooking', function (){
        $startDateB = $('#startdayS').datepicker().value();
        $endDateB = $('#enddayS').datepicker().value();
        idCardB = $('#inputidcardS').val();
        idRoomB = $('#inputIdRoomS').val();
        cusNameB = $('#inputNameS').val();
        cusAddressB = $('#inputAddressS').val();
        cusGenderB = $('#inputgenderS').val();
        cusPhoneB = $('#inputphoneS').val();
        var _roomBookP,_customerP
        _customerP = '{"idCard": "'+idCardB+'","cusName": "'+cusNameB+'","cusAddress": "'+cusAddressB+'","cusGender": "'+cusGenderB+'","cusPhone": "'+cusPhoneB+'"}'
        _roomBookP = '{"idCard": "'+idCardB+'","idRoom": "'+idRoomB+'","startDate": "'+datefmyyyymmdd($startDateB)+'","endDate": "'+datefmyyyymmdd($endDateB)+'","staffName": "Online Booking"}'
        if (!$startDateB || !$endDateB || !idCardB || !idRoomB || !cusNameB || !cusAddressB || !cusGenderB || !cusPhoneB) {
            $("#warning-alertS").show()
        }
        else{
            $.getJSON('https://hotelmanagerapi.azurewebsites.net/api/customer')
            .done(function (data) { 
                var _customer = data;
                var listidcard = [];
                _customer.forEach( function(arritem) {
                    listidcard.push(arritem.idCard)
                });
                var pos = listidcard.indexOf(idCardB);
                if (pos > -1) {
                    var roomStatusUpdate ='{ "idRoom": "'+idRoomB+'",  "rType": "'+$('#inputRoomTypeS').val()+'",  "rPrice": '+$('#inputRoomPriceS').val()+',  "rStatus": "Đã Đặt" }';
                    console.log(roomStatusUpdate);
                    $.post('https://hotelmanagerapi.azurewebsites.net/api/roombook', JSON.parse(_roomBookP),"json")
                        .done(
                            function(){
                                $.ajax({
                                    url: 'https://hotelmanagerapi.azurewebsites.net/api/room/'+idRoomB,
                                    contentType: 'application/json',
                                    method: 'put',
                                    data:  roomStatusUpdate,
                                    success: function () {
                                        $("#success-alertS").show();
                                        $('.posstandarroom').html("");
                                        $('.loading').show();
                                        LoadRoomList();
                                    }
                                });
                            }
                        )
                        .fail(
                            function(jqXHR){
                                $("#danger-alertS").show()
                                $(".error").html(jqXHR.responseText);
                            }
                        );
                }else{
                    $.post('https://hotelmanagerapi.azurewebsites.net/api/customer' ,JSON.parse(_customerP),"json")
                    .done(
                        function()
                        {
                            $.post('https://hotelmanagerapi.azurewebsites.net/api/roombook', JSON.parse(_roomBookP),"json")
                            .done(
                                function(){
                                    $.ajax({
                                        url: 'https://hotelmanagerapi.azurewebsites.net/api/room/'+idRoomB,
                                        contentType: 'application/json',
                                        datatype: "json",
                                        method: 'put',
                                        data:  JSON.parse(roomStatusUpdate),
                                        success: function () {
                                            $("#success-alertS").show();
                                            $('.posstandarroom').html("");
                                            $('.loading').show();
                                            LoadRoomList();
                                        }
                                    });
                                }
                            )
                            .fail(
                                function(jqXHR){
                                    $("#danger-alertS").show()
                                    $(".error").html(jqXHR.responseText);
                                }
                            );
                        }
                    )
                    .fail(
                        function(jqXHR){
                            $("#danger-alertS").show()
                            $(".error").html(jqXHR.responseText);
                        }
                    );
                }
            });
        }
    });
    $('.posbooking').on('click', '#vBooking', function (){
        $startDateB = $('#startdayV').datepicker().value();
        $endDateB = $('#enddayV').datepicker().value();
        idCardB = $('#inputidcardV').val();
        idRoomB = $('#inputIdRoomV').val();
        cusNameB = $('#inputNameV').val();
        cusAddressB = $('#inputAddressV').val();
        cusGenderB = $('#inputgenderV').val();
        cusPhoneB = $('#inputphoneV').val();
        var _roomBookP,_customerP
        _customerP = '{"idCard": "'+idCardB+'","cusName": "'+cusNameB+'","cusAddress": "'+cusAddressB+'","cusGender": "'+cusGenderB+'","cusPhone": "'+cusPhoneB+'"}'
        _roomBookP = '{"idCard": "'+idCardB+'","idRoom": "'+idRoomB+'","startDate": "'+datefmyyyymmdd($startDateB)+'","endDate": "'+datefmyyyymmdd($endDateB)+'","staffName": "Online Booking"}'
        if (!$startDateB || !$endDateB || !idCardB || !idRoomB || !cusNameB || !cusAddressB || !cusGenderB || !cusPhoneB) {
            $("#warning-alertV").show()
        }
        else{
            $.getJSON('https://hotelmanagerapi.azurewebsites.net/api/customer')
            .done(function (data) { 
                var _customer = data;
                var listidcard = [];
                _customer.forEach( function(arritem) {
                    listidcard.push(arritem.idCard)
                });
                // for (let index = 0; index < listidcard.length; index++) {
                //     console.log(listidcard[index]); 
                // }
                var pos = listidcard.indexOf(idCardB);
                if (pos > -1) {
                    var roomStatusUpdate ='{ "idRoom": "'+idRoomB+'",  "rType": "'+$('#inputRoomTypeV').val()+'",  "rPrice": '+$('#inputRoomPriceV').val()+',  "rStatus": "Đã Đặt" }';
                    console.log(roomStatusUpdate);
                    $.post('https://hotelmanagerapi.azurewebsites.net/api/roombook', JSON.parse(_roomBookP),"json")
                        .done(
                            function(){
                                $.ajax({
                                    url: 'https://hotelmanagerapi.azurewebsites.net/api/room/'+idRoomB,
                                    contentType: 'application/json',
                                    method: 'put',
                                    data:  roomStatusUpdate,
                                    success: function () {
                                        $("#success-alertV").show();
                                        $('.posviproom').html("");
                                        $('.loading').show();
                                        LoadRoomList();
                                    }
                                });
                            }
                        )
                        .fail(
                            function(jqXHR){
                                $("#danger-alertV").show()
                                $(".error").html(jqXHR.responseText);
                            }
                        );
                }else{
                    $.post('https://hotelmanagerapi.azurewebsites.net/api/customer' ,JSON.parse(_customerP),"json")
                    .done(
                        function()
                        {
                            $.post('https://hotelmanagerapi.azurewebsites.net/api/roombook', JSON.parse(_roomBookP),"json")
                            .done(
                                function(){
                                    $.ajax({
                                        url: 'https://hotelmanagerapi.azurewebsites.net/api/room/'+idRoomB,
                                        contentType: 'application/json',
                                        datatype: "json",
                                        method: 'put',
                                        data:  JSON.parse(roomStatusUpdate),
                                        success: function () {
                                            $("#success-alertV").show();
                                            $('.posviproom').html("");
                                            $('.loading').show();
                                            LoadRoomList();
                                        }
                                    });
                                }
                            )
                            .fail(
                                function(jqXHR){
                                    $("#danger-alertV").show()
                                    $(".error").html(jqXHR.responseText);
                                }
                            );
                        }
                    )
                    .fail(
                        function(jqXHR){
                            $("#danger-alertV").show()
                            $(".error").html(jqXHR.responseText);
                        }
                    );
                }
            });
        }
    });
    $('.posbooking').on('click', '#lBooking', function (){
        $startDateB = $('#startdayL').datepicker().value();
        $endDateB = $('#enddayL').datepicker().value();
        idCardB = $('#inputidcardL').val();
        idRoomB = $('#inputIdRoomL').val();
        cusNameB = $('#inputNameL').val();
        cusAddressB = $('#inputAddressL').val();
        cusGenderB = $('#inputgenderL').val();
        cusPhoneB = $('#inputphoneL').val();
        var _roomBookP,_customerP
        _customerP = '{"idCard": "'+idCardB+'","cusName": "'+cusNameB+'","cusAddress": "'+cusAddressB+'","cusGender": "'+cusGenderB+'","cusPhone": "'+cusPhoneB+'"}'
        _roomBookP = '{"idCard": "'+idCardB+'","idRoom": "'+idRoomB+'","startDate": "'+datefmyyyymmdd($startDateB)+'","endDate": "'+datefmyyyymmdd($endDateB)+'","staffName": "Online Booking"}'
        if (!$startDateB || !$endDateB || !idCardB || !idRoomB || !cusNameB || !cusAddressB || !cusGenderB || !cusPhoneB) {
            $("#warning-alertL").show()
        }
        else{
            $.getJSON('https://hotelmanagerapi.azurewebsites.net/api/customer')
            .done(function (data) { 
                var _customer = data;
                var listidcard = [];
                _customer.forEach( function(arritem) {
                    listidcard.push(arritem.idCard)
                });
                // for (let index = 0; index < listidcard.length; index++) {
                //     console.log(listidcard[index]); 
                // }
                var pos = listidcard.indexOf(idCardB);
                if (pos > -1) {
                    var roomStatusUpdate ='{ "idRoom": "'+idRoomB+'",  "rType": "'+$('#inputRoomTypeL').val()+'",  "rPrice": '+$('#inputRoomPriceL').val()+',  "rStatus": "Đã Đặt" }';
                    console.log(roomStatusUpdate);
                    $.post('https://hotelmanagerapi.azurewebsites.net/api/roombook', JSON.parse(_roomBookP),"json")
                        .done(
                            function(){
                                $.ajax({
                                    url: 'https://hotelmanagerapi.azurewebsites.net/api/room/'+idRoomB,
                                    contentType: 'application/json',
                                    method: 'put',
                                    data:  roomStatusUpdate,
                                    success: function () {
                                        $("#success-alertL").show();
                                        $('.posluxuryroom').html("");
                                        $('.loading').show();
                                        LoadRoomList();
                                    }
                                });
                            }
                        )
                        .fail(
                            function(jqXHR){
                                $("#danger-alertL").show()
                                $(".error").html(jqXHR.responseText);
                            }
                        );
                }else{
                    $.post('https://hotelmanagerapi.azurewebsites.net/api/customer' ,JSON.parse(_customerP),"json")
                    .done(
                        function()
                        {
                            $.post('https://hotelmanagerapi.azurewebsites.net/api/roombook', JSON.parse(_roomBookP),"json")
                            .done(
                                function(){
                                    $.ajax({
                                        url: 'https://hotelmanagerapi.azurewebsites.net/api/room/'+idRoomB,
                                        contentType: 'application/json',
                                        datatype: "json",
                                        method: 'put',
                                        data:  JSON.parse(roomStatusUpdate),
                                        success: function () {
                                            $("#success-alertL").show();
                                            $('.posluxuryroom').html("");
                                            $('.loading').show();
                                            LoadRoomList();
                                        }
                                    });
                                }
                            )
                            .fail(
                                function(jqXHR){
                                    $("#danger-alertL").show()
                                    $(".error").html(jqXHR.responseText);
                                }
                            );
                        }
                    )
                    .fail(
                        function(jqXHR){
                            $("#danger-alertL").show()
                            $(".error").html(jqXHR.responseText);
                        }
                    );
                }
            });
        }
    });
/* #endregion */

/* #region  btn pass room info to booking form */
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

});