using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Referrer
    {
        public string UrlReferrer { get; set; }
        public string UtmSource { get; set; }
        public string UtmCampaing { get; set; }
        public string UtmMedium { get; set; }
        public string UtmContent { get; set; }
        public string IpAddress { get; set; }
        public string UtmTerm { get; set; }

		public static Referrer Get()
		{
			return (Referrer)System.Web.HttpContext.Current.Session["Referrer"];
		}
		public static void Set(Referrer Ref)
		{
			System.Web.HttpContext.Current.Session["Referrer"] = Ref;
		}
	}
}
