using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class DrinkDAO : BaseDao
    {
        public List<Drink> GetAllDrinks()
        {

            string queryDrinks = "SELECT DrinkName, Price FROM [Drinks]";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(queryDrinks, sqlParameters));
        }

        private List<Drink> ReadTables(DataTable dataTable)
        {
            List<Drink> drink = new List<Drink>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Drink drinks = new Drink()
                {
                    drinkName = (string)dr["DrinkName"],
                    Price = (decimal)dr["Price"],
                }; 
                drink.Add(drinks);
            }
            return drink;
        }
    }
}
