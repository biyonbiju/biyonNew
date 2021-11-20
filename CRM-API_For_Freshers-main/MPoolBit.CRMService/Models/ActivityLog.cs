using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class ActivityLog
    {
        public long Id { get; set; }
        public string Activity { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? LastUpdatedOn { get; set; }
        public string Path { get; set; }
        public long? ModuleId { get; set; }

        public virtual User CreatedByNavigation { get; set; }
        public virtual Module Module { get; set; }
    }
}
