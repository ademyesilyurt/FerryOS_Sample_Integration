using Entities.Parameter.FerrySearch;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Parameter
{
    public class Ticket
    {
         public Ferry Ferry { get; set; }
         public List<Customer> Customer { get; set; }
         public List<VehicleCustomer> VehicleDriveCustomer { get; set; }
         public string VoucherGuid { get; set; }
    }

    public class VehicleCustomer
    {
         public int VehicleTypeID { get; set; }
         public int DriveCustomerNumber { get; set; }
        public int ReturnDriveCustomerNumber { get; set; }
         public string Plate { get; set; }
         public string Model { get; set; }
         public string Brand { get; set; }
    }

    public class Ferry
    {
        public string langCode { get; set; }
        public long DepartureTimeID { get; set; }
        public long ArrivalTimeID { get; set; }
        public short DepartureRegionID { get; set; }
        public short ArrivalRegionID { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public int RouteType { get; set; }
        public int AdultCount { get; set; }
        public int ChildCount { get; set; }
        public int InfantCount { get; set; }
        public int VehicleCount { get; set; }
        public IList<VehicleType> VehicleType { get; set; }

    }


    public class Delete
    {
        public long ID { get; set; }
     
        public Guid VoucherGuid { get; set; }
    }

    public class DepartureRegion
    {
        public int CountryID { get; set; }
        
        public string LangCode { get; set; }
    }

 

    public class ArrivalRegion
    {
        public int RegionID { get; set; }
    }

    public class ArrivalRegionCode
    {
        public string RegionCode { get; set; }
    }

    public class VehicleType
    {
        public string LangCode { get; set; }
    }

    public class FerryContent
    {
        public string LangCode { get; set; }
        public int[] FerryID { get; set; }
    }

    public class TicketSearch
    {

        public string routeType { get; set; }
        public DateTime serviceDate { get; set; }
        public DateTime returnServiceDate { get; set; }
        public int departureRegionID { get; set; }
        public int arrivalRegionID { get; set; }
        public int adultQuantity { get; set; }
        public int childQuantity { get; set; }
        public int infantQuantity { get; set; }
        public int vehicleQuantity { get; set; }
        public List<ChildAge> childAge { get; set; }
        public List<InfantAge> infantAge { get; set; }
        public List<vehicleType> vehicleType { get; set; }
        public bool havePets { get; set; }
        public int departureExpeditionID { get; set; }
        public int returnExpeditionID { get; set; }
        public string langCode { get; set; }

    }

    public class PassengerAge
    {

        public DateTime? Age { get; set; }
    }

    public class CreateTicket
    {

  
        public TicketSearch TicketSearch { get; set; }
  
        public List<Customer> Customer { get; set; }
        public List<Vehicle> Vehicle { get; set; }
        public string LangCode { get; set; }
        public string SalesWebUrlReferrer { get; set; }
        public int SalesID { get; set; }
        public int LastUserID { get; set; }

    }
    public class Vehicle
    {
        public int VehicleTypeID { get; set; }
        public int DriveCustomerNumber { get; set; }
        public int ReturnDriveCustomerNumber { get; set; }
     
        public string Plate { get; set; }
 
        public string Model { get; set; }
     
        public string Brand { get; set; }
    }
   


    public class GetChangeTicket
    {
        public string LangCode { get; set; }
        public Guid VoucherGuid { get; set; }
        public int[] CustomerID { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime? ReturnDate { get; set; }
 
    }

    public class SetChangeTicket
    {
        public bool ApprovePriceDifference { get; set; }
        public string LangCode { get; set; }
        public Guid VoucherGuid { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime? ReturnDate { get; set; }
 
        public IList<SetChangeTicketItem> Item { get; set; }
    }

    public class SetChangeTicketItem
    {
        public int CustomerID { get; set; }
        public int DepartureExpeditionID { get; set; }
        public int ReturnExpeditionID { get; set; }
    }



 


    public class PricesList
    {

        public string LangCode { get; set; }
        public int RouteZoneID { get; set; }
        public int FerryID { get; set; }
        public int RouteID { get; set; }
        public DateTime? ServiceDate { get; set; }

    }

    public class SearchVehicleType
    {
        public int VehicleTypeID { get; set; }
    }

    public class itinerary
    {
        public IList<Expedition> Expedition { get; set; }
        public string LangCode { get; set; }
    }

    public class Expedition
    {
        public int ExpeditionID { get; set; }
    }


}
