using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class CodeGenerator
    {
        public long Id { get; set; }
        public long? BranchId { get; set; }
        public long? LatestCode { get; set; }
        public long? CodeGeneratorModuleId { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual CodeGeneratorModule CodeGeneratorModule { get; set; }
    }
}
