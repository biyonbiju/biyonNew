using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class PaymentMode
    {
        public PaymentMode()
        {
            AccountPaymentReceipt = new HashSet<AccountPaymentReceipt>();
            UserDetails = new HashSet<UserDetails>();
        }

        public long Id { get; set; }
        public short? IsDeleted { get; set; }
        public string PaymentModel { get; set; }

        public virtual ICollection<AccountPaymentReceipt> AccountPaymentReceipt { get; set; }
        public virtual ICollection<UserDetails> UserDetails { get; set; }
    }
}
