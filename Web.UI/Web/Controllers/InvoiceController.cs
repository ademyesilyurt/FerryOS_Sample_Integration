using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
 
    public class InvoiceController : Controller
    {
        // GET: Invoice
        public ActionResult Index()
        {
           
    
            return View();
        }


        public ActionResult Update(Entities.Parameter.InvoiceUpdate.Root Parameter)
        {
            Parameter.invoiceItem.integrationInvoiceID = "";
            WebService.RestApi restApi = new WebService.RestApi();
            return Json(restApi.Rest<Entities.Response.Booking.invoiceupdate.Root>(Parameter, "api/booking/invoiceupdate", "Post"));

        }
    }
}