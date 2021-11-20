using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class OperationSettings
    {
        public long Id { get; set; }
        public long? BranchId { get; set; }
        public string DemandRequestPrefix { get; set; }
        public string NocPrefix { get; set; }
        public long? DemandRequestCount { get; set; }
        public long? NocCount { get; set; }
        public string AttendancePrefix { get; set; }
        public long? AttendanceCount { get; set; }

        public virtual Branch Branch { get; set; }
    }
}
