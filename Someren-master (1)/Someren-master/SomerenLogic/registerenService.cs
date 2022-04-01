using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;
using SomerenDAL;
using System.Security.Cryptography;

namespace SomerenLogic
{
    public class registerenService
    {
        RegistrerenDao registrerendb;

        public registerenService()
        {
            registrerendb = new RegistrerenDao();
        }
                
        public void Addregistreren(string username, string password, string hashed)
        {
            PasswordWithSaltHasher pwHasher = new PasswordWithSaltHasher();
            HashWithSaltResult hashResultSha256 = pwHasher.HashWithSalt("", 64, SHA256.Create());
            registrerendb.Addregistreren(username, password, hashed);
        }
    }
}
