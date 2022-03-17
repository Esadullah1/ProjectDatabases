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
    public class DrinksService
    {
        DrinksDao drinkdb;
        

        public DrinksService()
        {
            drinkdb = new DrinksDao();
        }

        public List<Drinks> GetDrinks()
        {
            List<Drinks> drink = drinkdb.GetAllDrinks();
            return drink;
        }

        public void DeleteDrink(Drinks drink)
        {
            drinkdb.DeleteDrink(drink);
        }

        public void UpdateDrink(Drinks drink)
        { 
            drinkdb.UpdateDrink(drink);
        }

        public void UpdateDrinkStock(Drinks drink)
        {
            drinkdb.UpdateDrinkStock(drink);
        }
    }
}
