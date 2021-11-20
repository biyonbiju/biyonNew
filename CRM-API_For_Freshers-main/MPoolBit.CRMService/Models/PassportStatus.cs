using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class PassportStatus
    {
        public PassportStatus()
        {
            UserDetails = new HashSet<UserDetails>();
        }

        public long Id { get; set; }
        public short? IsDeleted { get; set; }
        public string PassportStatus1 { get; set; }

        public virtual ICollection<UserDetails> UserDetails { get; set; }
    }
}
