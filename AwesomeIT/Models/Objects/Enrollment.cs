using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AwesomeIT.Models.Objects
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int enrollmentid { get; set; }
        public int courseid { get; set; }
        public int studentid { get; set; }
        public Grade grade { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}