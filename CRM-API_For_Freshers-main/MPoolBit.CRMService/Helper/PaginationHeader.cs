using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MPoolBit.CRMService.Helper
{
    public class PaginationHeader
    {
        public long Id { get; set; }//sponsorshipcompanyId
        public long FinancialPeriodId { get; set; }
        public int Year { get; set; }
        public int NoOfRows { get; set; }
        public List<Filter> Filters { get; set; }
        public string GlobalFilter { get; set; }
        public int StartIndex { get; set; }
        public long UserId { get; set; }
        public long BranchId { get; set; }
    }
    public class Filter
    {
        public string Felid { get; set; }
        public string Value { get; set; }
    }
}
