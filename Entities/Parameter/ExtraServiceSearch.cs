using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Parameter.ExtraServices.calculate
{
    public class ChildBirthDate
    {
        public DateTime birthDate { get; set; }
    }

    public class Root
    {
        public int adultQuantity { get; set; }
        public int childQuantity { get; set; }
        public DateTime serviceDate { get; set; }
        public int serviceID { get; set; }
        public List<ChildBirthDate> childBirthDate { get; set; }
        public string langCode { get; set; }
        public string voucherGuid { get; set; }
    }


}
namespace Entities.Parameter.ExtraServices.Search
{

    public class City
    {
        public int cityID { get; set; }
    }

    public class Region
    {
        public int regionID { get; set; }
    }

    public class Root
    {
        public bool calculate { get; set; }
        public string langCode { get; set; }
        public int pageIndex { get; set; }
        public int pageSize { get; set; }
        public int productTypeID { get; set; }
        public int companyID { get; set; }
        public string productGroupCode { get; set; }
        public int webProductGroupID { get; set; }
        public DateTime serviceStartDate { get; set; }
        public DateTime serviceEndDate { get; set; }
        public List<DateTime> birthDate { get; set; }
        public int maxPrice { get; set; }
        public int minPrice { get; set; }
        public string name { get; set; }
        public int countryID { get; set; }
        public int cityID { get; set; }
        public int districtID { get; set; }
        public List<Region> regions { get; set; }
        public List<City> citys { get; set; }
    }



}



