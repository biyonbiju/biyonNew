using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MPoolBit.CRMService.Models
{
    public class CrmquotationTerms
    {
        public long Id { get; set; }
        public long? BranchId { get; set; }
        public string Terms { get; set; }
        public short? IsDeleted { get; set; }

        public virtual Branch Branch { get; set; }
    }
}
