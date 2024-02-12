using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Parameter
{
    public class HotelCalculate
    {
        public int AdultQuantity { get; set; }
        public int ChildQuantity { get; set; }
      
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int HotelID { get; set; }
        public List<HotelChildBirthDate> ChildBirthDate { get; set; }
        public string LangCode { get; set; }
        public Guid? VoucherGuid { get; set; }

    }

    public class HotelChildBirthDate
    {

        public DateTime? BirthDate { get; set; }
    }


}
