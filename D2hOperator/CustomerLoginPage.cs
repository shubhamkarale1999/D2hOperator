using DataAccess.Entities;
using DataAccess.Operations;
using System;

namespace D2hOperator
{
    internal class CustomerLoginPage
    {
        private static string connectionString = @"Data Source=DESKTOP-HA16J39;Initial Catalog=CableSystemManagement;Integrated Security=True";

        private static CustomerDashboardOperations customerDashboard = new CustomerDashboardOperations(connectionString);

        internal static void Execute(string Username)
        {
        repete:
            CustomerEntities c = customerDashboard.GetCustomer(Username);
            Console.WriteLine("Welcome {0}", c.Name);
            Console.WriteLine("Your Package Name is {0}", c.PackageName);
            Console.WriteLine("=============================");
            Console.WriteLine("1. Get My Infomation \r\n2. Get Yearly Statement\r\n3. Raise a Complaint\r\n4. Get Agent Information\r\n5. Logout");
            Console.WriteLine("=============================");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        CustomerInformation.Execute(Username);
                        goto repete;
                    }
                    break;
                case 2:
                    {

                        GetYearlyStatement.Execute(Username);
                        goto repete;
                    }
                    break;
                case 3:
                    {
                        RiseYourComplaint.Execute(Username);
                        goto repete;

                    }
                    break;
                case 4:
                    {
                        GetAgentInformation.Execute();
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