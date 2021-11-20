using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class AttendanceReason
    {
        public AttendanceReason()
        {
            AttendanceRegisterDetails = new HashSet<AttendanceRegisterDetails>();
        }

        public long Id { get; set; }
        public string Reason { get; set; }
        public short? IsDeductiable { get; set; }
        public short? IsDeleted { get; set; }

        public virtual ICollection<AttendanceRegisterDetails> AttendanceRegisterDetails { get; set; }
    }
}
