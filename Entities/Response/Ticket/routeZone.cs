using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Response.Ticket.routeZone
{
    public class Result
    {
        public int id { get; set; }
        public string departureRegionName { get; set; }
        public string arrivalRegionName { get; set; }
        public int arrivalRegionID { get; set; }
        public int departureRegionID { get; set; }
    }

    public class Root
    {
        public List<Valid> valid { get; set; }
        public int recordCount { get; set; }
        public bool success { get; set; }
        public List<Result> result { get; set; }
    }

    public class Valid
    {
        public string key { get; set; }
        public string value { get; set; }
        public string code { get; set; }
    }
}
