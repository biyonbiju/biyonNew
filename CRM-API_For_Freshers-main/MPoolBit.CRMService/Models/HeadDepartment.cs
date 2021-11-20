using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class HeadDepartment
    {
        public long Id { get; set; }
        public long? DepartmentId { get; set; }
        public long? BranchId { get; set; }
        public long? EmployeeId { get; set; }
        public short? IsDeleted { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Department Department { get; set; }
        public virtual User Employee { get; set; }
    }
}
