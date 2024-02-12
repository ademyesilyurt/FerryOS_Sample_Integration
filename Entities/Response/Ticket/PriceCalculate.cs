using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Response.Ticket
{
    public class PriceCalculate : BaseResponse
    {
        public PriceCalculate()
        {
            valid = new List<validation>();
        }
        public  Calculate result { get; set; }
    }

    public class Calculate
    {
        public IList<Passenger> passenger { get; set; }
        public IList<Vehicle> vehicle { get; set; }
    }

    public class Passenger
    {
        public int typeID { get; set; }
        public string typeName { get; set; }
        public string routeName { get; set; }
        public string departureRegionName { get; set; }
        public string arrivalRegionName { get; set; }
        public decimal amount { get; set; }
        public decimal portTax { get; set; }
        public decimal taxRate { get; set; }
        public Int64 departureExpeditionID { get; set; }
        public Int64 returnExpeditionID { get; set; }
        public decimal taxAmount { get; set; }
        public decimal totalAmount { get; set; }
        public string currencyTypeName { get; set; }
        public int currencyTypeID { get; set; }
        public string currencyTypeSymbol { get; set; }
        public string currencyTypeCode { get; set; }
        public decimal productCampaignValue { get; set; }
        public string productCampaignName { get; set; }
        public int productCampaignValueType { get; set; }

    }

    public class Vehicle
    {
        public decimal productCampaignValue { get; set; }
        public string productCampaignName { get; set; }
        public int productCampaignValueType { get; set; }
        public int typeID { get; set; }
        public string typeName { get; set; }
        public string routeName { get; set; }
        public decimal amount { get; set; }
        public decimal portTax { get; set; }
        public decimal taxRate { get; set; }
        public decimal taxAmount { get; set; }
        public decimal totalAmount { get; set; }
        public string currencyTypeName { get; set; }
        public int currencyTypeID { get; set; }
        public string currencyTypeSymbol { get; set; }
        public string currencyTypeCode { get; set; }

    }
}
