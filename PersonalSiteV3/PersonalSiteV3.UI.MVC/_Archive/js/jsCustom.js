var typed = $(".typed");
var strings;

$(function () {
    strings = $('.typed-items').text();
    strings = $('.typed-items').data('typed-person') + ',' + strings;
    strings = strings.split(',');

    typed.typed({
        strings: strings,
        typeSpeed: 90,
        loop: true,
    });
});

var bStrings = [strings, typed];
$('.background').each(function (i) {
    $(this).css('background-color', 'rgba(132, 97, 35, .7)', [i % bStrings.length]);
});