using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class Notification
    {
        public long Id { get; set; }
        public long? ModuleId { get; set; }
        public long? ActivityId { get; set; }
        public short? IsNotified { get; set; }
        public int? NotificationType { get; set; }
        public long? BranchId { get; set; }
        public short? IsDeleted { get; set; }
        public string Description { get; set; }
        public long? UserId { get; set; }
        public string ExpiryDocumentType { get; set; }
        public long? DocumentTypeId { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual DocumentType DocumentType { get; set; }
        public virtual Module Module { get; set; }
    }
}
