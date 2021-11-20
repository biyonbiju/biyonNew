using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class User
    {
        public User()
        {

            AccountInvoice = new HashSet<AccountInvoice>();
            AccountNote = new HashSet<AccountNote>();
            CrmopportunityAccount = new HashSet<Crmopportunity>();
            CrmopportunityOwner = new HashSet<Crmopportunity>();
            AccountPaymentReceiptApprovedBy = new HashSet<AccountPaymentReceipt>();
            AccountPaymentReceiptCheckedBy = new HashSet<AccountPaymentReceipt>();
            AccountPaymentReceiptPreparedBy = new HashSet<AccountPaymentReceipt>();
            AccountPaymentReceiptUser = new HashSet<AccountPaymentReceipt>();
            AccountUserInvoiceApprovedBy = new HashSet<AccountUserInvoice>();
            AccountUserInvoiceCheckedBy = new HashSet<AccountUserInvoice>();
            AccountUserInvoicePreparedBy = new HashSet<AccountUserInvoice>();
            AccountUserInvoiceUser = new HashSet<AccountUserInvoice>();
            ActivityLog = new HashSet<ActivityLog>();
            AttendanceRegisterDetails = new HashSet<AttendanceRegisterDetails>();
            BasicDetails = new HashSet<BasicDetails>();
            BasicDetailsSalesExecutive = new HashSet<BasicDetails>();
            CampAllocation = new HashSet<CampAllocation>();
            ClientTimeSheetApprovedBy = new HashSet<ClientTimeSheet>();
            ClientTimeSheetCheckedBy = new HashSet<ClientTimeSheet>();
            ClientTimeSheetClient = new HashSet<ClientTimeSheet>();
            ClientTimeSheetEmployee = new HashSet<ClientTimeSheetEmployee>();
            ClientTimeSheetPreparedBy = new HashSet<ClientTimeSheet>();
            ContractSalaryDetails = new HashSet<ContractSalaryDetails>();
            CrmleadAssignedSalesExecutive = new HashSet<Crmlead>();
            CrmleadClient = new HashSet<Crmlead>();


            CrmtaskClient = new HashSet<Crmtask>();
            CrmtaskTaskOwner = new HashSet<Crmtask>();
            CrmtaskTaskAssignedByNavigation = new HashSet<Crmtask>();
            CrmtaskTaskAssignedToNavigation = new HashSet<Crmtask>();
            DemandRequestAllocation = new HashSet<DemandRequestAllocation>();
            DemandRequestClient = new HashSet<DemandRequest>();
            DemandRequestRequestedBy = new HashSet<DemandRequest>();
            HeadDepartment = new HashSet<HeadDepartment>();
            JobDetailsLineManager = new HashSet<JobDetails>();
            JobDetailsUser = new HashSet<JobDetails>();
            KnownTrade = new HashSet<KnownTrade>();
            LabourTimeCard = new HashSet<LabourTimeCard>();
            LabourTimeCardHeader = new HashSet<LabourTimeCardHeader>();
            MedicalDetails = new HashSet<MedicalDetails>();
            NocDetailsAssistance = new HashSet<NocDetails>();
            NocDetailsClient = new HashSet<NocDetails>();
            NocDetailsRegards = new HashSet<NocDetails>();
            NocEmployeeDetailsDeMobilizeRequest = new HashSet<NocEmployeeDetails>();
            NocEmployeeDetailsEmployee = new HashSet<NocEmployeeDetails>();
            PermissionCreatedByNavigation = new HashSet<Permission>();
            PermissionUser = new HashSet<Permission>();
            ProjectClient = new HashSet<Project>();
            ProjectDetails = new HashSet<ProjectDetails>();
            ProjectEngineer = new HashSet<Project>();
            ProjectSalesExecutive = new HashSet<Project>();
            SalaryDetails = new HashSet<SalaryDetails>();
            StaffSalary = new HashSet<StaffSalary>();
            SupplierInvoiceDetails = new HashSet<SupplierInvoiceDetails>();
            SupplierTimeCard = new HashSet<SupplierTimeCard>();
            SupplierTimeCardHeaderEmployee = new HashSet<SupplierTimeCardHeader>();
            SupplierTimeCardHeaderSupplier = new HashSet<SupplierTimeCardHeader>();
            UserDocument = new HashSet<UserDocument>();
            UserHistory = new HashSet<UserHistory>();
            UserRate = new HashSet<UserRate>();
            UserRefrence = new HashSet<UserRefrence>();
            UserSponsorshipCompany = new HashSet<UserSponsorshipCompany>();
            UserTransfer = new HashSet<UserTransfer>();
            CrmcustomerSalesExecutiveHistoryCustomer = new HashSet<CrmcustomerSalesExecutiveHistory>();
            CrmcustomerSalesExecutiveHistorySalesExecutive = new HashSet<CrmcustomerSalesExecutiveHistory>();
            CustomerEvaluation = new HashSet<CustomerEvaluation>();


        }

        public long Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public short IsActive { get; set; }
        public long? UserRoleId { get; set; }
        public long? BasicDetailId { get; set; }
        public long? UserDetailsId { get; set; }
        public short? IsDeleted { get; set; }
        public long? UserRoleRuleId { get; set; }
        //public short? IsFound { get; set; }

        public virtual BasicDetails BasicDetail { get; set; }
        public virtual UserDetails UserDetails { get; set; }
        public virtual UserRole UserRole { get; set; }
        public virtual UserRoleRules UserRoleRule { get; set; }
        public virtual ICollection<AccountInvoice> AccountInvoice { get; set; }
        public virtual ICollection<AccountNote> AccountNote { get; set; }
        public virtual ICollection<AccountPaymentReceipt> AccountPaymentReceiptApprovedBy { get; set; }
        public virtual ICollection<AccountPaymentReceipt> AccountPaymentReceiptCheckedBy { get; set; }
        public virtual ICollection<AccountPaymentReceipt> AccountPaymentReceiptPreparedBy { get; set; }
        public virtual ICollection<AccountPaymentReceipt> AccountPaymentReceiptUser { get; set; }
        public virtual ICollection<AccountUserInvoice> AccountUserInvoiceApprovedBy { get; set; }
        public virtual ICollection<AccountUserInvoice> AccountUserInvoiceCheckedBy { get; set; }
        public virtual ICollection<AccountUserInvoice> AccountUserInvoicePreparedBy { get; set; }
        public virtual ICollection<AccountUserInvoice> AccountUserInvoiceUser { get; set; }
        public virtual ICollection<ActivityLog> ActivityLog { get; set; }
        public virtual ICollection<AttendanceRegisterDetails> AttendanceRegisterDetails { get; set; }
        public virtual ICollection<BasicDetails> BasicDetails { get; set; }
        public virtual ICollection<CampAllocation> CampAllocation { get; set; }
        public virtual ICollection<ClientTimeSheet> ClientTimeSheetApprovedBy { get; set; }
        public virtual ICollection<ClientTimeSheet> ClientTimeSheetCheckedBy { get; set; }
        public virtual ICollection<ClientTimeSheet> ClientTimeSheetClient { get; set; }
        public virtual ICollection<ClientTimeSheetEmployee> ClientTimeSheetEmployee { get; set; }
        public virtual ICollection<ClientTimeSheet> ClientTimeSheetPreparedBy { get; set; }
        public virtual ICollection<ContractSalaryDetails> ContractSalaryDetails { get; set; }
        public virtual SisterConcernCompanies SisterConcernCompanies { get; set; }
        [JsonIgnore]
        public virtual ICollection<Crmlead> CrmleadAssignedSalesExecutive { get; set; }
        [JsonIgnore]
        public virtual ICollection<Crmlead> CrmleadClient { get; set; }



        [JsonIgnore]
        public virtual ICollection<Crmtask> CrmtaskClient { get; set; }
        [JsonIgnore]
        public virtual ICollection<Crmtask> CrmtaskTaskOwner { get; set; }
        [JsonIgnore]

        public virtual ICollection<Crmtask> CrmtaskTaskAssignedByNavigation { get; set; }
        [JsonIgnore]

        public virtual ICollection<Crmtask> CrmtaskTaskAssignedToNavigation { get; set; }
        public virtual ICollection<DemandRequestAllocation> DemandRequestAllocation { get; set; }
        public virtual ICollection<DemandRequest> DemandRequestClient { get; set; }
        public virtual ICollection<DemandRequest> DemandRequestRequestedBy { get; set; }
        public virtual ICollection<HeadDepartment> HeadDepartment { get; set; }
        public virtual ICollection<JobDetails> JobDetailsLineManager { get; set; }
        public virtual ICollection<JobDetails> JobDetailsUser { get; set; }
        public virtual ICollection<KnownTrade> KnownTrade { get; set; }
        public virtual ICollection<LabourTimeCard> LabourTimeCard { get; set; }
        public virtual ICollection<LabourTimeCardHeader> LabourTimeCardHeader { get; set; }
        public virtual ICollection<MedicalDetails> MedicalDetails { get; set; }
        public virtual ICollection<NocDetails> NocDetailsAssistance { get; set; }
        public virtual ICollection<NocDetails> NocDetailsClient { get; set; }
        public virtual ICollection<NocDetails> NocDetailsRegards { get; set; }
        public virtual ICollection<NocEmployeeDetails> NocEmployeeDetailsDeMobilizeRequest { get; set; }
        public virtual ICollection<NocEmployeeDetails> NocEmployeeDetailsEmployee { get; set; }
        public virtual ICollection<Permission> PermissionCreatedByNavigation { get; set; }
        public virtual ICollection<Permission> PermissionUser { get; set; }
        public virtual ICollection<Project> ProjectClient { get; set; }
        public virtual ICollection<ProjectDetails> ProjectDetails { get; set; }
        public virtual ICollection<Project> ProjectEngineer { get; set; }
        public virtual ICollection<Project> ProjectSalesExecutive { get; set; }
        public virtual ICollection<SalaryDetails> SalaryDetails { get; set; }
        public virtual ICollection<StaffSalary> StaffSalary { get; set; }
        public virtual ICollection<SupplierInvoiceDetails> SupplierInvoiceDetails { get; set; }
        public virtual ICollection<SupplierTimeCard> SupplierTimeCard { get; set; }
        public virtual ICollection<SupplierTimeCardHeader> SupplierTimeCardHeaderEmployee { get; set; }
        public virtual ICollection<SupplierTimeCardHeader> SupplierTimeCardHeaderSupplier { get; set; }
        public virtual ICollection<UserDocument> UserDocument { get; set; }
        public virtual ICollection<UserHistory> UserHistory { get; set; }
        public virtual ICollection<UserRate> UserRate { get; set; }
        public virtual ICollection<UserRefrence> UserRefrence { get; set; }
        public virtual ICollection<UserSponsorshipCompany> UserSponsorshipCompany { get; set; }
        public virtual ICollection<UserTransfer> UserTransfer { get; set; }
        [JsonIgnore]

        public virtual ICollection<Crmopportunity> CrmopportunityAccount { get; set; }
        [JsonIgnore]

        public virtual ICollection<Crmopportunity> CrmopportunityOwner { get; set; }
        [JsonIgnore]
        public virtual ICollection<BasicDetails> BasicDetailsSalesExecutive { get; set; }

        public virtual ICollection<CrmcustomerSalesExecutiveHistory> CrmcustomerSalesExecutiveHistoryCustomer { get; set; }
        public virtual ICollection<CrmcustomerSalesExecutiveHistory> CrmcustomerSalesExecutiveHistorySalesExecutive { get; set; }
        public virtual ICollection<CustomerEvaluation> CustomerEvaluation { get; set; }

    }
}
