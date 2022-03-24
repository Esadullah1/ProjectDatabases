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
    public class ActivityDao : BaseDao
    {

        public List<Activity> GetAllActivities()
        {

            string query = "SELECT ActivityID FROM [Activity]";



            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables1(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Activity> GetAllSupervisorActivities()
        {

            string query = "SELECT ActivityNumber, SupervisorName, ActivityName FROM [ActivitySupervisors]";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
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



                };
                activity1.Add(activities1);
            }
            return activity1;
        }

    }
}
