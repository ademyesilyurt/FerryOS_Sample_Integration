using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Response.Ticket
{
    public class ChangeTicket : BaseResponse
    {
        public ChangeTicket()
        {
            valid = new List<validation>();
        }
        public List<ChangeTickets> Result { get; set; }
    }
    public class ChangeTickets
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int CustomerID { get; set; }
        public Route DepartureExpedition { get; set; }
        public Route ReturnExpedition { get; set; }
        public IList<validation> valid { get; set; }
    }

    public class Route
    {
        public bool isVehicleBooking { get; set; }
        public string RouteName { get; set; }
        public int RouteID { get; set; }
        public IList<FerrySearchResult> Expedition { get; set; }
    }
}
