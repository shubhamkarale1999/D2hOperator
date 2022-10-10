using DataAccess.Entities;
using DataAccess.Operations;
using System;

namespace D2hOperator
{
    internal class RiseYourComplaint
    {

        private static string connectionString = @"Data Source=DESKTOP-HA16J39;Initial Catalog=CableSystemManagement;Integrated Security=True";

        private static CustomerDashboardOperations customerDashboard = new CustomerDashboardOperations(connectionString);

        private static CustomerComplaintOperations CustomerComplaint = new CustomerComplaintOperations(connectionString);


        internal static void Execute(string Username)
        {
            Console.WriteLine("Rise Your Complaint here");
            string CustComplaint = Console.ReadLine();
            Customer cm = customerDashboard.GetCustomerDetails(Username);
            int CustomerId = cm.CustomerId;
            Console.WriteLine(CustomerId);
            bool isAdded = CustomerComplaint.AddComplaint(CustComplaint, CustomerId);
            if (isAdded)
            {
                Console.WriteLine("Complaint Added Successfully");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Something Went Wrong Shubham");
                Console.ReadLine();
            }
            LoginPage.Execute();
        }
    }
}