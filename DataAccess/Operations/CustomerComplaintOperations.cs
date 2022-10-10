using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Operations
{
    public class CustomerComplaintOperations
    {

        private string _connectionString;
        public CustomerComplaintOperations(string connectionString)
        {
            _connectionString = connectionString;
        }
        public Boolean AddComplaint(string CustComplaint,int CustomerId)
        {
            bool result = false;
            int cnt = 0;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand($"EXECUTE [dbo].[usp_AddComplaintinto] '{CustComplaint}',{CustomerId}", connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                //  SqlCommandReader reader = command.ExecuteReader();

                //DataSet ds = new DataSet();

                // adapter.Fill(ds, CustComplaint);
                // adapter.Fill(ds, CustomerId);
                // adapter.Fill(ds, CustomerId);
                while (reader.Read())
                {
                    cnt++;
                }
                connection.Close();
            }
            if(cnt>0)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
            
            
        }
        
    }
}
