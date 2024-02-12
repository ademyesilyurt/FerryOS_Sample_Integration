function SelectAllTimeTable() {
    var b = new AjaxBuilder(
        {
            AjaxMethodType: AjaxMethodType.Post
            , RequestUrl: "../TimeTable/SelectAllTimeTable",
            Parameters: {
                RouteZoneID: $("#RouteZoneID").val(), StartDate: $("#StartDate").val(), EndDate: $("#EndDate").val()
            }, ProgressID: null
            , ProgressFunction: "loading"
            , ComplateFunctionName: "FillTimeTable"
        }); b.Request()

}
function FillTimeTable(g) {
    var j = true;
    var h = true;
    var i = null;
    var k = null;
    $("#timetable tbody tr").remove();
    console.log(g);
    for (var l = 0; l < g.result.length; l++) {
        if (g.result[l].status == 1 && g.result[l].passengerRemainingQuota > 0)
            {
            if (g.result[l].departureRegionID == parseInt($("#RouteZoneID option:selected").attr("dp"))) {
                if (l > 1) {
                    if (g.result[l].serviceDate != g.result[l - 1].serviceDate) {
                        $("#timetable tbody").append("<tr><td class='ferrydate' colspan='7'>" + JsonToStrDate(g.result[l].serviceDate) + " - " + g.result[l].dayName + "</td></tr>")
                    }
                }
                else {
                    $("#timetable tbody").append("<tr><td class='ferrydate' colspan='7'>" + JsonToStrDate(g.result[l].serviceDate) + " - " + g.result[l].dayName + "</td></tr>")
                }
                $("#timetable tbody").append("<tr><td></td><td>" + g.result[l].departureRegionName + " | " + g.result[l].ferryName + "</td><td>" + JsonToStrHours(g.result[l].departureTime) + "</td><td>" + (g.result[l].vehicleRemainingQuota == 0 ? "No Car" : ".") + "</td><td class='borderleft' colspan='3'></td></tr>");
                if (k == null) {
                    k = g.result[l].departureRegionName.split("-")[0]
                }
            }
            else {
                if (l > 1) {
                    if (g.result[l].ServiceDate != g.result[l - 1].serviceDate) { $("#timetable tbody").append("<tr><td class='ferrydate' colspan='7'>" + JsonToStrDate(g.result[l].serviceDate) + " - " + g.result[l].dayName + "</td></tr>") }
                }
                $("#timetable tbody").append("<tr><td colspan='4'></td><td class='borderleft'>" + g.result[l].departureRegionName + " | " + g.result[l].ferryName + "</td><td>" + JsonToStrHours(g.result[l].departureTime) + "</td><td>" + (g.result[l].vehicleRemainingQuota == 0 ? "No Car" : ".") + "</td></tr>");
                if (i == null) {
                    i = g.result[l].departureRegionName.split("-")[0];
                }
            }
        }
    }
    $("#departure").html(k); $("#arrival").html(i);
} 

SelectAllTimeTable();