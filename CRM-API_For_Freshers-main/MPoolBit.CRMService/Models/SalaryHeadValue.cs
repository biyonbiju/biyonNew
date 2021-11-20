using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class SalaryHeadValue
    {
        public long Id { get; set; }
        public decimal? NotRatePer { get; set; }
        public decimal? HotRatePer { get; set; }
        public decimal? PotRatePer { get; set; }
        public long? SalaryHeadId { get; set; }
        public short? IsOverTime { get; set; }
        public short? IsHourly { get; set; }

        public virtual SalaryHead SalaryHead { get; set; }
    }
}
