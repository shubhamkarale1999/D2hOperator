using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Operations
{
    public class GetTodaysComplaintsOperation
    {
        private string _connectionString;

        public GetTodaysComplaintsOperation(string connectionString)
        {
            this._connectionString = connectionString;
        }
        public List<CustomerComplaint> GetCustomerComplaint()
        {

           List<CustomerComplaint> complaintsList = new List<CustomerComplaint>();

                using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand($"Execute [dbo].[usp_GetTodaysComplaint]", connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {

                    CustomerComplaint custComplaint = new CustomerComplaint();

                    custComplaint.CustomerId = (int)reader[0];

                    custComplaint.ComplaintDescription = (string)reader[1];

                    custComplaint.CustomerFirstName=(string)reader[2];

                    custComplaint.CustomerLastName=(string)reader[3];

                    custComplaint.CustomerCity = (string)reader[4];

                    custComplaint.CustomerContact = (string)reader[5];


                    complaintsList.Add(custComplaint);

                }
               

                connection.Close();
            }

            return complaintsList;
        }
    }
}
