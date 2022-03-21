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

            string query = "SELECT ActivityID, Description, StartDateTime, EndDateTime FROM  [Activity]";



            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Activity> ReadTables(DataTable dataTable)
        {
            List<Activity> activity = new List<Activity>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Activity activities = new Activity()
                {

                    ActivityID = (string)(dr["ActivityID"]),
                    Description = (string)dr["Description"],
                    StartDateTime = (string)dr["StartDateTime"],
                    EndDateTime = (string)dr["EndDateTime"]
                    

                };
                activity.Add(activities);
            }
            return activity;
        }
    }
}
