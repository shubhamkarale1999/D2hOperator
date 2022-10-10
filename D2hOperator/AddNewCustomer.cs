using System;
using DataAccess.Operations;

namespace D2hOperator
{
    internal class AddNewCustomer
    {

        private static string _connectionString = @"Data Source=DESKTOP-HA16J39;Initial Catalog=CableSystemManagement;Integrated Security=True";

        private static AddNewCustomerOperation addNewCustomer =new AddNewCustomerOperation(_connectionString);
        private string connectionString;

        public AddNewCustomer(string connectionString)
        {
            this.connectionString = connectionString;
        }

        internal static void Execute()
        {
            try
            {
                Console.WriteLine("Please Enter Customer First Name");
                string FirstName = Console.ReadLine();
                Console.WriteLine("Enter Customer Last Name");
                string LastName = Console.ReadLine();
                Console.WriteLine("Enetr City");
                string CustomerCity = Console.ReadLine();
                Console.WriteLine("Choose Package \r\n1. Daimond\r\n2. Gold\r\n3. Silver");
                int PackageId = int.Parse(Console.ReadLine());
                Console.WriteLine("Please Enetr Customer Contact Details");
                string Contact = Console.ReadLine();
                Console.WriteLine("Enter Username");
                string Username = Console.ReadLine();
                Console.WriteLine("Enetr Password");
                string Password = Console.ReadLine();
                Console.WriteLine("Enter Group Of Customer \r\n1. Group A\r\n2. Group B\r\n3. Group C\r\n4. Group D\r\n5. Group E");
                int GropId = int.Parse(Console.ReadLine());


                bool isCustAdded = addNewCustomer.AddNewCust(FirstName, LastName, CustomerCity, PackageId, Contact, Username, Password, GropId);
                if (isCustAdded)
                {
                    Console.WriteLine("Customer Added Successfully");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Something Went Wrong- Sagar");
                    Console.ReadLine();
                }
            }
            catch
            {
                LoginPage.Execute();
            }

        }
    }
}