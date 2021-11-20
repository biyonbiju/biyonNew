using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class CrmtaskType
    {
        public CrmtaskType()
        {
            Crmtask = new HashSet<Crmtask>();
            CrmtaskDetail = new HashSet<CrmtaskDetail>();
        }

        public long Id { get; set; }
        public string Type { get; set; }
        public short? IsDeleted { get; set; }
        [JsonIgnore]
        public virtual ICollection<Crmtask> Crmtask { get; set; }
        public virtual ICollection<CrmtaskDetail> CrmtaskDetail { get; set; }

    }
}
