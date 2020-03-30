﻿using System;
using System.Collections.Generic;

namespace E_LearningPlatform.Domain.Models
{
    public partial class UserCourse
    {
        public int CourseId { get; set; }
        public int UserId { get; set; }

        public virtual Course Course { get; set; }
        public virtual User User { get; set; }
    }
}
