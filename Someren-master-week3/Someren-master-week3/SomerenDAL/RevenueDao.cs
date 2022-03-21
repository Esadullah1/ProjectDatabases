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
        public List<Revenue> GetAllPrice()
        {

            string query = "SELECT drink, COUNT(student) AS TotalBought FROM CashRegister GROUP BY drink";



            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<studentrev> GetAllStudentNames()
        {

            string query = "SELECT DISTINCT student FROM CashRegister";



            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables1(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<sumrev> GetAllSum()
        {

            string query = "SELECT SUM(price) AS TotalSum FROM CashRegister";



            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables2(ExecuteSelectQuery(query, sqlParameters));
        }




        private List<Revenue> ReadTables(DataTable dataTable)
        {
            List<Revenue> revenues = new List<Revenue>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Revenue revenue = new Revenue()
                {

                    student = (int)dr["TotalBought"],
                    drink = (string)dr["drink"]
                    

                };
                revenues.Add(revenue);
            }
            return revenues;


        }

        private List<studentrev> ReadTables1(DataTable dataTable)
        {
            List<studentrev> revenues = new List<studentrev>();

            foreach (DataRow dr in dataTable.Rows)
            {
                studentrev revenue = new studentrev()
                {

                    student1 = (string)dr["student"],
                    


                };
                revenues.Add(revenue);
            }
            return revenues;

        }

        private List<sumrev> ReadTables2(DataTable dataTable)
        {
            List<sumrev> revenues = new List<sumrev>();

            foreach (DataRow dr in dataTable.Rows)
            {
                sumrev revenue = new sumrev()
                {

                    price1 = (decimal)dr["TotalSum"],



                };
                revenues.Add(revenue);
            }
            return revenues;

        }

    }
}
