using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Parameter
{
    public class Login
    {
        public string Password { get; set; }
        public string Email { get; set; }
        public string PlatformRecordID { get; set; }
        public int RegisteredPlatformID { get; set; }
        public string LangCode { get; set; }
    }
}
