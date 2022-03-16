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
    class RevenueService
    {
        RevenueDao revenuedb;

        public RevenueService()
        {
            revenuedb = new RevenueDao();
        }

        public List<Revenue> GetRevenue()
        {
            List<Revenue> revenue = revenuedb.GetPrice();
            return revenue;
        }
    }
}
