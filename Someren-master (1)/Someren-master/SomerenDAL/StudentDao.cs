﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class StudentDao : BaseDao
    {      
        public List<Student> GetAllStudents()
        {
 
            string query = "SELECT StudentID, FirstName, DateOfBirth FROM [Students]";
            var sqlCommand = new SqlCommand(query);
            return ReadTables(ExecuteSelectQuery(sqlCommand));
        }

        private List<Student> ReadTables(DataTable dataTable)
        {
            List<Student> students = new List<Student>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Student student = new Student()
                {
                    studentID = (int)dr["StudentID"],
                    studentName = (string)(dr["FirstName"].ToString()),
                    DateOfBirth = (DateTime)dr["DateOfBirth"]
                };
                students.Add(student);
            }
            return students;
        }
    }
}