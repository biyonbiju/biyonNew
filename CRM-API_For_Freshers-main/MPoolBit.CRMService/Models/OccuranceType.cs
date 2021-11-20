using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class OccuranceType
    {
        public OccuranceType()
        {
            ProjectRate = new HashSet<ProjectRate>();
            RateContractTempleteTrades = new HashSet<RateContractTempleteTrades>();
            UserRate = new HashSet<UserRate>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public short? IsDeleted { get; set; }

        public virtual ICollection<ProjectRate> ProjectRate { get; set; }
        public virtual ICollection<RateContractTempleteTrades> RateContractTempleteTrades { get; set; }
        public virtual ICollection<UserRate> UserRate { get; set; }
    }
}
