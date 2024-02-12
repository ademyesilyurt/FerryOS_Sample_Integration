using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Parameter.ExtraServiceInsert
{
    public class Customer
    {
        public string name { get; set; }
        public string surName { get; set; }
        public int currencyTypeID { get; set; }
        public int customerTypeID { get; set; }
        public DateTime? birthDate { get; set; }
        public DateTime? returnServiceDate { get; set; }
        public int extraServicePropertiesID { get; set; }
    }

    public class Root
    {
        public string langCode { get; set; }
        public int serviceID { get; set; }
        public string voucherGuid { get; set; }
        public DateTime serviceDate { get; set; }
        public List<Customer> customer { get; set; }
    }


}
