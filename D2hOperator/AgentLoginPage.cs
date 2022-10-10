using System;

namespace D2hOperator
{
    internal class AgentLoginPage
    {
        internal static void Execute(string username)
        {
            repete:
            Console.WriteLine("Wel-Come To AgentLogin");
            Console.WriteLine("============Agent Login============");
            Console.WriteLine("Please Choose Correct Option");
            Console.WriteLine("1. Add a new customer\r\n2. Get Todays Complaints\r\n3. Complaint Resolution Report\r\n4. Resolve a complaint\r\n5. Logout");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    {
                        AddNewCustomer.Execute();
                        goto repete;
                    }
                    break;
                case 2:
                    {
                        GetTodaysComplaint.Execute();
                        goto repete;
                    }
                    break;
                case 3:
                    {
                        ComplaintResolution.Execute();
                        goto repete;
                    }
                    break;
                case 4:
                    {
                        ResolveComplaint.Execute(username);
                        goto repete;

                    }
                    break;
                case 5:
                    {
                        LoginPage.Execute();
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Please Choose Correct Option");
                    }
                    break;
            }
        }
    }
}