using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class LineManager
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Remarks { get; set; }
        public short? IsDeleted { get; set; }
    }
}
