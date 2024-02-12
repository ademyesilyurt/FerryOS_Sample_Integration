using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Response.Common
{
    public class District_Response : BaseResponse
    {
        public District_Response() {
            valid = new List<validation>();
        }
        public List<District> result { get; set; }
    }
    public class District
    {
        public Int64 cityID { get; set; }
        public Int64 id { get; set; }
        public String name { get; set; }

    }
}
