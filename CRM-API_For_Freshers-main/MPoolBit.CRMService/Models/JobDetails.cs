using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class JobDetails
    {
        public long Id { get; set; }
        public long? DepartmentId { get; set; }
        public long? DesignationId { get; set; }
        public long? WorkLocationId { get; set; }
        public string Remarks { get; set; }
        public long? UserId { get; set; }
        public long? GradeId { get; set; }
        public long? LineManagerId { get; set; }

        public virtual Department Department { get; set; }
        public virtual Designation Designation { get; set; }
        public virtual GradeType Grade { get; set; }
        public virtual User LineManager { get; set; }
        public virtual User User { get; set; }
        public virtual OfficeLocation WorkLocation { get; set; }
    }
}
