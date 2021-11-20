using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MPoolBit.CRMService.Models
{
    public partial class CrmleadComments
    {
        public CrmleadComments()
        {
            BasicDetails = new HashSet<BasicDetails>();
            Crmlead = new HashSet<Crmlead>();
        }

        public long Id { get; set; }
        public string Comment { get; set; }
        public short? IsDeleted { get; set; }
        [JsonIgnore]

        public virtual ICollection<BasicDetails> BasicDetails { get; set; }
        public virtual ICollection<Crmlead> Crmlead { get; set; }
        public virtual ICollection<LeadComments> LeadComments { get; set; }
    }
}
