using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Response.Ticket
{
    public class Region_Response : BaseResponse
    {
        public Region_Response() { }
        public IEnumerable<FerryRoute> result { get; set; }
    }

    public class FerryRoute
    {
        public int regionID { get; set; }
        public string name { get; set; }
        public string portCoordinateX { get; set; }
        public string portCoordinateY { get; set; }
    }
}
