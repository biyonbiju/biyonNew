using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MPoolBit.CRMService.Models
{
    public class CrmopportunityTerms
    {
        public long Id { get; set; }
        public long? OpportunityId { get; set; }
        public string Terms { get; set; }
        public virtual Crmopportunity Opportunity { get; set; }
    }
}
