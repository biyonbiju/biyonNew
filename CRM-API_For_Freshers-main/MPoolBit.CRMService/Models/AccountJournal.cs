using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class AccountJournal
    {
        public AccountJournal()
        {
            AccountJournalDetails = new HashSet<AccountJournalDetails>();
        }

        public long Id { get; set; }
        public DateTime? Date { get; set; }
        public string JournelCode { get; set; }
        public string FileName { get; set; }
        public long? DocumentUploadId { get; set; }
        public string Narration { get; set; }
        public short? IsDeleted { get; set; }
        public long? SponsorshipCompanyId { get; set; }
        public long? FinancialPeriodId { get; set; }
        public DateTime? ProcessingDate { get; set; }

        public virtual Attachment DocumentUpload { get; set; }
        public virtual FinancialPeriod FinancialPeriod { get; set; }
        public virtual SponsorshipCompany SponsorshipCompany { get; set; }
        public virtual ICollection<AccountJournalDetails> AccountJournalDetails { get; set; }
    }
}
