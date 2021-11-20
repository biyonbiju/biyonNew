using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class VisaSponsor
    {
        public VisaSponsor()
        {
            UserDetails = new HashSet<UserDetails>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public short? IsDeleted { get; set; }
        public string ShortName { get; set; }

        public virtual ICollection<UserDetails> UserDetails { get; set; }
    }
}
