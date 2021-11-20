using System;
using System.Collections.Generic;

namespace MPoolBit.CRMService.Models
{
    public partial class CustomerEvaluationDetails
    {
        public long Id { get; set; }
        public long? CustomerEvaluationId { get; set; }
        public long? QuestionId { get; set; }
        public long? AnswerId { get; set; }
        public short? IsDeleted { get; set; }

        public virtual CustomerEvaluationAnswer Answer { get; set; }
        public virtual CustomerEvaluation CustomerEvaluation { get; set; }
        public virtual CustomerEvaluationQuestionnaire Question { get; set; }
    }
}
