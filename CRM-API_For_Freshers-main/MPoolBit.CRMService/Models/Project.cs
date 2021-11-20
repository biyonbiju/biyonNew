using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class Project
    {
        public Project()
        {
            AccountJournalBookDetail = new HashSet<AccountJournalBookDetail>();
            AttendanceRegister = new HashSet<AttendanceRegister>();
            ClientInvoiceProject = new HashSet<ClientInvoiceProject>();
            ClientTimeSheetEmployee = new HashSet<ClientTimeSheetEmployee>();
            ClientTimeSheetProject = new HashSet<ClientTimeSheetProject>();
            DemandRequest = new HashSet<DemandRequest>();
            LabourTimeCard = new HashSet<LabourTimeCard>();
            NocDetails = new HashSet<NocDetails>();
            ProjectDocument = new HashSet<ProjectDocument>();
            ProjectHolidayDetails = new HashSet<ProjectHolidayDetails>();
            ProjectLocation = new HashSet<ProjectLocation>();
            ProjectRate = new HashSet<ProjectRate>();
            SupplierInvoiceDetails = new HashSet<SupplierInvoiceDetails>();
            SupplierTimeCard = new HashSet<SupplierTimeCard>();
        }

        public long Id { get; set; }
        public string ProjectName { get; set; }
        public string ProjectNumber { get; set; }
        public long? ProjectTypeId { get; set; }
        public string ClientProjectNo { get; set; }
        public string ContractName { get; set; }
        public long? PaymentTypeId { get; set; }
        public long? ClientId { get; set; }
        public string Lpono { get; set; }
        public short? IsMiview { get; set; }
        public long? SponsorshipCompanyId { get; set; }
        public long? SalesExecutiveId { get; set; }
        public DateTime? StartDate { get; set; }
        public long? EngineerId { get; set; }
        public string ContactNumber { get; set; }
        public short? IsDeleted { get; set; }
        public long? ProjectDetailsId { get; set; }
        public DateTime? EndDate { get; set; }
        public string ReferenceNumber { get; set; }
        public long? BranchId { get; set; }
        public short? IsTransfer { get; set; }
        public long? TransferSponsorshipCompanyId { get; set; }
        public string EngineerName { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual User Client { get; set; }
        public virtual User Engineer { get; set; }
        public virtual PaymentSchedule PaymentType { get; set; }
        public virtual ProjectDetails ProjectDetails { get; set; }
        public virtual ProjectType ProjectType { get; set; }
        public virtual User SalesExecutive { get; set; }
        public virtual SponsorshipCompany SponsorshipCompany { get; set; }
        public virtual SponsorshipCompany TransferSponsorshipCompany { get; set; }
        public virtual ICollection<AccountJournalBookDetail> AccountJournalBookDetail { get; set; }
        public virtual ICollection<AttendanceRegister> AttendanceRegister { get; set; }
        public virtual ICollection<ClientInvoiceProject> ClientInvoiceProject { get; set; }
        public virtual ICollection<ClientTimeSheetEmployee> ClientTimeSheetEmployee { get; set; }
        public virtual ICollection<ClientTimeSheetProject> ClientTimeSheetProject { get; set; }
        public virtual ICollection<DemandRequest> DemandRequest { get; set; }
        public virtual ICollection<LabourTimeCard> LabourTimeCard { get; set; }
        public virtual ICollection<NocDetails> NocDetails { get; set; }
        public virtual ICollection<ProjectDocument> ProjectDocument { get; set; }
        public virtual ICollection<ProjectHolidayDetails> ProjectHolidayDetails { get; set; }
        public virtual ICollection<ProjectLocation> ProjectLocation { get; set; }
        public virtual ICollection<ProjectRate> ProjectRate { get; set; }
        public virtual ICollection<SupplierInvoiceDetails> SupplierInvoiceDetails { get; set; }
        public virtual ICollection<SupplierTimeCard> SupplierTimeCard { get; set; }
    }
}
