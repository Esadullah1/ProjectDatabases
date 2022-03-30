using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class RegistrerenDao : BaseDao
    {
        private SqlConnection dbConnection;

        public RegistrerenDao()
        {
            string conn = ConfigurationManager.ConnectionStrings["2122_INF1b_db5"].ConnectionString;
            dbConnection = new SqlConnection(conn);
        }
        public void Addregistreren(string username, string password)
        {
            dbConnection.Open();
            SqlCommand command = new SqlCommand(
                "INSERT INTO login (username, password)" +
                "VALUES (@username, @password);" +
                "SELECT SCOPE_IDENTITY();",
                dbConnection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
           
            command.ExecuteNonQuery();
            dbConnection.Close();
        }

        

    }
}
