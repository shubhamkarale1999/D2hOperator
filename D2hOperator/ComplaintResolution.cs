using System;
using System.Collections.Generic;
using DataAccess.Entities;
using DataAccess.Operations;

namespace D2hOperator
{


    internal class ComplaintResolution
    {
        private static string connectionString = @"Data Source=DESKTOP-HA16J39;Initial Catalog=CableSystemManagement;Integrated Security=True";

        private static ComplaintResolutionReportOperations complaintResolutionReportOperations= new ComplaintResolutionReportOperations(connectionString);
        public static void Execute()
        {
            List<ComplaintResolutionReportEntities> CustCompResolution = complaintResolutionReportOperations.GetComplaintResolutionReport();

           foreach(ComplaintResolutionReportEntities entity in CustCompResolution)
            {
                Console.WriteLine("Complaint Resolution Id              {0}",entity.ResolutionId);
                Console.WriteLine("Complaint Resolution Description     {0}",entity.ResolutionDescription);
                Console.WriteLine("Complaint Resolution Amount          {0}",entity.ResolutionAmount);
                Console.WriteLine("Type Of Customer Complaint           {0}",entity.ComplaintType);
                Console.WriteLine("Agent Name                           {0} {1}",entity.AgentFirstName,entity.AgentLastName);
              
                Console.WriteLine(entity.AgentContact);
                Console.WriteLine("-------------------------------");
            }
            Console.ReadLine();


        }
    }
}