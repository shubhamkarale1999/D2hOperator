using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Operations
{
    public class ComplaintResolutionOperation
    {
        private string _connectionString;

        public ComplaintResolutionOperation(string connectionString)
        {
            this._connectionString = connectionString;
        }
        public Boolean ResolveAComplaint(int customerId, string custComplaintDesc, int complaintResolutionAmount, int custComplaintType, int agentId)
        {
            bool result = false;
            int cnt=0;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand($"EXECUTE [dbo].[usp_ResolveAComplaint] '{custComplaintDesc}',{complaintResolutionAmount},{custComplaintType},{agentId}", connection);


                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cnt++;
                }
                if (cnt > 0)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
                return result;
        }
    }
}
