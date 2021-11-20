using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class SponsorshipCompany
    {
        public SponsorshipCompany()
        {
            Account = new HashSet<Account>();
            AccountDocument = new HashSet<AccountDocument>();
            AccountGroup = new HashSet<AccountGroup>();
            AccountGroupCode = new HashSet<AccountGroupCode>();
            AccountInvoice = new HashSet<AccountInvoice>();
            AccountJournal = new HashSet<AccountJournal>();
            AccountJournalBook = new HashSet<AccountJournalBook>();
            AccountNote = new HashSet<AccountNote>();
            AccountOpeningBalance = new HashSet<AccountOpeningBalance>();
            AccountPaymentReceipt = new HashSet<AccountPaymentReceipt>();
            AccountSettings = new HashSet<AccountSettings>();
            AccountUserInvoice = new HashSet<AccountUserInvoice>();
            AttendanceRegister = new HashSet<AttendanceRegister>();
            BasicDetails = new HashSet<BasicDetails>();
            ClientTimeSheet = new HashSet<ClientTimeSheet>();
            CostCategory = new HashSet<CostCategory>();
            Crmlead = new HashSet<Crmlead>();
            DemandRequest = new HashSet<DemandRequest>();
            NocDetails = new HashSet<NocDetails>();
            NocEmployeeDetails = new HashSet<NocEmployeeDetails>();
            ProjectSponsorshipCompany = new HashSet<Project>();
            ProjectTransferSponsorshipCompany = new HashSet<Project>();
            SponsorshipCompanyDocument = new HashSet<SponsorshipCompanyDocument>();
            StaffSalaryHeader = new HashSet<StaffSalaryHeader>();
            UserDocument = new HashSet<UserDocument>();
            UserSponsorshipCompany = new HashSet<UserSponsorshipCompany>();
            crmOpportunitySponsorshipCompany = new HashSet<Crmopportunity>();

        }

        public long Id { get; set; }
        public string Name { get; set; }
        public short? IsDeleted { get; set; }
        public long? BranchId { get; set; }
        public string Address { get; set; }
        public string StaffCodePrefix { get; set; }
        public string ClientCodePrefix { get; set; }
        public string SupplierCodePrefix { get; set; }
        public long? CountyId { get; set; }
        public long? ReportHeaderId { get; set; }
        public long? ReportFooterId { get; set; }
        public string ProjectCodePrefix { get; set; }
        public string LabourCodePrefix { get; set; }
        public string SuppliedLabourCodePrefix { get; set; }
        public string ShortName { get; set; }
        public string NameInArabic { get; set; }
        public long? CountryId { get; set; }
        public long? CurrencyId { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Trn { get; set; }
        public string PhoneNo { get; set; }
        public string Fax { get; set; }
        public long? LogoId { get; set; }
        public long? StampId { get; set; }
        public string Place { get; set; }
        public string Pobox { get; set; }
        public string Remark { get; set; }
        public string Molid { get; set; }
        public long? WaterMarkId { get; set; }
        public long? CrmcealId { get; set; }


        public virtual Branch Branch { get; set; }
        public virtual Country County { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual Attachment Logo { get; set; }
        public virtual Attachment ReportFooter { get; set; }
        public virtual Attachment ReportHeader { get; set; }
        public virtual Attachment Crmceal { get; set; }
        public virtual Attachment Stamp { get; set; }
        public virtual Attachment WaterMark { get; set; }
        public virtual ICollection<Account> Account { get; set; }
        public virtual ICollection<AccountDocument> AccountDocument { get; set; }
        public virtual ICollection<AccountGroup> AccountGroup { get; set; }
        public virtual ICollection<AccountGroupCode> AccountGroupCode { get; set; }
        public virtual ICollection<AccountInvoice> AccountInvoice { get; set; }
        public virtual ICollection<AccountJournal> AccountJournal { get; set; }
        public virtual ICollection<AccountJournalBook> AccountJournalBook { get; set; }
        public virtual ICollection<AccountNote> AccountNote { get; set; }
        public virtual ICollection<AccountOpeningBalance> AccountOpeningBalance { get; set; }
        public virtual ICollection<AccountPaymentReceipt> AccountPaymentReceipt { get; set; }
        public virtual ICollection<AccountSettings> AccountSettings { get; set; }
        public virtual ICollection<AccountUserInvoice> AccountUserInvoice { get; set; }
        public virtual ICollection<AttendanceRegister> AttendanceRegister { get; set; }
        public virtual ICollection<BasicDetails> BasicDetails { get; set; }
        public virtual ICollection<ClientTimeSheet> ClientTimeSheet { get; set; }
        public virtual ICollection<CostCategory> CostCategory { get; set; }
        [JsonIgnore]
        public virtual ICollection<Crmlead> Crmlead { get; set; }
        public virtual ICollection<DemandRequest> DemandRequest { get; set; }
        public virtual ICollection<NocDetails> NocDetails { get; set; }
        public virtual ICollection<NocEmployeeDetails> NocEmployeeDetails { get; set; }
        public virtual ICollection<Project> ProjectSponsorshipCompany { get; set; }
        public virtual ICollection<Project> ProjectTransferSponsorshipCompany { get; set; }
        public virtual ICollection<SponsorshipCompanyDocument> SponsorshipCompanyDocument { get; set; }
        public virtual ICollection<StaffSalaryHeader> StaffSalaryHeader { get; set; }
        public virtual ICollection<UserDocument> UserDocument { get; set; }
        public virtual ICollection<UserSponsorshipCompany> UserSponsorshipCompany { get; set; }
        public virtual ICollection<Crmopportunity> crmOpportunitySponsorshipCompany { get; set; }

    }
}
