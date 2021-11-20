using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class Crmpriority
    {
        public Crmpriority()
        {
            Crmtask = new HashSet<Crmtask>();
        }

        public long Id { get; set; }
        public string Priority { get; set; }
        public short? IsDeleted { get; set; }
        [JsonIgnore]
        public virtual ICollection<Crmtask> Crmtask { get; set; }
    }
}
