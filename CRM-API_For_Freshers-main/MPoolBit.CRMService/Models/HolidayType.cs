using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class HolidayType
    {
        public HolidayType()
        {
            ProjectHolidayDetails = new HashSet<ProjectHolidayDetails>();
        }

        public long Id { get; set; }
        public short? IsDeleted { get; set; }
        public string Type { get; set; }

        public virtual ICollection<ProjectHolidayDetails> ProjectHolidayDetails { get; set; }
    }
}
