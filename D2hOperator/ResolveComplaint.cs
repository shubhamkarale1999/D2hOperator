using DataAccess.Entities;
using DataAccess.Operations;
using System;

namespace D2hOperator
{
    internal class ResolveComplaint
    {

        private static string connectionString = @"Data Source=DESKTOP-HA16J39;Initial Catalog=CableSystemManagement;Integrated Security=True";


        private static AgentInformationOperation AgentInformation = new AgentInformationOperation(connectionString);

        private static ComplaintResolutionOperation ResolveOperation = new ComplaintResolutionOperation(connectionString);

        private static GetAgentId getAgentId=new GetAgentId(connectionString);
        internal static void Execute(string username)
        {
            Console.WriteLine("Resolve a complaint");
            Console.WriteLine("======================");
            Console.WriteLine("Enter Customer Id");
            int CustomerId=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Complaint Description");
            string CustComplaintDesc=Console.ReadLine();
            Console.WriteLine("Enter Complaint Resolution Amount");
            int ComplaintResolutionAmount=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Customer Complaint Type\r\n1. Manpower\r\n2. Hardware\r\n3. Traveling\r\n4. Installation\r\n5. Signal");
            int CustComplaintType=int.Parse(Console.ReadLine());
            GetAgentIdEntite gd = getAgentId.MyGetAgentId(username);
            int AgentId =gd.AgentId;
           // Console.WriteLine(gd.AgentId);
           // Console.ReadLine();

            bool isResolved = ResolveOperation.ResolveAComplaint(CustomerId, CustComplaintDesc, ComplaintResolutionAmount, CustComplaintType,AgentId);

            if(isResolved)
            {
                Console.WriteLine("Added Successfully");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Something Went Wrong Shubham");
                Console.ReadLine();
            }
        }
    }
}