using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class YearlyStatement
    {
        /*public int monthId {get; set;}

        public DateTime monthDate { get; set;}

        public string monthName { get; set;}

        public int CustomerId {get; set;}
        
        public int year {get; set;}

        public string month { get; set;}

        public DateTime PaymentDate { get; set;}

        public int paidAmount { get; set;}*/

        public DateTime? PaymentDate { get; set; }


        public int? paidAmount { get; set; }

        public int? pendingAmount { get; set; }

       
        

    }
}
