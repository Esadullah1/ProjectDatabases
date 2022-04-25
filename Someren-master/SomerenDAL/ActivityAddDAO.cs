using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;
using System.Configuration;

namespace SomerenDAL
{
    public class ActivityAddDAO : BaseDao
    {

        private SqlConnection dbConnection;

        public ActivityAddDAO()
        {
            string conn = ConfigurationManager.ConnectionStrings["2122_INF1b_db5"].ConnectionString;
            dbConnection = new SqlConnection(conn);
        }
        public void AddActivities(string ActivityID, string Description, string StartDateTime, string EndDateTime, string ActivityNumber)
        {
            dbConnection.Open();
            SqlCommand command = new SqlCommand(
                "INSERT INTO Activity (ActivityID, Description, StartDateTime, EndDateTime, ActivityNumber)" +
                "VALUES (@ActivityID, @Description, @StartDateTime, @EndDateTime, @ActivityNumber);" +
                "SELECT SCOPE_IDENTITY();",
                dbConnection);
            command.Parameters.AddWithValue("@ActivityID", ActivityID);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@StartDateTime", StartDateTime);
            command.Parameters.AddWithValue("@EndDateTime", EndDateTime);
            command.Parameters.AddWithValue("@ActivityNumber", ActivityNumber.ToString());
            command.ExecuteNonQuery();
            dbConnection.Close();
        }



        public List<ActivityAdd> GetAllActivities()
        {

            string query = "SELECT ActivityID, Description, StartDateTime, EndDateTime, ActivityNumber FROM  [Activity]";



            var sqlCommand = new SqlCommand(query);
            return ReadTables(ExecuteSelectQuery(sqlCommand));
        }

        private List<ActivityAdd> ReadTables(DataTable dataTable)
        {
            List<ActivityAdd> activity = new List<ActivityAdd>();

            foreach (DataRow dr in dataTable.Rows)
            {
                ActivityAdd activities = new ActivityAdd()
                {

                    ActiviyID = (string)(dr["ActivityID"]),
                    Description = (string)dr["Description"],
                    StartDateTime = (string)dr["StartDateTime"],
                    EndDateTime = (string)dr["EndDateTime"],
                    ActivityNumber = (int)dr["ActivityNumber"]


                };
                activity.Add(activities);
            }
            return activity;
        }

        public void DeleteActivity(ActivityAdd activity)
        {
            SqlCommand command = new SqlCommand("DELETE FROM [Activity] WHERE ActivityID = @ActivityID", OpenConnection());
            command.Parameters.AddWithValue("@ActivityID", activity.ActiviyID);
            command.ExecuteNonQuery();



        }
        public void UpdateActivityID(ActivityAdd activity)
        {
            SqlCommand command = new SqlCommand("UPDATE [Activity] SET ActivityID = @ActivityID WHERE ActivityNumber = @ActivityNumber", OpenConnection());
            command.Parameters.AddWithValue("@ActivityID", activity.ActiviyID);
            command.Parameters.AddWithValue("@ActivityNumber", activity.ActivityNumber);
            command.ExecuteNonQuery();
        }

        public void UpdateDescription(ActivityAdd activity)
        {
            SqlCommand command = new SqlCommand("UPDATE [Activity] SET Description = @Description WHERE ActivityNumber = @ActivityNumber", OpenConnection());
            command.Parameters.AddWithValue("@Description", activity.Description);
            command.Parameters.AddWithValue("@ActivityNumber", activity.ActivityNumber);
            command.ExecuteNonQuery();
        }
    }
}
