using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;
using SomerenDAL;
using System.Data.SqlClient;
using System.Configuration;

namespace SomerenLogic
{
    public class ActivityAddService
    {

        ActivityAddDAO activitydb;

        public ActivityAddService()
        {
            activitydb = new ActivityAddDAO();
        }

        public List<ActivityAdd> GetActivity()
        {
            List<ActivityAdd> activity = activitydb.GetAllActivities();
            return activity;
        }
        public void AddActivities(string ActivityID, string Description, string StartDateTime, string EndDateTime, string ActivityNumber)
        {
            activitydb.AddActivities(ActivityID, Description, StartDateTime, EndDateTime, ActivityNumber);
        }

        public void DeleteActivity(ActivityAdd activity)
        {
            activitydb.DeleteActivity(activity);
        }
        public void UpdateActivityID(ActivityAdd activity)
        {
            activitydb.UpdateActivityID(activity);
        }
        public void UpdateDescription(ActivityAdd activity)
        {
            activitydb.UpdateDescription(activity);
        }
    }
}
