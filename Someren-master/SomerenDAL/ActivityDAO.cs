using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class ActivityDAO : BaseDao
    {
        public List<Activity> GetAllActivities()
        {

            string query = "SELECT ActivityID, Description, StartDateTime, EndDateTime FROM  [Activity]";

            var sqlCommand = new SqlCommand(query);
            return ReadTables(ExecuteSelectQuery(sqlCommand));
        }

        private List<Activity> ReadTables(DataTable dataTable)
        {
            List<Activity> activity = new List<Activity>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Activity activities = new Activity()
                {

                    ActiviyID = (string)(dr["ActivityID"]),
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
