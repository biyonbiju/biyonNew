using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class MedicalDetails
    {
        public long Id { get; set; }
        public DateTime? MedicalDate { get; set; }
        public long? MedicalStatusId { get; set; }
        public long? MedicalAttachmentId { get; set; }
        public long? EidstatusId { get; set; }
        public string Remarks { get; set; }
        public long? UserId { get; set; }
        public short? IsDeleted { get; set; }
        public string MedicalFileName { get; set; }

        public virtual Eidstatus Eidstatus { get; set; }
        public virtual Attachment MedicalAttachment { get; set; }
        public virtual MedicalStatus MedicalStatus { get; set; }
        public virtual User User { get; set; }
    }
}
