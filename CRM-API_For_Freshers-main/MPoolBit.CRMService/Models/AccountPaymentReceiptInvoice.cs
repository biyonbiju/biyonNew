using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class AccountPaymentReceiptInvoice
    {
        public long Id { get; set; }
        public long? AccountPaymentReceiptId { get; set; }
        public long? InvoiceId { get; set; }
        public decimal? InvoiceAmount { get; set; }
        public decimal? Amount { get; set; }
        public short? IsDeleted { get; set; }

        public virtual AccountPaymentReceipt AccountPaymentReceipt { get; set; }
        public virtual AccountUserInvoice Invoice { get; set; }
    }
}
