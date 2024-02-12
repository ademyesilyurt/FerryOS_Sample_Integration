using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Parameter.GetVPosBank
{
    public class Root
    {
        public string langCode { get; set; }
        public int bankID { get; set; }
        public int creditCardID { get; set; }
        public int installmentID { get; set; }
        public int paymentType { get; set; }
        public string voucherGuid { get; set; }
    }
}
