using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class CrmleadSource
    {
        public CrmleadSource()
        {
            Crmlead = new HashSet<Crmlead>();
        }

        public long Id { get; set; }
        public string Source { get; set; }
        public short? IsDeleted { get; set; }
        public long? LeadCatogory { get; set; }

        [JsonIgnore]
        public virtual ICollection<Crmlead> Crmlead { get; set; }
    }
}
