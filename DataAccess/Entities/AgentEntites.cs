using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class AgentEntites
    {
        public int AgentId { get; set; }
       public  string FirstName { get; set; }

        public string LastName { get; set; }

        public int? ContactName { get; set; }

        public string Address {get; set; }
    }
}
