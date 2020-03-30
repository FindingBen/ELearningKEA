using System;
using System.Collections.Generic;

namespace E_LearningPlatform.Domain.Models
{
    public partial class Course
    {
        public Course()
        {
            Quiz = new HashSet<Quiz>();
            Topic = new HashSet<Topic>();
            UserCourse = new HashSet<UserCourse>();
        }

        public int CourseId { get; set; }
        public string CourseTitle { get; set; }
        public string CourseDescription { get; set; }
        public int TotalDuration { get; set; }
        public DateTime PublishedAt { get; set; }
        public string CourseCode { get; set; }

        public virtual ICollection<Quiz> Quiz { get; set; }
        public virtual ICollection<Topic> Topic { get; set; }
        public virtual ICollection<UserCourse> UserCourse { get; set; }
    }
}
