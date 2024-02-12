using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Response.Ticket
{
    public class FerrySearch : BaseResponse
    {
        public FerrySearch() { }
        public IEnumerable<FerrySearchResult> result { get; set; }
    }
    public class FerrySearchResult
    {
        public bool defaultExpedition { get; set; }
        public string withFerriesAvailable { get; set; }
        public int expeditionID { get; set; }
        public int ferryID { get; set; }
        public string ferryCompanyName { get; set; }
        public string ferryName { get; set; }
        public string departurePort { get; set; }
        public string arrivalPort { get; set; }
        public string picture { get; set; }
        public DateTime? serviceDate { get; set; }
        public TimeSpan? departureTime { get; set; }
        public TimeSpan? arrivalTime { get; set; }
        public int travelTime { get; set; }
        public string description { get; set; }
        public int routeID { get; set; }
        public string routeName { get; set; }
        public int departureRegionID { get; set; }
        public string departureRegionName { get; set; }
        public int arrivalRegionID { get; set; }
        public string arrivalRegionName { get; set; }
        public string mandatoryFields { get; set; }
        public bool available { get; set; }
        public bool canNotSaleOneWay { get; set; }
        public bool canNotSaleOpenReturn { get; set; }
        public bool canNotSaleSameDay { get; set; }
    }
}
