using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Parameter
{
    public class Reservations
    {
        public int UserID { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public string LangCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int Step { get; set; }
        public int SalesID { get; set; }
    }
}
