using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class Permission
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public short? IsActive { get; set; }
        public long? UserId { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? LastUpdatedOn { get; set; }
        public short? IsModule { get; set; }
        public long? ModuleId { get; set; }
        public long? PermissionTypeId { get; set; }

        public virtual User CreatedByNavigation { get; set; }
        public virtual Module Module { get; set; }
        public virtual PermissionType PermissionType { get; set; }
        public virtual User User { get; set; }
    }
}
