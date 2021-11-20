using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class Camp
    {
        public Camp()
        {
            AttendanceRegister = new HashSet<AttendanceRegister>();
            CampAllocation = new HashSet<CampAllocation>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public short? IsDeleted { get; set; }

        public virtual ICollection<AttendanceRegister> AttendanceRegister { get; set; }
        public virtual ICollection<CampAllocation> CampAllocation { get; set; }
    }
}
