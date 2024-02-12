 using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Parameter
{

    public class PaymentReceipt
    {
        
        public DateTime PaymentStartDate { get; set; }
        
        public DateTime PaymentEndDate { get; set; }
 
        public List<int> BranchID { get; set; }
        public string LangCode { get; set; }
        public int PageSize { get; set; }
        public int PageIndex { get; set; }
        public bool? AccountingTransfer { get; set; }
    }
    public class PaymentReceiptTransferUpdate
    {
        public long PaymentID { get; set; }
        public string LangCode { get; set; }
    }

    public class VPosPayment3DSecureReturn
    {
        public List<Input3d> inputs { get; set; }
        public Guid voucherGuid { get; set; }
        public string langCode { get; set; }
    }
    
    public class VPosPaymentGiroGate
    {
 
        public string CountryCode { get; set; }
        public string LangCode { get; set; }
 
        public Guid VoucherGuid { get; set; }
        public decimal Amount { get; set; }
 
        public string Name { get; set; }
 
        public string SurName { get; set; }
        public string ApproveReturnUrl { get; set; }
        public string NotApproveReturnUrl { get; set; }
        public string IpAddress { get; set; }
        public string Email { get; set; }
        public string Gsm { get; set; }
        public int GiroGatePaymentTypeID { get; set; }
        public int InstallmentID { get; set; }

    }

    public class GiroGatePaymentType
    {

        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int BankID { get; set; }
        public int CompanyID { get; set; }
        public int GiroGatePaymentTypeID { get; set; }
    }

    public class CashPayment
    {
        public string LangCode { get; set; }
 
        public Guid VoucherGuid { get; set; }
        public int CurrencyTypeID { get; set; }
    }

    public class PosBank
    {
        public string LangCode { get; set; }
        public int BankID { get; set; }
        public int CreditCardID { get; set; }
        public int InstallmentID { get; set; }
        public int PaymentType { get; set; }
 
        public Guid VoucherGuid { get; set; }
    }

    public class PaymentListParameter
    {
        public long SalesID { get; set; }
        public long ID { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int Approval { get; set; }
        public int RefundSubtractionTypeID { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int Refunded { get; set; }
        public string LangCode { get; set; }
    }

}
