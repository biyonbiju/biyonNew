using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class ProjectDocument
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public short? IsDeleted { get; set; }
        public DateTime? Date { get; set; }
        public string Remark { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public long? ProjectId { get; set; }
        public long? AttachmentId { get; set; }
        public string FileName { get; set; }
        public long? DocumentTypeId { get; set; }

        public virtual Attachment Attachment { get; set; }
        public virtual DocumentType DocumentType { get; set; }
        public virtual Project Project { get; set; }
    }
}
