using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MPoolBit.CRMService.Models
{
    public partial class CrmleadStatus
    {
        public CrmleadStatus()
        {
            Crmlead = new HashSet<Crmlead>();
            Crmopportunity = new HashSet<Crmopportunity>();
            Crmtask = new HashSet<Crmtask>();
            CrmtaskDetail = new HashSet<CrmtaskDetail>();
        }

        public long Id { get; set; }
        public string Status { get; set; }
        public string CrmType { get; set; }
        public short? IsDeleted { get; set; }
        [JsonIgnore]

        public virtual ICollection<Crmlead> Crmlead { get; set; }
        [JsonIgnore]

        public virtual ICollection<Crmopportunity> Crmopportunity { get; set; }

        [JsonIgnore]

        public virtual ICollection<Crmtask> Crmtask { get; set; }

        [JsonIgnore]

        public virtual ICollection<CrmtaskDetail> CrmtaskDetail { get; set; }
    }
}
