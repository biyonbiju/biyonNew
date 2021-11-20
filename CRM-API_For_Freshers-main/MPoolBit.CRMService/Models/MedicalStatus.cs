using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class MedicalStatus
    {
        public MedicalStatus()
        {
            MedicalDetails = new HashSet<MedicalDetails>();
        }

        public long Id { get; set; }
        public string Status { get; set; }
        public short? IsDeleted { get; set; }

        public virtual ICollection<MedicalDetails> MedicalDetails { get; set; }
    }
}
