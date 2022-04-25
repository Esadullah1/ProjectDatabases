using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class ActivityStudentsDAO : BaseDao
    {
        public List<ActivityStudents> GetAllActivityStudents()
        {

            string query = $"SELECT StudentID, ActivityID FROM [ActivityStudents] JOIN Students on ActivityStudents.StudentID = Students.StudentID";
            var sqlCommand = new SqlCommand(query);
            return ReadTables(ExecuteSelectQuery(sqlCommand));
        }

        private List<ActivityStudents> ReadTables(DataTable dataTable)
        {
            List<ActivityStudents> activityStudent = new List<ActivityStudents>();

            foreach (DataRow dr in dataTable.Rows)
            {
                ActivityStudents activityStudents = new ActivityStudents()
                {
                    StudentID = (int)dr["StudentID"]
                };
                activityStudent.Add(activityStudents);
            }
            return activityStudent;
        }
        public List<ActivityStudents> selectActivities(ActivityAdd activity)
        {
            SqlCommand command = new SqlCommand("SELECT [StudentID] FROM Students WHERE StudentID IN(SELECT StudentID FROM ActivityStudents WHERE ActivityID = @ActivityID)", OpenConnection());
            command.Parameters.AddWithValue("@ActivityID", activity.ActiviyID);
            command.ExecuteNonQuery();
            return ReadTables(ExecuteSelectQuery(command));
        }
    }
}
