using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class ProjectType
    {
        public ProjectType()
        {
            Project = new HashSet<Project>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public short? IsDeleted { get; set; }

        public virtual ICollection<Project> Project { get; set; }
    }
}
