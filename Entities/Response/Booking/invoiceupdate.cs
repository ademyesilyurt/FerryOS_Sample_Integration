using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Response.Booking.invoiceupdate
{
    public class Root
    {
        public List<Entities.Response.validation> valid { get; set; }
        public int recordCount { get; set; }
        public bool success { get; set; }
        public int result { get; set; }
    }

 
}
