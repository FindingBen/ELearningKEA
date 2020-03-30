using System;
using System.Collections.Generic;

namespace E_LearningPlatform.Domain.Models
{
    public partial class Question
    {
        public Question()
        {
            Answer = new HashSet<Answer>();
        }

        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public byte CorrectAnswer { get; set; }
        public int QuizId { get; set; }

        public virtual Quiz Quiz { get; set; }
        public virtual ICollection<Answer> Answer { get; set; }
    }
}
