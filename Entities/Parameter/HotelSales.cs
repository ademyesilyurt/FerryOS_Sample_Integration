using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Parameter
{
    public class HotelSales
    {
        public HotelCalculate HotelCalculate { get; set; }
        public List<HotelCustomers> Customer { get; set; }
        public int HotelID { get; set; }
        public int GroupID { get; set; }
        public string LangCode { get; set; }
    }

    public class HotelCustomers
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Gsm { get; set; }
        public DateTime? BirthDate { get; set; }
        public int Gender { get; set; }
        public int CustomerTypeID { get; set; }
    }
}
