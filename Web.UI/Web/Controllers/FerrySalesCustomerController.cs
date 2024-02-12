 
using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    
    public class FerrySalesCustomerController : Controller
    {
        // GET: FerrySalesCustomer
        public ActionResult Index()
        {
            return View();
        }
        

        public ActionResult Add(Entities.Parameter.InsertTicket.Root Parameter,string Gsm, string Email)
        {
			Parameter.langCode = Configuration.Lang;

			if (Parameter.vehicle == null)
				Parameter.vehicle = new List<Entities.Parameter.InsertTicket.Vehicle>();
			if (Parameter.ticketSearch.infantAge == null)
				Parameter.ticketSearch.infantAge = new List<Entities.Parameter.InsertTicket.InfantAge>();
			if (Parameter.ticketSearch.vehicleType == null)
				Parameter.ticketSearch.vehicleType = new List<Entities.Parameter.InsertTicket.vehicleType>();

			if (Parameter.salesWebUrlReferrer == null)
				Parameter.salesWebUrlReferrer = "";

			if (Parameter.ticketSearch.childAge == null)
				Parameter.ticketSearch.childAge = new List<Entities.Parameter.InsertTicket.ChildAge>();


			WebService.RestApi restApi = new WebService.RestApi();
			Entities.Response.Voucher.Root api = restApi.Rest<Entities.Response.Voucher.Root>(Parameter, "api/ticket/insert",  "Post");


			Entities.Parameter.InvoiceUpdate.Root invoice = new Entities.Parameter.InvoiceUpdate.Root();
			invoice.langCode = Parameter.langCode;
			invoice.voucherGuid = api.result.guid.ToString();
			invoice.invoiceItem = new Entities.Parameter.InvoiceUpdate.InvoiceItem();
			invoice.invoiceItem.gsm = Gsm;
			invoice.invoiceItem.integrationInvoiceID = "";
			invoice.invoiceItem.invoiceType = 1;
			invoice.invoiceItem.email = Email;
			Entities.Response.Booking.invoiceupdate.Root invoice_api = restApi.Rest<Entities.Response.Booking.invoiceupdate.Root>(invoice, "api/booking/invoiceupdate", "Post");


			if (invoice_api.valid.Count > 0)
				api.valid.AddRange(invoice_api.valid);


			return Json(api);
		}




    }
}