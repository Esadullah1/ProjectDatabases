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

            string query = "SELECT DrinkName, Price, Alcoholic, Stock, Voucher FROM [Drinks] WHERE Stock > 1 AND Price > 1 ORDER BY Stock";



            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
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
                    Voucher = (bool)dr["Voucher"]

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
            SqlCommand command = new SqlCommand ("UPDATE Drinks SET DrinkName = @DrinkName", OpenConnection());
            command.Parameters.AddWithValue("@DrinkName", drink.DrinkName);
            command.ExecuteNonQuery();

        }
    }
}
