using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Parameter
{
    public class ProductDetail
    {
        public string LangCode { get; set; }
        public string Url { get; set; }
        public int HotelID { get; set; }
    }

    public class Product
    {
        public bool Calculate { get; set; }
        public string LangCode { get; set; }
        public int pageIndex { get; set; }
        public int pageSize { get; set; }
        public int ProductTypeID { get; set; }
        public int CompanyID { get; set; }
        public string ProductGroupCode { get; set; }
        public int WebProductGroupID { get; set; }
        public DateTime? ServiceStartDate { get; set; }
        public DateTime? ServiceEndDate { get; set; }
        public IList<DateTime> BirthDate { get; set; }
        public decimal MaxPrice { get; set; }
        public decimal MinPrice { get; set; }
        public string Name { get; set; }
        public int CountryID { get; set; }
        public int CityID { get; set; }
        public int DistrictID { get; set; }
        public IList<Regions> Regions { get; set; }
        public IList<Citys> Citys { get; set; }

    }


    public class Regions
    {
        public int RegionID { get; set; }
    }

    public class Citys
    {
        public int CityID { get; set; }
    }

    public class WebProductGrup
    {
        public int ProductTypeID { get; set; }
        public int ID { get; set; }
    }
}
