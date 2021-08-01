(function ($) {
    "use strict"; // Start of use strict

    // Floating label headings for the contact form
    $("body").on("input propertychange", ".floating-label-form-group", function (e) {
        $(this).toggleClass("floating-label-form-group-with-value", !!$(e.target).val());
    }).on("focus", ".floating-label-form-group", function () {
        $(this).addClass("floating-label-form-group-with-focus");
    }).on("blur", ".floating-label-form-group", function () {
        $(this).removeClass("floating-label-form-group-with-focus");
    });

    // Show the navbar when the page is scrolled up
    var MQL = 992;

    //primary navigation slide-in effect
    if ($(window).width() > MQL) {
        var headerHeight = $('#mainNav').height();
        $(window).on('scroll', {
            previousTop: 0
        },
            function () {
                var currentTop = $(window).scrollTop();
                //check if user is scrolling up
                if (currentTop < this.previousTop) {
                    //if scrolling up...
                    if (currentTop > 0 && $('#mainNav').hasClass('is-fixed')) {
                        $('#mainNav').addClass('is-visible');
                    } else {
                        $('#mainNav').removeClass('is-visible is-fixed');
                    }
                } else if (currentTop > this.previousTop) {
                    //if scrolling down...
                    $('#mainNav').removeClass('is-visible');
                    if (currentTop > headerHeight && !$('#mainNav').hasClass('is-fixed')) $('#mainNav').addClass('is-fixed');
                }
                this.previousTop = currentTop;
            });
    }

})(jQuery); // End of use strict

//add some formatting to the code blocks
$("pre").each(function () {
    $(this).addClass("prettyprint");
    PR.prettyPrint();
});

$('p iframe').each(function () {
    $(this).parent().addClass('aspect-ratio');
});
$(".back-to-top").click(function () {
    $("html, body").animate({ scrollTop: 0 }, 1000);
});

$(function () {
    $('.lazy-bg, img').lazy();
});
var pages = $('#box_pagination .pagination li');
if (pages.eq(1).hasClass('active')) {
    $('#box_pagination .pagination .page-item:first-child a').removeAttr('href');
    $('#box_pagination .pagination .page-item:first-child').css('opacity', '.5');
    $('#box_pagination .pagination .page-item:first-child a').css('cursor', 'not-allowed');
    $('#box_pagination .pagination .page-item:first-child a').addClass('not-hover');
} else if (pages.eq(pages.length - 2).hasClass('active')) {
    $('#box_pagination .pagination .page-item:last-child a').removeAttr('href');
    $('#box_pagination .pagination .page-item:last-child').css('opacity', '.5');
    $('#box_pagination .pagination .page-item:last-child a').css('cursor', 'not-allowed');
    $('#box_pagination .pagination .page-item:last-child a').addClass('not-hover');
}


