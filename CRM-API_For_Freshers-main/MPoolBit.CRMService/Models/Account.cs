using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class Account
    {
        public Account()
        {
            AccountDocument = new HashSet<AccountDocument>();
            AccountJournalBookDetail = new HashSet<AccountJournalBookDetail>();
            AccountJournalDetails = new HashSet<AccountJournalDetails>();
            AccountNoteAccount = new HashSet<AccountNoteAccount>();
            AccountOpeningBalanceDetails = new HashSet<AccountOpeningBalanceDetails>();
            AccountPaymentReceiptAccount = new HashSet<AccountPaymentReceiptAccount>();
            AccountSettingsCreditNoteAccount = new HashSet<AccountSettings>();
            AccountSettingsDebitNoteAccount = new HashSet<AccountSettings>();
            AccountSettingsDefaultCashAccount = new HashSet<AccountSettings>();
            AccountSettingsDefaultCustomerAccount = new HashSet<AccountSettings>();
            AccountSettingsDefaultSupplierAccount = new HashSet<AccountSettings>();
            AccountSettingsGainLossAccount = new HashSet<AccountSettings>();
            AccountSettingsInputTaxAccount = new HashSet<AccountSettings>();
            AccountSettingsLeaveSalaryAccount = new HashSet<AccountSettings>();
            AccountSettingsLoanAccount = new HashSet<AccountSettings>();
            AccountSettingsOtherDeductionAccount = new HashSet<AccountSettings>();
            AccountSettingsOutputTaxAccount = new HashSet<AccountSettings>();
            AccountSettingsProjectAccount = new HashSet<AccountSettings>();
            AccountSettingsPurchaseAccount = new HashSet<AccountSettings>();
            AccountSettingsSalaryAccount = new HashSet<AccountSettings>();
            AccountSettingsSalesAccount = new HashSet<AccountSettings>();
            AccountSettingsSecurityAccount = new HashSet<AccountSettings>();
            AccountSettingsSettlementAccount = new HashSet<AccountSettings>();
            AccountSettingsSiteAllowanceAccount = new HashSet<AccountSettings>();
            AccountSettingsTelephoneAccount = new HashSet<AccountSettings>();
            AccountSettingsVehicleFineAccount = new HashSet<AccountSettings>();
            BasicDetailsAccount = new HashSet<BasicDetails>();
            BasicDetailsAdvanceAccount = new HashSet<BasicDetails>();
            //Crmopportunity = new HashSet<Crmopportunity>();
        }

        public long Id { get; set; }
        public string AccountName { get; set; }
        public string ShortName { get; set; }
        public long? AccountGroupId { get; set; }
        public short? IsBlocked { get; set; }
        public decimal? TotalAmount { get; set; }
        public long? CostCategoryId { get; set; }
        public string CodeNo { get; set; }
        public short? IsDeleted { get; set; }
        public long? SponsorshipCompanyId { get; set; }

        public virtual AccountGroup AccountGroup { get; set; }
        public virtual CostCategory CostCategory { get; set; }
        public virtual SponsorshipCompany SponsorshipCompany { get; set; }
        public virtual ICollection<AccountDocument> AccountDocument { get; set; }
        public virtual ICollection<AccountJournalBookDetail> AccountJournalBookDetail { get; set; }
        public virtual ICollection<AccountJournalDetails> AccountJournalDetails { get; set; }
        public virtual ICollection<AccountNoteAccount> AccountNoteAccount { get; set; }
        public virtual ICollection<AccountOpeningBalanceDetails> AccountOpeningBalanceDetails { get; set; }
        public virtual ICollection<AccountPaymentReceiptAccount> AccountPaymentReceiptAccount { get; set; }
        public virtual ICollection<AccountSettings> AccountSettingsCreditNoteAccount { get; set; }
        public virtual ICollection<AccountSettings> AccountSettingsDebitNoteAccount { get; set; }
        public virtual ICollection<AccountSettings> AccountSettingsDefaultCashAccount { get; set; }
        public virtual ICollection<AccountSettings> AccountSettingsDefaultCustomerAccount { get; set; }
        public virtual ICollection<AccountSettings> AccountSettingsDefaultSupplierAccount { get; set; }
        public virtual ICollection<AccountSettings> AccountSettingsGainLossAccount { get; set; }
        public virtual ICollection<AccountSettings> AccountSettingsInputTaxAccount { get; set; }
        public virtual ICollection<AccountSettings> AccountSettingsLeaveSalaryAccount { get; set; }
        public virtual ICollection<AccountSettings> AccountSettingsLoanAccount { get; set; }
        public virtual ICollection<AccountSettings> AccountSettingsOtherDeductionAccount { get; set; }
        public virtual ICollection<AccountSettings> AccountSettingsOutputTaxAccount { get; set; }
        public virtual ICollection<AccountSettings> AccountSettingsProjectAccount { get; set; }
        public virtual ICollection<AccountSettings> AccountSettingsPurchaseAccount { get; set; }
        public virtual ICollection<AccountSettings> AccountSettingsSalaryAccount { get; set; }
        public virtual ICollection<AccountSettings> AccountSettingsSalesAccount { get; set; }
        public virtual ICollection<AccountSettings> AccountSettingsSecurityAccount { get; set; }
        public virtual ICollection<AccountSettings> AccountSettingsSettlementAccount { get; set; }
        public virtual ICollection<AccountSettings> AccountSettingsSiteAllowanceAccount { get; set; }
        public virtual ICollection<AccountSettings> AccountSettingsTelephoneAccount { get; set; }
        public virtual ICollection<AccountSettings> AccountSettingsVehicleFineAccount { get; set; }
        public virtual ICollection<BasicDetails> BasicDetailsAccount { get; set; }
        public virtual ICollection<BasicDetails> BasicDetailsAdvanceAccount { get; set; }
        //public virtual ICollection<Crmopportunity> Crmopportunity { get; set; }
    }
}
