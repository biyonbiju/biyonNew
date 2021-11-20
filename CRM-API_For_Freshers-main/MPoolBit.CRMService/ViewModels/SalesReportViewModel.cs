using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MPoolBit.CRMService.ViewModels
{
    public partial class SalesReportViewModel
    {
        public string Owner { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string OpportunityName { get; set; }
        public string InvoiceDiscount { get; set; }
        public string InvoiceNumber { get; set; }
        public decimal? InvoiceAmount { get; set; }
        public string AccountName { get; set; }
        public decimal? InvoiceVAT { get; set; }
        public decimal? InvoiceTotal { get; set; }
        public long? AccountUserInvoiceId { get; set; }
        

    }
}
