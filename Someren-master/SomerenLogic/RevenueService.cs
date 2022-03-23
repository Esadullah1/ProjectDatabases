using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class RevenueService
    {
        RevenueDao revenuedb;

        public RevenueService()
        {
            revenuedb = new RevenueDao();
        }

        public List<Revenue> GetPrice()
        {
            List<Revenue> revenues = revenuedb.GetAllPrice();
            return revenues;
        }

        public List<studentrev> GetStudentNames()
        {
            List<studentrev> revenues = revenuedb.GetAllStudentNames();
            return revenues;
        }

        public List<sumrev> GetSum()
        {
            List<sumrev> revenues = revenuedb.GetAllSum();
            return revenues;
        }



    }
}
