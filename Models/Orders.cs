using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS4200.Models
{
    public class Orders
    {
        public int ordersID { get; set; }
        public string description { get; set; }
        public DateTime orderDate { get; set; }
        public int customerID { get; set; }
        // need this to link back to customer, "iCollection" for the customer (on the many side) (on other side we need "public virtual")
        public virtual Customer customer { get; set; }
        public ICollection<LineItem> lineItem { get; set; }
    }
}