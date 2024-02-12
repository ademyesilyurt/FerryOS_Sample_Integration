using Library;
using System;
using System.Collections.Generic;
 
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    
    public class PaymentController : Controller
    {
        // GET: Payment
        public ActionResult Index()
        {
                 return View();
        }
		 
		// GET: Payment
		public ActionResult GetInstallment(Entities.Parameter.GetVPosBank.Root Parameter)
		{
			WebService.RestApi restApi = new WebService.RestApi();
			Entities.Response.Booking.getvposbank.Root api = restApi.Rest<Entities.Response.Booking.getvposbank.Root>(Parameter, "api/booking/getvposbank", "Post");
			return Json(api);
		}

		public ActionResult GetContent(string code, string voucher)
		{
			string LangCode = Configuration.Lang;
			WebService.RestApi restApi = new WebService.RestApi();
			Entities.Response.Content.Content.Root api = restApi.Rest<Entities.Response.Content.Content.Root>(null, "api/content/get?langCode=" + LangCode + "&contentCode=" + code, "Get");
			api.result.templateContent = api.result.templateContent.Replace("#DATE#", DateTime.Today.ToString("dd.MM.yyyy")).Replace("#VOUCHER#", voucher);
			return Json(api);
		}
		 
		public ActionResult Payment(Entities.Parameter.VPosPayment.Root Parameter)
		{
			Parameter.approveReturnUrl = "";
			Parameter.notApproveReturnUrl = "";
			Parameter.ipAddress = "";
			WebService.RestApi restApi = new WebService.RestApi();
			Entities.Response.Booking.vpospayment.Root api = restApi.Rest<Entities.Response.Booking.vpospayment.Root>(Parameter, "api/booking/vpospayment", "Post");
			return Json(api);
		}
		public ActionResult Payment_VirtualPos_3dSecure(Entities.Parameter.VPosPayment3DSecure.Root Parameter)
		{
			Parameter.cardNO = Parameter.cardNO.Replace(" ","");

            WebService.RestApi restApi = new WebService.RestApi();
			Entities.Response.Booking.VPosPayment3DSecure.Root api = restApi.Rest<Entities.Response.Booking.VPosPayment3DSecure.Root>(Parameter, "api/booking/VPosPayment3DSecure", "Post");
			if (api.valid == null)
				api.valid = new List<Entities.Response.Booking.VPosPayment3DSecure.Valid>();
            if (!api.success)
				api.valid.Add(new Entities.Response.Booking.VPosPayment3DSecure.Valid() { value = "Cekim yapılamadı lütfen tekrar deneyiniz" });

			return Json(api);
		}

	}
}