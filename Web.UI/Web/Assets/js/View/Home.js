$("#ChildQuantity").change(
	function () {
		for (var i = 0; i < parseInt($("#ChildQuantity").val()); i++) {
			$(".childage" + (i + 1)).css("display", "");
		}
		for (var i = parseInt($("#ChildQuantity").val()); i < 4; i++) {
			$(".childage" + (i + 1)).css("display", "none");
		}

		if (parseInt($("#ChildQuantity").val()) > 0)
			$(".childs").css("display", "");
		else
			$(".childs").css("display", "none");
	}


);


$("#VehicleQuantity").change(
	function () {
		for (var i = 0; i < parseInt($("#VehicleQuantity").val()); i++) {
			$(".vehicle" + (i + 1)).css("display", "");
		}
		for (var i = parseInt($("#VehicleQuantity").val()); i < 4; i++) {
			$(".vehicle" + (i + 1)).css("display", "none");
		}

		if (parseInt($("#VehicleQuantity").val()) > 0)
			$(".vehicles").css("display", "");
		else
			$(".vehicles").css("display", "none");


	}
);