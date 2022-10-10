using DataAccess.Entities;
using DataAccess.Operations;
using System;

namespace D2hOperator
{
    public class CustomerInformation
    {
        private static string connectionString = @"Data Source=DESKTOP-HA16J39;Initial Catalog=CableSystemManagement;Integrated Security=True";

        private static CustomerDashboardOperations customerDashboard = new CustomerDashboardOperations(connectionString);
        public static void Execute(string Username)
        {
            Customer cd = customerDashboard.GetCustomerDetails(Username);
            Console.WriteLine("Customer Id          {0}", cd.CustomerId);
            Console.WriteLine("CustomerFirstName    {0}", cd.CustomerFirstName);
            Console.WriteLine("CustomerLastName     {0}", cd.CustomerLastName);
            Console.WriteLine("CustomerCity         {0}", cd.CustomerCity);
            Console.WriteLine("CustomerQuery        {0}", cd.CustomerQuery);
            Console.WriteLine("PaymentDate          {0}", cd.PaymentDate);
            Console.WriteLine("PackageId            {0}", cd.PackageId);
            Console.WriteLine("CustomerStetus       {0}", cd.CustomerStetus);
            Console.WriteLine("CustomerContact      {0}", cd.CustomerContact);
            Console.WriteLine("Username             {0}", cd.Username);
            Console.WriteLine("Password             {0}", cd.Password);
            Console.ReadLine();
           // LoginPage.Execute();
        }
        
    }
}