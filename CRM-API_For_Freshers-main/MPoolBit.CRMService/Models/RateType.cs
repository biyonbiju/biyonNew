using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class RateType
    {
        public RateType()
        {
            ProjectRate = new HashSet<ProjectRate>();
            RateContractTempleteTrades = new HashSet<RateContractTempleteTrades>();
            UserRate = new HashSet<UserRate>();
            crmFAT = new HashSet<CrmleadDetails>();

        }

        public long Id { get; set; }
        public short? IsDeleted { get; set; }
        public string Type { get; set; }

        public virtual ICollection<ProjectRate> ProjectRate { get; set; }
        public virtual ICollection<RateContractTempleteTrades> RateContractTempleteTrades { get; set; }
        public virtual ICollection<UserRate> UserRate { get; set; }
        public virtual ICollection<CrmleadDetails> crmFAT { get; set; }
    }
}
