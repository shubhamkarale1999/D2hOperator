using DataAccess.Entities;
using DataAccess.Operations;
using System;
using System.Collections.Generic;

namespace D2hOperator
{
    internal class CustomerLogin
    {
        private static string connectionString = @"Data Source=DESKTOP-HA16J39;Initial Catalog=CableSystemManagement;Integrated Security=True";

        private static CustomerDashboardOperations customerDashboard = new CustomerDashboardOperations(connectionString);

        private static PasswordValidation PasswordValidation = new PasswordValidation(connectionString);


        internal static void Execute()
        {
            repete:
            Console.WriteLine("=======CUSTOMER LOGIN=====");
            Console.WriteLine("Enetr Username");
            string Username = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string Password = Console.ReadLine();
            bool isvalid = PasswordValidation.MyValidation(Username, Password);
            if (isvalid == true)
            {
                CustomerLoginPage.Execute(Username);
               
            }
            else
            {
                Console.WriteLine("Wrong Credintials");
                Console.WriteLine("Do you want to Continue yes/no");
                string result = Console.ReadLine();
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