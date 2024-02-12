using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
   
    public class TimeTableController : Controller
    {
        // GET: TimeTable
      //  [OutputCache(Duration = 1800, VaryByParam = "*")]
        public ActionResult Index()
        {
            
            return View();
        }

      //  [OutputCache(Duration = 3600, VaryByParam = "*")]
        public ActionResult SelectAllTimeTable(Entities.Parameter.TimeTable.Root Parameter)
        {
             
            string LangCode = Configuration.Lang;
            Parameter.langCode = LangCode;




            WebService.RestApi restApi = new WebService.RestApi();
            Entities.Response.Ticket.TimeTable.Root api = restApi.Rest<Entities.Response.Ticket.TimeTable.Root>(Parameter, "api/ticket/timetable", "Post");
            return Json(api);


 
        }

    }
}