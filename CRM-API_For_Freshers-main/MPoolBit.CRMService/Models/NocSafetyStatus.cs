using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class NocSafetyStatus
    {
        public NocSafetyStatus()
        {
            NocEmployeeDetails = new HashSet<NocEmployeeDetails>();
        }

        public long Id { get; set; }
        public string Status { get; set; }
        public short? IsDeleted { get; set; }

        public virtual ICollection<NocEmployeeDetails> NocEmployeeDetails { get; set; }
    }
}
