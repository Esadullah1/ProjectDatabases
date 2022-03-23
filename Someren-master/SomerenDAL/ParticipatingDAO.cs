using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class ParticipatingDAO : BaseDao
    {
        public List<Participating> GetAllParticipaters()
        {
            string query = "SELECT FirstName FROM Students WHERE Students.StudentID NOT IN(SELECT StudentID FROM ActivityStudent)";
            var sqlCommand = new SqlCommand(query);           
            return ReadTables(ExecuteSelectQuery(sqlCommand));
        }

        private List<Participating> ReadTables(DataTable dataTable)
        {
            List<Participating> Participating = new List<Participating>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Participating Participate = new Participating()
                {
                    NotParticipatingStudents = (string)dr["FirstName"]
                };
                Participating.Add(Participate);
            }
            return Participating;
        }
    }
}
