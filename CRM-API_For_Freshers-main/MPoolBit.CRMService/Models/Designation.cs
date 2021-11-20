using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class Designation
    {
        public Designation()
        {
            AttendanceRegisterDetails = new HashSet<AttendanceRegisterDetails>();
            ClientInvoiceDesignation = new HashSet<ClientInvoiceDesignation>();
            ClientTimeSheetDesignation = new HashSet<ClientTimeSheetDesignation>();
            ClientTimeSheetEmployee = new HashSet<ClientTimeSheetEmployee>();
            Crmlead = new HashSet<Crmlead>();
            CrmleadDetails = new HashSet<CrmleadDetails>();
            CrmopportunityDetail = new HashSet<CrmopportunityDetail>();
            DemandRequestAllocation = new HashSet<DemandRequestAllocation>();
            DemandRequestTrades = new HashSet<DemandRequestTrades>();
            JobDetails = new HashSet<JobDetails>();
            KnownTrade = new HashSet<KnownTrade>();
            LabourTimeCard = new HashSet<LabourTimeCard>();
            NocEmployeeDetails = new HashSet<NocEmployeeDetails>();
            ProjectDetails = new HashSet<ProjectDetails>();
            ProjectRate = new HashSet<ProjectRate>();
            RateContractTempleteTrades = new HashSet<RateContractTempleteTrades>();
            SupplierInvoiceDetails = new HashSet<SupplierInvoiceDetails>();
            SupplierTimeCard = new HashSet<SupplierTimeCard>();
            UserDetails = new HashSet<UserDetails>();
            UserRate = new HashSet<UserRate>();
            UserRefrence = new HashSet<UserRefrence>();
            CrmleadReference = new HashSet<CrmleadReference>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public short? IsDeleted { get; set; }
        public string ShortName { get; set; }
        public string NameInArabic { get; set; }
        public short? IsLaboursTrade { get; set; }
        public short? IsStaffsTrade { get; set; }
        public short? IsVisasTrade { get; set; }
        public short? IsSales { get; set; }
        public string Cost { get; set; }
        [JsonIgnore]
        public virtual ICollection<AttendanceRegisterDetails> AttendanceRegisterDetails { get; set; }
        [JsonIgnore]

        public virtual ICollection<ClientInvoiceDesignation> ClientInvoiceDesignation { get; set; }
        [JsonIgnore]

        public virtual ICollection<ClientTimeSheetDesignation> ClientTimeSheetDesignation { get; set; }
        [JsonIgnore]

        public virtual ICollection<ClientTimeSheetEmployee> ClientTimeSheetEmployee { get; set; }
        [JsonIgnore]

        public virtual ICollection<Crmlead> Crmlead { get; set; }
        [JsonIgnore]

        public virtual ICollection<CrmleadDetails> CrmleadDetails { get; set; }
        [JsonIgnore]

        public virtual ICollection<CrmopportunityDetail> CrmopportunityDetail { get; set; }
        [JsonIgnore]

        public virtual ICollection<DemandRequestAllocation> DemandRequestAllocation { get; set; }
        [JsonIgnore]

        public virtual ICollection<DemandRequestTrades> DemandRequestTrades { get; set; }
        [JsonIgnore]


        public virtual ICollection<JobDetails> JobDetails { get; set; }
        [JsonIgnore]

        public virtual ICollection<KnownTrade> KnownTrade { get; set; }
        [JsonIgnore]

        public virtual ICollection<LabourTimeCard> LabourTimeCard { get; set; }
        [JsonIgnore]

        public virtual ICollection<NocEmployeeDetails> NocEmployeeDetails { get; set; }
        [JsonIgnore]

        public virtual ICollection<ProjectDetails> ProjectDetails { get; set; }
        [JsonIgnore]

        public virtual ICollection<ProjectRate> ProjectRate { get; set; }
        [JsonIgnore]

        public virtual ICollection<RateContractTempleteTrades> RateContractTempleteTrades { get; set; }
        [JsonIgnore]

        public virtual ICollection<SupplierInvoiceDetails> SupplierInvoiceDetails { get; set; }
        [JsonIgnore]

        public virtual ICollection<SupplierTimeCard> SupplierTimeCard { get; set; }
        [JsonIgnore]

        public virtual ICollection<UserDetails> UserDetails { get; set; }
        [JsonIgnore]

        public virtual ICollection<UserRate> UserRate { get; set; }
        [JsonIgnore]

        public virtual ICollection<UserRefrence> UserRefrence { get; set; }
        public virtual ICollection<CrmleadReference> CrmleadReference { get; set; }
    }
}
