using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class CampAllocation
    {
        public long Id { get; set; }
        public long? CampId { get; set; }
        public DateTime? CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }
        public long? EmployeeId { get; set; }
        public long? BranchId { get; set; }
        public short? IsDeleted { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Camp Camp { get; set; }
        public virtual User Employee { get; set; }
    }
}
