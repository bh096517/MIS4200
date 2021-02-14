using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS4200.Models
{
    public class Course
    {
        public int courseID { get; set; }
        public string courseName { get; set; }
        public string courseDescription { get; set; }
        public int studentID { get; set; }

        // create publics
        public virtual instructor Insructor { get; set; }
        public int instructorID { get; set; }
    }
}