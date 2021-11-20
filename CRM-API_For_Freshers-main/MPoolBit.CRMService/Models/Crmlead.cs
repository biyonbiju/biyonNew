using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class Crmlead
    {
        public Crmlead()
        {
            CrmleadDetails = new HashSet<CrmleadDetails>();
            CrmleadDetails = new HashSet<CrmleadDetails>();
            Crmopportunity = new HashSet<Crmopportunity>();
            Crmtask = new HashSet<Crmtask>();
            CrmleadReference = new HashSet<CrmleadReference>();
            CrmleadDocuments = new HashSet<CrmleadDocuments>();
        }

        public long Id { get; set; }
        public long? SourceId { get; set; }
        public long? CompanyTypeId { get; set; }
        public long? AssignedSalesExecutiveId { get; set; }
        public DateTime? Date { get; set; }
        public short? IsDeleted { get; set; }
        public string CompanyName { get; set; }
        public long? CompanyPhotoId { get; set; }
        public long? CompanyLocationId { get; set; }
        public string ContactPerson { get; set; }
        public string ContactNumber { get; set; }
        public string WebSite { get; set; }
        public string ProjectName { get; set; }
        public long? EmiratesId { get; set; }
        public long? DesignationId { get; set; }
        public string Email { get; set; }
        public string TelNo { get; set; }
        public long? ProjectLocationId { get; set; }
        public long? BranchId { get; set; }
        public long? SponsorShipCompanyId { get; set; }
        public long? LeadStatusId { get; set; }
        public long? LeadStatusCommentId { get; set; }
        public long? OfficePhotoId { get; set; }
        public long? ClientId { get; set; }
        public long? ProjectPhotoId { get; set; }
        public string LeadNo { get; set; }
        public short? IsClient { get; set; }
        public string Pbno { get; set; }
        public short? IsFatown { get; set; }
        public long? PhotoId { get; set; }
        public long? WorkCategoryId { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public short? IsActive { get; set; }
        public long? ProjectSitePhotoId { get; set; }
        public long? ModeOfCompletionId { get; set; }
        public virtual User AssignedSalesExecutive { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual User Client { get; set; }
        public virtual Location CompanyLocation { get; set; }
        public virtual Attachment CompanyPhoto { get; set; }
        public virtual CrmcompanyType CompanyType { get; set; }
        public virtual Designation Designation { get; set; }
        public virtual Emirate Emirates { get; set; }
        public virtual CrmleadStatus LeadStatus { get; set; }
        public virtual CrmleadComments LeadStatusComment { get; set; }
        public virtual Attachment OfficePhoto { get; set; }
        public virtual Attachment ProjectSitePhoto { get; set; }
        public virtual Location ProjectLocation { get; set; }
        public virtual Attachment ProjectPhoto { get; set; }
        public virtual CrmleadSource Source { get; set; }
        public virtual SponsorshipCompany SponsorShipCompany { get; set; }
        public virtual ICollection<CrmleadDetails> CrmleadDetails { get; set; }
        public virtual ICollection<Crmopportunity> Crmopportunity { get; set; }
        public virtual ICollection<LeadComments> LeadComments { get; set; }
        [JsonIgnore]
        public virtual ICollection<Crmtask> Crmtask { get; set; }
        public virtual ICollection<CrmleadReference> CrmleadReference { get; set; }
        public virtual Attachment Photo { get; set; }
        public virtual WorkCategory WorkCategory { get; set; }
        public virtual ICollection<CrmleadDocuments> CrmleadDocuments { get; set; }
    }
}
