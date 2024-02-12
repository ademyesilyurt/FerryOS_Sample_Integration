using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Parameter.InsertTicket
{
    public class ChildAge
    {
        public DateTime age { get; set; }
    }

    public class Customer
    {
        public int parentID { get; set; }
        public DateTime? birthDate { get; set; }
        public DateTime? passportExpireDate { get; set; }
        public int countryID { get; set; }
        public int gender { get; set; }
        public string genderName { get; set; }
        public int id { get; set; }
        public string passportNo { get; set; }
        public string email { get; set; }
        public string gsm { get; set; }
        public string birthPlace { get; set; }
        public string name { get; set; }
        public string surName { get; set; }
        public string citizenshipID { get; set; }
        public string countryCode { get; set; }
        public string accountingCode { get; set; }
        public string countryName { get; set; }
        public int customerTypeID { get; set; }
        public string customerTypeName { get; set; }
        public bool sgkFormRecevied { get; set; }
    }

    public class InfantAge
    {
        public DateTime age { get; set; }
    }

    public class Root
    {
        public TicketSearch ticketSearch { get; set; }
        public List<Customer> customer { get; set; }
        public List<Vehicle> vehicle { get; set; }
        public string langCode { get; set; }
        public string salesWebUrlReferrer { get; set; }
        public int salesID { get; set; }
        public int lastUserID { get; set; }
    }

    public class TicketSearch
    {
        public int routeType { get; set; }
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
    }

    public class vehicleType
    {
        public int vehicleTypeID { get; set; }
    }

    public class Vehicle
    {
        public int vehicleTypeID { get; set; }
        public int driveCustomerNumber { get; set; }
        public int returnDriveCustomerNumber { get; set; }
        public string plate { get; set; }
        public string model { get; set; }
        public string brand { get; set; }
    }

}
