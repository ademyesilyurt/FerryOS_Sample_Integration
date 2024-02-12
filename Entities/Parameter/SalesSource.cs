using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Parameter
{
    public class SalesSource
    {

        public string langCode { get; set; }
        public string voucherGuid { get; set; }
        public string utmCampaing { get; set; }
        public string utmMedium { get; set; }
        public string utmSource { get; set; }
        public string utmTerm { get; set; }
        public string urlReferrer { get; set; }
        public string utmContent { get; set; }

    }
}
