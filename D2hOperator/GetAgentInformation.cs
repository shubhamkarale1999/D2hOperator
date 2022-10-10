using DataAccess.Entities;
using DataAccess.Operations;
using System;
using System.Collections.Generic;

namespace D2hOperator
{
    internal class GetAgentInformation
    {
        private static string connectionString = @"Data Source=DESKTOP-HA16J39;Initial Catalog=CableSystemManagement;Integrated Security=True";

        private static AgentInformationOperation AgentInformation = new AgentInformationOperation(connectionString);



        public static void Execute()
        {
            List<AgentEntites> agents = AgentInformation.GetAgentInformation();
            Console.WriteLine("Below Is The Agent Information");
            foreach (AgentEntites agent in agents)
            {
                Console.WriteLine("Agent Id             {0}", agent.AgentId);
                Console.WriteLine("Agent First Name     {0}", agent.FirstName);
                Console.WriteLine("Agent Last Name      {0}", agent.LastName);
                Console.WriteLine("Contact              {0}", agent.ContactName);
                Console.WriteLine("Address              {0}", agent.Address);
                Console.WriteLine("-----------------------------------------------");
            }
            Console.ReadLine();
           // LoginPage.Execute();
        }
    }
}