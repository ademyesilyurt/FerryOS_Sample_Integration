using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Parameter
{
    public class Voucher
    {
        public string LangCode { get; set; }
    
        public Guid? VoucherGuid { get; set; }
        public int SalesID { get; set; }
    }
}
