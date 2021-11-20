using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class DemandRequestType
    {
        public DemandRequestType()
        {
            DemandRequest = new HashSet<DemandRequest>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public short? IsDeleted { get; set; }

        public virtual ICollection<DemandRequest> DemandRequest { get; set; }
    }
}
