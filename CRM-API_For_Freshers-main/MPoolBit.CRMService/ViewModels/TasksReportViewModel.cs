using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MPoolBit.CRMService.ViewModels
{
    public partial class TasksReportViewModel
    {
        public DateTime? TaskDueDate { get; set; }
        public DateTime? TaskCompletedDate { get; set; }
        public DateTime? TaskCreatedDate { get; set; }
        public string TaskUnder { get; set; }
        public string TaskOwner { get; set; }
        public string taskId { get; set; }
        public string TaskType { get; set; }
        public string IsTask { get; set; }
        public string TaskPriority { get; set; }
        public string Client { get; set; }
        public string Project { get; set; }
        public string TaskComment { get; set; }
        public string TaskStatus { get; set; }
    }
}
 