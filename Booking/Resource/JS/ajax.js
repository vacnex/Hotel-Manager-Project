$(document).ready(function () {
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
        }
    );
    $('#startday').datepicker({
        uiLibrary: 'bootstrap4'
    });
    $('#endday').datepicker({
        uiLibrary: 'bootstrap4'
    });
/* #endregion */

    $('.btnstandar').click(function (e) { 
        $.getJSON("https://localhost:44373/api/room",
            function (data) {
                var _room = data;
                console.log(_room)
            }
        );
        
    });
});