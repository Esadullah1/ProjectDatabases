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

            string query = $"SELECT FirstName, ActivityID FROM [ActivityStudent] JOIN Students on ActivityStudent.StudentID = Students.StudentID";
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

                    StudentFirstName = (string)dr["FirstName"],
                    //ActiviyId = (string)dr["ActivityID"]

                };
                activityStudent.Add(activityStudents);
            }
            return activityStudent;
        }
        public List<ActivityStudents> selectActivities(Activity activity)
        {
            SqlCommand command = new SqlCommand("SELECT [FirstName] FROM Students WHERE StudentID IN(SELECT StudentID FROM ActivityStudent WHERE ActivityID = @ActivityID)", OpenConnection());
            command.Parameters.AddWithValue("@ActivityID", activity.ActiviyID);
            command.ExecuteNonQuery();
            return ReadTables(ExecuteSelectQuery(command));
        }
    }
}
