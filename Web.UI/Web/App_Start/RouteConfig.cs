using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WebService;

namespace Web
{
    public class URLS
    {
        public Int64 ID { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string LangCode { get; set; }
    }
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
           
    
            routes.MapRoute(
            name: "Default",
            url: "{controller}/{action}/{id}",
            defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
        );

             
        }

      
    }
}