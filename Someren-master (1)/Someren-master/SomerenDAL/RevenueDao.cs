﻿using System;
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
        
    }
}