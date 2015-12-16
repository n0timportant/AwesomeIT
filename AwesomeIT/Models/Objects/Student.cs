using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AwesomeIT.Models.Objects
{
    public class Student
    {
        public int studentid { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public DateTime enrollmentdate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}