using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class AttendanceRegisterDetails
    {
        public long Id { get; set; }
        public long? EmployeeId { get; set; }
        public long? DesignationId { get; set; }
        public long? AttendanceRegisterId { get; set; }
        public long? AttendanceReasonId { get; set; }
        public long? AttendanceStatusId { get; set; }
        public string Remarks { get; set; }
        public string ContactNumber { get; set; }

        public virtual AttendanceReason AttendanceReason { get; set; }
        public virtual AttendanceRegister AttendanceRegister { get; set; }
        public virtual AttendanceStatus AttendanceStatus { get; set; }
        public virtual Designation Designation { get; set; }
        public virtual User Employee { get; set; }
    }
}
