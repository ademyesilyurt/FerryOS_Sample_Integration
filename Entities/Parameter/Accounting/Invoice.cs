using System;
using System.Collections.Generic;
 
using System.Linq;
using System.Text;


namespace Entities.Parameter.Accounting
{
    public class BranchInvoice
    {
        public int BranchID { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string InvoiceID { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public string LangCode { get; set; }

    }
    public class CaseTransaction
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int TransactionTypeID { get; set; }
        public int CaseTransactionItemTypeID { get; set; }
        public int isApprove { get; set; }
        public int UserID { get; set; }
        public string LangCode { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }


    public class CustomerInvoice
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public long SalesID { get; set; }
        public string LangCode { get; set; }
        public bool? InvoicePrint { get; set; }
        public int BranchID { get; set; }
        public int InvoiceID { get; set; }
        public int recordCount { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }




    public class ExpencesInvoice
    {
        public string LangCode { get; set; }
        public int Year { get; set; }
    }


    public class EGovrementMailBox
    {
        public string LangCode { get; set; }
        public int PageSize { get; set; }
        public int PageIndex { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int eDocumentDirectionType { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string UUID { get; set; }
        public string FromTax { get; set; }
        public int CompanyID { get; set; }


    }

    public class EGovrementEInvoiceEArchiveReport
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string LangCode { get; set; }
    }

    public class BranchAccountTransaction
    {
        public int Year { get; set; }
        public string LangCode { get; set; }
    }


    public class GetInvoiceParameter
    {
        public string LangCode { get; set; }
        public long SalesID { get; set; }



    }
    public class ExpencesInvoiceTransferUpdate
    {
        public string LangCode { get; set; }
        public int BranchAccountTransactionsID { get; set; }
        public string AccountingTransferCode { get; set; }
    }

    public class CustomerInvoiceTransferUpdate
    {
        public long SalesID { get; set; }
        public string LangCode { get; set; }
        public int CompanyID { get; set; }
        public string AccountingTransferCode { get; set; }
        public bool isAccountingTransfer { get; set; }
    }

    public class CustomerInvoiceSendMailArchiveUpdate
    {
        public long SalesID { get; set; }
        public string LangCode { get; set; }
        public int CompanyID { get; set; }
        public bool isSend { get; set; }
    }

    public class BranchInvoiceTransferUpdate
    {
        public long InvoiceID { get; set; }
        public string LangCode { get; set; }
        public int CompanyID { get; set; }
        public string AccountingTransferCode { get; set; }
        public bool isAccountingTransfer { get; set; }
    }

    public class ApproveDiscount
    {
        public int ID { get; set; }
        public decimal Amount { get; set; }
        public string LangCode { get; set; }

    }

}
