using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class CrmtaskDocument
    {
        public long Id { get; set; }
        public long? TaskId { get; set; }

        public long? AttachmentId { get; set; }
        public string Description { get; set; }
        public short? IsDeleted { get; set; }
        [JsonIgnore]
        public virtual Crmtask Task { get; set; }
    }
}
