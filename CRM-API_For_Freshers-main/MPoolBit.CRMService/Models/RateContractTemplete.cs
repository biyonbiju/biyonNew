using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class RateContractTemplete
    {
        public RateContractTemplete()
        {
            RateContractTempleteTrades = new HashSet<RateContractTempleteTrades>();
        }

        public long Id { get; set; }
        public string ContractName { get; set; }
        public short? IsDeleted { get; set; }
        public long? UserRoleId { get; set; }
        public long? DocumentId { get; set; }
        public string FileName { get; set; }

        public virtual Attachment Document { get; set; }
        public virtual UserRole UserRole { get; set; }
        public virtual ICollection<RateContractTempleteTrades> RateContractTempleteTrades { get; set; }
    }
}
