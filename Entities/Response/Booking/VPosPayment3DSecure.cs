using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Response.Booking.VPosPayment3DSecure
{
    public class Input
    {
        public string type { get; set; }
        public string name { get; set; }
        public string id { get; set; }
        public string value { get; set; }
    }

    public class Result
    {
        public string voucherGuid { get; set; }
        public string approveReturnUrl { get; set; }
        public string notApproveReturnUrl { get; set; }
        public string hostUrl { get; set; }
        public List<Input> inputs { get; set; }
        public bool secure3D { get; set; }
        public List<Valid> valid { get; set; }
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
