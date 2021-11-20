using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPoolBit.CRMService.Models
{
    public partial class Crmtask
    {
        public Crmtask()
        {
            CrmtaskDetail = new HashSet<CrmtaskDetail>();
            CrmtaskDocument = new HashSet<CrmtaskDocument>();
        }

        public long Id { get; set; }
        public long? LeadId { get; set; }
        public long? ClientId { get; set; }
        public long? TaskTypeId { get; set; }
        public long? TaskOwnerId { get; set; }
        public long? PurposeId { get; set; }
        public long? PriorityId { get; set; }
        public short? IsDeleted { get; set; }
        public long? TaskAssignedTo { get; set; }
        public long? TaskAssignedBy { get; set; }
        public DateTime? TaskCreatedDate { get; set; }
        public DateTime? TaskCompletedDate { get; set; }
        public DateTime? DueDate { get; set; }

        public long? BranchId { get; set; }
        public long? SponsorShipCompanyId { get; set; }
        public long? StatusId { get; set; }
        public long? ProjectId { get; set; }
        public long? OpportunityId { get; set; }

        public int? TaskOnId { get; set; }

        public string CaseId { get; set; }
        public virtual User Client { get; set; }
        public virtual Crmlead Lead { get; set; }
        public virtual Crmpriority Priority { get; set; }
        public virtual Crmpurpose Purpose { get; set; }
        public virtual User TaskOwner { get; set; }
        public virtual User TaskAssignedByNavigation { get; set; }
        public virtual User TaskAssignedToNavigation { get; set; }
        public virtual CrmtaskType TaskType { get; set; }
        public virtual ICollection<CrmtaskDetail> CrmtaskDetail { get; set; }
        public virtual ICollection<CrmtaskDocument> CrmtaskDocument { get; set; }

        public virtual CrmleadStatus Status { get; set; }
        public  Crmopportunity Opportunity { get; set; }

        public Project Project { get; set; }

    }
}
