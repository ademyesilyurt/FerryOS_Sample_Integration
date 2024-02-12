using Library;
using System;
using System.Collections.Generic;
 
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    
    
    public class CommonController : Controller
    {

 

            public ActionResult ArrivalRegion(int regionID)
            {
                Entities.Response.Ticket.Region_Response api = new Entities.Response.Ticket.Region_Response();
                try
                {
                    WebService.RestApi restApi = new WebService.RestApi();

                    api = restApi.Rest<Entities.Response.Ticket.Region_Response>(new { regionID = regionID }, "api/ticket/arrivalregion", "Post");




                    api.success = true;
                }
                catch (Exception ex)
                {
                    api.valid.Add(new Entities.Response.validation() { value = ex.Message });
                    api.success = false;
                }

                return Json(api);
            }

            public ActionResult DepartureRegion()
            {
                Entities.Response.Ticket.Region_Response api = new Entities.Response.Ticket.Region_Response();
                try
                {
                    WebService.RestApi restApi = new WebService.RestApi();

                    api = restApi.Rest<Entities.Response.Ticket.Region_Response>(new { }, "api/ticket/departureregion", "Post");




                    api.success = true;
                }
                catch (Exception ex)
                {
                    api.valid.Add(new Entities.Response.validation() { value = ex.Message });
                    api.success = false;
                }

                return Json(api);
            }

            public ActionResult City(int country_id)
            {
                Entities.Response.Common.City_Response api = new Entities.Response.Common.City_Response();
                try
                {
                    WebService.RestApi restApi = new WebService.RestApi();
                    api = restApi.Rest<Entities.Response.Common.City_Response>(null, "api/common/citys?country_id=" + country_id, "Get");
                }
                catch (Exception ex)
                {
                    api.success = false;
                }
                return Json(api);
            }

            public ActionResult District(int city_id)
            {
                Entities.Response.Common.District_Response api = new Entities.Response.Common.District_Response();
                try
                {
                    WebService.RestApi restApi = new WebService.RestApi();
                    api = restApi.Rest<Entities.Response.Common.District_Response>(null, "api/common/districts?city_id=" + city_id, "Get");
                }
                catch (Exception ex)
                {
                    api.success = false;
                }
                return Json(api);
            }

            public ActionResult Neighborhood(int district_id)
            {
                Entities.Response.Common.Neighborhood_Response api = new Entities.Response.Common.Neighborhood_Response();
                try
                {
                    WebService.RestApi restApi = new WebService.RestApi();
                    api = restApi.Rest<Entities.Response.Common.Neighborhood_Response>(new { district_id = district_id }, "api/common/district", "Get");
                }
                catch (Exception ex)
                {
                    api.success = false;
                }
                return Json(api);
            }


            public ActionResult FerrySearch(Entities.Parameter.TicketSearch ticketSearch)
            {
                Entities.Response.Ticket.FerrySearchResult api = new Entities.Response.Ticket.FerrySearchResult();


                WebService.RestApi restApi = new WebService.RestApi();
                api = restApi.Rest<Entities.Response.Ticket.FerrySearchResult>(ticketSearch, "api/ticket/search", "Post");



                return Json(api);
            }

            public ActionResult VehicleTypes()
            {
                WebService.RestApi restApi = new WebService.RestApi();
            Entities.Response.Ticket.FerryVehicleType api = restApi.Rest<Entities.Response.Ticket.FerryVehicleType>(new { langCode = Configuration.Lang }, "api/ticket/vehicletypes", "Post");



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

        public ActionResult LanguageSelection(string LangCode)
            {
                WebService.RestApi restApi = new WebService.RestApi();
                Entities.Response.Ticket.PriceCalculate api = restApi.Rest<Entities.Response.Ticket.PriceCalculate>(null, "api/ticket/search", "Get");



                return Json(api);
            }



        }
    }