using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS4200.Models
{
    public class Grade
    {
        public int gradeID { get; set; }
        public int courseID { get; set; }
        public decimal letterGrade { get; set; }
        public int studentID { get; set; }
        // need this to link back to customer, "iCollection" for the customer (on the many side) (on other side we need "public virtual")
        public virtual Student student { get; set; }
        public ICollection<Grade> grade { get; set; }
    }
}