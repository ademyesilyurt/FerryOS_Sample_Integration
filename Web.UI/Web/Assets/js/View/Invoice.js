$(".saveinvoice").click(function () {
    var b = new AjaxBuilder({
        AjaxMethodType: AjaxMethodType.Post,
        RequestUrl: "../invoice/update",
        Parameters: {
            Parameter: {
                langCode: $("html").attr("lang"),
                voucherGuid: getParameterByName("Voucher"),
                invoiceItem: {
                    countryID: $("#CountryID").val(),
                    cityID: $("#CityID").val(),
                    eInvoice: $("#EInvoice").val(),
                    districtID: $("#DistrictID").val(),
                    address: $("#Address").val(),
                    citizenshipID: $("#CitizenshipID").val()
                    , company: $("#Company").val(),
                    email: $("#Email").val(),
                    gsm: ($("#Gsm").val() === "" ? "" : $("#gsmcountryphonecode").val()) + $("#Gsm").val()
                    , name: $("#Name").val()
                    , phone: ($("#Phone").val() === "" ? "" : $("#phonecountryphonecode").val()) + $("#Phone").val()
                    , surName: $("#SurName").val(),
                    taxNo: $("#TaxNumber").val(),
                    taxOffice: $("#TaxOffice").val(),
                    title: $("#Title").val(),
                    invoiceType: $("#InvoiceType").val()
                }
            }
        }, ProgressID: null, ProgressFunction: "loading", ComplateFunctionName: "successInvoice"
    }); b.Request();
});

function successInvoice(b) {
    if (b.valid === null) {
        location.href = "../payment?Voucher=" + getParameterByName("Voucher");
    } else {
        UIAlert(b.valid);
    }
}
$("#InvoiceType").change(function () {
    if ($("#InvoiceType").val() === "1") { $(".company").css("display", "none"); $(".bireysel").css("display", ""); } else {
        $(".company").css("display", "");
        $(".bireysel").css("display", "none");
    }
});

$(document).ready(function () {
    if ($("#InvoiceType").val() === "1") { $(".company").css("display", "none"); $(".bireysel").css("display", ""); } else {
        $(".company").css("display", "");
        $(".bireysel").css("display", "none");
    }
    $('#Gsm').mask('000-000-0000', { 'translation': { 0: { pattern: /[0-9*]/ } } });
    $('#Phone').mask('000-000-0000', { 'translation': { 0: { pattern: /[0-9*]/ } } });
    $(".blk1 a").html("FERIBOT BİLETİ");
    $(".blk2 a").html("YOLCU BİLGİLERİ");
    $(".blk1").removeClass("active");
    $(".blk5").addClass("active");
    $("body").addClass("inner3");
});

$("#CountryID").on("change", function () {
    $("#CityID option").remove();
    var b = new AjaxBuilder({
        AjaxMethodType: AjaxMethodType.Post,
        RequestUrl: "../common/City"
        , Parameters: { country_id: $("#CountryID").val() }
        , ProgressID: null, ProgressFunction: "loading", ComplateFunctionName: "FillCity"
    });
    b.Request()
}); function FillCity(c) {
    $("#CityID option").remove();
    $("#CityID").append(new Option("Seçiniz", "0"))
    for (var d = 0; d < c.result.length; d++) { $("#CityID").append(new Option(c.result[d].name, c.result[d].id)) }
}
$("#CityID").change(function () {
    $("#DistrictID option").remove();
    var b = new AjaxBuilder({
        AjaxMethodType: AjaxMethodType.Post
        , RequestUrl: "../common/District"
        , Parameters: {
            city_id: $("#CityID").val()
        }, ProgressID: null,
        ProgressFunction: "loading",
        ComplateFunctionName: "FillDistrict"
    }); b.Request()

});

function FillDistrict(c) {
    $("#DistrictID option").remove();
    $("#DistrictID").append(new Option("Seçiniz", "0"))
    for (var d = 0; d < c.result.length; d++) {
        $("#DistrictID").append(new Option(c.result[d].name, c.result[d].id)
        )
    }
}
