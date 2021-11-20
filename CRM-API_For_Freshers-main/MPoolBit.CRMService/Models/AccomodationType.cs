using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class AccomodationType
    {
        public AccomodationType()
        {
            ProjectDetails = new HashSet<ProjectDetails>();
        }

        public long Id { get; set; }
        public string TypeName { get; set; }
        public short? IsDeleted { get; set; }

        public virtual ICollection<ProjectDetails> ProjectDetails { get; set; }
    }
}
