function initialize() {
	var m = new google.maps.LatLng(38.323463, 26.303023);
	var k = new google.maps.LatLng(38.317578, 26.304044);
	var i = new google.maps.LatLng(38.430163, 27.135874);
	var n = new google.maps.LatLng(38.322586, 26.297607);
	var h = new google.maps.LatLng(38.37285040198313, 26.13864773158457);
	var j = new google.maps.Map(document.getElementById("mapCanvas"), {
		zoom: 9, center: m, mapTypeId: google.maps.MapTypeId.ROADMAP
	}); var l = new google.maps.Marker({ position: m, title: "Çeşme Merkez Ofis", map: j, draggable: false });
	
} initialize(); function Send() {
	var b = new AjaxBuilder(
		{
			AjaxMethodType: AjaxMethodType.Post, RequestUrl: "../../contact/Send", ValidMessage: "ValidMessage", Parameters: {
				Name: $("#Name").val(),
				SurName: $("#SurName").val(),
				Email:$("#Email").val(),
				Phone: $("#Phone").val(),
				Subject: $("#Subject").val(),
				Message: $("#Message").val(),
				ValidationCode: $("#ValidationCode").val(),
				LangCode: $("#language").attr("content")
			}, ProgressID: "load", ProgressFunction: "loading", ComplateFunctionName: "SendSuccess"
		}); b.Request();
} function SendSuccess(b) { if (b.Status === 200) { UIAlert(b.Result); } }