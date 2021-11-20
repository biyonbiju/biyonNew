using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class AccountSettings
    {
        public long Id { get; set; }
        public long? SponsorshipCompanyId { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public long? SundryDebtorAccountGroupId { get; set; }
        public long? SundryCreditorAccountGroupId { get; set; }
        public long? EmployeeSalaryAccountGroupId { get; set; }
        public long? EmployeeLoanAccountGroupId { get; set; }
        public long? DefaultCashAccountId { get; set; }
        public long? SalesAccountId { get; set; }
        public long? PurchaseAccountId { get; set; }
        public long? DefaultCustomerAccountId { get; set; }
        public long? DefaultSupplierAccountId { get; set; }
        public long? GainLossAccountId { get; set; }
        public long? CreditNoteAccountId { get; set; }
        public long? DebitNoteAccountId { get; set; }
        public long? InputTaxAccountId { get; set; }
        public long? OutputTaxAccountId { get; set; }
        public long? SalaryAccountId { get; set; }
        public long? LoanAccountId { get; set; }
        public long? LeaveSalaryAccountId { get; set; }
        public long? SiteAllowanceAccountId { get; set; }
        public long? SettlementAccountId { get; set; }
        public long? VehicleFineAccountId { get; set; }
        public long? SecurityAccountId { get; set; }
        public long? OtherDeductionAccountId { get; set; }
        public long? ProjectAccountId { get; set; }
        public long? TelephoneAccountId { get; set; }
        public long? DefaultJournlDocumentId { get; set; }
        public long? PdcreceiptDocumentId { get; set; }
        public long? PdcpaymentDocumentId { get; set; }
        public long? CreditNoteDocumentId { get; set; }
        public long? DebitNoteDocumentId { get; set; }
        public long? DepreciationDocumentId { get; set; }
        public long? CurrencyId { get; set; }
        public decimal? InputTax { get; set; }
        public decimal? OutputTax { get; set; }
        public long? CashPaymentDocumentNumber { get; set; }
        public long? CashReceiptDocumentNumber { get; set; }
        public long? JournlDocumentNumber { get; set; }
        public long? PurchaseOrderDocumentNumber { get; set; }
        public long? SalesInvoiceDocumentNumber { get; set; }
        public long? BankPaymentDocumentNumber { get; set; }
        public long? BankReceiptDocumentNumber { get; set; }
        public long? ContraDocumentNumber { get; set; }
        public long? PurchaceInvoiceDocumentNumber { get; set; }
        public short? IsDeleted { get; set; }
        public long? FinancialPeriodId { get; set; }
        public decimal? TaxPercentage { get; set; }
        public string PurchaceInvoicePrefix { get; set; }
        public string SalesInvoicePrefix { get; set; }
        public long? BranchId { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Account CreditNoteAccount { get; set; }
        public virtual AccountDocument CreditNoteDocument { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual Account DebitNoteAccount { get; set; }
        public virtual AccountDocument DebitNoteDocument { get; set; }
        public virtual Account DefaultCashAccount { get; set; }
        public virtual Account DefaultCustomerAccount { get; set; }
        public virtual AccountDocument DefaultJournlDocument { get; set; }
        public virtual Account DefaultSupplierAccount { get; set; }
        public virtual AccountDocument DepreciationDocument { get; set; }
        public virtual AccountGroup EmployeeLoanAccountGroup { get; set; }
        public virtual AccountGroup EmployeeSalaryAccountGroup { get; set; }
        public virtual FinancialPeriod FinancialPeriod { get; set; }
        public virtual Account GainLossAccount { get; set; }
        public virtual Account InputTaxAccount { get; set; }
        public virtual Account LeaveSalaryAccount { get; set; }
        public virtual Account LoanAccount { get; set; }
        public virtual Account OtherDeductionAccount { get; set; }
        public virtual Account OutputTaxAccount { get; set; }
        public virtual AccountDocument PdcpaymentDocument { get; set; }
        public virtual AccountDocument PdcreceiptDocument { get; set; }
        public virtual Account ProjectAccount { get; set; }
        public virtual Account PurchaseAccount { get; set; }
        public virtual Account SalaryAccount { get; set; }
        public virtual Account SalesAccount { get; set; }
        public virtual Account SecurityAccount { get; set; }
        public virtual Account SettlementAccount { get; set; }
        public virtual Account SiteAllowanceAccount { get; set; }
        public virtual SponsorshipCompany SponsorshipCompany { get; set; }
        public virtual AccountGroup SundryCreditorAccountGroup { get; set; }
        public virtual AccountGroup SundryDebtorAccountGroup { get; set; }
        public virtual Account TelephoneAccount { get; set; }
        public virtual Account VehicleFineAccount { get; set; }
    }
}
