using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class Crmopportunity
    {
        public Crmopportunity()
        {
        
            CrmopportunityDetail = new HashSet<CrmopportunityDetail>();
            CrmopportunityTerms = new HashSet<CrmopportunityTerms>();

        }
        public long Id { get; set; }
        public long? LeadId { get; set; }
        public short? IsDeleted { get; set; }
        public DateTime? Date { get; set; }
        public long? AccountId { get; set; }
        public long? StatusId { get; set; }
        public string Comments { get; set; }
        public string Contact { get; set; }
        public string OpportunityNumber { get; set; }
        public string OpportunityName { get; set; }

        public long? OwnerId { get; set; }
        public long? BranchId { get; set; }
        public long? SponsorShipCompanyId { get; set; }
        public virtual User Account { get; set; }

        public virtual Crmlead Lead { get; set; }

        public virtual CrmleadStatus Status { get; set; }
        public virtual SponsorshipCompany SponsorShipCompany { get; set; }
        public virtual User Owner { get; set; }
        public virtual ICollection<CrmopportunityDetail> CrmopportunityDetail { get; set; }
        public virtual ICollection<CrmopportunityTerms> CrmopportunityTerms { get; set; }
    }
}
