using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;

namespace DataAccess.Operations
{
    public class ComplaintResolutionReportOperations
    {
        List<ComplaintResolutionReportEntities> ComplaintResolutionReportEntities = new List<ComplaintResolutionReportEntities>();
        private string _connectionString;

        public ComplaintResolutionReportOperations(string connectionString)
        {
            this._connectionString = connectionString;
        }
        public List<ComplaintResolutionReportEntities> GetComplaintResolutionReport()
        {
            List<ComplaintResolutionReportEntities> CustComplaintReport= new List<ComplaintResolutionReportEntities>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                SqlCommand command = new SqlCommand($"EXECUTE [dbo].[usp_GetComplaintResolutionReport]", connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    ComplaintResolutionReportEntities ReportEntity = new ComplaintResolutionReportEntities();

                    ReportEntity.ResolutionId = (int)reader[0];

                    ReportEntity.ResolutionDescription = (string)reader[1];

                    ReportEntity.ResolutionAmount=(int) reader[2];

                    ReportEntity.ComplaintType = (string)reader[3];

                    ReportEntity.AgentFirstName = (string)reader[4];

                    ReportEntity.AgentLastName = (string)reader[5];

                    ReportEntity.AgentContact=reader[6] !=null ? reader[6].ToString() : "";  

                    //       agent.FirstName = reader[1] != null ? reader[1].ToString() : "";
                    CustComplaintReport.Add(ReportEntity);


                }
            }
            return CustComplaintReport;
        }
    }
}
