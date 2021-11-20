using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class ClientTimeSheetDesignation
    {
        public long Id { get; set; }
        public long? ClientTimeSheetId { get; set; }
        public long? DesignationId { get; set; }
        public short? IsDeleted { get; set; }

        public virtual ClientTimeSheet ClientTimeSheet { get; set; }
        public virtual Designation Designation { get; set; }
    }
}
