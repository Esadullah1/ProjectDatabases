using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;
using SomerenDAL;

namespace SomerenLogic
{
    public class ActivityService
    {
        ActivityDao activitydb;

        public ActivityService()
        {
            activitydb = new ActivityDao();
        }

        public List<Activity> GetActivity()
        {
            List<Activity> activity = activitydb.GetAllActivities();
            return activity;
        }
        public void AddActivities(string ActivityID, string Description, string StartDateTime, string EndDateTime, string ActivityNumber)
        {
            activitydb.AddActivities(ActivityID, Description, StartDateTime, EndDateTime, ActivityNumber);
        }

        public void DeleteActivity(Activity activity)
        {
            activitydb.DeleteActivity(activity);
        }
        public void UpdateActivityID(Activity activity)
        {
            activitydb.UpdateActivityID(activity);
        }
        public void UpdateDescription(Activity activity)
        {
            activitydb.UpdateDescription(activity);
        }
    }


}

