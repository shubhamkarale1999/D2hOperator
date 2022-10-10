using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class ComplaintResolutionReportEntities
    {
        public int ResolutionId { get; set; }

        public string ResolutionDescription { get; set; }

        public int ResolutionAmount { get; set; }

        public string ComplaintType { get; set; }

        public string AgentFirstName { get; set; }

        public string AgentLastName { get; set; }

        public string AgentContact { get; set; }
    }
}
