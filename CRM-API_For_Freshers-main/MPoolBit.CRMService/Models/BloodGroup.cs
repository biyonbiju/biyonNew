using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class BloodGroup
    {
        public BloodGroup()
        {
            BasicDetails = new HashSet<BasicDetails>();
        }

        public long Id { get; set; }
        public short? IsDeleted { get; set; }
        public string Group { get; set; }

        public virtual ICollection<BasicDetails> BasicDetails { get; set; }
    }
}
