using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class InsuranceCardType
    {
        public InsuranceCardType()
        {
            UserDetails = new HashSet<UserDetails>();
        }

        public long Id { get; set; }
        public short? IsDeleted { get; set; }
        public string InsuranceCardType1 { get; set; }

        public virtual ICollection<UserDetails> UserDetails { get; set; }
    }
}
