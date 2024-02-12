using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Response.Ticket.itinenary
{
    public class ArrivalTime
    {
        public int ticks { get; set; }
        public int days { get; set; }
        public int hours { get; set; }
        public int milliseconds { get; set; }
        public int microseconds { get; set; }
        public int nanoseconds { get; set; }
        public int minutes { get; set; }
        public int seconds { get; set; }
        public int totalDays { get; set; }
        public int totalHours { get; set; }
        public int totalMilliseconds { get; set; }
        public int totalMicroseconds { get; set; }
        public int totalNanoseconds { get; set; }
        public int totalMinutes { get; set; }
        public int totalSeconds { get; set; }
    }

    public class DepartureTime
    {
        public int ticks { get; set; }
        public int days { get; set; }
        public int hours { get; set; }
        public int milliseconds { get; set; }
        public int microseconds { get; set; }
        public int nanoseconds { get; set; }
        public int minutes { get; set; }
        public int seconds { get; set; }
        public int totalDays { get; set; }
        public int totalHours { get; set; }
        public int totalMilliseconds { get; set; }
        public int totalMicroseconds { get; set; }
        public int totalNanoseconds { get; set; }
        public int totalMinutes { get; set; }
        public int totalSeconds { get; set; }
    }

    public class Result
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
        public DateTime serviceDate { get; set; }
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
