using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Operations
{
    public  class PasswordValidation
    {
        private string _connectionString;

        public PasswordValidation(string connectionString)
        {
            this._connectionString = connectionString;
        }

        public Boolean MyValidation(string username,string password)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                
                SqlCommand cmd = new SqlCommand($"EXECUTE [dbo].[usp_CheckUsernamePassword] '{username}','{password}'");
                cmd.Connection = con;
                con.Open();

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                con.Close();

                bool loginSuccessful = ((ds.Tables.Count > 0) && (ds.Tables[0].Rows.Count > 0));

                if (loginSuccessful)
                {
                    return true;
                }

            }
            return false;
        }
    }
}
