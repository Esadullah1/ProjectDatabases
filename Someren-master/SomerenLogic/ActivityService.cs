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

      
            ActivityDao activityDb;

            public ActivityService()
            {
                activityDb = new ActivityDao();
            }

            public List<Activity> GetActivities()
            {
                List<Activity> activities = activityDb.GetAllActivites();
                return activities;
            }
        
    }
}
