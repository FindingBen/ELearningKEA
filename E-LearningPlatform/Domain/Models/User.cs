using System;
using System.Collections.Generic;

namespace E_LearningPlatform.Domain.Models
{
    public partial class User
    {
        public User()
        {
            UserCourse = new HashSet<UserCourse>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<UserCourse> UserCourse { get; set; }
    }
}
