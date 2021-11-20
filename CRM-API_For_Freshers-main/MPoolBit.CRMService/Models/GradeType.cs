using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class GradeType
    {
        public GradeType()
        {
            JobDetails = new HashSet<JobDetails>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long? RoleId { get; set; }
        public short? IsDeleted { get; set; }

        public virtual UserRole Role { get; set; }
        public virtual ICollection<JobDetails> JobDetails { get; set; }
    }
}
