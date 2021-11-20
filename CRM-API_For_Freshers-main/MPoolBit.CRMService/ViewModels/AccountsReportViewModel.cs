using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MPoolBit.CRMService.ViewModels
{
    public class AccountsReportViewModel
    {
        public DateTime? AccountDate { get; set; }
        public string AccountOwner { get; set; }
        public string AccountName { get; set; }
        public string AccountMobile { get; set; }
        public string AccountPhone { get; set; }
        public string AccountEmail { get; set; }
        
    }
}
