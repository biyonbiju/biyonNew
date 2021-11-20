using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class CodeGeneratorModule
    {
        public CodeGeneratorModule()
        {
            CodeGenerator = new HashSet<CodeGenerator>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CodeGenerator> CodeGenerator { get; set; }
    }
}
