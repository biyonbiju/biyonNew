using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class AccountDocument
    {
        public AccountDocument()
        {
            AccountJournalBook = new HashSet<AccountJournalBook>();
            AccountPaymentReceipt = new HashSet<AccountPaymentReceipt>();
            AccountSettingsCreditNoteDocument = new HashSet<AccountSettings>();
            AccountSettingsDebitNoteDocument = new HashSet<AccountSettings>();
            AccountSettingsDefaultJournlDocument = new HashSet<AccountSettings>();
            AccountSettingsDepreciationDocument = new HashSet<AccountSettings>();
            AccountSettingsPdcpaymentDocument = new HashSet<AccountSettings>();
            AccountSettingsPdcreceiptDocument = new HashSet<AccountSettings>();
            AccountUserInvoice = new HashSet<AccountUserInvoice>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public long? Category { get; set; }
        public string PaymentPrefix { get; set; }
        public string ReceiptPrefix { get; set; }
        public string JournlPrefix { get; set; }
        public short? IsPdc { get; set; }
        public string FileName { get; set; }
        public long? AttachmentId { get; set; }
        public long? AccountHeadId { get; set; }
        public short? IsDeleted { get; set; }
        public long? SponsorshipCompanyId { get; set; }

        public virtual Account AccountHead { get; set; }
        public virtual AccountDocumentCategory CategoryNavigation { get; set; }
        public virtual SponsorshipCompany SponsorshipCompany { get; set; }
        public virtual ICollection<AccountJournalBook> AccountJournalBook { get; set; }
        public virtual ICollection<AccountPaymentReceipt> AccountPaymentReceipt { get; set; }
        public virtual ICollection<AccountSettings> AccountSettingsCreditNoteDocument { get; set; }
        public virtual ICollection<AccountSettings> AccountSettingsDebitNoteDocument { get; set; }
        public virtual ICollection<AccountSettings> AccountSettingsDefaultJournlDocument { get; set; }
        public virtual ICollection<AccountSettings> AccountSettingsDepreciationDocument { get; set; }
        public virtual ICollection<AccountSettings> AccountSettingsPdcpaymentDocument { get; set; }
        public virtual ICollection<AccountSettings> AccountSettingsPdcreceiptDocument { get; set; }
        public virtual ICollection<AccountUserInvoice> AccountUserInvoice { get; set; }
    }
}
