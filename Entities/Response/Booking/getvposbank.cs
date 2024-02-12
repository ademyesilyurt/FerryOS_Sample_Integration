using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Response.Booking.getvposbank
{
    public class Result
    {
        public int companyID { get; set; }
        public string bank { get; set; }
        public string cardName { get; set; }
        public int paymentTypeID { get; set; }
        public int sort { get; set; }
        public string logo { get; set; }
        public bool secure3DMandatory { get; set; }
        public bool secure3D { get; set; }
        public int bankID { get; set; }
        public int creditCardID { get; set; }
        public List<SalesBankInstallmentList> salesBankInstallmentList { get; set; }
    }

    public class Root
    {
        public List<Valid> valid { get; set; }
        public int recordCount { get; set; }
        public bool success { get; set; }
        public List<Result> result { get; set; }
    }

    public class SalesBankInstallmentList
    {
        public int companyID { get; set; }
        public int bankID { get; set; }
        public int installment { get; set; }
        public int installmentID { get; set; }
        public decimal amount { get; set; }
        public int id { get; set; }
    }

    public class Valid
    {
        public string key { get; set; }
        public string value { get; set; }
        public string code { get; set; }
    }

}
