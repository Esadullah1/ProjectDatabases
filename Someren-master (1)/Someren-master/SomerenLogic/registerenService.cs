using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;
using SomerenDAL;

namespace SomerenLogic
{
    public class registerenService
    {
        RegistrerenDao registrerendb;

        public registerenService()
        {
            registrerendb = new RegistrerenDao();
        }
                
        public void AddActivities(string username, string password)
        {
            registrerendb.Addregistreren(username, password);
        }
    }
}
