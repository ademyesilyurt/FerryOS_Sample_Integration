using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Response.Common
{
    public class Country_Response : BaseResponse
    {
        public Country_Response() {
            valid = new List<validation>();
        }
        public List<Country> result { get; set; }
    }
    public class Country
    {
        public int id { get; set; }
        public String code { get; set; }
        public String name { get; set; }
        public decimal postage { get; set; }
        public string phoneCode { get; set; }
        public string forthCrsCountryCode { get; set; }
        public int postageCurrencyTypeID { get; set; }
    }
}
