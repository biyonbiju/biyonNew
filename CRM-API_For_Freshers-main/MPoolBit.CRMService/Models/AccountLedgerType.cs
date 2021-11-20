using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class AccountLedgerType
    {
        public AccountLedgerType()
        {
            AccountPaymentReceipt = new HashSet<AccountPaymentReceipt>();
        }

        public long Id { get; set; }
        public string Type { get; set; }
        public short? IsDeleted { get; set; }

        public virtual ICollection<AccountPaymentReceipt> AccountPaymentReceipt { get; set; }
    }
}
