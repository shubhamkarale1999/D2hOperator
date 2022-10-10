using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Operations
{
    public class CustomerDashboardOperations
    {
        private string _connectionString;
        public CustomerDashboardOperations(string connectionString)
        {
            _connectionString = connectionString;
        }

        
        public CustomerEntities GetCustomer(string Username)
        {
            
            CustomerEntities customer = new CustomerEntities();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand($"Execute [dbo].[usp_Customer_Dashboard]'{Username}'", connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                int cnt = 0;
                while (reader.Read())
                {
                    // CustomerEntities c = new CustomerEntities();


                    customer.Name = (string)reader[0];

                    customer.PackageName = (string)reader[1];

                    cnt++;



                }
                if(cnt==0)
                {
                    Console.WriteLine("Wrong Credintials");
                }

                connection.Close();
            }

            return customer;
        }
        public  Customer GetCustomerDetails(string Username)
        {
            Customer cust = new Customer();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand($"Execute [dbo].[usp_GetCustomerInfo] '{Username}'", connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //Customer c= new Customer();
                    cust.CustomerId = (int)reader[0];
                    cust.CustomerFirstName = (string)reader[1];
                    cust.CustomerLastName = (string)reader[2];
                    cust.CustomerCity = (string)reader[3];
                    cust.CustomerQuery = (string)reader[4];
                    cust.PaymentDate = (DateTime)reader[5];
                    cust.PackageId = (int)reader[6];
                    cust.CustomerStetus = (int)reader[7];
                    cust.CustomerContact = (string)reader[8];
                    cust.Username = (string)reader[9];
                    cust.Password = (string)reader[10];
                }
               
            }

            return cust;

        }
    }
}
    

