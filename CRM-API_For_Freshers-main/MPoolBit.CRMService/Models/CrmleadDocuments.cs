using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class CrmleadDocuments
    {
        public long Id { get; set; }
        public string FileName { get; set; }
        public long? DocumentTypeId { get; set; }
        public string Description { get; set; }
        public long? AttachmentId { get; set; }
        public short? IsDeleted { get; set; }
        public long? LeadId { get; set; }
        public DateTime? ExpiryDate { get; set; }

        public virtual Attachment Attachment { get; set; }
        public virtual DocumentType DocumentType { get; set; }
        public virtual Crmlead Lead { get; set; }
    }
}
