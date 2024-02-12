using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Response.Booking.vpospayment
{
    public class Result
    {
        public int orderID { get; set; }
        public string message { get; set; }
        public bool successful { get; set; }
        public string errorCode { get; set; }
        public string referenceNumber { get; set; }
    }

    public class Root
    {
        public List<Valid> valid { get; set; }
        public int recordCount { get; set; }
        public bool success { get; set; }
        public Result result { get; set; }
    }

    public class Valid
    {
        public string key { get; set; }
        public string value { get; set; }
        public string code { get; set; }
    }



}
