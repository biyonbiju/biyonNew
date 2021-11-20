using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class LeadComments
    {
        public long Id { get; set; }
        public long? LeadId { get; set; }
        public long? CommentId { get; set; }
        public short? IsDeleted { get; set; }

        public virtual CrmleadComments Comment { get; set; }
        public virtual Crmlead Lead { get; set; }
		
    }
}
