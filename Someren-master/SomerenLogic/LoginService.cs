using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;
using SomerenDAL;

namespace SomerenLogic
{
    public class LoginService
    {
        LoginDAO loginDAO;

        public LoginService()
        {
            loginDAO = new LoginDAO();
        }
        public List<Login> GetAllPasswords()
        {
            return loginDAO.GetAllPasswords();

        }
    }
}
