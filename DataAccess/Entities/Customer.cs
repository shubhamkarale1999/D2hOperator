using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Customer
    {

        public   int  CustomerId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerQuery { get; set; }
        public DateTime  PaymentDate { get; set; }
        public int PackageId { get; set; }
        public int CustomerStetus { get; set; }
        public string CustomerContact { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }
}
