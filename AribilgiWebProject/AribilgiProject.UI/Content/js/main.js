(function ($) {
	"use strict";

	var windowOn = $(window);

	$(window).on('load', function () {

		$('#preloader').delay(999999).fadeOut('slow');
	
		$('body').delay(350).css({ 'overflow': 'visible' });
	
	})



	////////////////////////////////////////////////////
	//  00. Sticky Header Js
	windowOn.on('scroll', function () {
		var scroll = $(window).scrollTop();
		if (scroll < 100) {
			$("#header-sticky,#header-mob-sticky,#header-tab-sticky").removeClass("header-sticky");
		} else {
			$("#header-sticky,#header-mob-sticky,#header-tab-sticky").addClass("header-sticky");
		}
	});



	///////////////////////////////////////////////////
	// 01.  Scroll to top
	windowOn.on('scroll', function () {
		var scroll = windowOn.scrollTop();
		if (scroll < 245) {
			$('.scroll-to-target').removeClass('open');

		} else {
			$('.scroll-to-target').addClass('open');
		}
	});

	///////////////////////////////////////////////////
	// 02. Scroll Up Js
	if ($('.scroll-to-target').length) {
		$(".scroll-to-target").on('click', function () {
		var target = $(this).attr('data-target');
		// animate
		$('html, body').animate({
			scrollTop: $(target).offset().top
		}, 1000);
	
		});
	}

	////////////////////////////////////////////////////
	// 03. Data CSS Js
	$("[data-background").each(function () {
		$(this).css("background-image", "url( " + $(this).attr("data-background") + "  )");
	});

	$("[data-width]").each(function () {
		$(this).css("width", $(this).attr("data-width"));
	});

	$("[data-bg-color]").each(function () {
		$(this).css("background-color", $(this).attr("data-bg-color"));
	});



	////////////////////////////////////////////////////
	// 04. Nice Select Js
	//$('select').niceSelect();


	////////////////////////////////////////////////////
	// 05. Mobile Menu Js
	$('#mobile-menu').meanmenu({
		meanMenuContainer: '.mobile-menu',
		meanScreenWidth: "1199",
		meanExpand: ['<i class="fal fa-plus"></i>'],
	});


	$(".tp-cat-toggle").on("click", function () {
		$('.category-menu').slideToggle(500);
	});


	////////////////////////////////////////////////////
	// 06. Sidebar Js
	$(".tp-menu-toggle").on("click", function () {
		$(".tpsideinfo").addClass("tp-sidebar-opened");
		$(".body-overlay").addClass("opened");
	});
	$(".tpsideinfo__close").on("click", function () {
		$(".tpsideinfo").removeClass("tp-sidebar-opened");
		$(".body-overlay").removeClass("opened");
	});
	$(".body-overlay").on("click", function () {
		$(".tpsideinfo").removeClass("tp-sidebar-opened");
		$(".body-overlay").removeClass("opened");
	});


	////////////////////////////////////////////////////
	// 07. Sidebar Js
	$(".tp-cart-toggle").on("click", function () {
		$(".tp-cart-info-area").addClass("tp-sidebar-opened");
		$(".cartbody-overlay").addClass("opened");
	});
	$(".tpcart__close").on("click", function () {
		$(".tp-cart-info-area").removeClass("tp-sidebar-opened");
		$(".cartbody-overlay").removeClass("opened");
	});
	$(".cartbody-overlay").on("click", function () {
		$(".tp-cart-info-area").removeClass("tp-sidebar-opened");
		$(".cartbody-overlay").removeClass("opened");
	});



	////////////////////////////////////////////////////
	// 09. Price Filter Js
	if ($("#slider-range").length) {

		$("#slider-range").slider({

			range: true,

			min: 0,

			max: 1000,

			values: [0, 500],

			slide: function (event, ui) {

				$("#amount").val("$" + ui.values[0] + " - $" + ui.values[1]);

			}

		});

		$("#amount").val("$" + $("#slider-range").slider("values", 0) +

			" - $" + $("#slider-range").slider("values", 1));

		$('#filter-btn').on('click', function () {

			$('.filter-widget').slideToggle(1000);

		});

	}


		////////////////////////////////////////////////////
	// 10. Swiper Js
	$('.cart-minus').on('click', function () {
		var $input = $(this).parent().find('input');
		var count = parseInt($input.val()) - 1;
		count = count < 1 ? 1 : count;
		$input.val(count);
		$input.change();
		return false;
	});

	$('.cart-plus').on('click', function () {
		var $input = $(this).parent().find('input');
		$input.val(parseInt($input.val()) + 1);
		$input.change();
		return false;
	});


	////////////////////////////////////////////////////
	// 11. Show Login Toggle Js
	$('#showlogin').on('click', function () {
		$('#checkout-login').slideToggle(900);
	});

	////////////////////////////////////////////////////
	// 12. Show Coupon Toggle Js
	$('#showcoupon').on('click', function () {
		$('#checkout_coupon').slideToggle(900);
	});

	////////////////////////////////////////////////////
	// 13. Create An Account Toggle Js
	$('#cbox').on('click', function () {
		$('#cbox_info').slideToggle(900);
	});

	////////////////////////////////////////////////////
	// 14. Shipping Box Toggle Js
	$('#ship-box').on('click', function () {
		$('#ship-box-info').slideToggle(1000);
	});

	////////////////////////////////////////////////////
	// 22. Slider Js
	$('[data-countdown]').each(function () {
		var $this = $(this),
			finalDate = $(this).data('countdown');
		$this.countdown(finalDate, function (event) {

			$this.html(event.strftime('<span class="cdown days"><span class="time-count">%-D</span> <p>Days</p></span> <span class="cdown hour"><span class="time-count">%-H</span> <p>Hour</p></span> <span class="cdown minutes"><span class="time-count">%M</span> <p>Minute</p></span> <span class="cdown second"> <span><span class="time-count">%S</span> <p>Second</p></span>'));
		});
	});



	///////////////////////////////////////////////////
	// 25. Magnific Js
	$(".popup-video").magnificPopup({
		type: "iframe",
	});


	////////////////////////////////////////////////////
	// 26. magnificPopup Js
	$('.popup-image').magnificPopup({
		type: 'image',
		gallery: {
			enabled: true
		}
	});

	////////////////////////////////////////////////////
	// 29. Postbox Js
	var democol = $('.tpproduct [class*="col"]');
	democol.on({
		mouseenter: function () {
			$(this).siblings().stop().css('z-index', '-1');
		},
		mouseleave: function () {
			$(this).siblings().stop().css('z-index', '1');
		}
	});
	

})(jQuery);