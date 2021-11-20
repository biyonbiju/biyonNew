using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MPoolBit.CRMService.Helper
{
    public class RequestHeader
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public long UserId { get; set; }
        public int? Mobilized { get; set; }

    }
}
