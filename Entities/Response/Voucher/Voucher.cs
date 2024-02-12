using Entities.Parameter;
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Response.Voucher
{
    public class Voucher_Response : BaseResponse
    {
        public Voucher_Response()
        {
            valid = new List<validation>();
        }
        public Root result { get; set; }
    }
     

    public class ClassAnalysis
    {
        public int id { get; set; }
        public int forthCrsReserveIssueRequestID { get; set; }
        public string classAbbr { get; set; }
        public string classResType { get; set; }
        public int quantity { get; set; }
        public int capacity { get; set; }
        public string upDownBed { get; set; }
        public string classAbbrType { get; set; }
        public int status { get; set; }
    }

    public class Contact
    {
        public int id { get; set; }
        public int salesID { get; set; }
        public int postTypeID { get; set; }
        public string postTypeName { get; set; }
        public int countryID { get; set; }
        public int companyID { get; set; }
        public string countryName { get; set; }
        public int cityID { get; set; }
        public string cityName { get; set; }
        public string address { get; set; }
        public string postalCode { get; set; }
        public string mobileNumber { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
    }

    public class SalesCurrency
    {
        public int currencyID { get; set; }
        public string name { get; set; }
        public string symbol { get; set; }
        public string code { get; set; }
        public int typeID { get; set; }
        public decimal amount { get; set; }
        public decimal currencyAmount { get; set; }
    }

    public class Customer
    {
        public int parentID { get; set; }
        public DateTime birthDate { get; set; }
        public DateTime passportExpireDate { get; set; }
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

    public class DailyPrice
    {
        public int id { get; set; }
        public int hotelSalesID { get; set; }
        public int roomClassID { get; set; }
        public int periodID { get; set; }
        public DateTime date { get; set; }
        public decimal amount { get; set; }
        public decimal buyingAmount { get; set; }
        public int salesCurrencyTypeID { get; set; }
        public int companyID { get; set; }
        public int  buyingCurrencyID { get; set; }
        public int quota { get; set; }
        public int quotaID { get; set; }
        public int customerTypeID { get; set; }
        public int roomTypeID { get; set; }
        public int priceType { get; set; }
        public string roomTypeName { get; set; }
        public string customerTypeName { get; set; }
    }
     
    public class ExtraService
    {
        public string productName { get; set; }
        public string currencyTypeSymbol { get; set; }
        public int currencyID { get; set; }
        public int customerID { get; set; }
        public int extraServiceID { get; set; }
        public string gsm { get; set; }
        public int id { get; set; }
        public int salesID { get; set; }
        public int userID { get; set; }
        public DateTime serviceDate { get; set; }
        public DateTime salesDate { get; set; }
        public decimal salesAmount { get; set; }
        public decimal commissionAmount { get; set; }
        public decimal totalSalesAmount { get; set; }
        public decimal totalSalesAmountTL { get; set; }
        public int currencyTypeID { get; set; }
        public int customerTypeID { get; set; }
        public string serviceNumber { get; set; }
        public string name { get; set; }
        public string surName { get; set; }
        public string productCategoriesName { get; set; }
        public DateTime birthDate { get; set; }
        public string customerTypeName { get; set; }
        public int extraServiceCategoriesID { get; set; }
        public string note { get; set; }
        public int extraServicePropertiesID { get; set; }
        public string extraServicePropertiesName { get; set; }
        public string extraServicePropertiesCategoriesName { get; set; }
        public decimal taxRate { get; set; }
        public decimal taxAmount { get; set; }
        public decimal termAmount { get; set; }
    }

    public class ForthCrsReservation
    {
        public List<ForthCrsReserveIssueRequest> forthCrsReserveIssueRequest { get; set; }
        public Contact contact { get; set; }
        public string langCode { get; set; }
    }

    public class ForthCrsReserveIssueRequest
    {
        public DateTime salesDate { get; set; }
        public int id { get; set; }
        public int salesID { get; set; }
        public int userID { get; set; }
        public int branchID { get; set; }
        public int companyID { get; set; }
        public string addFees { get; set; }
        public string address { get; set; }
        public decimal amount { get; set; }
        public bool isTicketDelivered { get; set; }
        public string postTypeName { get; set; }
        public string countryName { get; set; }
        public string mobileNumber { get; set; }
        public int postTypeID { get; set; }
        public string postalCode { get; set; }
        public string email { get; set; }
        public int commissionID { get; set; }
        public string branchName { get; set; }
        public string userName { get; set; }
        public int postage { get; set; }
        public decimal branchCommissionAmount { get; set; }
        public decimal forthCrsCommissionAmount { get; set; }
        public int forthCrsCommissionRate { get; set; }
        public int forthCrsComissionServiceFeeRate { get; set; }
        public decimal netAmount { get; set; }
        public decimal netTotalAmount { get; set; }
        public decimal totalAmount { get; set; }
        public decimal totalAmountTL { get; set; }
        public string approvalCode { get; set; }
        public string company { get; set; }
        public string companyName { get; set; }
        public string vesselName { get; set; }
        public string depStation { get; set; }
        public string arrStation { get; set; }
        public string depStationName { get; set; }
        public string arrStationName { get; set; }
        public string depDate { get; set; }
        public DateTime departureDate { get; set; }
        public string deptime { get; set; }
        public TimeSpan departureTime { get; set; }
        public TimeSpan arrivalTime { get; set; }
        public string arrDate { get; set; }
        public DateTime arrivalDate { get; set; }
        public string arrtime { get; set; }
        public string cardType { get; set; }
        public string city { get; set; }
        public string deliveryAddr { get; set; }
        public string deliveryCity { get; set; }
        public string deliveryCountry { get; set; }
        public string deliveryType { get; set; }
        public string deliveryZipCode { get; set; }
        public string leaderName { get; set; }
        public string mobile { get; set; }
        public int payType { get; set; }
        public string phone { get; set; }
        public string promoCode { get; set; }
        public string remarks { get; set; }
        public string reservationCountry { get; set; }
        public string reservationPrice { get; set; }
        public string specialCode { get; set; }
        public string transactionCode { get; set; }
        public string travelIns { get; set; }
        public string travelInsDoc { get; set; }
        public string vesselID { get; set; }
        public string crsReservationCode { get; set; }
        public int status { get; set; }
        public List<ClassAnalysis> classAnalysis { get; set; }
        public List<ReserveIssuePerPassenger> reserveIssuePerPassenger { get; set; }
        public List<ReserveIssuePerVehicle> reserveIssuePerVehicle { get; set; }
    }

    public class Hotel
    {
        public string name { get; set; }
        public DateTime checkInDate { get; set; }
        public DateTime checkOutDate { get; set; }
        public DateTime salesDate { get; set; }
        public decimal buyingAmount { get; set; }
        public decimal commissionAmount { get; set; }
        public decimal salesAmount { get; set; }
        public decimal salesAmountTL { get; set; }
        public decimal taxAmount { get; set; }
        public int currencyTypeID { get; set; }
        public int hotelID { get; set; }
        public int id { get; set; }
        public int adult { get; set; }
        public int child { get; set; }
        public int roomClassID { get; set; }
        public int roomTypeID { get; set; }
        public string roomClassName { get; set; }
        public string roomTypeName { get; set; }
        public int salesID { get; set; }
        public string note { get; set; }
        public Guid guid { get; set; }
        public string currencyTypeSymbol { get; set; }
        public string currencyTypeName { get; set; }
        public int taxRate { get; set; }
        public List<DailyPrice> dailyPrice { get; set; }
        public List<Customer> customer { get; set; }
        public decimal termAmount { get; set; }
        public decimal totalSalesAmount { get; set; }
        public int rateOfReturn { get; set; }
    }

    public class PassengerTicket
    {
        public string citizenshipID { get; set; }
        public int customerID { get; set; }
        public int id { get; set; }
        public int expeditionID { get; set; }
        public int salesID { get; set; }
        public DateTime serviceDate { get; set; }
        public DateTime salesDate { get; set; }
        public decimal salesAmount { get; set; }
        public decimal totalSalesAmount { get; set; }
        public decimal totalSalesAmountTL { get; set; }
        public decimal commissionAmount { get; set; }
        public int currencyID { get; set; }
        public int currencyTypeID { get; set; }
        public decimal portTax { get; set; }
        public int salesItemID { get; set; }
        public TimeSpan arrivalTime { get; set; }
        public TimeSpan departureTime { get; set; }
        public string ferryName { get; set; }
        public string ferryCompanyName { get; set; }
        public int ferryID { get; set; }
        public int routeID { get; set; }
        public string departureRegionName { get; set; }
        public string arrivalRegionName { get; set; }
        public string name { get; set; }
        public string passportNo { get; set; }
        public string surName { get; set; }
        public string gsm { get; set; }
        public bool openWay { get; set; }
        public string currencyTypeCode { get; set; }
        public string currencyTypeSymbol { get; set; }
        public int returnTicketID { get; set; }
        public DateTime birthDate { get; set; }
        public int routeType { get; set; }
        public string nationality { get; set; }
        public int passengerTypeID { get; set; }
        public string passengerTypeName { get; set; }
        public int departureRegionID { get; set; }
        public int arrivalRegionID { get; set; }
        public string countryName { get; set; }
        public DateTime? passportExpireDate { get; set; }
        public int countryID { get; set; }
        public int gender { get; set; }
        public string genderName { get; set; }
        public int visaTypeID { get; set; }
        public DateTime? visaExpireDate { get; set; }
        public DateTime? visaBeginDate { get; set; }
        public string visaClassName { get; set; }
        public decimal taxAmount { get; set; }
        public decimal termAmount { get; set; }
        public bool isBranchesCanChange { get; set; }
    }

    public class ReserveIssuePerPassenger
    {
        public int id { get; set; }
        public int forthCrsReserveIssueRequestID { get; set; }
        public int customerID { get; set; }
        public string addFees { get; set; }
        public DateTime birthDate { get; set; }
        public string birthPlace { get; set; }
        public string cabinOccupancyMode { get; set; }
        public string classAbbr { get; set; }
        public string classAbbrType { get; set; }
        public int capacity { get; set; }
        public string discount { get; set; }
        public DateTime docExpire { get; set; }
        public string documentNo { get; set; }
        public string documentType { get; set; }
        public string fareCode { get; set; }
        public string loyalty { get; set; }
        public string nationality { get; set; }
        public string passInitial { get; set; }
        public string passName { get; set; }
        public string passSex { get; set; }
        public string passSSR { get; set; }
        public int passType { get; set; }
        public string residence { get; set; }
        public int status { get; set; }
    }

    public class ReserveIssuePerVehicle
    {
        public int id { get; set; }
        public int vehicleType { get; set; }
        public string vehicleTypeName { get; set; }
        public int meters { get; set; }
        public string trailer { get; set; }
        public string discount { get; set; }
        public string fareCode { get; set; }
        public string plateNo { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public string nationality { get; set; }
        public string loyalty { get; set; }
        public string height { get; set; }
        public string addFees { get; set; }
        public string specialType { get; set; }
        public string driverSurName { get; set; }
        public string driverName { get; set; }
        public int forthCrsReserveIssueRequestID { get; set; }
        public int status { get; set; }
    }

    public class Result
    {
        public List<PassengerTicket> passengerTicket { get; set; }
        public List<VehicleTicket> vehicleTicket { get; set; }
        public List<ExtraService> extraService { get; set; }
        public List<Hotel> hotel { get; set; }
        public List<SalesCurrency> salesCurrency { get; set; }
        public SalesSource salesSource { get; set; }
        public int id { get; set; }
        public DateTime salesDate { get; set; }
        public decimal totalAmount { get; set; }
        public decimal totalAmountTL { get; set; }
        public decimal totalCommisonAmount { get; set; }
        public decimal totalRemainingAmount { get; set; }
        public int branchID { get; set; }
        public int step { get; set; }
        public int userID { get; set; }
        public string userName { get; set; }
        public string branchName { get; set; }
        public int reservationStatus { get; set; }
        public ForthCrsReservation forthCrsReservation { get; set; }
        public string note { get; set; }
        public Guid guid { get; set; }
    }

    public class Root
    {
        public List<Entities.Response.validation> valid { get; set; }
        public int recordCount { get; set; }
        public bool success { get; set; }
        public Result result { get; set; }
    }

    public class SalesSource
    {
        public int companyID { get; set; }
        public int id { get; set; }
        public int status { get; set; }
        public string utmCampaing { get; set; }
        public string utmMedium { get; set; }
        public string utmSource { get; set; }
        public string utmTerm { get; set; }
        public string utmContent { get; set; }
        public string urlReferrer { get; set; }
        public int salesID { get; set; }
    }

    public class Valid
    {
        public string key { get; set; }
        public string value { get; set; }
        public string code { get; set; }
    }

    public class VehicleTicket
    {
        public int status { get; set; }
        public int customerID { get; set; }
        public int returnCustomerID { get; set; }
        public int id { get; set; }
        public int expeditionID { get; set; }
        public int salesID { get; set; }
        public bool openWay { get; set; }
        public DateTime serviceDate { get; set; }
        public DateTime salesDate { get; set; }
        public decimal commissionAmount { get; set; }
        public decimal portTax { get; set; }
        public decimal salesAmount { get; set; }
        public decimal totalSalesAmount { get; set; }
        public decimal totalSalesAmountTL { get; set; }
        public int currencyID { get; set; }
        public int currencyTypeID { get; set; }
        public int vehicleTypeID { get; set; }
        public int returnSalesItemID { get; set; }
        public int ferryID { get; set; }
        public int routeID { get; set; }
        public int returnTicketID { get; set; }
        public TimeSpan arrivalTime { get; set; }
        public TimeSpan departureTime { get; set; }
        public string ferryName { get; set; }
        public string departureRegionName { get; set; }
        public string arrivalRegionName { get; set; }
        public string name { get; set; }
        public string passportNo { get; set; }
        public string surName { get; set; }
        public string gsm { get; set; }
        public string currencyTypeCode { get; set; }
        public string currencyTypeSymbol { get; set; }
        public DateTime birthDate { get; set; }
        public string nationality { get; set; }
        public string model { get; set; }
        public string brand { get; set; }
        public string plate { get; set; }
        public int departureRegionID { get; set; }
        public int arrivalRegionID { get; set; }
        public DateTime passportExpireDate { get; set; }
        public int routeType { get; set; }
        public string vehicleTypeName { get; set; }
        public decimal termAmount { get; set; }
        public decimal taxAmount { get; set; }
    }
}
