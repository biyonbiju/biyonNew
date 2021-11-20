using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class CustomerEvaluationAnswer
    {
        public CustomerEvaluationAnswer()
        {
            CustomerEvaluationDetails = new HashSet<CustomerEvaluationDetails>();
        }

        public long Id { get; set; }
        public string Answer { get; set; }
        public decimal? Score { get; set; }
        public short? IsDeleted { get; set; }
        public long? QuestionId { get; set; }

        public virtual CustomerEvaluationQuestionnaire Question { get; set; }
        public virtual ICollection<CustomerEvaluationDetails> CustomerEvaluationDetails { get; set; }
    }
}
