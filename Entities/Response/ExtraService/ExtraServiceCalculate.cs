using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Response.ExtraService.ExtraServiceCalculate
{
    public class ExtraServiceAvailableNextDay
    {
        public int companyID { get; set; }
        public DateTime date { get; set; }
        public int extraServiceID { get; set; }
    }

    public class ExtraServiceProperty
    {
        public int companyID { get; set; }
        public int id { get; set; }
        public int extraServicePropertiesCategoriesID { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public int sort { get; set; }
    }

    public class Result
    {
        public string name { get; set; }
        public string surName { get; set; }
        public string currencyTypeSymbol { get; set; }
        public int currencyID { get; set; }
        public int extraServiceID { get; set; }
        public DateTime serviceDate { get; set; }
        public decimal amount { get; set; }
        public int currencyTypeID { get; set; }
        public int customerTypeID { get; set; }
        public DateTime? birthDate { get; set; }
        public string customerTypeName { get; set; }
        public int extraServicePropertiesID { get; set; }
        public string extraServicePropertiesName { get; set; }
        public string extraServicePropertiesCategoriesName { get; set; }
        public int extraServicePropertiesCategoriesID { get; set; }
        public List<ExtraServiceProperty> extraServiceProperties { get; set; }
        public List<ExtraServiceAvailableNextDay> extraServiceAvailableNextDays { get; set; }
        public decimal taxRate { get; set; }
        public decimal taxAmount { get; set; }
        public decimal startAge { get; set; }
        public decimal endAge { get; set; }
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
