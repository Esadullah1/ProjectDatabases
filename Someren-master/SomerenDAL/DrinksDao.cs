using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;

namespace SomerenDAL
{
    public class DrinksDao : BaseDao
    {
        public List<Drinks> GetAllDrinks()
        {

            string query = "SELECT DrinkName, Price, Alcoholic, Stock, Voucher, DrinkID FROM  [Drinks] WHERE DrinkID NOT IN (SELECT DrinkID FROM Drinks WHERE DrinkID IN (4, 5, 6)) AND Stock > 1 AND Price > 1 ORDER BY Stock ";
            var sqlCommand = new SqlCommand(query);
            return ReadTables(ExecuteSelectQuery(sqlCommand));
        }

        private List<Drinks> ReadTables(DataTable dataTable)
        {
            List<Drinks> drink = new List<Drinks>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Drinks drinks = new Drinks()
                {
                  
                    DrinkName = (string)(dr["DrinkName"].ToString()),
                    Price = (decimal)dr["Price"],
                    Alcoholic = (bool)dr["Alcoholic"],
                    Stock = (int)dr["Stock"],
                    Voucher = (bool)dr["Voucher"],
                    DrinkID = (int)dr["DrinkID"]

                };
                drink.Add(drinks);
            }
            return drink;
        }


        public void DeleteDrink(Drinks drink)
        {
            SqlCommand command = new SqlCommand ("DELETE FROM [Drinks] WHERE DrinkName = @DrinkName", OpenConnection());
            command.Parameters.AddWithValue("@DrinkName", drink.DrinkName);
            command.ExecuteNonQuery();
            

            
        }

        public void UpdateDrink(Drinks drink)
        {
            SqlCommand command = new SqlCommand("UPDATE [Drinks] SET DrinkName = @DrinkName WHERE DrinkID = @DrinkID", OpenConnection());
            command.Parameters.AddWithValue("@DrinkName", drink.DrinkName);
            command.Parameters.AddWithValue("@DrinkID",drink.DrinkID);
            command.ExecuteNonQuery();





        }

        public void UpdateDrinkStock(Drinks drink)
        {
            SqlCommand command = new SqlCommand("UPDATE [Drinks] SET Stock = @Stock WHERE DrinkID = @DrinkID", OpenConnection());
            command.Parameters.AddWithValue("@Stock", drink.Stock);
            command.Parameters.AddWithValue("@DrinkID", drink.DrinkID);
            command.ExecuteNonQuery();





        }
    }
}
