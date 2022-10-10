using DataAccess.Entities;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccess.Operations
{
    public class CityOperations
    {
        private string _connectionString;
        public CityOperations(string connectionString)
        {
            _connectionString = connectionString;
        }
        public List<City> GetCities(string input)
        {
            List<City> cities = new List<City>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                SqlCommand command = new SqlCommand($"select c.[CityId],c.[CityName] from City as c where c.[CityName] like '{input}%'", connection);

                connection.Open();


                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    City c = new City();
                    c.CityId = (int)reader[0];
                    c.CityName = (string)reader[1];

                    cities.Add(c);

                }

                connection.Close();

            }

            return cities;
        }
    }
}
