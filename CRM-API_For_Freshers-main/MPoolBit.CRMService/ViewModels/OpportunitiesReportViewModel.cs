using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MPoolBit.CRMService.ViewModels
{
    public partial class OpportunitiesReportViewModel
    {
        public string OpportunityOwner { get; set; }
        public DateTime? OpportunityClosedDate { get; set; }
        public string OpportunityNumber { get; set; }
        public string OpportunityName { get; set; }
        public string OpportunityComment { get; set; }
        public string Stage { get; set; }
        public string AccountName { get; set; }
    }
}
