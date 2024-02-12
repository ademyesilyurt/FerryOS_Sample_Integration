using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Response
{
    public class BaseResponse
    {
        public List<validation> valid { get; set; }

        public int recordCount { get; set; }
        public bool success { get; set; }


    }

    public class validation
    {
        public string key { get; set; }
        public string value { get; set; }
        public string code { get; set; }
    }
}
