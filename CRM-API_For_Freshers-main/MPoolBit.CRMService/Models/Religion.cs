using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class Religion
    {
        public Religion()
        {
            BasicDetails = new HashSet<BasicDetails>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public short? IsDeleted { get; set; }

        public virtual ICollection<BasicDetails> BasicDetails { get; set; }
    }
}
