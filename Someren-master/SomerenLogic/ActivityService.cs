using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenLogic
{
    public class ActivityService
    {


        ActivityDao activityDb;

        public ActivityService()
        {
            activityDb = new ActivityDao();
        }



        public List<Activity> GetActivitiesSupervisors()
        {
            List<Activity> activities = activityDb.GetAllSupervisorActivities();
            return activities;
        }
        
        public List<Activity> GetAllActivities()
        {
            List<Activity> activities = activityDb.GetAllActivities();
            return activities;
        }

        public void AddSupervisor(Activity activity)
        {
            activityDb.AddSupervisor(activity);
        }

        public void DeleteSupervisor(Activity activity)
        {
            activityDb.DeleteSupervisor(activity);
        }

        public void InsertIntoActivity(Activity activity)
        {
            activityDb.InsertIntoActivity(activity);
        }

    }
}
