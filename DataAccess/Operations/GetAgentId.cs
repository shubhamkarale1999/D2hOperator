using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Operations
{
    public class GetAgentId
    {
        private string _connectionString;

        public GetAgentId(string connectionString)
        {
            this._connectionString = connectionString;
        }
        public GetAgentIdEntite MyGetAgentId(string username)
        {
            GetAgentIdEntite getId = new GetAgentIdEntite();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand($"Execute [dbo].[GetAgentId] '{username}'", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    getId.AgentId = (int)reader[0];
                }
                connection.Close();
            }

            return getId;
        }
    }
}
