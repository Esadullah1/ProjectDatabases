using System;
using System.Data.SqlClient;
using System.Configuration;
using SomerenModel;

namespace SomerenDAL
{
    public class CashRegisterDAO : BaseDao
    {
        private SqlConnection dbConnection;

        public CashRegisterDAO()
        {
            string conn = ConfigurationManager.ConnectionStrings["2122_INF1b_db5"].ConnectionString;
            dbConnection = new SqlConnection(conn);
        }
        public void AddCashRegister(string drinks, string students, string price, string date)
        {
            dbConnection.Open();
            SqlCommand command = new SqlCommand(
                "INSERT INTO CashRegister (student, drink, price, date)" +
                "VALUES (@StudentName, @DrinkName, @price, @date);" +
                "SELECT SCOPE_IDENTITY();",
                dbConnection);
            command.Parameters.AddWithValue("@StudentName", students);
            command.Parameters.AddWithValue("@DrinkName", drinks);
            command.Parameters.AddWithValue("@price", Convert.ToDecimal(price));
            command.Parameters.AddWithValue("@date", date);
            command.ExecuteNonQuery();
            dbConnection.Close();
        }
    }
}
