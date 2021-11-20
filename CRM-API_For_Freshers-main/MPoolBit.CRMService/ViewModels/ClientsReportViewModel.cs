using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MPoolBit.CRMService.ViewModels
{
    public partial class ClientsReportViewModel
    {
        public DateTime? LeadDate { get; set; }
        public string ClientOwner { get; set; }
        public string ClientName { get; set; }
        public string ClientEmail { get; set; }
        public string ClientPhone { get; set; }
        public long? ClientId { get; set; }
    }
}
