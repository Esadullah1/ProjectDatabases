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
    public class ActivityService
    {
        ActivityDAO activityDb;

        public ActivityService()
        {
            activityDb = new ActivityDAO();
        }



        public List<Activity> GetActivitiesSupervisors()
        {
            List<Activity> activities = activityDb.GetAllSupervisorActivities();
            return activities;
        }

        public List<Activity> GetAllActivities()
        {
            List<Activity> activities = activityDb.GetActivities();
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
