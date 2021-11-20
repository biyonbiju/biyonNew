using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MPoolBit.CRMService.ViewModels
{
    public class CRMDailySalesManReportViewModel
    {
        public long? Id { get; set; }
        public DateTime? Date { get; set; }
        public string CompanyName { get; set; }
        public string ProjectName { get;set; }
        public string LocationName { get; set; }
        public string ContactPersonName { get; set; }
        public string Status { get; set; }
        public string Details { get; set; }
        public string Result { get; set; }
        public long? TaskTypeId { get; set; }
        public string TaskTypeName { get; set; }
    }
}
