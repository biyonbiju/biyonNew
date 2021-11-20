using Newtonsoft.Json;
using System;
using System.Collections.Generic;


namespace MPoolBit.CRMService.Models
{
    public partial class CrmcompanyType
    {
        public CrmcompanyType()
        {
            Crmlead = new HashSet<Crmlead>();
        }

        public long Id { get; set; }
        public string Type { get; set; }
        public short? IsDeleted { get; set; }
        [JsonIgnore]

        public virtual ICollection<Crmlead> Crmlead { get; set; }
    }
}
