using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class ClientTimeSheetProject
    {
        public long Id { get; set; }
        public long? ClientTimeSheetId { get; set; }
        public long? ProjectId { get; set; }
        public short? IsDeleted { get; set; }

        public virtual ClientTimeSheet ClientTimeSheet { get; set; }
        public virtual Project Project { get; set; }
    }
}
