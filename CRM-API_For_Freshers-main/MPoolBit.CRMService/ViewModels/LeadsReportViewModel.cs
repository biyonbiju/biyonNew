using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MPoolBit.CRMService.ViewModels
{
    public partial class LeadsReportViewModel
    {
        public DateTime? LeadDate { get; set; }
        public string LeadOwner { get; set; }
        public string LeadName { get; set; }
        public string LeadStatus { get; set; }
        public string Work { get; set; }
     
    }
}
