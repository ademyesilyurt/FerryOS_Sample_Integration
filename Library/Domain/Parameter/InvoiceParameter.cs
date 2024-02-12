using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Parameter
{
  public  class InvoiceParameter
    {
        public string SalesID { get; set; }
        public string GUID { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string InvoiceID { get; set; }
    }
}
