using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Parameter.ferryPrices
{
    public class Root
    {
        public string langCode { get; set; }
        public int routeZoneID { get; set; }
        public int ferryID { get; set; }
        public int routeID { get; set; }
        public DateTime serviceDate { get; set; }
    }
}
