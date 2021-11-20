using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MPoolBit.CRMService.Models
{
    public class CustomerActivityReportRequest
    {

        public long? BranchId { get; set; }
        public long? UserId { get; set; }
        public List<long> CustomerIds { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

    }
}
