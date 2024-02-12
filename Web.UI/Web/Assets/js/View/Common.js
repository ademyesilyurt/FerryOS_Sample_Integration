
$("#DepartureRegionID").change(function () {
	var d = $("#DepartureRegionID").val();
	$("#DepartureRegionID").val(d);
	$("#ArrivalRegionID option").remove();
	$("#ArrivalRegionID").append(new Option("-", ""));
	var c = new AjaxBuilder({
		AjaxMethodType: AjaxMethodType.Post, RequestUrl: "../common/ArrivalRegion",
		Parameters: { regionID: $("#DepartureRegionID").val() },
		ProgressID: null, ProgressFunction: "loading",
		ComplateFunctionName: "FillArrival"
	});
	c.Request()
});
function FillArrival(c) {

	$("#ArrivalRegionID option").remove();
	for (var d = 0; d < c.result.length; d++) {
		$("#ArrivalRegionID").append("<option " + (d == 0 ? "selected" : "") + " value='" + c.result[d].regionID + "'>" + c.result[d].name + "</option>");
	}
	if ($("#DepartureRegionID").val() == "") {
		$("#ArrivalRegionID").append("<option  selected value='0'>-</option>");
	}




	if ($("#ferrysearch") != []) {
		$("#ferrysearch").click();
	}



}


$("#lang").change(
	function () {
		location.href = "../" + $("#lang").val();
	}
);