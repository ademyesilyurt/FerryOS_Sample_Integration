using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Response.Common
{
    public class City_Response : BaseResponse
    {
        public City_Response() {
            valid = new List<validation>();
        }
        public List<City> result { get; set; }
    }
    public class City
    {
        public Int64 countryID { get; set; }
        public Int64 id { get; set; }
        public String name { get; set; }
        public String code { get; set; }
    }
}
