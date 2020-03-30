using System;
using System.Collections.Generic;

namespace E_LearningPlatform.Domain.Models
{
    public partial class Topic
    {
        public Topic()
        {
            Video = new HashSet<Video>();
        }

        public int TopicId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
        public virtual ICollection<Video> Video { get; set; }
    }
}
