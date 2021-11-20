using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class NocReportType
    {
        public NocReportType()
        {
            NocDetails = new HashSet<NocDetails>();
        }

        public long Id { get; set; }
        public string Type { get; set; }
        public short? IsDeleted { get; set; }
        public string Remarks { get; set; }

        public virtual ICollection<NocDetails> NocDetails { get; set; }
    }
}
