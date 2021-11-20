using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class AccountInvoiceDetails
    {
        public long Id { get; set; }
        public long? AccountInvoiceId { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string InvoiceNo { get; set; }
        public long? CostCategoryId { get; set; }
        public string LpoDnNo { get; set; }
        public decimal? Amount { get; set; }
        public short? IsDeleted { get; set; }

        public virtual AccountInvoice AccountInvoice { get; set; }
        public virtual CostCategory CostCategory { get; set; }
    }
}
