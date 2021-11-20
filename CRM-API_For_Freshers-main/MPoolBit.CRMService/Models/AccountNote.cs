using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class AccountNote
    {
        public AccountNote()
        {
            AccountNoteAccount = new HashSet<AccountNoteAccount>();
            AccountNoteInvoice = new HashSet<AccountNoteInvoice>();
        }

        public long Id { get; set; }
        public string CreditNoteNo { get; set; }
        public DateTime? Date { get; set; }
        public long? UserId { get; set; }
        public string Remarks { get; set; }
        public short? AcknowledgementCopy { get; set; }
        public long? DocumentUploadId { get; set; }
        public string FileName { get; set; }
        public short? IsDeleted { get; set; }
        public long? FinancialPeriodId { get; set; }
        public long? SponsorshipCompanyId { get; set; }
        public long? UserRoleId { get; set; }
        public DateTime? ProcessingDate { get; set; }

        public virtual Attachment DocumentUpload { get; set; }
        public virtual FinancialPeriod FinancialPeriod { get; set; }
        public virtual SponsorshipCompany SponsorshipCompany { get; set; }
        public virtual User User { get; set; }
        public virtual UserRole UserRole { get; set; }
        public virtual ICollection<AccountNoteAccount> AccountNoteAccount { get; set; }
        public virtual ICollection<AccountNoteInvoice> AccountNoteInvoice { get; set; }
    }
}
