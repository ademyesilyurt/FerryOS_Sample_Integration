using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Parameter
{
    public class Branch
    {
        public string Name { get; set; }
        public long BranchID { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int CountryID { get; set; }
        public int CityID { get; set; }
        public int DistrictID { get; set; }
        public int BranchTypeID { get; set; }
        public int CompanyID { get; set; }
    }
}
