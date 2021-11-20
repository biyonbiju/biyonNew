using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class AccountUserInvoiceDocument
    {
        public long Id { get; set; }
        public long? DocumentTypeId { get; set; }
        public string Description { get; set; }
        public long? AccountUserInvoiceId { get; set; }
        public string FileName { get; set; }
        public long? AttachmentId { get; set; }
        public short? IsDeleted { get; set; }

        public virtual AccountUserInvoice AccountUserInvoice { get; set; }
        public virtual Attachment Attachment { get; set; }
        public virtual DocumentType DocumentType { get; set; }
    }
}
