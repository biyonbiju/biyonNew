using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class AttendanceStatus
    {
        public AttendanceStatus()
        {
            AttendanceRegisterDetails = new HashSet<AttendanceRegisterDetails>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public short? IsDeleted { get; set; }

        public virtual ICollection<AttendanceRegisterDetails> AttendanceRegisterDetails { get; set; }
    }
}
