using System;
using DataAccess.Operations;

namespace D2hOperator
{
    internal class AgentLogin
    {
        private static string connectionString = @"Data Source=DESKTOP-HA16J39;Initial Catalog=CableSystemManagement;Integrated Security=True";
        
        private static AgentPasswordValidation agentPasswordValidation=new AgentPasswordValidation(connectionString);
        internal static void Execute()
        {
            repete:
            Console.WriteLine("Please Enetr Username");
            string Username=Console.ReadLine();
            Console.WriteLine("Please Enetr Password");
            string Password=Console.ReadLine();
            bool IsValidPassword = agentPasswordValidation.MyAgentValidation(Username, Password);
            if (IsValidPassword)
            {
                AgentLoginPage.Execute(Username);
            }
            else
            {
                Console.WriteLine("Wrong Credintials Agent Login");
                Console.WriteLine("Do you want to Continue yes/no");
                string result=Console.ReadLine();
                if (result == "yes")
                {
                    goto repete;
                }
                else
                {
                    LoginPage.Execute();
                }
                Console.ReadLine();
                

            }
        }
    }
}