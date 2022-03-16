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
    public class RevenueDao : BaseDao
    {
        public List<Revenue> GetPrice()
        {

            string query = $"SELECT [Student] FROM [CashRegister] WHERE [date] BETWEEN ";



            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Revenue> ReadTables(DataTable dataTable)
        {
            List<Revenue> revenue = new List<Revenue>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Revenue revenues = new Revenue()
                {
                    price = (int)dr["Price"],
                    turnover = (int)dr["turnover"],
                    customers = (bool)dr["Student"]


                };
                revenue.Add(revenues);
            }
            return revenue;
        }
    }
}
