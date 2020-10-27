// ========================================================================= //
//  Typed Js
// ========================================================================= //

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