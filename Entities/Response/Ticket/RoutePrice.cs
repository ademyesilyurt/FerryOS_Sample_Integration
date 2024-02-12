using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Response.Ticket
{
    public class RoutePrice : BaseResponse
    {
        public RoutePrice()
        {
            valid = new List<validation>();
        }
        public IList<Ferry_Price> result { get; set; }
    }

    public class RouteTemp
    {
        public bool AvailableVehicle { get; set; }
        public int RouteID { get; set; }
        public int ReturnRouteID { get; set; }
        public int FerryID { get; set; }
        public string FerryName { get; set; }
        public string Picture { get; set; }
        public string CompanyName { get; set; }
        public string DepartureRegionName { get; set; }
        public string ArrivalRegionName { get; set; }
        public Price Price { get; set; }
        public int NeighborhoodDepartureRegionID { get; set; }
        public int NeighborhoodArrivalRegionID { get; set; }


    }

    public class Ferry_Price
    {
        public int FerryID { get; set; }
        public bool AvailableVehicle { get; set; }
        public string FerryName { get; set; }
        public string CompanyName { get; set; }
        public string Picture { get; set; }
        public IList<Route_Price> Route { get; set; }
    }

    public class Route_Price
    {
        public bool AvailableVehicle { get; set; }
        public int RouteID { get; set; }
        public int ReturnRouteID { get; set; }

        public string CompanyName { get; set; }
        public string DepartureRegionName { get; set; }
        public string ArrivalRegionName { get; set; }
        public Price Price { get; set; }
        public int NeighborhoodDepartureRegionID { get; set; }
        public int NeighborhoodArrivalRegionID { get; set; }


    }

    public class Price
    {
        public IList<Passenger_Price> Passenger { get; set; }
        public IList<Vehicle_Price> Vehicle { get; set; }
    }

    public class Passenger_Price
    {
        public Decimal OneWaySalesAmount { get; set; }
        public Decimal OpenReturnSalesAmount { get; set; }
        public Decimal ReturnDifferentDaySalesAmount { get; set; }
        public Decimal ReturnSameDaySalesAmount { get; set; }
        public Decimal EndAge { get; set; }
        public Decimal PortTax { get; set; }
        public Decimal StartAge { get; set; }
        public Int32 PassengerTypeID { get; set; }
        public string PassengerTypeName { get; set; }
        public Int32 TaxValueType { get; set; }
        public string CurrencyTypeSymbol { get; set; }
        public Decimal PortTaxOneWay { get; set; }
        public Decimal PortTaxOpenReturn { get; set; }
        public Decimal PortTaxReturnDifferentDay { get; set; }
        public Decimal PortTaxReturnSameDay { get; set; }
        public int RouteID { get; set; }
        public int ReturnRouteID { get; set; }
        public int FerryID { get; set; }
        public int NeighborhoodDepartureRegionID { get; set; }
        public int NeighborhoodArrivalRegionID { get; set; }
    }


    public class Vehicle_Price
    {
        public decimal OneWaySalesAmount { get; set; }
        public decimal OpenReturnSalesAmount { get; set; }
        public decimal ReturnDifferentDaySalesAmount { get; set; }
        public decimal ReturnSameDaySalesAmount { get; set; }
        public Int32 FerryVehicleTypeID { get; set; }
        public string CurrencyTypeSymbol { get; set; }
        public string FerryVehicleTypeName { get; set; }
        public decimal PortTax { get; set; }
        public Int32 TaxValueType { get; set; }
        public int FerryID { get; set; }
        public int RouteID { get; set; }
        public int ReturnRouteID { get; set; }
        public int NeighborhoodDepartureRegionID { get; set; }
        public int NeighborhoodArrivalRegionID { get; set; }

    }
}
