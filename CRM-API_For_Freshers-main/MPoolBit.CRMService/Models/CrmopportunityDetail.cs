using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MPoolBit.CRMService.Models
{
    public partial class CrmopportunityDetail
    {
        public long Id { get; set; }
        public long? OpportunityId { get; set; }
        public long? TradeId { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Rate { get; set; }
        public short? IsDeleted { get; set; }
        public long? LeadDetailId { get; set; }
        [JsonIgnore]
        public virtual CrmleadDetails LeadDetail { get; set; }
        [JsonIgnore]
        public virtual Crmopportunity Opportunity { get; set; }
        public virtual Designation Trade { get; set; }
    }
}
