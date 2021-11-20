using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class Country
    {
        public Country()
        {
            BasicDetails = new HashSet<BasicDetails>();
            Branch = new HashSet<Branch>();
            District = new HashSet<District>();
            Emirate = new HashSet<Emirate>();
            SponsorshipCompany = new HashSet<SponsorshipCompany>();
            State = new HashSet<State>();
        }

        public long Id { get; set; }
        public string CountryCode { get; set; }
        public string Name { get; set; }
        public long? CurrencyId { get; set; }
        public string CountryNameInArabic { get; set; }
        public string Nationality { get; set; }
        public short? IsDeleted { get; set; }

        public virtual Currency Currency { get; set; }
        public virtual ICollection<BasicDetails> BasicDetails { get; set; }
        public virtual ICollection<Branch> Branch { get; set; }
        public virtual ICollection<District> District { get; set; }
        public virtual ICollection<Emirate> Emirate { get; set; }
        public virtual ICollection<SponsorshipCompany> SponsorshipCompany { get; set; }
        public virtual ICollection<State> State { get; set; }
    }
}
