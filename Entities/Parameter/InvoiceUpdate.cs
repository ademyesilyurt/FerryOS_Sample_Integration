using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Parameter.InvoiceUpdate
{

    public class InvoiceItem
    {
        public bool eInvoice { get; set; }
        public int countryID { get; set; }
        public int cityID { get; set; }
         public int districtID { get; set; }
        public string address { get; set; }
        public string citizenshipID { get; set; }
        public string email { get; set; }
        public string gsm { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string surName { get; set; }
        public string taxNo { get; set; }
        public string taxOffice { get; set; }
        public string title { get; set; }
        public string integrationInvoiceID { get; set; }
        public int invoiceType { get; set; }
      
    }

    public class Root
    {
        public string langCode { get; set; }
        public string voucherGuid { get; set; }
        public InvoiceItem invoiceItem { get; set; }
    }



}
