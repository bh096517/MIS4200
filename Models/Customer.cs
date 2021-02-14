using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS4200.Models
{
    public class Customer
    {
       public int customerID {get; set;}
        // use "prop tab" and change sring, DateTime, etc and name
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public DateTime customerSince { get; set; }
        //remove the "set" so no modifications can be done
        public string fullName {
            get
            {
                return lastName + ", " + firstName;
            }
        }
        public ICollection<Orders>  orders { get; set; }
        // customer has many orders an ICollection, 

    }
}