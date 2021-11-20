using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class NocAccomadationStatus
    {
        public NocAccomadationStatus()
        {
            DemandRequestFat = new HashSet<DemandRequest>();
            DemandRequestTransportationStatus = new HashSet<DemandRequest>();
            NocEmployeeDetailsAccomadationStatus = new HashSet<NocEmployeeDetails>();
            NocEmployeeDetailsTransportationStatus = new HashSet<NocEmployeeDetails>();
        }

        public long Id { get; set; }
        public string Type { get; set; }
        public short? IsDeleted { get; set; }

        public virtual ICollection<DemandRequest> DemandRequestFat { get; set; }
        public virtual ICollection<DemandRequest> DemandRequestTransportationStatus { get; set; }
        public virtual ICollection<NocEmployeeDetails> NocEmployeeDetailsAccomadationStatus { get; set; }
        public virtual ICollection<NocEmployeeDetails> NocEmployeeDetailsTransportationStatus { get; set; }
    }
}
