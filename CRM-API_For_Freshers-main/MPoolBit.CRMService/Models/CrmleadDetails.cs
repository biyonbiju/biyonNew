using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MPoolBit.CRMService.Models
{
    public partial class CrmleadDetails
    {
        public CrmleadDetails()
        {
            CrmopportunityDetail = new HashSet<CrmopportunityDetail>();
        }

        public long Id { get; set; }
        public string Pbno { get; set; }
        public short? IsFatown { get; set; }
        public short? IsClient { get; set; }
        public long? TradeId { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Rate { get; set; }
        public long? LeadId { get; set; }
        public long? FATId { get; set; }
        public short? IsDeleted { get; set; }
        public long? TypeId { get; set; }

        [JsonIgnore]
        public virtual Crmlead Lead { get; set; }
        public virtual Designation Trade { get; set; }
        public virtual RateType FAT { get; set; }
        [JsonIgnore]
        public virtual ICollection<CrmopportunityDetail> CrmopportunityDetail { get; set; }

    }
}
