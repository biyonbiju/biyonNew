using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class UserTransfer
    {
        public long Id { get; set; }
        public long? BranchId { get; set; }
        public long? UserId { get; set; }
        public long? UserRoleId { get; set; }
        public short? IsDeleted { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public short? IsReTransfer { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual User User { get; set; }
        public virtual UserRole UserRole { get; set; }
    }
}
