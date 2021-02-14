using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS4200.Models
{
    public class Classes
    {
        public int classesID { get; set; }
        public string classesName { get; set; }
        public string classDescription { get; set; }
        public string classLocation { get; set; }
        public ICollection<instructor> Instructor { get; set; }
    }
}