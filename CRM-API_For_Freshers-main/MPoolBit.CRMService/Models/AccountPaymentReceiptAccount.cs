using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class AccountPaymentReceiptAccount
    {
        public long Id { get; set; }
        public long? AccountPaymentReceiptId { get; set; }
        public long? AccountId { get; set; }
        public decimal? DebitAmount { get; set; }
        public decimal? CreditAmount { get; set; }
        public string Narration { get; set; }
        public long? CostCentreId { get; set; }
        public short? IsDeleted { get; set; }

        public virtual Account Account { get; set; }
        public virtual AccountPaymentReceipt AccountPaymentReceipt { get; set; }
        public virtual CostCategory CostCentre { get; set; }
    }
}
