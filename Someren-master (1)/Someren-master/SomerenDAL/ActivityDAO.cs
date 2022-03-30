using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class ActivityDAO : BaseDao
    {
        public List<Activity> GetAllSupervisorActivities()
        {

            string query = "SELECT ActivityNumber, SupervisorName, ActivityName FROM [ActivitySupervisors]";

            var sqlCommand = new SqlCommand(query);
            return ReadTables(ExecuteSelectQuery(sqlCommand));
        }

        public List<Activity> GetActivities()
        {

            string query = "SELECT ActivityID FROM [Activity]";

            var sqlCommand = new SqlCommand(query);
            return ReadTables1(ExecuteSelectQuery(sqlCommand));
        }


        private List<Activity> ReadTables(DataTable dataTable)
        {
            List<Activity> activities = new List<Activity>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Activity activity = new Activity()
                {
                    ActivityName = (dr["ActivityName"]).ToString(),
                    ActivityNumber = dr["ActivityNumber"].ToString(),
                    SupervisorName = dr["SupervisorName"].ToString()
                };
                activities.Add(activity);
            }
            return activities;
        }

        public void AddSupervisor(Activity activity)
        {
            SqlCommand command = new SqlCommand("UPDATE [ActivitySupervisors] SET SupervisorName = @SupervisorName WHERE ActivityNumber = @ActivityNumber", OpenConnection());
            command.Parameters.AddWithValue("@SupervisorName", activity.SupervisorName);
            command.Parameters.AddWithValue("@ActivityNumber", activity.ActivityNumber);
            command.ExecuteNonQuery();
        }

        public void DeleteSupervisor(Activity activity)
        {
            SqlCommand command = new SqlCommand("Update ActivitySupervisors SET SupervisorName = NULL WHERE SupervisorName = @SupervisorName AND ActivityNumber = @ActivityNumber;", OpenConnection());
            command.Parameters.AddWithValue("@SupervisorName", activity.SupervisorName);
            command.Parameters.AddWithValue("@ActivityNumber", activity.ActivityNumber);

            command.ExecuteNonQuery();
        }
        

        public void InsertIntoActivity(Activity activity)
        {
            SqlCommand command = new SqlCommand("INSERT INTO ActivitySupervisors(ActivityName) SELECT ActivityID FROM Activity WHERE ActivityID = @ActivityID;", OpenConnection());
            command.Parameters.AddWithValue("@ActivityID", activity.ActivityName);
            command.ExecuteNonQuery();
        }

        private List<Activity> ReadTables1(DataTable dataTable1)
        {
            List<Activity> activity1 = new List<Activity>();

            foreach (DataRow dr in dataTable1.Rows)
            {
                Activity activities1 = new Activity()
                {

                    ActivityName = (string)(dr["ActivityID"]),
                    ActiviyID = (string)(dr["ActivityID"])

                };
                activity1.Add(activities1);
            }
            return activity1;
        }


    }

}
