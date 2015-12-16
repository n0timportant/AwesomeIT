using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AwesomeIT.Models.Objects
{
    public class Course
    {
        public int courseid { get; set; }
        public string title { get; set; }
        public string credits { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}