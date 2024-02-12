function Secure3d(e, d)
{
    console.log(d);
    var f = new AjaxBuilder({
        AjaxMethodType: AjaxMethodType.Post
        , RequestUrl: "../../Payment/Payment_VirtualPos_3dSecure"
        , Parameters: {
            cardNO: $("#CardNO").val()
            , cvc: $("#Cvc").val()
            , expireYear: $("#ExpireYear").val()
            , expireMonth: $("#ExpireMonth").val()
            , voucherGuid: e
            , installmentID: $("#InstallmentID").val()
            , langCode: $("html").attr("lang")
            , name: $("#Name").val()
            , surName: $("#SurName").val()
            , approveReturnUrl: d
            , notApproveReturnUrl: d
        }, ProgressID: null, ProgressFunction: "loading", ComplateFunctionName: "Secure3dSuccess"
    }); f.Request()
} function Secure3dSuccess(e) {
    if (e.valid == null) {
        var h = ""; for (var g = 0; g < e.result.inputs.length; g++)
        {
            h = h + '<input type="' + e.result.inputs[g].Type + '" id="' + e.result.inputs[g].Id + '" name="' + e.result.inputs[g].name + '" value="' + e.result.inputs[g].value + '"/>'
        }
        h = h + '<button style="font-size:12px" class="btn btn-success" id="send3d" type="submit">' + ISLEMINIZE_DEVAM_ETMEK_ICIN_TIKLAYINIZ + "</button>";
        var f = ('</br></br><form action="' + e.result.hostUrl + '" method="post">' + h + "   </form>");
        PopUp(f, ONAY, 322, 170);
        $("#send3d").click();
    } else {
        UIAlert(e.valid)
    }
};