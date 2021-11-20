using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class AccountInvoiceType
    {
        public AccountInvoiceType()
        {
            AccountInvoice = new HashSet<AccountInvoice>();
        }

        public long Id { get; set; }
        public string TypeName { get; set; }
        public short? IsDeleted { get; set; }

        public virtual ICollection<AccountInvoice> AccountInvoice { get; set; }
    }
}
