using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Response.Content.Content
{
    public class Result
    {
        public int companyID { get; set; }
        public int id { get; set; }
        public int status { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string templateContent { get; set; }
        public string categoryName { get; set; }
        public int categoryID { get; set; }
    }

    public class Root
    {
        public List<Valid> valid { get; set; }
        public int recordCount { get; set; }
        public bool success { get; set; }
        public Result result { get; set; }
    }

    public class Valid
    {
        public string key { get; set; }
        public string value { get; set; }
        public string code { get; set; }
    }
}
