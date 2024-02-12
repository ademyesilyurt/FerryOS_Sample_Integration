using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Parameter
{


    public class User_CmToken_Update
    {
        public string Token { get; set; }
        public string DeviceID { get; set; }
        public string LangCode { get; set; }
    }

    public class WebNotificationUser
    {
        public string TokenKey { get; set; }

    }

}
