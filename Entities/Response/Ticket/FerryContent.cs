using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Response.Ticket
{
    public class FerryContent : BaseResponse
    {
        public FerryContent()
        {
            valid = new List<validation>();
        }
        public IList<Content> result { get; set; }
    }
    public class Content
    {
        public int ferryID { get; set; }
        public string ferryName { get; set; }
        public string ferryCompanyName { get; set; }
        public string ferryContent { get; set; }
    }
}
