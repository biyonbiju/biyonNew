using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class HoliDay
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime? Year { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public short? IsDeleted { get; set; }
        public int? NoDays { get; set; }
        public short? IsRecurring { get; set; }
        public string Period { get; set; }
        public int? WeekNumber { get; set; }
    }
}
