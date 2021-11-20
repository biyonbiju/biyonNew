using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class AccountUserInvoice
    {
        public AccountUserInvoice()
        {
            AccountJournalBook = new HashSet<AccountJournalBook>();
            AccountNoteInvoice = new HashSet<AccountNoteInvoice>();
            AccountPaymentReceiptInvoice = new HashSet<AccountPaymentReceiptInvoice>();
            AccountUserInvoiceDocument = new HashSet<AccountUserInvoiceDocument>();
            ClientInvoiceDesignation = new HashSet<ClientInvoiceDesignation>();
            ClientInvoiceExpense = new HashSet<ClientInvoiceExpense>();
            ClientInvoiceProject = new HashSet<ClientInvoiceProject>();
            ClientInvoiceReference = new HashSet<ClientInvoiceReference>();
            ClientTimeSheetEmployee = new HashSet<ClientTimeSheetEmployee>();
            SupplierInvoiceDetails = new HashSet<SupplierInvoiceDetails>();
            SupplierTimeCard = new HashSet<SupplierTimeCard>();
        }

        public long Id { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public long? UserId { get; set; }
        public int? Month { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string Remarks { get; set; }
        public decimal? NetTotal { get; set; }
        public decimal? Deduction { get; set; }
        public decimal? SafetyDeduction { get; set; }
        public decimal? AbsentPenality { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? Advance { get; set; }
        public string BillNo { get; set; }
        public decimal? InvoiceAmount { get; set; }
        public decimal? TaxPercentage { get; set; }
        public long? AccountDocumentId { get; set; }
        public short? IsFinal { get; set; }
        public short? IsPosted { get; set; }
        public short? IsDeleted { get; set; }
        public long? FinancialPeriodId { get; set; }
        public long? SponsorshipCompanyId { get; set; }
        public long? UserRoleId { get; set; }
        public DateTime? ProcessingDate { get; set; }
        public short? IsDirectInvoice { get; set; }
        public short? IsPerformaInvoice { get; set; }
        public DateTime? AcknowledgementDate { get; set; }
        public short? IsAdvance { get; set; }
        public long? PreparedById { get; set; }
        public long? CheckedById { get; set; }
        public long? ApprovedById { get; set; }
        public decimal? Total { get; set; }
        public decimal? Vat { get; set; }
        public string Status { get; set; }
        public short? IsPaymentCertificateFinal { get; set; }
        public short? IsTransfer { get; set; }
        public decimal? BalanceAmountPr { get; set; }

        public virtual AccountDocument AccountDocument { get; set; }
        public virtual User ApprovedBy { get; set; }
        public virtual User CheckedBy { get; set; }
        public virtual FinancialPeriod FinancialPeriod { get; set; }
        public virtual User PreparedBy { get; set; }
        public virtual SponsorshipCompany SponsorshipCompany { get; set; }
        public virtual User User { get; set; }
        public virtual UserRole UserRole { get; set; }
        public virtual ICollection<AccountJournalBook> AccountJournalBook { get; set; }
        public virtual ICollection<AccountNoteInvoice> AccountNoteInvoice { get; set; }
        public virtual ICollection<AccountPaymentReceiptInvoice> AccountPaymentReceiptInvoice { get; set; }
        public virtual ICollection<AccountUserInvoiceDocument> AccountUserInvoiceDocument { get; set; }
        public virtual ICollection<ClientInvoiceDesignation> ClientInvoiceDesignation { get; set; }
        public virtual ICollection<ClientInvoiceExpense> ClientInvoiceExpense { get; set; }
        public virtual ICollection<ClientInvoiceProject> ClientInvoiceProject { get; set; }
        public virtual ICollection<ClientInvoiceReference> ClientInvoiceReference { get; set; }
        public virtual ICollection<ClientTimeSheetEmployee> ClientTimeSheetEmployee { get; set; }
        public virtual ICollection<SupplierInvoiceDetails> SupplierInvoiceDetails { get; set; }
        public virtual ICollection<SupplierTimeCard> SupplierTimeCard { get; set; }
    }
}
