using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class InactiveReason
    {
        public InactiveReason()
        {
            BasicDetails = new HashSet<BasicDetails>();
        }

        public long Id { get; set; }
        public string Reason { get; set; }
        public short? IsDeleted { get; set; }

        public virtual ICollection<BasicDetails> BasicDetails { get; set; }
    }
}
