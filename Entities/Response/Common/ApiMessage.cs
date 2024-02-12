using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Response.Common
{
    public class ApiMessage_Response : BaseResponse
    {
        public ApiMessage_Response() {
            valid = new List<validation>();
        }
        public List<ApiMessage> Result { get; set; }
    }
    public class ApiMessage
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public IList<LangValue> Language { get; set; }
    }
    public class LangValue
    {
        public Int32 LanguageID { get; set; }
        public string LanguageCode { get; set; }
        public String Value { get; set; }
    }
}
