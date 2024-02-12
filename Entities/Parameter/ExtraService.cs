using System;
using System.Collections.Generic;
 using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Parameter
{
     

    public class ExtraServiceChildBirthDate
    {

        public DateTime? birthDate { get; set; }
    }

    public class ExtraServiceAvailableNextDays
    {

        public DateTime date { get; set; }
        public int extraServiceID { get; set; }
        public int id { get; set; }
        public int quota { get; set; }
        public string langCode { get; set; }
    }


    public class CreateExtraService
    {
        public string langCode { get; set; }
        public int serviceID { get; set; }
        public Guid? voucherGuid { get; set; }
 
        public DateTime serviceDate { get; set; }

        public IList<ExtraServiceCustomers> customer { get; set; }

    }


    public class ExtraServiceCustomers
    {
        public string name { get; set; }
        public string surName { get; set; }
        public int currencyTypeID { get; set; }
        public int customerTypeID { get; set; }
        public DateTime? birthDate { get; set; }
        public DateTime? returnServiceDate { get; set; }
        public int extraServicePropertiesID { get; set; }
    }



}



