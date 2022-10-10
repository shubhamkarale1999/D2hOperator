using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Operations
{
    public class YearlyStatementOperations
    {
        private string _connectionString;

        public YearlyStatementOperations(string connectionString)
        {
            _connectionString = connectionString;
        }

        public static void Execute()
        {
            throw new NotImplementedException();
        }

        public List<YearlyStatement> GetStatement(string Username, string year)
        {
            List<YearlyStatement> yss = new List<YearlyStatement>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand($"EXECUTE [dbo].[usp_YerlyStatement] '{Username}','{year}'", connection);
                
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    YearlyStatement ys=new YearlyStatement();
                    ys.PaymentDate = (DateTime)reader[0];
                    ys.paidAmount = (int)reader[1];
                    ys.pendingAmount=(int)reader[2];

                    yss.Add(ys);
                }

                connection.Close();

            }

                return yss;
        }
    }
}
