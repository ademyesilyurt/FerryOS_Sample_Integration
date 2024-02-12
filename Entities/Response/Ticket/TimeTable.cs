using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Response.Ticket.TimeTable
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
		public int status { get; set; }
		public int companyID { get; set; }
		public int routeID { get; set; }
		public int ferryID { get; set; }
		public int expeditionID { get; set; }
		public int passengerRemainingQuota { get; set; }
		public DateTime serviceDate { get; set; }
		public DateTime arrivalDate { get; set; }
		public DateTime returnServiceDate { get; set; }
		public TimeSpan departureTime { get; set; }
		public TimeSpan arrivalTime { get; set; }
		public int departureRegionID { get; set; }
		public int arrivalRegionID { get; set; }
		public string departureRegionName { get; set; }
		public string arrivalRegionName { get; set; }
		public string ferryName { get; set; }
		public decimal vehicleRemainingQuota { get; set; }
		public string dayName { get; set; }
		public string picture { get; set; }
		public decimal oneWaySalesAmount { get; set; }
		public decimal openReturnSalesAmount { get; set; }
		public decimal returnDifferentDaySalesAmount { get; set; }
		public decimal returnSameDaySalesAmount { get; set; }
		public decimal portTax { get; set; }
		public string currencySymbol { get; set; }
		public string currencyTypeName { get; set; }
		public string passengerTypeName { get; set; }
		public int passengerTypeID { get; set; }
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
