using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Parameter.routeZone
{
    public class Root
    {
        public string langCode { get; set; }
        public int routeZoneID { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }
}
