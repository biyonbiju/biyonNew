using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class Branch
    {
        public Branch()
        {
            AccountSettings = new HashSet<AccountSettings>();
            AttendanceRegister = new HashSet<AttendanceRegister>();
            BasicDetails = new HashSet<BasicDetails>();
            BranchDocument = new HashSet<BranchDocument>();
            CampAllocation = new HashSet<CampAllocation>();
            CodeGenerator = new HashSet<CodeGenerator>();
            Crmlead = new HashSet<Crmlead>();
            HeadDepartment = new HashSet<HeadDepartment>();
            Notification = new HashSet<Notification>();
            OperationSettings = new HashSet<OperationSettings>();
            Project = new HashSet<Project>();
            CrmquotationTerms = new HashSet<CrmquotationTerms>();
            SponsorshipCompany = new HashSet<SponsorshipCompany>();
            UserSponsorshipCompany = new HashSet<UserSponsorshipCompany>();
            UserTransfer = new HashSet<UserTransfer>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public short? IsDeleted { get; set; }
        public long? OrganisationId { get; set; }
        public string ShortName { get; set; }
        public string CompanyCode { get; set; }
        public string Address { get; set; }
        public long? CountryId { get; set; }
        public long? CurrencyId { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public long? LogoId { get; set; }
        public string StaffCodePrefix { get; set; }
        public string ClientCodePrefix { get; set; }
        public string SupplierCodePrefix { get; set; }

        public string CrmCustomerPrefix { get; set; }

        public string CrmLeadPrefix { get; set; }

        public string ProjectCodePrefix { get; set; }
        public string LabourCodePrefix { get; set; }
        public string SuppliedLabourCodePrefix { get; set; }
        [JsonIgnore]

        public virtual Country Country { get; set; }
        [JsonIgnore]

        public virtual Currency Currency { get; set; }
        public virtual Attachment Logo { get; set; }
        public virtual Organisation Organisation { get; set; }
        public virtual ICollection<AccountSettings> AccountSettings { get; set; }
        [JsonIgnore]

        public virtual ICollection<AttendanceRegister> AttendanceRegister { get; set; }
        [JsonIgnore]

        public virtual ICollection<BasicDetails> BasicDetails { get; set; }
        public virtual ICollection<BranchDocument> BranchDocument { get; set; }
        [JsonIgnore]

        public virtual ICollection<CampAllocation> CampAllocation { get; set; }
        public virtual ICollection<CodeGenerator> CodeGenerator { get; set; }
        [JsonIgnore]
        public virtual ICollection<Crmlead> Crmlead { get; set; }
        public virtual ICollection<HeadDepartment> HeadDepartment { get; set; }
        [JsonIgnore]

        public virtual ICollection<Notification> Notification { get; set; }
        [JsonIgnore]

        public virtual ICollection<OperationSettings> OperationSettings { get; set; }
        [JsonIgnore]

        public virtual ICollection<CrmquotationTerms> CrmquotationTerms { get; set; }
        public virtual ICollection<Project> Project { get; set; }
        public virtual ICollection<SponsorshipCompany> SponsorshipCompany { get; set; }
        public virtual ICollection<UserSponsorshipCompany> UserSponsorshipCompany { get; set; }
        [JsonIgnore]

        public virtual ICollection<UserTransfer> UserTransfer { get; set; }
    }
}
