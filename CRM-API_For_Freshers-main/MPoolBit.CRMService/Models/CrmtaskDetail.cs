using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class CrmtaskDetail
    {
        public long Id { get; set; }
        public long? TaskId { get; set; }
        public string Comments { get; set; }
        public long? PhotoId { get; set; }
        public long? TaskTypeId { get; set; }
        public long? StatusId { get; set; }
        public short? IsDeleted { get; set; }
        public string TaskDescription { get; set; }
        public string ContactName { get; set; }
        public string ContactNumber { get; set; }
        public string EMail { get; set; }
        public DateTime? FollowupDate { get; set; }
        public DateTime? TaskCompletedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }
        [JsonIgnore]
        public virtual Crmtask Task { get; set; }
        public virtual CrmtaskType TaskType { get; set; }
        public virtual CrmleadStatus Status { get; set; }
        [JsonIgnore]
        public virtual Attachment Photo { get; set; }
    }
}
