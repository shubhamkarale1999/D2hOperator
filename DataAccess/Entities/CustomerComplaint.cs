using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class CustomerComplaint
    {
        public int CustomerId { get; set; }
      public  string ComplaintDescription { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName {get; set;}
        public string    CustomerCity { get; set;}
        public string CustomerContact { get; set;}
    }
}
