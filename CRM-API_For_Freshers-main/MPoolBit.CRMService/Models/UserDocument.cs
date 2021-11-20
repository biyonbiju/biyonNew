using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class UserDocument
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public long? AttachmentId { get; set; }
        public long? UserId { get; set; }
        public short? IsDeleted { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string Remarks { get; set; }
        public long? SupplierDescriptionId { get; set; }
        public long? CompanyId { get; set; }
        public string FileName { get; set; }
        public long? DocumentTypeId { get; set; }
        public long? StatusId { get; set; }

        public virtual Attachment Attachment { get; set; }
        public virtual SponsorshipCompany Company { get; set; }
        public virtual DocumentType DocumentType { get; set; }
        public virtual Eidstatus Status { get; set; }
        public virtual SupplierDescription SupplierDescription { get; set; }
        public virtual User User { get; set; }
    }
}
