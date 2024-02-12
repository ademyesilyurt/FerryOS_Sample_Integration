using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Response.Booking.Invoice
{
    public class Credential
    {
        public int companyID { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string value { get; set; }
        public bool notPrintService { get; set; }
        public string ipAddress { get; set; }
        public int langID { get; set; }
        public DateTime localTime { get; set; }
        public string versionNumber { get; set; }
        public string applicationID { get; set; }
        public string deviceTypeID { get; set; }
    }

    public class Exchange
    {
        public DateTime date { get; set; }
        public decimal value { get; set; }
        public string typeID { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string symbol { get; set; }
        public string code { get; set; }
        public int companyID { get; set; }
        public int fluctuation { get; set; }
    }

    public class InvoiceItem
    {
        public string productCode { get; set; }
        public int productCategoryID { get; set; }
        public int productID { get; set; }
        public string productType { get; set; }
        public string productName { get; set; }
        public string shortProductName { get; set; }
        public decimal amount { get; set; }
        public decimal taxRate { get; set; }
        public decimal taxAmount { get; set; }
        public string accountingCode { get; set; }
        public int currencyTypeID { get; set; }
        public string currencyTypeCode { get; set; }
        public int currencyID { get; set; }
        public int ticketOfNumber { get; set; }
        public string accountingGroupCode { get; set; }
    }

    public class InvoicePayment
    {
        public int paymentID { get; set; }
        public decimal amount { get; set; }
        public DateTime paymentDate { get; set; }
        public string paymentTypeID { get; set; }
        public int currencyTypeID { get; set; }
        public string currencyTypeCode { get; set; }
        public string currencyTypeSymbol { get; set; }
        public int currencyID { get; set; }
        public string accountingCode { get; set; }
        public decimal currencyAmount { get; set; }
        public int installment { get; set; }
        public decimal exchangeRate { get; set; }
        public decimal customerCommission { get; set; }
        public decimal termAmount { get; set; }
        public string paymentName { get; set; }
        public string paymentTypeName { get; set; }
    }

   

    public class Result
    {
        public Int64 salesID { get; set; }
        public String voucherGuid { get; set; }
        public Boolean eInvoice { get; set; }
        public Int32 cityID { get; set; }
        public string city { get; set; }
        public string district { get; set; }
        public Int32 countryID { get; set; }
        public string country { get; set; }
        public Int32 districtID { get; set; }
        public string integrationInvoiceID { get; set; }
        public Int32 invoiceSortNo { get; set; }
        public int neighborhoodID { get; set; }
        public string address { get; set; }
        public string citizenshipID { get; set; }
        public string company { get; set; }
        public string gIBInvoiceCode { get; set; }
        public string accountingTransferCode { get; set; }
        public string eInvoiceStatusParameter { get; set; }
        public string eTTN { get; set; }
        public string email { get; set; }

        public string gsm { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string surName { get; set; }
        public string taxNo { get; set; }
        public string taxOffice { get; set; }
        public string title { get; set; }
        public int branchID { get; set; }
        public bool companyBranch { get; set; }
        public int invoiceType { get; set; }
    }

    public class Root
    {
        public List<Valid> valid { get; set; }
        public int recordCount { get; set; }
        public bool success { get; set; }
        public Result result { get; set; }
    }

    public class Valid
    {
        public string key { get; set; }
        public string value { get; set; }
        public string code { get; set; }
    }
}
