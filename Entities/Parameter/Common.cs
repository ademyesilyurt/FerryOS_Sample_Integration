using System;
using System.Collections.Generic;
 using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace Entities.Parameter
{

    public class Customer
    {
        public DateTime BirthDate { get; set; }
        public DateTime? PassportExpireDate { get; set; }
        public long CountryID { get; set; }
        public int Gender { get; set; }
        public long ID { get; set; }
        public string PassportNo { get; set; }
        public int Status { get; set; }
        public string Email { get; set; }
        public string Gsm { get; set; }
        
        public string Name { get; set; }
        
        public string SurName { get; set; }
        public int ReturnFerryID { get; set; }
        public int FerryID { get; set; }
        public int VehicleType { get; set; }
        public decimal PortTax { get; set; }
        public decimal PortTaxValueType { get; set; }
        public int PassengerTypeID { get; set; }
        public decimal SalesAmount { get; set; }
        public long DepartureCustomerID { get; set; }
        public long ReturnCustomerID { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Plate { get; set; }
         public int Adult { get; set; }
        public List<int> Child { get; set; }
        public List<int> Infant { get; set; }
    }


    public class Gender
    {
        public string LangCode { get; set; }
    }


    public class InvoiceTypes
    {

        public string LangCode { get; set; }
    }

    public class NextStep
    {
        public string LangCode { get; set; }
        public int SalesID { get; set; }
    }

    public class Country
    {
        public string LangCode { get; set; }
    }

    public class Currency
    {
        public string LangCode { get; set; }
    }

    public class ApiMessage
    {
        public string LangCode { get; set; }
    }

    public class City
    {
        public int CountryID { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public string LangCode { get; set; }
    }

    public class District
    {

        public int CityID { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public string LangCode { get; set; }
    }

    public class Neighborhood
    {

        public int DistrictID { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public string LangCode { get; set; }
    }
}
