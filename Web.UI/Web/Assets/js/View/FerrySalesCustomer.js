var _childAge = [];
var _infantAge = [];
var _vehicleType = [];
var Parameter = {
	ReturnExpeditionID: 0
	, DepartureExpeditionID: 0
	, RouteType: 0
	, vehicleType: _vehicleType
	, AdultQuantity: 0
	, ChildQuantity: 0

	, InfantQuantity: 0
	, VehicleQuantity: 0
	, ChildAge: []
	, InfantAge: []
};


function Calculate() {
	_vehicleType = [];
	_vehicleType.push({ vehicleTypeID: getParameterByName("VehicleTypeID1") });
	_vehicleType.push({ vehicleTypeID: getParameterByName("VehicleTypeID2") });
	for (var d = 0; d < $(".childs").length; d++) {
		if ($("#ChildBirthDate" + (d + 1).toString()).val() !== "") {
			_childAge.push(
				{ age: $("#ChildBirthDate" + (d + 1).toString()).val() });
		}
	}
	for (var e = 0; e < $(".infants").length; e++) {
		if ($("#InfantBirthDate" + (e + 1).toString()).val() !== "") {
			_infantAge.push({ Age: $("#InfantBirthDate" + (e + 1).toString()).val() });
		}
	}
	var c = new AjaxBuilder({
		AjaxMethodType: AjaxMethodType.Post
		, RequestUrl: "../../ferrysearch/calculate"
		, Parameters: {
			returnExpeditionID: getParameterByName("ReturnExpeditionID")
			, departureExpeditionID: getParameterByName("DepartureExpeditionID")
			, routeType: getParameterByName("RouteType")
			, vehicleType: _vehicleType
			, adultQuantity: getParameterByName("AdultQuantity")
			, childQuantity: getParameterByName("ChildQuantity")
			, infantQuantity: getParameterByName("InfantQuantity")
			, vehicleQuantity: getParameterByName("VehicleQuantity")
			, childAge: _childAge
			, infantAge: []
		}, ProgressID: null, ProgressFunction: "loading", ComplateFunctionName: "FillCalculate"
	}); c.Request()
}
function FillCalculate(e) {
	if (e.valid == null) {
		var h = 0; var f = "";
		if (e.result !== null) {
			if (e.result.passenger !== null) {
				for (var g = 0; g < e.result.passenger.length; g++) { h += e.result.passenger[g].totalAmount; f = e.result.passenger[g].currencyTypeSymbol }
			} if (e.result.vehicle !== null) {
				for (var k = 0; k < e.result.vehicle.length; k++) { h += e.result.vehicle[k].totalAmount; f = e.result.vehicle[k].currencyTypeSymbol; }
			}
		} $("#ferrypricetotal strong").html(h + "" + f);
	} else { UIAlert(e.valid); }
}

$(document).ready(
	function () {
		Calculate()
	});

function Add() {
	var e = []; var f = [];
	$(".adults").each(function (b) {
		var a = this.id;
		e.push({ name: $("#AdultName" + a).val(), surName: $("#AdultSurName" + a).val(), birthDate: $("#AdultBirthDate" + a).val(), passportExpireDate: $("#AdultPassportExpireDate" + a).val(), passportNo: $("#AdultPassportNo" + a).val(), Gender: $("#AdultGender" + a).val(), CountryID: $("#AdultCountry" + a).val(), customerTypeID: 1, citizenshipID: $("#AdultCitizenshipID" + a).val() })

	});
	$(".childs").each(function (b) {
		var a = this.id; e.push({ name: $("#ChildName" + a).val(), surName: $("#ChildSurName" + a).val(), birthDate: $("#ChildBirthDate" + a).val(), passportExpireDate: $("#ChildPassportExpireDate" + a).val(), passportNo: $("#ChildPassportNo" + a).val(), gender: $("#ChildGender" + a).val(), countryID: $("#ChildCountry" + a).val(), customerTypeID: 2, citizenshipID: $("#AdultCitizenshipID" + a).val() }
		)
	});

	$(".vehicles").each(function (b) {
		var a = this.id;
		f.push({
			vehicleTypeID: $("#VehicleTypeID" + a).attr("typeof"), plate: $("#Plate" + a).val(), brand: $("#Brand" + a).val(), model: $("#Model" + a).val(), driveCustomerNumber: $("#DriveCustomerNumber" + a).val(), returnDriveCustomerNumber: $("#ReturnDriveCustomerNumber" + a).val()
		})
	});
	var h = {
		ticketSearch: {
			returnExpeditionID: getParameterByName("ReturnExpeditionID"),
			departureExpeditionID: getParameterByName("DepartureExpeditionID"),
			departureRegionID: getParameterByName("DepartureRegionID"),
			routeType: getParameterByName("RouteType"),
			vehicleType: _vehicleType,
			adultQuantity: getParameterByName("AdultQuantity"),
			childQuantity: getParameterByName("ChildQuantity"),
			infantQuantity: 0,
			vehicleQuantity: getParameterByName("VehicleQuantity"),
			childAge: _childAge,
			infantAge: _infantAge
		}, customer: e, Vehicle: f
	}; var g = new AjaxBuilder({
		AjaxMethodType: AjaxMethodType.Post,
		RequestUrl: "../../FerrySalesCustomer/add",
		ValidMessage: "validation",
		Parameters: { Parameter: h, Gsm: $("#Gsm").val(), Email: $("#Email").val() },
		ProgressID: null,
		ProgressFunction: "loading",
		ComplateFunctionName: "Success"
	});
	g.Request()
}

var productBasketList = [];
var dataLayer = dataLayer || [];

function Success(c) {

	if (c.valid == null) {

		if (c.result.passengerTicket != null) {
			for (var d = 0; d < c.result.passengerTicket.length; d++) {
				dataLayer.push({ event: "addToCart", ecommerce: { currencyCode: "TRY", add: { products: [{ id: c.result.passengerTicket[d].ID, name: c.result.passengerTicket[d].ferryName + "-" + c.result.passengerTicket[d].departureRegionName, price: (c.result.passengerTicket[d].totalSalesAmountTL), brand: c.result.passengerTicket[d].ferryName, category: "Feribot Bileri", variant: c.result.passengerTicket[d].departureRegionName, dimension1: c.result.passengerTicket[d].DepartureRegionName, quantity: 1 }] } } })
			}
		}

		/*criteo basket*/
		productBasketList = [];
		if (c.result.passengerTicket != null) {
			for (var d = 0; d < c.result.passengerTicket.length; d++) {
				productBasketList.push({ id: "FERRY" + c.result.passengerTicket[d].ferryID, price: c.result.passengerTicket[d].totalSalesAmount, quantity: 1 })
			}
		}

		dataLayer.push({
			event: 'crto_basketpage',
			crto: {
				email: '',
				products: productBasketList
			}
		});
		/*citeo*/


		$("#closepopup").css("display", "none")
		location.href = (invoiceurl + "?Voucher=" + c.result.guid)
	}
	else { UIAlert(c.valid) }
}

$(".form-control").change(function () {
	var b = 1; $("#DriveCustomerNumber1 option").remove(); $("#ReturnDriveCustomerNumber1 option").remove(); $("#DriveCustomerNumber2 option").remove(); $("#ReturnDriveCustomerNumber2 option").remove(); $(".adults .Name").each(function (d) { var a = this.id; $("#DriveCustomerNumber1").append(new Option($("#" + a).val() + " " + $("#" + a.replace("Name", "SurName")).val(), b)); $("#DriveCustomerNumber2").append(new Option($("#" + a).val() + " " + $("#" + a.replace("Name", "SurName")).val(), b)); $("#ReturnDriveCustomerNumber1").append(new Option($("#" + a).val() + " " + $("#" + a.replace("Name", "SurName")).val(), b)); $("#ReturnDriveCustomerNumber2").append(new Option($("#" + a).val() + " " + $("#" + a.replace("Name", "SurName")).val(), b)); b = b + 1 })
});

$(document).ready(function () {

	for (var b = 0; b < parseInt(getParameterByName("AdultQuantity")); b++) {
		$("#AdultBirthDate" + (b + 1)).datetimepicker({ lang: (navigator.language == undefined ? navigator.userLanguage : navigator.language).substr(0, 2), timepicker: false, format: "d.m.Y", formatDate: "d.m.Y", validateOnBlur: false, dayOfWeekStart: 1, closeOnDateSelect: true, }); $("#AdultPassportExpireDate" + (b + 1)).datetimepicker({ lang: (navigator.language == undefined ? navigator.userLanguage : navigator.language).substr(0, 2), timepicker: false, format: "d.m.Y", formatDate: "d.m.Y", validateOnBlur: false, dayOfWeekStart: 1, closeOnDateSelect: true })
	}
	for (var b = 0; b < parseInt(getParameterByName("ChildQuantity")); b++) {
		$("#ChildBirthDate" + (b + 1)).datetimepicker({ lang: (navigator.language == undefined ? navigator.userLanguage : navigator.language).substr(0, 2), timepicker: false, format: "d.m.Y", formatDate: "d.m.Y", validateOnBlur: false, dayOfWeekStart: 1, closeOnDateSelect: true }); $("#ChildPassportExpireDate" + (b + 1)).datetimepicker({ lang: (navigator.language == undefined ? navigator.userLanguage : navigator.language).substr(0, 2), timepicker: false, format: "d.m.Y", formatDate: "d.m.Y", validateOnBlur: false, dayOfWeekStart: 1, closeOnDateSelect: true })
	}
	for (var b = 0; b < parseInt(getParameterByName("InfantQuantity")); b++) {
		$("#InfantBirthDate" + (b + 1)).datetimepicker({ lang: (navigator.language == undefined ? navigator.userLanguage : navigator.language).substr(0, 2), timepicker: false, format: "d.m.Y", formatDate: "d.m.Y", validateOnBlur: false, dayOfWeekStart: 1, closeOnDateSelect: true }); $("#InfantPassportExpireDate" + (b + 1)).datetimepicker({ lang: (navigator.language == undefined ? navigator.userLanguage : navigator.language).substr(0, 2), timepicker: false, format: "d.m.Y", formatDate: "d.m.Y", validateOnBlur: false, dayOfWeekStart: 1, closeOnDateSelect: true })
	}
});

$("body").addClass("inner3");