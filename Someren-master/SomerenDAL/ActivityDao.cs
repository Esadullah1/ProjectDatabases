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
        public List<Activity> GetAllActivites()
        {

            string query = "SELECT ActivityID, SupervisorName FROM [ActivitySupervisors]";

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
                    ActivityID = (int)dr["ActivityID"],
                    SupervisorName = dr["SupervisorName"].ToString()
                };
                activities.Add(activity);
            }
            return activities;
        }

        public void AddSupervisor(Activity activity)
        {
            SqlCommand command = new SqlCommand("UPDATE [ActivitySupervisors] SET SupervisorName = @SupervisorName WHERE ActivityID = @ActivityID", OpenConnection());
            command.Parameters.AddWithValue("@SupervisorName", activity.SupervisorName);
            command.Parameters.AddWithValue("@ActivityID", activity.ActivityID);
            command.ExecuteNonQuery();
        }

        public void DeleteSupervisor(Activity activity)
        {
            SqlCommand command = new SqlCommand("Update ActivitySupervisors SET SupervisorName = NULL WHERE SupervisorName = @SupervisorName AND ActivityID = @ActivityID;", OpenConnection());
            command.Parameters.AddWithValue("@SupervisorName", activity.SupervisorName);
            command.Parameters.AddWithValue("@ActivityID", activity.ActivityID);

            command.ExecuteNonQuery();



        }
    }
}
