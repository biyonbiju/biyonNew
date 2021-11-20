using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class BranchDocument
    {
        public long Id { get; set; }
        public long? AttachmentId { get; set; }
        public long? BranchId { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string FileName { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string Remarks { get; set; }
        public short? IsDeleted { get; set; }
        public long? DocumentTypeId { get; set; }

        public virtual Attachment Attachment { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual DocumentType DocumentType { get; set; }
    }
}
