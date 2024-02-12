using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Response.Common
{
    public class Neighborhood_Response : BaseResponse
    {
        public Neighborhood_Response() {
            valid = new List<validation>();
        }
        public List<Neighborhood> result { get; set; }
    }
    public class Neighborhood
    {
        public Int64 DistrictID { get; set; }
        public Int64 CityID { get; set; }
        public Int64 CountryID { get; set; }
        public Int64 ID { get; set; }
        public String Name { get; set; }
        public String Code { get; set; }
        public String PostalCode { get; set; }
    }
}
