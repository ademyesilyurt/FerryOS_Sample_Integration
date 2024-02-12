using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Response.Common
{
    public class InvoiceType_Response : BaseResponse
    {
        public InvoiceType_Response() {
            valid = new List<validation>();
        }
        public List<InvoiceTypes> result { get; set; }
    }
    public class InvoiceTypes
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}
