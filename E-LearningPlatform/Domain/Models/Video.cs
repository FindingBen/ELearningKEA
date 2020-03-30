using System;
using System.Collections.Generic;

namespace E_LearningPlatform.Domain.Models
{
    public partial class Video
    {
        public int VideoId { get; set; }
        public string Link { get; set; }
        public int TopicId { get; set; }

        public virtual Topic Topic { get; set; }
    }
}
