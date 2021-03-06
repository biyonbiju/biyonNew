using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class LicenceType
    {
        public LicenceType()
        {
            UserDetails = new HashSet<UserDetails>();
        }

        public long Id { get; set; }
        public string LicenceType1 { get; set; }
        public short? IsDeleted { get; set; }

        public virtual ICollection<UserDetails> UserDetails { get; set; }
    }
}
