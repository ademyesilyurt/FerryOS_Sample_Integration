using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Parameter
{

    public class PackageTourBook
    {
        public CalculatePackageTour Calculate { get; set; }
        public IList<FerryTcket> FerryTcket { get; set; }
        public IList<ExtraService> ExtraService { get; set; }
        public IList<Hotel> Hotel { get; set; }
    }
    public class CalculatePackageTour
    {
        public string Phone { get; set; }
        public int PackageTourID { get; set; }
        public int CompanyID { get; set; }
        public string LangCode { get; set; }
        public int BranchID { get; set; }
        public int UserID { get; set; }
        public long SalesID { get; set; }
        public List<Customer> Customer { get; set; }
    }
    public class FerryTcket
    {
        public int ExpeditionID { get; set; }
        public int CustomerNo { get; set; }
        public DateTime? BirthDate { get; set; }
        public string PassportNo { get; set; }
        public string CitizenshipID { get; set; }
    }
    public class ExtraService
    {
        public int ExtraServiceID { get; set; }
        public int CustomerNo { get; set; }
        public int GroupID { get; set; }
        public int ExtraServicePropertiesID { get; set; }
    }

    public class Hotel
    {
        public int HotelID { get; set; }
        public int GroupID { get; set; }
    }

}
