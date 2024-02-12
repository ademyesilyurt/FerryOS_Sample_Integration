using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Parameter.VPosPayment3DSecure
{
    public class Root
    {
        public string langCode { get; set; }
        public string voucherGuid { get; set; }
        public int installmentID { get; set; }
        public int amount { get; set; }
        public string cardNO { get; set; }
        public string cvc { get; set; }
        public string expireYear { get; set; }
        public string expireMonth { get; set; }
        public string name { get; set; }
        public string surName { get; set; }
        public string approveReturnUrl { get; set; }
        public string notApproveReturnUrl { get; set; }
        public string ipAddress { get; set; }
    }

}
