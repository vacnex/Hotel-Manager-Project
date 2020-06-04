$(document).ready(function () {
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
});