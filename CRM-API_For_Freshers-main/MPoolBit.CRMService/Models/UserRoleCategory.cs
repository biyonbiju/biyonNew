using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class UserRoleCategory
    {
        public UserRoleCategory()
        {
            BasicDetails = new HashSet<BasicDetails>();
            StaffSalaryHeader = new HashSet<StaffSalaryHeader>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public short? IsDeleted { get; set; }
        public long? SalaryHeadId { get; set; }

        public virtual SalaryHead SalaryHead { get; set; }
        public virtual ICollection<BasicDetails> BasicDetails { get; set; }
        public virtual ICollection<StaffSalaryHeader> StaffSalaryHeader { get; set; }
    }
}
