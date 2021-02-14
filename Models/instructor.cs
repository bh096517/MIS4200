using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS4200.Models
{
    public class instructor
    {
        public int instructorID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string officePhoneNumber { get; set; }
        public string email { get; set; }
        public ICollection<Course> course { get; set; }
        //  public int instructorID { get; set; }
        public virtual instructor Instructor { get; set; }
    }
}