using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Operations
{
    public class AddNewCustomerOperation
    {
        private string _connectionString;
        public AddNewCustomerOperation(string connectionString)
        {
            _connectionString = connectionString;
        }
        public Boolean AddNewCust(string firstName, string lastName, string customerCity, int packageId, string contact, string username, string password, int gropId)
        {

            Boolean result = false;
            int cnt=0;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand($"EXECUTE [dbo].[usp_AddNewCustomer] '{firstName}','{lastName}','{customerCity}',{packageId},'{contact}','{username}','{password}',{gropId}", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    cnt++;
                }
                if(cnt>0)
                {
                    result = true;
                }
                else
                {
                    result =false;
                }
            }
                return result;
        }
    }
}
