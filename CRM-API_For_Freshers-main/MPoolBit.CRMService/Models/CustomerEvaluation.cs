using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class CustomerEvaluation
    {
        public CustomerEvaluation()
        {
            CustomerEvaluationDetails = new HashSet<CustomerEvaluationDetails>();
        }

        public long Id { get; set; }
        public long? CustomerId { get; set; }
        public short? IsDeleted { get; set; }

        public virtual User Customer { get; set; }
        public virtual ICollection<CustomerEvaluationDetails> CustomerEvaluationDetails { get; set; }
    }
}
