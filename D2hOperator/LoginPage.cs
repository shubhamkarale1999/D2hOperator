using System;
using System.Linq.Expressions;

namespace D2hOperator
{
    internal class LoginPage
    {
        internal static void Execute()
        {
            try
            {
                repete:
                Console.WriteLine("===><WEL-COME to CableManagementSystem><===");
                Console.WriteLine("==(*)Login Page(*)==");
                Console.WriteLine("1. Customer Login");
                Console.WriteLine("2. Agent Login");
                Console.WriteLine("3. Exit");
                int num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        CustomerLogin.Execute();
                        break;
                    case 2:
                        AgentLogin.Execute();
                        break;
                    case 3:
                        {

                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Please Choose Correct Option");
                            goto repete;
                        }
                        break;
                }

            }
            catch
            {
                Console.WriteLine("Something Went Wrong");
                LoginPage.Execute();
            }
        }
        
    }
}