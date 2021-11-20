using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class LabourTimeCard
    {
        public long Id { get; set; }
        public long? EmployeeId { get; set; }
        public long? DesignationId { get; set; }
        public long? ProjectId { get; set; }
        public DateTime? Day { get; set; }
        public decimal? NotHrs { get; set; }
        public decimal? HotHrs { get; set; }
        public decimal? IncHrs { get; set; }
        public decimal? NormalHrs { get; set; }
        public decimal? NormalRate { get; set; }
        public decimal? NotRate { get; set; }
        public decimal? HotRate { get; set; }
        public decimal? IncRate { get; set; }
        public decimal? NormalAmt { get; set; }
        public decimal? NotAmt { get; set; }
        public decimal? HotAmt { get; set; }
        public decimal? IncAmt { get; set; }
        public decimal? DedHrs { get; set; }
        public decimal? DedRate { get; set; }
        public decimal? DedAmt { get; set; }
        public short? IsAbsent { get; set; }
        public short? IsHoliday { get; set; }
        public short? IsDeleted { get; set; }
        public long? LabourTimeCardHeaderId { get; set; }

        public virtual Designation Designation { get; set; }
        public virtual User Employee { get; set; }
        public virtual LabourTimeCardHeader LabourTimeCardHeader { get; set; }
        public virtual Project Project { get; set; }
    }
}
