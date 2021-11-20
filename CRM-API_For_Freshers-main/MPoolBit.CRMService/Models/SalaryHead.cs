using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class SalaryHead
    {
        public SalaryHead()
        {
            SalaryDetails = new HashSet<SalaryDetails>();
            SalaryHeadValue = new HashSet<SalaryHeadValue>();
            UserRoleCategory = new HashSet<UserRoleCategory>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public short? IsDeleted { get; set; }

        public virtual ICollection<SalaryDetails> SalaryDetails { get; set; }
        public virtual ICollection<SalaryHeadValue> SalaryHeadValue { get; set; }
        public virtual ICollection<UserRoleCategory> UserRoleCategory { get; set; }
    }
}
