using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS4200.Models
{
    public class Student
    {
        public int studentID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string email { get; set; }
        //remove the "set" so no modifications can be done
        public string fullName
        {
            get
            {
                return lastName + ", " + firstName;
            }
        }
    }
}