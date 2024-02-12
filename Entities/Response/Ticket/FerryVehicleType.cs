using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Response.Ticket
{
    public class FerryVehicleType : BaseResponse
    {
        public FerryVehicleType()
        {
            valid = new List<validation>();
        }
        public IEnumerable<FerryVehicleTypes> result { get; set; }
    }

    public class FerryVehicleTypes
    {
        public decimal lenght { get; set; }
        public decimal maxLength { get; set; }
        public Int32 vehicleCategoriID { get; set; }
        public Int32 id { get; set; }
        public string description { get; set; }
        public string name { get; set; }
        public int ferryVehicleGroupID { get; set; }
        public string ferryVehicleGroupName { get; set; }
    }
}
