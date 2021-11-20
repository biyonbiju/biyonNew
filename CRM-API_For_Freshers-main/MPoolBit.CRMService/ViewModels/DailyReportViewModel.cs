using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MPoolBit.CRMService.ViewModels
{
    public class DailyReportViewModel
    {
        public string SalesmanName { get; set; }
        public DateTime? Date { get; set; }
        public string CompanyName { get; set; }
        public string ProjectName { get; set; }
        public string ProjectLocation { get; set; }
        public string ContactPerson { get; set; }
        public string Status { get; set; }
        public string Details { get; set; }
        public string Result { get; set; }
    }
}
