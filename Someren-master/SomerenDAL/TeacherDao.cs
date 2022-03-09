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
    public class TeacherDao : BaseDao
    {
        public List<Teacher> GetAllTeachers()
        {
            string query = "SELECT TeacherID, Firstname FROM [Teachers]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Teacher> ReadTables(DataTable datatable)
        {
            List<Teacher> teachers = new List<Teacher>();
            foreach (DataRow dr in datatable.Rows)
            {
                Teacher teacher = new Teacher()
                {
                    Number = (int)dr["TeacherID"],
                    Name = (string)(dr["FirstName"].ToString())
                };
                teachers.Add(teacher);
            }
            return teachers;

        }


    }
}