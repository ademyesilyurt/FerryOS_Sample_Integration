using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Response.Common
{
    public class Gender_Response : BaseResponse
    {
        public Gender_Response() {
            valid = new List<validation>();
        }
        public List<Gender> result { get; set; }
    }
    public class Gender
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}
