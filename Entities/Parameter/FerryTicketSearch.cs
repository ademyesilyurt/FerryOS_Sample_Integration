using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Parameter.FerryTicketSearch
{
    public class ChildAge
    {
        public DateTime age { get; set; }
    }

    public class InfantAge
    {
        public DateTime age { get; set; }
    }

    public class Root
    {
        public int routeType { get; set; }
        public DateTime serviceDate { get; set; }
        public DateTime returnServiceDate { get; set; }
        public int departureRegionID { get; set; }
        public int arrivalRegionID { get; set; }
        public int adultQuantity { get; set; }
        public int childQuantity { get; set; }
        public int infantQuantity { get; set; }
        public int vehicleQuantity { get; set; }
        public List<ChildAge> childAge { get; set; }
        public List<InfantAge> infantAge { get; set; }
        public List<vehicleType> vehicleType { get; set; }
        public bool havePets { get; set; }
        public int departureExpeditionID { get; set; }
        public int returnExpeditionID { get; set; }
        public string langCode { get; set; }
    }

    public class vehicleType
    {
        public int vehicleTypeID { get; set; }
    }

}
