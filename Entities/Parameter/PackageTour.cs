using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Parameter
{
    public class PackageTour
    {
        public class CalculatePackageTourParameter
        {
            public string Phone { get; set; }
            public int PackageTourID { get; set; }
            public string LangCode { get; set; }
            public List<Customer> Customer { get; set; }
        }

        public class PackageTourCategoryListParameter
        {
            public string LangCode { get; set; }
            public int? ParentID { get; set; }
            public int PageIndex { get; set; }
            public int PageSize { get; set; }
            public int Status { get; set; }
        }

        public class PackageTourProductListParameter
        {
            public string LangCode { get; set; }
            public int PageIndex { get; set; }
            public int PageSize { get; set; }
            public int PackageTourID { get; set; }
        }

        public class PackageTourListParameter
        {
            public string LangCode { get; set; }
            public int PageIndex { get; set; }
            public int PageSize { get; set; }
            public string ProductGroupCode { get; set; }
            public int CategoryID { get; set; }
            public int HotelID { get; set; }
            public int ExtraServiceID { get; set; }
            public string CategoryUrl { get; set; }
            public DateTime? StartDate { get; set; }
            public DateTime? EndDate { get; set; }
        }
        public class PackageTourParameter
        {
            public string LangCode { get; set; }
            public int PackageTourID { get; set; }
            public string Url { get; set; }
        }
    }
}
