using System;
using System.Collections.Generic;
using DataAccess.Entities;
using DataAccess.Operations;
using DataAccess.Operations;

namespace D2hOperator
{
    internal class GetTodaysComplaint
    {

        private static string connectionString = @"Data Source=DESKTOP-HA16J39;Initial Catalog=CableSystemManagement;Integrated Security=True";

        private static GetTodaysComplaintsOperation GetTodaysComplaintsOperation = new GetTodaysComplaintsOperation(connectionString);
        public static void Execute()
        {
            int cnt=0;
            Console.WriteLine("List Of Todays Complaints As Below");

            List<CustomerComplaint> customerComplaints = GetTodaysComplaintsOperation.GetCustomerComplaint();

            foreach(CustomerComplaint customerComplaint in customerComplaints)
            {
                Console.WriteLine("Customer Id      {0}",customerComplaint.CustomerId);
                Console.WriteLine("Complaint Descripyion    {0}",customerComplaint.ComplaintDescription);
                Console.WriteLine("Customer First Name      {0}",customerComplaint.CustomerFirstName);
                Console.WriteLine("Customer Last Name       {0}",customerComplaint.CustomerLastName);
                Console.WriteLine("Customer City            {0}",customerComplaint.CustomerCity);
                Console.WriteLine("Customer Contact         {0}",customerComplaint.CustomerContact);
                Console.WriteLine("--------------------------------------");
                cnt++;
            }
            if(cnt==0)
            {
                Console.WriteLine("There Is No Any Complaint For Today");
            }
            Console.ReadLine();

        }
    }
}