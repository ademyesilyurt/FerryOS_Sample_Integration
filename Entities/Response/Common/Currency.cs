using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Response.Common
{
    public class Result
    {
        public DateTime date { get; set; }
        public decimal value { get; set; }
        public int typeID { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string symbol { get; set; }
        public string code { get; set; }
        public int companyID { get; set; }
        public int fluctuation { get; set; }
    }

    public class Root
    {
        public List<Result> result { get; set; }
        public List<validation> valid { get; set; }
        public int recordCount { get; set; }
        public bool success { get; set; }
    }

}
