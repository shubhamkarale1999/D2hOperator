using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Operations
{
    public class AgentInformationOperation
    {
        private string connectionString;

        public AgentInformationOperation(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public List<AgentEntites> GetAgentInformation()
        {
            List<AgentEntites> agentEntites = new List<AgentEntites>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand command = new SqlCommand($"EXECUTE [dbo].[usp_GetAgentInformation]", connection);

                connection.Open();


                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    AgentEntites agent=new AgentEntites();

                    agent.AgentId = (int)reader[0];
                    agent.FirstName = reader[1] != null ? reader[1].ToString() : "";
                    agent.LastName = reader[2] != null ? reader[2].ToString() : "";
                    agent.ContactName = reader.IsDBNull(3) ? (int?)null : reader.GetInt32(3);
                    agent.Address = reader[4] != null ? reader[4].ToString() : "";

                    agentEntites.Add(agent);

                    // c.payment_date = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4);
                    //  c.month_= reader[3] != null ? reader[3].ToString() : "";
                }

                connection.Close();
            }
            return agentEntites;
        }
    }
}
