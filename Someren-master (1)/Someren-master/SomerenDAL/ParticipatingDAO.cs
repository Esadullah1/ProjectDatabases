using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using SomerenModel;
using System.Windows.Forms;

namespace SomerenDAL
{
    public class ParticipatingDAO : BaseDao
    {
        public List<Participating> GetAllParticipaters()
        {
            string query = "SELECT StudentID FROM Students WHERE Students.StudentID NOT IN(SELECT StudentID FROM ActivityStudents)";
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
                    NotParticipatingStudents = (int)dr["StudentID"]
                };
                Participating.Add(Participate);
            }
            return Participating;
        }
        public void AddParticipant(int student, string activity)
        {
            SqlCommand command = new SqlCommand(
                "INSERT INTO ActivityStudents " +
                $"VALUES (@StudentID, @ActivityID)",
                OpenConnection());
            command.Parameters.AddWithValue("@StudentID", student);
            command.Parameters.AddWithValue("@ActivityID", activity);
            command.ExecuteNonQuery();
        }
        public void RemoveParticipant(int student, string activity)
        {
            SqlCommand command = new SqlCommand(
                "DELETE FROM ActivityStudents " +
                "WHERE ActivityID = @ActivityID " +
                "AND ActivityStudents.StudentID = @StudentID",
                OpenConnection());
            command.Parameters.AddWithValue("@StudentID", student);
            command.Parameters.AddWithValue("@ActivityID", activity);
            command.ExecuteNonQuery();

        }
    }
}
