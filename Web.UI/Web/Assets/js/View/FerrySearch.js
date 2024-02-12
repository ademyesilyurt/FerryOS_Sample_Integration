
var selectGo = 0;
var selectReturn = 0;

var _vehicleType = [];
var childAge = [];
var infantAge = [];


function GetVehiclePrice(FerryID, RouteZoneID, RouteID) {

    var ajaxFerryCalculate = new AjaxBuilder(
        {
            AjaxMethodType: AjaxMethodType.Post
            , RequestUrl: "../../FerrySearch/VehiclePrice"
            , Parameters: {
                FerryID: ferryID
                , RouteZoneID: routeZoneID
                , RouteID: routeID


            }
            , ProgressID: null
            , ProgressFunction: "loading"
            , ComplateFunctionName: "FillVehiclePrice"
        }
    );
    ajaxFerryCalculate.Request();
}

function FillVehiclePrice(api) {

    var html = "";
    for (var xx = 0; xx < api.result.length; xx++) {
        $("#vehicleprices .modal-title").html(api.result[xx].ferryName + " - " + ARAC_FIYATLARI);
        for (var i = 0; i < api.result[xx].route.length; i++) {
            if (api.result[xx].route[i].routeID === api.id) {
                html += '<table class="table" style="width:100%;    font-size: 12px;">';
                html += '<thead>';
                html += '<tr>';
                html += '    <td colspan="5">' + api.result[xx].route[i].departureRegionName + '>' + api.result[xx].route[i].arrivalRegionName + '</td>';
                html += '</tr>';
                html += '<tr>';
                html += '    <td>' + YOLCU_TIPI + '</td>';
                html += '    <td>' + TEK_YON + '</td>';
                html += '    <td>' + DONUS_ACIK + '</td>';
                html += '    <td>' + AYNI_GUN_GIDIS_DONUS + '</td>';
                html += '    <td>' + FARKLI_GUN_GIDIS_DONUS + '</td>';
                html += '</tr>';
                html += '    </thead>';
                html += '<tbody>';
                for (var x = 0; x < api.result[xx].route[i].price.vehicle.length; x++) {

                    html += '<tr>';
                    html += '<td>' + api.result[xx].route[i].price.Vehicle[x].ferryVehicleTypeName + '</td>';
                    html += '<td>' + api.result[xx].route[i].price.Vehicle[x].oneWaySalesAmount + api.result[xx].route[i].price.vehicle[x].currencyTypeSymbol + '</td>';
                    html += '<td>' + api.result[xx].route[i].price.Vehicle[x].openReturnSalesAmount + api.result[xx].route[i].price.vehicle[x].currencyTypeSymbol + '</td>';
                    html += '<td>' + api.result[xx].route[i].price.Vehicle[x].returnSameDaySalesAmount + api.result[xx].route[i].price.vehicle[x].currencyTypeSymbol + '</td>';
                    html += '<td>' + api.result[xx].route[i].price.Vehicle[x].returnDifferentDaySalesAmount + api.result[xx].route[i].price.vehicle[x].currencyTypeSymbol + '</td>';
                    html += '</tr>';

                }
                html += '</tbody>';
                html += '</table>';
            }
        }
    }
    $("#vehicleprices .modal-body").html(html);
    $('#vehicleprices').modal();
}



$("#ferrysearch").click(

    function () {

        if ($('input[name=RouteType]:checked').val() != "2") {
            $(".goingferry").removeClass("col-lg-6");
            $(".goingferry").addClass("col-lg-12");
            $(".goingferry img").css("width", "auto")
            $(".goingferry img").css("height", "100px")
            $(".returningferry").css("display", "none")
        } else {
            $(".goingferry").removeClass("col-lg-12");
            $(".goingferry").addClass("col-lg-6");
            $(".goingferry img").css("width", "100%")
            $(".goingferry img").css("height", "auto")
            $(".returningferry").css("display", "")
        }

        _vehicleType = [];
        if ($("#VehicleQuantity").val() == "1")
            _vehicleType.push({ VehicleTypeID: $("#vehicle1").val() })
        if ($("#VehicleQuantity").val() == "2") {
            _vehicleType.push({ VehicleTypeID: $("#vehicle1").val() })
            _vehicleType.push({ VehicleTypeID: $("#vehicle2").val() })
        }

        childAge = [];
        for (var i = 0; i < parseInt($("#ChildQuantity").val()); i++) {
            if ($("#childage" + (i + 1).toString()).val() != "")
                childAge.push({ age: $("#childage" + (i + 1).toString()).val() });
        }



        $(".returningferry ul li").remove();
        $(".goingferry ul li").remove();
        $(".ferrypricetotal strong").html("");


        var param = {
            departureRegionID: $("#DepartureRegionID").val()
            , arrivalRegionID: $("#ArrivalRegionID").val()
            , serviceDate: $("#DepartureDate").val()
            , returnServiceDate: $("#ReturnDate").val()
            , routeType: $('input[name=RouteType]:checked').val()
            , vehicleType: _vehicleType
            , adultQuantity: $("#AdultQuantity").val()
            , childQuantity: $("#ChildQuantity").val()
            , infantQuantity: $("#InfantQuantity").val()
            , vehicleQuantity: $("#VehicleQuantity").val()
            , childAge: childAge
            , infantAge: []
            , langCode: $('html').attr("lang")


        }



        var ajaxFerrySearch = new AjaxBuilder(
            {
                AjaxMethodType: AjaxMethodType.Post
                , RequestUrl: "../../ferrysearch/Search"
                , validMessage: "validation"
                , Parameters: param
                , ProgressID: null
                , ProgressFunction: "loading"
                , ComplateFunctionName: "FillFerrySearchresult"
            }
        );


        ajaxFerrySearch.Request();





    }
);


function SelectExpedition(id, r) {

    if (!$("#" + id).hasClass("selectpassive")) {
        $("." + r + " .row").removeClass("selectex");
        $("#" + id).addClass("selectex");
        var availableferry = $("#" + id).attr("withferriesavailable").split(",");
        if (r == "goingferry") {
            selectGo = id;
            $(".returningferry .row").removeClass("selectex");
            $(".returningferry .row").removeClass("selectpassive");
            $(".returningferry .row").each(function (index) {
                var rid = "#" + this.id;
                var aktif = false;
                for (var i = 0; i < availableferry.length; i++) {
                    if ($(rid).attr("ferryid") == availableferry[i])
                        aktif = true;
                }
                if (!aktif)
                    $(rid).addClass("selectpassive")
            });
            selectReturn = 0;
            if (/Android|webOS|iPhone|iPad|iPod|BlackBerry|IEMobile|Opera Mini/i.test(navigator.userAgent)) {
                if ($('input[name=RouteType]:checked').val() == "2")

                    $('html, body').animate({
                        scrollTop: $("#" + $(".goingferry .row:first").attr("id")).offset().top
                    }, 500, 'linear');


                else
                    $('html, body').animate({
                        scrollTop: $("#" + $(".goingferry .row:last").attr("id")).offset().top
                    }, 500, 'linear');

            }


            if ($('input[name=RouteType]:checked').val() != "2")
                Calculate();

        }
        else {
            selectReturn = id;
            if (/Android|webOS|iPhone|iPad|iPod|BlackBerry|IEMobile|Opera Mini/i.test(navigator.userAgent)) {
                $('html, body').animate({
                    scrollTop: $("#" + $(".returningferry .row:last").attr("id")).offset().top
                }, 500, 'linear');

                if (selectGo == 0)
                    $('html, body').animate({
                        scrollTop: $("#" + $("#ReturnDate").attr("id")).offset().top
                    }, 500, 'linear');

            }

            Calculate();


        }

    }
}
var dataLayer = dataLayer || [];
var listProduct = [];

function FillFerrySearchresult(api) {
    console.log(api);
    listProduct = [];

    if (api.valid == null) {
        $(".goingferry .row").remove();

        var hs = null
        var hsid = 0;
        for (var i = 0; i < api.result.length; i++) {
            if (api.result[i].ferryID === 1) {
                hs = true;
                hsid = api.result[i].ferryID;
            }
        }

        if (api.result.length > 0) {
            
            if (JsonToStrDate(api.result[0].serviceDate) != $("#DepartureDate").val())
                UIAlert("Giriş için Uygun sefer bulunamadı en yakın seferler listelenmektedir.");
        }

        for (var i = 0; i < api.result.length; i++) {

            

            $(".goingferry").append("<div class='row row small-gutters mt-md-0 mt-sm-2' FerryID='" + api.result[i].ferryID + "'  WithFerriesAvailable='" + api.result[i].withFerriesAvailable + "' id='" + api.result[i].expeditionID + "'>"
                + "<div class= 'col-sm-6 col-md-4 col-lg-4 col-xl-4 col-xxl-4 col-6'>"
                + "<img src='" + system_url + "/storage/" + company_id + "/ferry/" + api.result[i].ferryID + "/medium/" + api.result[i].picture + "'>"
                + "</div>"
                + "<div class='col-sm-6 col-md-4 col-lg-4 col-xl-4 col-xxl-4 col-6'>"
                + "<label><b>" + api.result[i].ferryName + "</b></label><br />"
                + "<label>" + api.result[i].ferryCompanyName + "</label>"
                + "<label><b>" + kalkis_limani + "</b> : " + api.result[i].departurePort + "</label>"
                + "<label><b>" + varis_limani + "</b> : " + api.result[i].arrivalPort + "</label>"

                + "<label>"
                + "<i class='fa fa-clock-o' aria-hidden='true'></i><div>" + SeyahatSuresi + " " + api.result[i].travelTime + " " + dk + "</div>"
                + "</label>"
                + "</div>"
                + "<div class='col-sm-6 col-md-3 col-lg-3 col-xl-3 col-xxl-3 col-6'>" + JsonToStrDate(api.result[i].serviceDate) + "<br />" + HourParse(api.result[i].departureTime) + "</div>"
                + "<div class='col-sm-6 col-md-1 col-lg-1 col-xl-1 col-xxl-1 col-6'>"
                + "<button type='button' class='selectbtn' onclick='SelectExpedition(" + api.result[i].expeditionID + ",\"goingferry\")'>" + SECINIZ + "</button>"
                + "</div>"

                + (api.result[i].description === null ? "" : "<div class='col-12'><label itemprop='description'>" + (api.result[i].description === null ? "" : api.result[i].description) + "</label></div>")
                + "</div>");
            if (hs == true & hsid == api.result[i].ferryID)
                hsid = 111111
            listProduct.push("1000" + '' + api.result[i].ferryID);

        }

        dataLayer.push({
            event: 'crto_listingpage',
            crto: {
                email: '',
                products: listProduct
            }
        });

    }
    else {
        $(".goingferry ul li").remove();
        if (api.Status == 404) {
            $(".goingferry ul").append("<li>" + api.valid[0].value + "</li>");

        }
        UIAlert(api.valid);
    }

    if ($('input[name=RouteType]:checked').val() != "2") {

        $(".goingferry img").css("width", "auto")
        $(".goingferry img").css("height", "100px")

    } else {

        $(".goingferry img").css("width", "100%")
        $(".goingferry img").css("height", "auto")



    }

    if ($('input[name=RouteType]:checked').val() == "2" & $("#ReturnDate").val() != "") {



        var ajaxFerryReturnSearch = new AjaxBuilder(
            {
                AjaxMethodType: AjaxMethodType.Post
                , RequestUrl: "../../ferrysearch/Search"
                , Parameters: {
                    departureRegionID: $("#ArrivalRegionID").val()
                    , arrivalRegionID: $("#DepartureRegionID").val()
                    , serviceDate: $("#ReturnDate").val()
                    , returnServiceDate: $("#DepartureDate").val()
                    , pouteType: $('input[name=RouteType]:checked').val()
                    , vehicleType: _vehicleType
                    , adultQuantity: $("#AdultQuantity").val()
                    , childQuantity: $("#ChildQuantity").val()
                    , infantQuantity: $("#InfantQuantity").val()
                    , vehicleQuantity: $("#VehicleQuantity").val()
                    , childAge: childAge
                    , infantAge: []
                    , langCode: $('html').attr("lang")

                }
                , ProgressID: null
                , ProgressFunction: "loading"
                , ComplateFunctionName: "FillFerryReturnSearchresult"
            }
        );
        ajaxFerryReturnSearch.Request();
    }

}


function FillFerryReturnSearchresult(api) {
     
    if (api.valid == null) {

        var hs = null
        var hsid = 0;
        for (var i = 0; i < api.result.length; i++) {
            if (api.result[i].ferryID == 1) {
                hs = true;
                hsid = api.result[i].ferryID
            }
        }
        if (api.result.length > 0) {

            if (JsonToStrDate(api.result[0].serviceDate) != $("#ReturnDate").val())
                UIAlert("Dönüş için Uygun sefer bulunamadı en yakın seferler listelenmektedir.");
        }


        $(".returningferry .row").remove();

        for (var i = 0; i < api.result.length; i++) {
            $(".returningferry").append("<div class='row row small-gutters mt-md-0 mt-sm-2' FerryID='" + api.result[i].ferryID + "'  WithFerriesAvailable='" + api.result[i].withFerriesAvailable + "' id='" + api.result[i].expeditionID + "'>"
                + "<div class='col-sm-6 col-md-4 col-lg-4 col-xl-4 col-xxl-4 col-6'>"
                + "<img src='" + system_url + "/storage/" + company_id +"/ferry/" + api.result[i].ferryID + "/medium/" + api.result[i].picture + "'>"
                + "</div>"
                + "<div class='col-sm-6 col-md-4 col-lg-4 col-xl-4 col-xxl-4 col-6'>"
                + "<label><b>" + api.result[i].ferryName + "</b></label><br />"
                + "<label>" + api.result[i].ferryCompanyName + "</label>"
                + "<label><b>" + kalkis_limani + "</b> : " + api.result[i].departurePort + "</label>"
                + "<label><b>" + varis_limani + "</b> : " + api.result[i].arrivalPort + "</label>"

                + "<label>"
                + "<i class='fa fa-clock-o' aria-hidden='true'></i><div>" + SeyahatSuresi + " " + api.result[i].travelTime + " " + dk + "</div>"
                + "</label>"
                + "</div>"
                + "<div class='col-sm-6 col-md-3 col-lg-3 col-xl-3 col-xxl-3 col-6'>" + JsonToStrDate(api.result[i].serviceDate) + "<br />" + HourParse(api.result[i].departureTime) + "</div>"
                + "<div class='col-sm-6 col-md-1 col-lg-1 col-xl-1 col-xxl-1 col-6'>"
                + "<button type='button' class='selectbtn' onclick='SelectExpedition(" + api.result[i].expeditionID + ",\"returningferry\")'>" + SECINIZ + "</button>"
                + "</div>"
                + (api.result[i].description === null ? "" : "<div class='col-12'><label itemprop='description'>" + (api.result[i].description === null ? "" : api.result[i].description) + "</label></div>")
                + "</div>");
            if (hs == true & hsid == api.result[i].ferryID)
                hsid = 111111


        }





    }
    else {
        $(".goingferry .row").remove();
        $(".returningferry .row").remove();

        if (api.success == false) {
            $(".goingferry").append("<div class='row'>" + api.valid[0].value + "</div>");
            $(".returningferry").append("<div class='row'>" + api.valid[0].value + "</div>");
        }


    }


}





function Calculate() {




    _vehicleType = [];

    if ($("#VehicleQuantity").val() == "1")
        _vehicleType.push({ vehicleTypeID: $("#vehicle1").val() })
    if ($("#VehicleQuantity").val() == "2") {
        _vehicleType.push({ vehicleTypeID: $("#vehicle1").val() })
        _vehicleType.push({ vehicleTypeID: $("#vehicle2").val() })
    }

    childAge = [];
    for (var i = 0; i < $(".child_age").length; i++) {
        if ($("#childage" + (i + 1).toString()).val() != "")
            childAge.push({ age: $("#childage" + (i + 1).toString()).val() });
    }



    var ajaxFerryCalculate = new AjaxBuilder(
        {
            AjaxMethodType: AjaxMethodType.Post
            , RequestUrl: "../../FerrySearch/calculate"
            , Parameters: {
                returnExpeditionID: selectReturn
                , departureExpeditionID: selectGo
                , routeType: $('input[name=RouteType]:checked').val()
                , departureRegionID: $("#DepartureRegionID").val()
                , vehicleType: _vehicleType
                , adultQuantity: $("#AdultQuantity").val()
                , childQuantity: $("#ChildQuantity").val()
                , infantQuantity: 0
                , vehicleQuantity: $("#VehicleQuantity").val()
                , childAge: childAge
                , infantAge: []
            }
            , ProgressID: null
            , ProgressFunction: "loading"
            , ComplateFunctionName: "FillCalculate"
        }
    );
    ajaxFerryCalculate.Request();
}

function FillCalculate(api) {
    console.log(api)
    if (api.valid == null) {
        var total = 0;
        var currency = "";
        var ProductCampaignValue = 0;
        var ProductCampaignName = "";
        var ProductCampaignValueType = 0;
        if (api.result != null) {

            if (api.result.passenger != null)
                for (var i = 0; i < api.result.passenger.length; i++) {
                    total += api.result.passenger[i].totalAmount;
                    currency = api.result.passenger[i].currencyTypeSymbol;
                    ProductCampaignValue += api.result.passenger[i].productCampaignValue;
                    if (ProductCampaignName != api.result.passenger[i].productCampaignName && api.result.passenger[i].productCampaignName != "") {
                        ProductCampaignName += api.result.passenger[i].productCampaignName;
                        ProductCampaignValueType = api.result.passenger[i].productCampaignValueType;
                    }
                }

            if (api.result.vehicle != null)
                for (var i = 0; i < api.result.vehicle.length; i++) {
                    total += api.result.vehicle[i].totalAmount;
                    currency = api.result.vehicle[i].currencyTypeSymbol;
                    ProductCampaignValue += api.result.vehicle[i].productCampaignValue;
                    if (ProductCampaignName != api.result.vehicle[i].productCampaignName && api.result.vehicle[i].productCampaignName != "") {
                        ProductCampaignName += api.result.vehicle[i].productCampaignName;
                        ProductCampaignValueType = api.result.vehicle[i].productCampaignValueType;
                    }
                }
        }
        if (ProductCampaignValue > 0) {
            $(".ferrypricetotal #discount").html(ProductCampaignName + " " + (ProductCampaignValueType == 1 ? "" : "%") + ProductCampaignValue + (ProductCampaignValueType == 1 ? "€" : ""));
            if (ProductCampaignValueType == 1)
                $(".ferrypricetotal #discountprice").html((ProductCampaignValue + total).toFixed(2) + "€");
            else
                $(".ferrypricetotal #discountprice").html((((ProductCampaignValue / 100) + 1) * total).toFixed(2) + "€");
        } else
            $(".ferrypricetotal #discount").html("");
        $(".ferrypricetotal #price").html(total.toFixed(2) + "" + currency);
    } else {
        UIAlert(api.valid);
        $(".ferrypricetotal strong").html("-");
    }
}

$("#continue").click(
    function () {
        if ($(".ferrypricetotal strong").html() != "-") {
            var cont = true;
            if (($('input[name=RouteType]:checked').val() == "1" || $('input[name=RouteType]:checked').val() == "3") & selectGo == 0)
                cont = false;
            if ($('input[name=RouteType]:checked').val() == "2" & (selectGo == 0 || selectReturn == 0))
                cont = false;

            if (cont)
                location.href = "../FerrySalesCustomer"  + "?ReturnExpeditionID=" + (selectReturn) + "&DepartureExpeditionID=" + selectGo + "&RouteType=" + $('input[name=RouteType]:checked').val() + "&DepartureRegionID=" + $("#DepartureRegionID").val() + "&DepartureDate=" + $("#DepartureDate").val() + "&ReturnDate=" + $("#returndate").val() + "&VehicleQuantity=" + $("#VehicleQuantity").val() + "&AdultQuantity=" + $("#AdultQuantity").val() + "&ChildQuantity=" + $("#ChildQuantity").val() + "&InfantQuantity=" + $("#InfantQuantity").val() + "&VehicleTypeID1=" + (_vehicleType.length > 0 ? _vehicleType[0].vehicleTypeID : 0) + "&VehicleTypeID2=" + (_vehicleType.length > 1 ? _vehicleType[1].vehicleTypeID : 0) + "&Child1Age=" + $("#childage1").val() + "&Child2Age=" + $("#childage2").val() + "&Child3Age=" + $("#childage3").val();
            else
                UIAlert(uygun_sefer_seciniz)
        }
        else
            UIAlert(uygun_sefer_seciniz)
    }
);

$(".wantnot").css("display", "none");
$(".subinnernav").css("margin-bottom", "0px");

$(".subinnernav li").eq(0).addClass("current")

$(document).ready(
    function () {

        $(".blk1 a").html("FERIBOT BİLETİ");
        $(".blk2 a").html("YOLCU BİLGİLERİ");
        $("body").addClass("inner3");

        $("#ferrysearch").click();

    }
);