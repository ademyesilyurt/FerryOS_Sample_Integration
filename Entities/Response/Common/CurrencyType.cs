using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Response.Common
{
    public class CurrencyType_Response : BaseResponse
    {
        public CurrencyType_Response() {
            valid = new List<validation>();
        }
        public List<CurrencyTypes> result { get; set; }
    }
    public class CurrencyTypes
    {
        public int ID { get; set; }
        public int Status { get; set; }
        public String Code { get; set; }
        public String Name { get; set; }
        public String Symbol { get; set; }
        public decimal Amount { get; set; }
    }
}
