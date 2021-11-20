using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class District
    {
        public District()
        {
            BasicDetails = new HashSet<BasicDetails>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long? StateId { get; set; }
        public long? CountryId { get; set; }
        public short? IsDeleted { get; set; }

        public virtual Country Country { get; set; }
        public virtual State State { get; set; }
        public virtual ICollection<BasicDetails> BasicDetails { get; set; }
    }
}
