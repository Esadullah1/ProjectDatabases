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
    public class ActivityStudentService
    {
         ActivityStudentsDAO activityStudentsDAO;

        public ActivityStudentService()
        {
            activityStudentsDAO = new ActivityStudentsDAO();
        }
        public List<ActivityStudents> GetActivityStudents()
        {
            return activityStudentsDAO.GetAllActivityStudents();
            
        }
        public List<ActivityStudents> SelectActivities(Activity activity)
        {
           return activityStudentsDAO.selectActivities(activity);
        }
    }
}
