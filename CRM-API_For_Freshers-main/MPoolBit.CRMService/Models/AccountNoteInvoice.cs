using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class AccountNoteInvoice
    {
        public long Id { get; set; }
        public long? AccountNoteId { get; set; }
        public long? InvoiceId { get; set; }
        public decimal? InvoiceAmount { get; set; }
        public decimal? Amount { get; set; }
        public short? IsDeleted { get; set; }

        public virtual AccountNote AccountNote { get; set; }
        public virtual AccountUserInvoice Invoice { get; set; }
    }
}
