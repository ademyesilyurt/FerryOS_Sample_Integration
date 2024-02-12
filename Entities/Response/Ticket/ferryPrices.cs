using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Response.Ticket.ferryPrices
{
    public class Passenger
    {
        public decimal oneWaySalesAmount { get; set; }
        public decimal openReturnSalesAmount { get; set; }
        public decimal returnDifferentDaySalesAmount { get; set; }
        public decimal returnSameDaySalesAmount { get; set; }
        public decimal endAge { get; set; }
        public decimal portTax { get; set; }
        public decimal startAge { get; set; }
        public int passengerTypeID { get; set; }
        public string passengerTypeName { get; set; }
        public int taxValueType { get; set; }
        public string currencyTypeSymbol { get; set; }
        public decimal portTaxOneWay { get; set; }
        public decimal portTaxOpenReturn { get; set; }
        public decimal portTaxReturnDifferentDay { get; set; }
        public decimal portTaxReturnSameDay { get; set; }
        public int routeID { get; set; }
        public int returnRouteID { get; set; }
        public int ferryID { get; set; }
        public int neighborhoodDepartureRegionID { get; set; }
        public int neighborhoodArrivalRegionID { get; set; }
    }

    public class Price
    {
        public List<Passenger> passenger { get; set; }
        public List<Vehicle> vehicle { get; set; }
    }

    public class Result
    {
        public int ferryID { get; set; }
        public bool availableVehicle { get; set; }
        public string ferryName { get; set; }
        public string companyName { get; set; }
        public string picture { get; set; }
        public List<Route> route { get; set; }
    }

    public class Root
    {
        public List<Valid> valid { get; set; }
        public int recordCount { get; set; }
        public bool success { get; set; }
        public List<Result> result { get; set; }
    }

    public class Route
    {
        public bool availableVehicle { get; set; }
        public int routeID { get; set; }
        public int returnRouteID { get; set; }
        public string companyName { get; set; }
        public string departureRegionName { get; set; }
        public string arrivalRegionName { get; set; }
        public Price price { get; set; }
        public int neighborhoodDepartureRegionID { get; set; }
        public int neighborhoodArrivalRegionID { get; set; }
    }

    public class Valid
    {
        public string key { get; set; }
        public string value { get; set; }
        public string code { get; set; }
    }

    public class Vehicle
    {
        public decimal oneWaySalesAmount { get; set; }
        public decimal openReturnSalesAmount { get; set; }
        public decimal returnDifferentDaySalesAmount { get; set; }
        public decimal returnSameDaySalesAmount { get; set; }
        public int ferryVehicleTypeID { get; set; }
        public string currencyTypeSymbol { get; set; }
        public string ferryVehicleTypeName { get; set; }
        public decimal portTax { get; set; }
        public decimal taxValueType { get; set; }
        public int ferryID { get; set; }
        public int routeID { get; set; }
        public int returnRouteID { get; set; }
        public int neighborhoodDepartureRegionID { get; set; }
        public int neighborhoodArrivalRegionID { get; set; }
    }
}
