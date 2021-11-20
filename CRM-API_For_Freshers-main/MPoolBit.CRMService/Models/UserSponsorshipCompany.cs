using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class UserSponsorshipCompany
    {
        public long Id { get; set; }
        public long? UserId { get; set; }
        public long? SponsorshipCompanyId { get; set; }
        public short? IsDefaultSponsorshipCompany { get; set; }
        public short? IsDeleted { get; set; }
        public long? BranchId { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual SponsorshipCompany SponsorshipCompany { get; set; }
        public virtual User User { get; set; }
    }
}
