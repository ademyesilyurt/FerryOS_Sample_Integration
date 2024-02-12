$(".subinnernav li").eq(3).addClass("current");
$(".wantnot").css("display", "none");
$("#BankID").change(function () { GetInstallment($("#BankID").val()); });
var installmentID = 0;
function Payment() {
    if ($("#bilgilendirmeform").is(":checked") && $("#sozlesmeform").is(":checked")) {
        if (!$("#secure3d").is(":checked")) {
            var b = new AjaxBuilder({
                AjaxMethodType: AjaxMethodType.Post, RequestUrl: "../../Payment/Payment", ValidMessage: "ValidMessage",
                Parameters: {
                    Parameter: {
                        installmentID: $("#InstallmentID").val(), langCode: $("#language").attr("content"), voucherGuid: getParameterByName("Voucher"),
                        cardNO: $("#CardNO").val(), cvc: $("#Cvc").val(), expireMonth: $("#ExpireMonth").val(), expireYear: $("#ExpireYear").val(),
                        name: $("#Name").val(), surName: $("#SurName").val()
                    }
                }, ProgressID: null, ProgressFunction: "loading", ComplateFunctionName: "PaymentSuccess"
            });
            b.Request();
        } else {
            Secure3d(getParameterByName("Voucher"),
                location.protocol + "//" + location.host + location.pathname + "?Voucher=" + getParameterByName("Voucher"));
        }
    } else { UIAlert(sozlesmeokuyunuz); }
} function PaymentSuccess(b) {
    if (b.success) {
        PopUp("<div>ÖDEMENİZ TAMAMLANMIŞTIR<BR>VOUCHER SAYFASINA YÖNLENDİRİLİYORSUNUZ<div>", "ÖDEMENİZ TAMAMLANDI", 300, 200);
        location.href = "https://" + location.hostname + "/" + $("#language").attr("content") + "/voucher?Voucher=" + getParameterByName("Voucher");
    } else { UIAlert(b.valid); }
} function GetInstallment(d) {
    var c = new AjaxBuilder({
        AjaxMethodType: AjaxMethodType.Post, RequestUrl: "../../Payment/GetInstallment",
        ValidMessage: "ValidMessage", Parameters: {
            Parameter: {
                bankID: d, installmentID: 0,
                langCode: $("#language").attr("content"),
                voucherGuid: getParameterByName("Voucher"),
                paymentType: 1
            }
        }, ProgressID: null, ProgressFunction: "loading", ComplateFunctionName: "InstallmentSuccess"
    });
    c.Request();
} function InstallmentSuccess(c) {
    console.log(c);
    $("#InstallmentID option").remove();
    if (c.success === 200) {
        if (c.result !== null) {
            if (c.result.length > 0) {
                for (var d = 0; d < c.result[0].salesBankInstallmentList.length; d++) {
                    if (c.result[0].salesBankInstallmentList.length > 0) {
                        $("#InstallmentID").append("<option value='" + c.result[0].salesBankInstallmentList[d].id + "'>" + c.result[0].salesBankInstallmentList[d].installment + ".Taksit</option>");
                    }
                }
            }
        }
        $("#InstallmentID").val(installmentID);
    } else {
        if (c.valid !== null) {
            UIAlert(c.valid);
        }
    }
}

$(document).ready(function () {
    if (!navigator.userAgent.match(/iPad|iPhone|Android|IEMobile|BlackBerry/i) ? true : false) { }
    $(".blk1 a").html("FERIBOT BİLETİ");
    $(".blk2 a").html("YOLCU BİLGİLERİ");
    $(".blk1").removeClass("active");
    $(".blk6").addClass("active");
    $("body").addClass("inner3");
});