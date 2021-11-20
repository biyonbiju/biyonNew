using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class State
    {
        public State()
        {
            BasicDetails = new HashSet<BasicDetails>();
            District = new HashSet<District>();
        }

        public long Id { get; set; }
        public long? CountryId { get; set; }
        public string StateName { get; set; }
        public short? IsDeleted { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<BasicDetails> BasicDetails { get; set; }
        public virtual ICollection<District> District { get; set; }
    }
}
