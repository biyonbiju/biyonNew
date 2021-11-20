using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class AccountPaymentReceipt
    {
        public AccountPaymentReceipt()
        {
            AccountPaymentReceiptAccount = new HashSet<AccountPaymentReceiptAccount>();
            AccountPaymentReceiptInvoice = new HashSet<AccountPaymentReceiptInvoice>();
        }

        public long Id { get; set; }
        public long? PaymentModeId { get; set; }
        public string BprvNo { get; set; }
        public DateTime? Date { get; set; }
        public long? AccountDocumentId { get; set; }
        public long? DocumentUploadId { get; set; }
        public string FileName { get; set; }
        public string ChequeNo { get; set; }
        public DateTime? ChequeDate { get; set; }
        public long? LedgerTypeId { get; set; }
        public string Payee { get; set; }
        public short? HasPayee { get; set; }
        public decimal? GrandTotal { get; set; }
        public long? PreparedById { get; set; }
        public long? CheckedById { get; set; }
        public long? ApprovedById { get; set; }
        public long? SponsorshipCompanyId { get; set; }
        public long? FinancialPeriodId { get; set; }
        public short? IsDeleted { get; set; }
        public short? IsVerified { get; set; }
        public short? IsApproved { get; set; }
        public short? Status { get; set; }
        public string UserRemarks { get; set; }
        public DateTime? PostedDate { get; set; }
        public string CustBank { get; set; }
        public long? UserRoleId { get; set; }
        public DateTime? ProcessingDate { get; set; }
        public long? UserId { get; set; }

        public virtual AccountDocument AccountDocument { get; set; }
        public virtual User ApprovedBy { get; set; }
        public virtual User CheckedBy { get; set; }
        public virtual Attachment DocumentUpload { get; set; }
        public virtual FinancialPeriod FinancialPeriod { get; set; }
        public virtual AccountLedgerType LedgerType { get; set; }
        public virtual PaymentMode PaymentMode { get; set; }
        public virtual User PreparedBy { get; set; }
        public virtual SponsorshipCompany SponsorshipCompany { get; set; }
        public virtual User User { get; set; }
        public virtual UserRole UserRole { get; set; }
        public virtual ICollection<AccountPaymentReceiptAccount> AccountPaymentReceiptAccount { get; set; }
        public virtual ICollection<AccountPaymentReceiptInvoice> AccountPaymentReceiptInvoice { get; set; }
    }
}
