using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class ExtraServiceDetailController : Controller
    {
        // GET: ExtraServiceDetail
        public ActionResult Index()
        {
            Entities.Response.ExtraService.ExtraServiceGet.Result extra = new WebService.RestApi().Rest<Entities.Response.ExtraService.ExtraServiceGet.Root>(null, "api/extraservice/get?url=" + (Request.Url.Segments.Length>2?Request.Url.Segments[2].Replace("/", ""): Request.Url.Segments[1].Replace("/", "")), "Get").result;
            ViewBag.PageName = extra.name;
            ViewBag.Title = extra.name;
            ViewBag.Keywords = extra.webTagKeywords;
            ViewBag.Descriptions = extra.webTagDescription;
            ViewBag.CanonicalUrl = extra.url;
            ViewBag.PageTitle = extra.name;
            return View(extra);
        }


        public ActionResult Calculate(Entities.Parameter.ExtraServiceGetParameter.Root Parameter)
        {
            if (Parameter.childBirthDate == null)
                Parameter.childBirthDate = new List<DateTime>();

            Parameter.langCode = Configuration.Lang;
            Entities.Response.ExtraService.ExtraServiceCalculate.Root extra = new WebService.RestApi().Rest<Entities.Response.ExtraService.ExtraServiceCalculate.Root>(Parameter, "api/extraservice/calculate", "Post");

            return Json(extra);
        }

        public ActionResult Add(Entities.Parameter.ExtraServiceInsert.Root Parameter)
        {

            Parameter.langCode = Configuration.Lang;
            Entities.Response.ExtraService.ExraServiceInsert.Root extra = new WebService.RestApi().Rest<Entities.Response.ExtraService.ExraServiceInsert.Root>(Parameter, "api/extraservice/insert", "Post");
            return Json(extra);
        }
    }
}