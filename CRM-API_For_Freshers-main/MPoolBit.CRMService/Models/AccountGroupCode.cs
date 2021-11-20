using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class AccountGroupCode
    {
        public int Id { get; set; }
        public int? Level { get; set; }
        public int? LastestCode { get; set; }
        public long? ParentId { get; set; }
        public long? SponsorshipCompanyId { get; set; }

        public virtual AccountGroup Parent { get; set; }
        public virtual SponsorshipCompany SponsorshipCompany { get; set; }
    }
}
