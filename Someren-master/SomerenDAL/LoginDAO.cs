using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class LoginDAO : BaseDao
    {
        public List<Login> GetAllPasswords()
        {
            string query = "SELECT username, password FROM login";
            var sqlCommand = new SqlCommand(query);

            return ReadTables(ExecuteSelectQuery(sqlCommand));
        }

        private List<Login> ReadTables(DataTable dataTable)
        {
            List<Login> login = new List<Login>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Login logins = new Login()
                {
                    userName = (string)dr["username"],
                    passWord = (string)dr["password"]
                };
                login.Add(logins);
            }
            return login;
        }
    }
}
