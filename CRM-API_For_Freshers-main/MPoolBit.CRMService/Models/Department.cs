using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class Department
    {
        public Department()
        {
            HeadDepartment = new HashSet<HeadDepartment>();
            JobDetails = new HashSet<JobDetails>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public short? IsDeleted { get; set; }
        public long? DepartmentHeadId { get; set; }

        public virtual ICollection<HeadDepartment> HeadDepartment { get; set; }
        public virtual ICollection<JobDetails> JobDetails { get; set; }
    }
}
