using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;
using SomerenDAL;

namespace SomerenLogic
{
    public class CashRegisterService
    {
        CashRegisterDAO cashRegisterDAO;

        public CashRegisterService()
        {
            cashRegisterDAO = new CashRegisterDAO();
        }
        public void AddCashRegister(string drinks, string students, string price, string date)
        {
            cashRegisterDAO.AddCashRegister(drinks ,students, price, date);
        }
    }
}
