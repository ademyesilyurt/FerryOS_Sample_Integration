using Library;
using System;
using System.Collections.Generic;
 
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
 

namespace Web.Controllers
{ 
    public class FerrySearchController : Controller
    {
        // GET: FerrySearch
       
      //  [WhitespaceFilter]
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult VehiclePrice(Entities.Parameter.Prices.Root Parameter)
        {
            WebService.RestApi restApi = new WebService.RestApi();
            Entities.Response.Ticket.RoutePrice api = restApi.Rest<Entities.Response.Ticket.RoutePrice>(Parameter, "api/ticket/arrivalregion", "Post");
            return Json(api);
        }


        public ActionResult Search(Entities.Parameter.FerryTicketSearch.Root Parameter)
        {
            Parameter.langCode = Configuration.Lang;

            
                Parameter.infantAge = new List<Entities.Parameter.FerryTicketSearch.InfantAge>();
            if (Parameter.childAge == null)
                Parameter.childAge = new List<Entities.Parameter.FerryTicketSearch.ChildAge>();
            if (Parameter.vehicleType == null)
                Parameter.vehicleType = new List<Entities.Parameter.FerryTicketSearch.vehicleType>();

            WebService.RestApi restApi = new WebService.RestApi();
            Entities.Response.Ticket.FerrySearch api = restApi.Rest<Entities.Response.Ticket.FerrySearch>(Parameter, "api/ticket/search", "Post");

            return Json(api);
        }



 
        public ActionResult Calculate(Entities.Parameter.FerrySearch.Root Parameter)
        {
            Parameter.langCode = Configuration.Lang;

            if (Parameter.childAge == null)
                Parameter.childAge = new List<Entities.Parameter.FerrySearch.ChildAge>();
            if (Parameter.infantAge == null)
                Parameter.infantAge = new List<Entities.Parameter.FerrySearch.InfantAge>();
            if (Parameter.vehicleType == null)
                Parameter.vehicleType = new List<Entities.Parameter.FerrySearch.vehicleType>();

            WebService.RestApi restApi = new WebService.RestApi();
                Entities.Response.Ticket.PriceCalculate api = restApi.Rest<Entities.Response.Ticket.PriceCalculate>(Parameter, "api/ticket/pricecalculate", "Post");


            return Json(api);
        }
    }
}