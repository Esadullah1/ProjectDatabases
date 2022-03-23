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
        ActivityDAO ActivityDao;

        public ActivityService()
        {
            ActivityDao = new ActivityDAO();
        }
        public List<Activity> GetActivity()
        {
            List<Activity> activity = ActivityDao.GetAllActivities();
            return activity;
        }

    }
}
