using System;
using System.Collections.Generic;

namespace E_LearningPlatform.Domain.Models
{
    public partial class Answer
    {
        public int AnswerId { get; set; }
        public string Text { get; set; }
        public int QuestionId { get; set; }

        public virtual Question Question { get; set; }
    }
}
