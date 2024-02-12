var UTC = "Asia/Yerevan";
$(window).resize(function () {
	if ($(".background-popup").html() != null) {
		$(".content-popup").css("top", (HSize() - $(".content-popup").height()) / 2 + "px");
		$(".content-popup").css("left", (WSize() - $(".content-popup").width()) / 2 + "px")
	}
});
function Printers() { var f = document.printapp.PrinterList().split(","); var e = []; for (var d = 0; d < f.length; d++) { e.push({ Name: f[d] }) } return e }
function Print(j, i, e, h) { try { document.printapp.StartPrint('"' + e + '" "' + h + '" ' + i + ' "' + j + '"') } catch (g) { } }
function PopUp(i, g, l, j) {
	var k = ""; var h = "<div class='header-popup'><img id='closepopup' style='float:right;float: right;width: 36px;position: absolute;right: -17px;top: -19px;' onclick=\"PopUp('','',0,0);\"; src='../../assets/img/close_popup.png'/>" + g + "</div>";
	if ($(".background-popup").length < 1) { $("body").prepend("<div style='height:" + $(window).height() * 2 + "px;width:" + $(window).width() + "px;' class='background-popup'></div>") }
	if ((i).search("http") == 0) {
		k = "<iframe frameborder='0' width='100%' height='" + (j - 70) + "'  src='" + i + "'/>"
	} else { k = i }
	if (i == "") { $(".background-popup").remove() }
	else {
		if ($(window).width() < 767) { j = $(window).height() - 82; l = $(window).width() - 10 } $(".background-popup").html("<div class='content-popup' style='height:" + j + "px;width:" + l + "px;top:" + ($(window).height() - j) / 2 + "px; left:" + ($(window).width() - l) / 2 + "px; '>" + h + "<div id='popupcontainer' style='height:" + (j - 50) + "px;padding:8px;overflow-y: auto;'>" + k + "</div></div>")
	} if ($(window).width() > 767) { $(".content-popup").css("top", ($(window).height() - $(".content-popup").height()) / 2 + "px"); $(".content-popup").css("left", ($(window).width() - $(".content-popup").width()) / 2 + "px") } else { $(".content-popup").css("height", ($(window).height() - 82) + "px"); $(".content-popup").css("width", ($(window).width() - 10) + "px !important") }
}
function loading(b) {
	if (!b) { if ($(".loading-popup").length < 1) { $("body").before("<div  class='loading-popup'><div style='font-family:Arial;top:" + ($(window).height() - 100) / 2 + "px;left:" + ($(window).width() - 100) / 2 + "px;' class='loading-popup-load'><img src='../../assets/img/loading.gif' /></div></div>") } }
	else { $(".loading-popup").remove() }
}
function HSize() {
	var d; var c; if (typeof window.innerWidth != "undefined") { d = window.innerWidth, c = window.innerHeight }
	else {
		if (typeof document.documentElement != "undefined" && typeof document.documentElement.clientWidth != "undefined" && document.documentElement.clientWidth != 0) { d = document.documentElement.clientWidth, c = document.documentElement.clientHeight }
		else { d = document.getElementsByTagName("body")[0].clientWidth, c = document.getElementsByTagName("body")[0].clientHeight }
	} return c
}
function WSize() {
	var d; var c; if (typeof window.innerWidth != "undefined") { d = window.innerWidth, c = window.innerHeight }
	else {
		if (typeof document.documentElement != "undefined" && typeof document.documentElement.clientWidth != "undefined" && document.documentElement.clientWidth != 0) { d = document.documentElement.clientWidth, c = document.documentElement.clientHeight }
		else { d = document.getElementsByTagName("body")[0].clientWidth, c = document.getElementsByTagName("body")[0].clientHeight }
	} return d
} var weekday = new Array(7); weekday[0] = "Pazar"; weekday[1] = "Pazartesi"; weekday[2] = "Salı"; weekday[3] = "Çarşamba"; weekday[4] = "Perşembe"; weekday[5] = "Cuma"; weekday[6] = "Cumartesi"; var Month = ["", "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık"];
function JsonToStrDate(dateString) {

	if (dateString == null)
		return "";
	else {

		var pattern = /Date\(([^)]+)\)/;
		var results = pattern.exec(dateString);
		var dt = new Date(parseFloat(results[1]));
		var d = new Date();

		dt.setTime((dt.getTime() + d.getHours() * 60 * 60 * 1000));
		return (dt.getDate() > 9 ? dt.getDate() : "0" + dt.getDate()) + "." + (dt.getMonth() + 1 > 9 ? (dt.getMonth() + 1) : "0" + (dt.getMonth() + 1)) + "." + dt.getFullYear();
	}
}
function HourParse(b) {
	if (b != null) { return (b.Hours > 9 ? b.Hours : "0" + b.Hours) + ":" + (b.Minutes > 9 ? b.Minutes : "0" + b.Minutes) }
	else { return "" }
}

function JsonToStrDateHours(dateString) {


	if (dateString == null || dateString == "")
		return "";
	else {
		var pattern = /Date\(([^)]+)\)/;
		var results = pattern.exec(dateString);
		var dt = new Date(parseFloat(results[1]));
		if (dt.getHours() == 0 & dt.getMinutes() == 0)
			dt.setTime((dt.getTime() + dt.getHours() * 60 * 60 * 1000));
		return (dt.getDate() > 9 ? dt.getDate() : ("0" + dt.getDate())) + "." + (dt.getMonth() + 1 > 9 ? (dt.getMonth() + 1) : "0" + (dt.getMonth() + 1)) + "." + dt.getFullYear() + " " + (dt.getHours() > 9 ? dt.getHours() : "0" + dt.getHours()) + ":" + (dt.getMinutes() > 9 ? dt.getMinutes() : ("0" + dt.getMinutes()));
	}
}
function JsonToStrHours(b) {
	if (b != null) {
		return b.Hours + ":" + (b.Minutes > 9 ? b.Minutes : "0" + b.Minutes)
	} else { return "" }
}

function datetoformat4(n) {
	var l = new Date(n);
	var s = l.getMonth() + 1; var o = l.getDate(); var q = l.getHours() > 9 ? l.getHours() : "0" + l.getHours(); var r = l.getMinutes() > 9 ? l.getMinutes() : "0" + l.getMinutes(); var u = l.getSeconds(); var p = l.getDay(); var t = new RegExp("_", "g"); var v = l.getFullYear(); var m = (o < 10 ? ("0" + o) : o) + "." + (s < 10 ? ("0" + s) : s) + "." + v + " " + q + ":" + r;
	if (v != 1) { return m } else { return "" }
} function datetoformat3(d) {
	var c = d.split(".");
	return new Date(parseInt(c[2]), (parseInt(c[1]) - 1), parseInt(c[0]), 8, 0, 0, 0)
} function DateToJson(d) {
	var c = d.split(".");
	return (new Date(parseInt(c[2]), (parseInt(c[1]) - 1), parseInt(c[0]), 8, 0, 0, 0)).toJSON()
} function StatusName(b) {
	if (b.Status == 1) { return "Aktif" } if (b.Status == 0) {
		return "Pasif"
	} if (b.Status == -1) { return "Silinmiş" }
}

function FormatCurrency(Type, Amount) {

	if (Type == "TL" || Type == "₺" || Type == "TRY")
		Type = "TRL";

	if (Type == "$")
		Type = "USD";

	if (Type == "€")
		Type = "EUR";

	if (Amount == 0)
		return "";
	else {
		var a = (new Intl.NumberFormat('de-DE', { style: 'currency', currency: "EUR" }).format(Amount)).replace("TRL", "₺") + " ";
		if (Type == "TRL")
			a = a.replace("€", "₺");
		else if (Type == "USD")
			a = a.replace("€", "$");
		return a;
	}
}


function TrkUppercase(h) {
	var j = []; for (var i = 0; i < $("#" + h).val().length; i++) {
		var g = $("#" + h).val().charCodeAt(i);
		var c = $("#" + h).val().charAt(i);
		if (g == 105) { j.push("I") } else {
			if (g == 305) { j.push("I") } else {
				if (g == 287) { j.push("G") } else {
					if (g == 286) { j.push("G") } else {
						if (g == 199) { j.push("C") }
						else {
							if (g == 231) { j.push("C") }
							else {
								if (g == 252) { j.push("U") }
								else {
									if (g == 220) { j.push("U") }
									else {
										if (g == 351) { j.push("S") }
										else {
											if (g == 350) { j.push("S") }
											else {
												if (g == 246) { j.push("O") }
												else {
													if (g == 214) { j.push("O") }
													else {
														if (g == 304) { j.push("I") }
														else {
															if (g >= 97 && g <= 122) { j.push(c.toUpperCase()) }
															else { j.push(c) }
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
	} return $("#" + h).val(j.join(""))
} function getUrlVars(i) { var j = [], f; var g = i.slice(i.indexOf("?") + 1).split("&"); for (var h = 0; h < g.length; h++) { f = g[h].split("="); j.push(f[0]); j[f[0]] = f[1] } return j } function getPosition(d) {
	var e = 0; var f = 0; if (!d) { var d = window.event } if (d.pageX || d.pageY) { e = d.pageX; f = d.pageY } else { if (d.clientX || d.clientY) { e = d.clientX + document.body.scrollLeft + document.documentElement.scrollLeft; f = d.clientY + document.body.scrollTop + document.documentElement.scrollTop } }
	return { x: e, y: f }
} function getParameterByName(d) { d = d.replace(/[\[]/, "\\[").replace(/[\]]/, "\\]"); var e = new RegExp("[\\?&]" + d + "=([^&#]*)"), f = e.exec(location.search); return f === null ? "" : decodeURIComponent(f[1].replace(/\+/g, " ")) } function LanguageSelection() { var b = new AjaxBuilder({ AjaxMethodType: AjaxMethodType.Post, RequestUrl: "../common/LanguageSelection", Parameters: { LangCode: $("#countriesFlag").val() }, ProgressID: null, ProgressFunction: "loading", ComplateFunctionName: "SuccessLanguageSelection" }); b.Request() }
function SuccessLanguageSelection(b) {
	if (b.Status == 200) { location.href = b.Result } else {
		UIAlert("Bir hata oluştu litfen tekrar deneyiniz.")
	}
} function getMeta(d) { var c = []; $("<img/>", { load: function () { c[0] = this.width; c[0] = this.height }, src: d }); return c }
$(document).ready(function () {
	$(".showpicture").click(
		function () { var d = $(this).attr("src"); var c = getMeta(d); PopUp(d, "", c[0], c[1]) })
});

function datepic() {
	if (/Android|webOS|iPhone|iPad|iPod|BlackBerry|IEMobile|Opera Mini/i.test(navigator.userAgent)) {
		$.getScript("../assets/AnyPicer/anypicker.js").done(function (script, textStatus) {

			$.getScript("../assets/AnyPicer/anypicker-i18n.js").done(function (script, textStatus) {

				$(".txtdate").each(function (index) {
					if ($("#" + this.id).attr("readonly") == undefined) {
						$("#" + this.id).AnyPicker(
							{
								mode: "datetime",
								lang: (navigator.language == undefined ? navigator.userLanguage : navigator.language).substr(0, 2),
								dateTimeFormat: "dd.MM.yyyy",
								setOutput: function (sOutLabel, oArrSelected, bIsManualChange) {
									$("#" + this.elem.id).val(sOutLabel);

									if ($("#DepartureDate").length > 0) {
										if (DateToJson($("#DepartureDate").val()) > DateToJson($("#ReturnDate").val()))
											$("#ReturnDate").val($("#DepartureDate").val());

										if (DateToJson($("#ReturnDate").val()) < DateToJson($("#DepartureDate").val()))
											$("#DepartureDate").val($("#ReturnDate").val());
									}
								},
								minValue: new Date("1910-01-01"),
								theme: "iOS"
							});



						$("#" + this.id).attr("readonly", "");
					}
				});
			});
		});
		$('head').append('<link href="../assets/AnyPicer/anypicker-ios.css" rel="stylesheet" />');
		$('head').append('<link href="../assets/AnyPicer/anypicker-all.css" rel="stylesheet" />');
	} else {
		$('head').append('<link href="../assets/css/jquery.datetimepicker.css" rel="stylesheet" />');
		$.getScript("../assets/js/jquery.datetimepicker.js").done(function (script, textStatus) {
			$(".txtdate").each(function (index) {
				$("#" + this.id).datetimepicker({
					lang: navigator.language.substr(0, 2),
					timepicker: false,
					format: 'd.m.Y',
					formatDate: 'd.m.Y',
					dayOfWeekStart: 1,
					allowBlank: true,
					validateOnBlur: false,
					mask: false,
					closeOnDateSelect: true,
					onSelectDate: function (dp, $input) {
						if ($("#DepartureDate").length > 0) {
							if (DateToJson($("#DepartureDate").val()) > DateToJson($("#ReturnDate").val()))
								$("#ReturnDate").val($("#DepartureDate").val());
							if (DateToJson($("#ReturnDate").val()) < DateToJson($("#DepartureDate").val()))
								$("#DepartureDate").val($("#ReturnDate").val());
						}
					}
				});
			//	$("#" + this.id).mask("99.99.9999");
			});
		});
	}
}

$(document).ready(
	function () {



		$('.toor').clone().appendTo('.sidebar');

		$('.btn_toggle').click(function (e) {
			$('body').toggleClass('change');


		})
		$('.sidebar .toor ul li').click(function (e) {
			$(this).find('.megamenu').slideToggle();
			$(this).siblings().find('.megamenu').slideUp();
		});

		datepic();

	}
);


$(document).ready(
	function () {
		$(".txtdate_bd").each(function (index) {
			if (/Android|webOS|iPhone|iPad|iPod|BlackBerry|IEMobile|Opera Mini/i.test(navigator.userAgent)) {
				$("#" + this.id).AnyPicker(
					{
						mode: "datetime",
						dateTimeFormat: "dd.MM.yyyy",
						lang: "tr",
						onChange: function s(iRow, iComp, oSelectedValues) {
							console.log("Changed Value : " + iRow + " " + iComp + " " + oSelectedValues);
						},

						theme: "iOS"
					});

			} else {
				$("#" + this.id).datetimepicker({
					lang: navigator.language.substr(0, 2),
					timepicker: false,
					format: 'd.m.Y',
					formatDate: 'd.m.Y',
					dayOfWeekStart: 1,
					allowBlank: true,
					validateOnBlur: false,
					mask: false,
					closeOnDateSelect: true
				});
				$("#" + this.id).mask("99.99.9999");
			}
		});
	}
);


$(document).ready(
	function () {
		$(".feribot ul li, .sidebar ul li").on("click",
			function () {

				$("." + this.className + " img").each(function (index) {
					if (this.id != null & this.id != "") {
						$(".sidebar #" + this.id).attr("src", $("#" + this.id).attr("data-src"));
						$(".feribot #" + this.id).attr("src", $("#" + this.id).attr("data-src"));
					}
				});
			}
		);
	});

//document.addEventListener("DOMContentLoaded", function () {
//    let lazyImages = [].slice.call(document.querySelectorAll("img.lazy"));
//    let active = false;

//    const lazyLoad = function () {
//        if (active === false) {
//            active = true;

//            setTimeout(function () {
//                lazyImages.forEach(function (lazyImage) {
//                    if ((lazyImage.getBoundingClientRect().top <= window.innerHeight && lazyImage.getBoundingClientRect().bottom >= 0) && getComputedStyle(lazyImage).display !== "none") {
//                        lazyImage.src = lazyImage.dataset.src;
//                        lazyImage.srcset = lazyImage.dataset.srcset;
//                        lazyImage.classList.remove("lazy");

//                        lazyImages = lazyImages.filter(function (image) {
//                            return image !== lazyImage;
//                        });

//                        if (lazyImages.length === 0) {
//                            document.removeEventListener("scroll", lazyLoad);
//                            window.removeEventListener("resize", lazyLoad);
//                            window.removeEventListener("orientationchange", lazyLoad);
//                        }
//                    }
//                });

//                active = false;
//            }, 200);
//        }
//    };

//    document.addEventListener("scroll", lazyLoad);
//    window.addEventListener("resize", lazyLoad);
//    window.addEventListener("orientationchange", lazyLoad);
//});


document.addEventListener("DOMContentLoaded", function () {
	var lazyImages = [].slice.call(document.querySelectorAll("img.lazy"));

	if ("IntersectionObserver" in window) {
		let lazyImageObserver = new IntersectionObserver(function (entries, observer) {
			entries.forEach(function (entry) {
				if (entry.isIntersecting) {
					let lazyImage = entry.target;
					lazyImage.src = lazyImage.dataset.src;
					lazyImage.srcset = lazyImage.dataset.srcset;
					lazyImage.classList.remove("lazy");
					lazyImageObserver.unobserve(lazyImage);
				}
			});
		});

		lazyImages.forEach(function (lazyImage) {
			lazyImageObserver.observe(lazyImage);
		});
	} else {
		// Possibly fall back to a more compatible method here
	}
});