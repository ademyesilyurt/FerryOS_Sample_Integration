var AjaxMethodType = { Post: "post", Get: "get" };

function isParameter(Parameters, id) {
	var ok = false;

	for (key in Parameters) {
		if (key == id) {
			ok = true;
		}
	}

	return ok;
}


function isNameList(list, name) {
	var ok = false;

	for (var i = 0; i < list.length; i++) {
		if (name == list[i])
			ok = true;
	}
	return ok;
}

var AjaxBuilder = function (Parameter) {

	AjaxBuilder.prototype.AjaxBuilderresult = { valid: {}, success: false, result: null, RecordCount: 0, ID: 0 };
	AjaxBuilder.prototype.Request = function () {

		if (Parameter.GroupElementID != null) {
			$("#" + Parameter.GroupElementID + " input[type=text]").each(function (index) {
				if (!isParameter(Parameter.Parameters, this.id))
					Parameter.Parameters[this.id] = $("#" + this.id).val()
			});

			$("#" + Parameter.GroupElementID + " select").each(function (index) {
				if (!isParameter(Parameter.Parameters, this.id))
					Parameter.Parameters[this.id] = $("#" + this.id).val()
			});
			$("#" + Parameter.GroupElementID + " textarea").each(function (index) {
				if (!isParameter(Parameter.Parameters, this.id))
					Parameter.Parameters[this.id] = $("#" + this.id).val()
			});

			$("#" + Parameter.GroupElementID + " input[type=checkbox]").each(function (index) {
				if (!isParameter(Parameter.Parameters, this.id))
					Parameter.Parameters[this.id] = $("#" + this.id).is(":checked")
			});

			var radiolistname = [];
			$("#" + Parameter.GroupElementID + " input[type=radio]").each(function (index) {
				if (!isParameter(Parameter.Parameters, this.name))
					if (!isNameList(radiolistname, this.name))
						radiolistname.push(this.name);
			});

			for (var i = 0; i < radiolistname.length; i++) {
				if (!isParameter(Parameter.Parameters, radiolistname[i]))
					Parameter.Parameters[radiolistname[i]] = $('input[name=' + radiolistname[i] + ']:checked').val()
			}

		}
		console.log(Parameter)
		$.ajax(
			{
				type: Parameter.AjaxMethodType,
				url: Parameter.RequestUrl,
				data: Parameter.Parameters,
				dataType: "JSON",
				async: true,
				beforeSend: function (xhr) {

					if (Parameter.ProgressFunction != null)
						window[Parameter.ProgressFunction](false);
					if (Parameter.ProgressID != null)
						$("#" + Parameter.ProgressID).css("display", "block");
				},
				success: function (result) {

					if (result.valid != null && result.valid.length > 0) {
						if (Parameter.validMessage != null && Parameter.validMessage != undefined) {
							$("#" + Parameter.validMessage).css("border", "1px solid #EC1212");
							$("#" + Parameter.validMessage).css("border-left", "4px solid #EC1212");
							$("#" + Parameter.validMessage).css("padding", "5px");
							$("#" + Parameter.validMessage).css("margin-bottom", "5px");
							$("#" + Parameter.validMessage).css("color", "#a94442");
							$("#" + Parameter.validMessage).html("");
						}
						var keys = result.valid;

						for (var i = 0; i < keys.length; i++) {

							if (keys[i].Key != "" && keys[i].Key != null)
								$("#" + keys[i].Key.split('.')[1]).css("border", "1px solid red");

							if (Parameter.validMessage != null && Parameter.validMessage != undefined)
								$("#" + Parameter.validMessage).append("● " + keys[i].Value + "<br>");
						}



						$("input").click(
							function () {
								$(this).removeAttr("style");
							}
						);



						AjaxBuilder.prototype.AjaxBuilderresult.result = result.result;
						AjaxBuilder.prototype.AjaxBuilderresult.success = result.success;
						AjaxBuilder.prototype.AjaxBuilderresult.valid = result.valid;
						AjaxBuilder.prototype.AjaxBuilderresult.ID = result.ID;
						AjaxBuilder.prototype.AjaxBuilderresult.RecordCount = result.RecordCount;
						if (Parameter.ComplateFunctionName != null)
							window[Parameter.ComplateFunctionName](AjaxBuilder.prototype.AjaxBuilderresult);
					}
					else {
						$("#" + Parameter.validMessage).css("border", "0px");
						$("#" + Parameter.validMessage).css("border-left", "0px");
						$("#" + Parameter.validMessage).css("padding", "0px");
						$("#" + Parameter.validMessage).css("margin-bottom", "0px");
						$("#" + Parameter.validMessage).html("");

						AjaxBuilder.prototype.AjaxBuilderresult.result = result.result;
						AjaxBuilder.prototype.AjaxBuilderresult.success = result.success;
						AjaxBuilder.prototype.AjaxBuilderresult.ID = result.ID;
						AjaxBuilder.prototype.AjaxBuilderresult.valid = null;
						AjaxBuilder.prototype.AjaxBuilderresult.RecordCount = result.RecordCount;
						if (Parameter.ComplateFunctionName != null)
							window[Parameter.ComplateFunctionName](AjaxBuilder.prototype.AjaxBuilderresult);

					}


				},
				error: function (xhr, status, error) {

					AjaxBuilder.prototype.AjaxBuilderresult.result = null;
					AjaxBuilder.prototype.AjaxBuilderresult.success = xhr.success;
					switch (xhr.success) {
						case 0:
							AjaxBuilder.prototype.AjaxBuilderresult.result = "Web sayfasına bağlanılamıyor.";
							break;
						case 404:
							AjaxBuilder.prototype.AjaxBuilderresult.result = "Web sayfası bulunamadı.";
							break;
						case 500:
							AjaxBuilder.prototype.AjaxBuilderresult.result = "Web sayfasında hata ile karşılaşıldı.";
							break;
						case 401:
							AjaxBuilder.prototype.AjaxBuilderresult.result = "Web sayfasına erişim yetkiniz bulunmamaktadır.";
							UIAlert("Sisteme giriş yapmanız gerekmektedir. Yönlendirileceksiniz.\n" + status + "\n" + error);
							location.href = "./Login";
							break;
						default:

					}


					if (error === 'parsererror')
						AjaxBuilder.prototype.AjaxBuilderresult.result = "Web sayfası verileri görüntülerken bir sorunla karşılaştı.";
					else if (error === 'timeout')
						AjaxBuilder.prototype.AjaxBuilderresult.result = "Web sayfasından uzun süredir cevap alınamıyor..";
					if (Parameter.ProgressID != null)
						$("#" + Parameter.ProgressID).css("display", "none");
					if (Parameter.ComplateFunctionName != null) {
						window[Parameter.ComplateFunctionName](AjaxBuilder.prototype.AjaxBuilderresult);
					}
					if (Parameter.ProgressFunction != null)
						window[Parameter.ProgressFunction](true);
				}
			}).done(function (data) {
				if (Parameter.ProgressFunction != null)
					window[Parameter.ProgressFunction](true);
				if (Parameter.ProgressID != null)
					$("#" + Parameter.ProgressID).css("display", "none");

			});

	};

}


function UIAlert(valid) {
	var text = "";
	if (valid != null) {
		if (typeof valid != "string") {
			for (var i = 0; i < valid.length; i++) {
				text += '● ' + valid[i].value + "</br>";
			}
		}
		else {
			text = '● ' + valid;
		}

		$("body").append("<div class='cssalert'  style='height:" + $(document).height() + "px;'><div style='top:" + (parseInt($(window).height() / 2) - 100) + "px;'>" + text + "</br></br><button onclick='$(\".cssalert\").remove();' >OK</button></br></br></div></div>");
		$(".cssalert button").focus();
	}
}
$("body").keyup(function (event) {
	if (event.keyCode == 27) {
		$(".cssalert").remove();

	}
});
