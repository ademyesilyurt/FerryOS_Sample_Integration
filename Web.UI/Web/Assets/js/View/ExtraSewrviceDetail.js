$('.carousel').carousel(

)
$("#ChildQuantity").change(
    function () {

        if ($("#ChildQuantity").val() === "1") {
            $("#childage1").css("display", "");
            $("#childage2").css("display", "none");
            $("#childage3").css("display", "none");
        }
        if ($("#ChildQuantity").val() === "2") {
            $("#childage1").css("display", "");
            $("#childage2").css("display", "");
            $("#childage3").css("display", "none");
        }
        if ($("#ChildQuantity").val() === "3") {
            $("#childage1").css("display", "");
            $("#childage2").css("display", "");
            $("#childage3").css("display", "");
        }
        if ($("#ChildQuantity").val() === "0") {
            $("#childage1").css("display", "none");
            $("#childage2").css("display", "none");
            $("#childage2").css("display", "none");
            $("#childage3").css("display", "none");
        }
    });


$(document).ready(
    function () {
        $(".blk1 a").html("FERIBOT BİLETİ");
        $(".blk2 a").html("YOLCU BİLGİLERİ");
        $(".blk1").removeClass("active");
        $(".blk3").addClass("active");
        $("body").addClass("inner3");

    });

$(".make_reserve").click(
    function () {
        $('html, body').animate({
            scrollTop: $(".slick-track").offset().top
        }, 500, 'linear');
    }
);
var calculateresult = null;
var productBasketList = [];
function BasketExtraService(j) {



    var g = $("#ServiceDate").val();
    var f = []; $(".searchresult .row").each(
        function (a) {
            f.push({
                name: $("#Name" + (a + 1).toString()).val(),
                surName: $("#SurName" + (a + 1).toString()).val(),
                BirthDate: $("#BirthDate" + (a + 1).toString()).val(),
                extraServicePropertiesID: $("#extraServicePropertiesID" + (a + 1).toString()).val(), customerTypeID: $("#Name" + (a + 1).toString()).attr("ctype")
            });
        });
    var i = new AjaxBuilder({
        AjaxMethodType: AjaxMethodType.Post,
        RequestUrl: "../../ExtraServiceDetail/Add",
        validMessage: "validMessage",
        Parameters: { serviceID: j, langCode: $("#language").attr("content"), serviceDate: g, voucherGuid: getParameterByName("Voucher"), customer: f },
        ProgressID: null,
        ProgressFunction: "loading",
        ComplateFunctionName: "ExtraserviceBasketSuccess"
    });
    i.Request()






}
function ExtraserviceBasketSuccess(b) {
    console.log(b);
    if (b.valid === null) {
        SATIN_ALMA_YONLENDIRME_UYARI = SATIN_ALMA_YONLENDIRME_UYARI.replace("#VOUCHER#", b.result);
        SATIN_ALMA_YONLENDIRME_UYARI = SATIN_ALMA_YONLENDIRME_UYARI.replace("#VOUCHER#", b.result);
        PopUp(SATIN_ALMA_YONLENDIRME_UYARI, "", 430, 215);
        location.href = SATIN_ALMA_YONLENDIRME_URL + "?Voucher=" + b.result;
        $("#closepopup").css("display", "none")


    } else { UIAlert(b.valid) }
}
var serviceid = 0;
function Calculate(p) {
    var i = $("#AdultQuantity").val();
    var k = parseInt($("#ChildQuantity").val());
    var m = p;
    serviceid = p;
    var l = $("#ServiceDate").val();
    var n = getParameterByName("Voucher");
    var j = [];

    for (var x = 0; x < k; x++) {
        if ($("#childage" + (x + 1) + "" + (x + 1)).val() !== "") { j.push({ birthDate: $("#childage" + (x + 1) + "" + (x + 1)).val() }) }
    }


    var o = new AjaxBuilder({
        AjaxMethodType: AjaxMethodType.Post, RequestUrl: "../../ExtraServiceDetail/Calculate", validMessage: "validMessage", Parameters: { adultQuantity: i, childQuantity: k, serviceID: m, langCode: $("#language").attr("content"), serviceDate: l, voucherGuid: n, childBirthDate: j },
        ProgressID: null, ProgressFunction: "loading", ComplateFunctionName: "ExtraserviceCalculateSuccess"
    }); o.Request()
}


function ExtraserviceCalculateSuccess(i) {
    console.log(i);
    var total = 0;
    var ctype = "";
    var bdate = "";

    $(".searchresult div").remove(); var h = 0;
    var j = 0;
    var n = 0;
    if (i.valid == null)
        i.valid = [];

        if (i.valid.length === 0) {
            for (var l = 0; l < i.result.length; l++) {
                if (i.result[l].customerTypeID === 1)
                { h = h + 1; n = h }
                else { j = j + 1; n = j }
                var k = "";
                if (i.result[l].extraServiceProperties !== null) {
                    for (var m = 0; m < i.result[l].extraServiceProperties.length; m++) {
                        k += "<option value=" + i.result[l].extraServiceProperties[m].ID + "> " + i.result[l].extraServiceProperties[m].name + "</option>"
                    }
                    if (k !== "") {
                        k = "<select id=extraServicePropertiesID" + (l + 1) + ">" + k + "</select>";
                    }
                }

                if (i.result[l].customerTypeID === 2 || i.result[l].customerTypeID === 3) {
                    bdate = JsonToStrDate(i.result[l].birthDate);
                }

                $(".searchresult").append('<div class="row"><div class="col-md-2"><div class="form-group"><label><b>' + (l + 1) + " - " + (i.result[l].customerTypeID == 1 ? "Yetişkin" : i.result[l].customerTypeID == 2 ? "Çocuk" : "Bebek") + "</b></label> </br> <label><b style='font-size:22px;'>" + i.result[l].amount + i.result[l].currencyTypeSymbol + '</b></label></div></div><div class="col-md-3"><div class="form-group"><label for="Name' + (l + 1) + '">Ad</label><input ctype="' + i.result[l].customerTypeID + '" type="text" id="Name' + (l + 1) + '" name="name" class="form-control Name"></div></div><div class="col-md-3"><div class="form-group"><label>Soyad</label><input type="text" class="form-control" id="SurName' + (l + 1) + '" name="name"></div></div><div class="col-md-3"><div class="form-group"><label>Doğum Tarihi</label><input type="text" value="' + bdate + '" id="BirthDate' + (l + 1) + '" name="name" style="border:1px solid #dcdcdc; width:100%" class="txtdate form-control"/></div></div>' + (i.result[l].extraServicePropertiesCategoriesName === null?"":'<div class="col-md-3"><div class="form-group"><label>' + (i.result[l].extraServicePropertiesCategoriesName) + "</label>" + k + '</div>')+'</div></div></div><hr>')
                total += i.result[l].amount;
                ctype = i.result[l].currencyTypeSymbol;
                bdate = "";

                productBasketList.push({ id: "2000" + serviceid, price: i.result[l].amount, quantity: 1 })
            }
            $(".searchresult").append("<div class='row' style='margin-bottom:50px;margin-top:30px;'><div class='col-md-4'><label style='font-size:22px;'>TOPLAM <b>" + total + ctype + "</b></label></div><div class='col-md-8'><input type='button' class='btn btn-orange' value='SEPETE EKLE' onclick='BasketExtraService(" + serviceid + ")' /></div></div>");

            datepic();
        } else {
            UIAlert(i.valid);
        }
     
};






$(function ($) {
    var options = {
        writable: true,
        minimum: 2,
        maximize: 12,
        onChange: function (v) {
            $('#adult').text(v)
        },
        onMinimum: function (e) {
            console.log('reached minimum: ' + e)
        },
        onMaximize: function (e) {
            console.log('reached maximize' + e)
        }
    }
    $('#handleCounter').handleCounter(options)
    $('#handleCounter2').handleCounter(options)
    $('#handleCounter3').handleCounter({ maximize: 100 })
})



$(function ($) {
    var options = {
        writable: true,
        minimum: 2,
        maximize: 11,
        onChange: function (v) {
            $('#change').text(v)
        },
        onMinimum: function (e) {
            console.log('reached minimum: ' + e)
        },
        onMaximize: function (e) {
            console.log('reached maximize' + e)
        }
    }
    $('#handleCount').handleCounter(options)
    $('#handleCount2').handleCounter(options)
    $('#handleCount3').handleCounter({ maximize: 100 })
})







var dataLayer = dataLayer || [];
dataLayer.push({
    event: 'crto_productpage',
    crto: {
        email: '',
        products: ["2000" + $("#ProductID").val()]
    }
});