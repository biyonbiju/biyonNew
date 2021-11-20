using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class NocStatus
    {
        public NocStatus()
        {
            NocDetails = new HashSet<NocDetails>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public short? IsDeleted { get; set; }

        public virtual ICollection<NocDetails> NocDetails { get; set; }
    }
}
