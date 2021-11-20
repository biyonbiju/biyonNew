using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class AccountJournalBook
    {
        public AccountJournalBook()
        {
            AccountJournalBookDetail = new HashSet<AccountJournalBookDetail>();
        }

        public long Id { get; set; }
        public string Jnumber { get; set; }
        public DateTime? Date { get; set; }
        public string RefNo { get; set; }
        public long? AccountDocumentId { get; set; }
        public short? IsDeleted { get; set; }
        public long? FinancialPeriodId { get; set; }
        public long? SponsorshipCompanyId { get; set; }
        public long? AccountUserInvoiceId { get; set; }
        public DateTime? ProcessingDate { get; set; }
        public string Remarks { get; set; }

        public virtual AccountDocument AccountDocument { get; set; }
        public virtual AccountUserInvoice AccountUserInvoice { get; set; }
        public virtual FinancialPeriod FinancialPeriod { get; set; }
        public virtual SponsorshipCompany SponsorshipCompany { get; set; }
        public virtual ICollection<AccountJournalBookDetail> AccountJournalBookDetail { get; set; }
    }
}
