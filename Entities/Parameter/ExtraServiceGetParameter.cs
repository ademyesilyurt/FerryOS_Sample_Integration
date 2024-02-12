using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Parameter.ExtraServiceGetParameter
{
  
    public class Root
    {
        public int adultQuantity { get; set; }
        public int childQuantity { get; set; }
        public DateTime serviceDate { get; set; }
        public int serviceID { get; set; }
        public List<DateTime> childBirthDate { get; set; }
        public string langCode { get; set; }
        public string voucherGuid { get; set; }
    }

}
