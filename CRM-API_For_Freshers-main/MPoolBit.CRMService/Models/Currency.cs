using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class Currency
    {
        public Currency()
        {
            AccountSettings = new HashSet<AccountSettings>();
            BasicDetails = new HashSet<BasicDetails>();
            Branch = new HashSet<Branch>();
            Country = new HashSet<Country>();
            SponsorshipCompany = new HashSet<SponsorshipCompany>();
        }

        public long Id { get; set; }
        public string ShortName { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string Rate { get; set; }
        public short? IsDeleted { get; set; }

        public virtual ICollection<AccountSettings> AccountSettings { get; set; }
        public virtual ICollection<BasicDetails> BasicDetails { get; set; }
        public virtual ICollection<Branch> Branch { get; set; }
        public virtual ICollection<Country> Country { get; set; }
        public virtual ICollection<SponsorshipCompany> SponsorshipCompany { get; set; }
    }
}
