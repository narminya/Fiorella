$(document).ready(function () {

    // HEADER

    $(document).on('click', '#search', function () {
        $(this).next().toggle();
    })

    $(document).on('click', '#mobile-navbar-close', function () {
        $(this).parent().removeClass("active");

    })
    $(document).on('click', '#mobile-navbar-show', function () {
        $('.mobile-navbar').addClass("active");

    })

    $(document).on('click', '.mobile-navbar ul li a', function () {
        if ($(this).children('i').hasClass('fa-caret-right')) {
            $(this).children('i').removeClass('fa-caret-right').addClass('fa-sort-down')
        }
        else {
            $(this).children('i').removeClass('fa-sort-down').addClass('fa-caret-right')
        }
        $(this).parent().next().slideToggle();
    })

    // SLIDER

    $(document).ready(function () {
        $(".slider").owlCarousel(
            {
                items: 1,
                loop: true,
                autoplay: true
            }
        );
    });

    // PRODUCT

    $(document).on('click', '.categories', function (e) {
        e.preventDefault();
        $(this).next().next().slideToggle();
    })

    $(document).on('click', '.category li a', function (e) {
        e.preventDefault();
        let category = $(this).attr('data-id');
        let products = $('.product-item');

        products.each(function () {
            if (category == $(this).attr('data-id')) {
                $(this).parent().fadeIn();
            }
            else {
                $(this).parent().hide();
            }
        })
        if (category == 'all') {
            products.parent().fadeIn();
        }
    })

    // ACCORDION 

    $(document).on('click', '.question', function () {
        $(this).siblings('.question').children('i').removeClass('fa-minus').addClass('fa-plus');
        $(this).siblings('.answer').not($(this).next()).slideUp();
        $(this).children('i').toggleClass('fa-plus').toggleClass('fa-minus');
        $(this).next().slideToggle();
        $(this).siblings('.active').removeClass('active');
        $(this).toggleClass('active');
    })

    // TAB

    $(document).on('click', 'ul li', function () {
        $(this).siblings('.active').removeClass('active');
        $(this).addClass('active');
        let dataId = $(this).attr('data-id');
        $(this).parent().next().children('p.active').removeClass('active');

        $(this).parent().next().children('p').each(function () {
            if (dataId == $(this).attr('data-id')) {
                $(this).addClass('active')
            }
        })
    })

    $(document).on('click', '.tab4 ul li', function () {
        $(this).siblings('.active').removeClass('active');
        $(this).addClass('active');
        let dataId = $(this).attr('data-id');
        $(this).parent().parent().next().children().children('p.active').removeClass('active');

        $(this).parent().parent().next().children().children('p').each(function () {
            if (dataId == $(this).attr('data-id')) {
                $(this).addClass('active')
            }
        })
    })

    // INSTAGRAM

    $(document).ready(function () {
        $(".instagram").owlCarousel(
            {
                items: 4,
                loop: true,
                autoplay: true,
                responsive: {
                    0: {
                        items: 1
                    },
                    576: {
                        items: 2
                    },
                    768: {
                        items: 3
                    },
                    992: {
                        items: 4
                    }
                }
            }
        );
    });

    $(document).ready(function () {
        $(".say").owlCarousel(
            {
                items: 1,
                loop: true,
                autoplay: true
            }
        );
    });

    var skipCount = parseInt($("#skipCount").val());

    $("#loadmore").click(function () {

        $.ajax({
            type: "GET",
            url: "Product/LoadMore/" + skipCount,
            success: function (res) {
                skipCount += 4;
                $("#products-container").append(res);
            }
        })
    })

    $("#input-search").keyup(function () {
        let searched = $(this).val();
        $.ajax({
            type: "GET",
            url: "Product/Search?searched=" + searched,
            success: function (res) {
                $("#search-result li:not(:first-child)").remove();
                $("#search-result").append(res);
                console.log(res);
            }
        })
    })


    $(document).on("click", ".addToCard", function () {
        let count = parseInt($(".rounded-circle").html());
        let id = $(this).attr("data-id");
        $.ajax({
            type: "GET",
            url: "Basket/addtobasket/" + id,
            success: function (res) {
                count++;
                $(".rounded-circle").html(count);
            }
        })
    })







    $(document).on("click", "#sub", function (e) {
        toastr.options = {
            "closeButton": false,
            "debug": false,
            "newestOnTop": false,
            "progressBar": false,
            "positionClass": "toast-top-right",
            "preventDuplicates": false,
            "onclick": null,
            "showDuration": "300",
            "hideDuration": "1000",
            "timeOut": "5000",
            "extendedTimeOut": "1000",
            "showEasing": "swing",
            "hideEasing": "linear",
            "showMethod": "fadeIn",
            "hideMethod": "fadeOut"
        }


        let email = $("#email").val();
        $.ajax({
            type: "GET",
            url: "Home/Subscribe?email=" + email,
            success: function (res) {
                if (res.result == "success") {
                    toastr["success"]("Success", res.message)
                    $("#email").val = "";
                }
                else {
                    toastr["error"]("Error", res.message)
                }


            },

        })
    })


})