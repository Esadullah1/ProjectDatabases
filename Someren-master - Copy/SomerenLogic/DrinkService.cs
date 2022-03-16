using System;
using System.Collections.Generic;
using SomerenDAL;
using SomerenModel;

namespace SomerenLogic
{
    public class DrinkService
    {
        DrinkDAO drinkdb;
            
        public DrinkService()
        {
            drinkdb = new DrinkDAO();
        }

        public List<Drink> GetDrink()
        {
            List<Drink> drink = drinkdb.GetAllDrinks();
            return drink;
        }
    }
}
