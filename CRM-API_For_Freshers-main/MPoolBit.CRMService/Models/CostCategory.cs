using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class CostCategory
    {
        public CostCategory()
        {
            Account = new HashSet<Account>();
            AccountInvoiceDetails = new HashSet<AccountInvoiceDetails>();
            AccountJournalBookDetail = new HashSet<AccountJournalBookDetail>();
            AccountJournalDetails = new HashSet<AccountJournalDetails>();
            AccountPaymentReceiptAccount = new HashSet<AccountPaymentReceiptAccount>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public short? IsDeleted { get; set; }
        public long? SponsorshipCompanyId { get; set; }

        public virtual SponsorshipCompany SponsorshipCompany { get; set; }
        public virtual ICollection<Account> Account { get; set; }
        public virtual ICollection<AccountInvoiceDetails> AccountInvoiceDetails { get; set; }
        public virtual ICollection<AccountJournalBookDetail> AccountJournalBookDetail { get; set; }
        public virtual ICollection<AccountJournalDetails> AccountJournalDetails { get; set; }
        public virtual ICollection<AccountPaymentReceiptAccount> AccountPaymentReceiptAccount { get; set; }
    }
}
