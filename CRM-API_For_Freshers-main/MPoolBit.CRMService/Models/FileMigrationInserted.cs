using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class FileMigrationInserted
    {
        public long Id { get; set; }
        public string FileName { get; set; }
        public short? Status { get; set; }
    }
}
