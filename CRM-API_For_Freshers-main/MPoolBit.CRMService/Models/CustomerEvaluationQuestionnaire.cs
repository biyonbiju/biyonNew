using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class CustomerEvaluationQuestionnaire
    {
        public CustomerEvaluationQuestionnaire()
        {
            CustomerEvaluationAnswer = new HashSet<CustomerEvaluationAnswer>();
            CustomerEvaluationDetails = new HashSet<CustomerEvaluationDetails>();
        }

        public long Id { get; set; }
        public string Question { get; set; }
        public short? IsDeleted { get; set; }

        public virtual ICollection<CustomerEvaluationAnswer> CustomerEvaluationAnswer { get; set; }
        public virtual ICollection<CustomerEvaluationDetails> CustomerEvaluationDetails { get; set; }
    }
}
