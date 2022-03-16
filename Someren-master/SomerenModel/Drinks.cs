using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Drinks
    {

    
   
        public string DrinkName { get; set; } // RoomNumber, e.g. 206
        public decimal Price { get; set; } // number of beds, either 4,6,8,12 or 16
        public bool Alcoholic { get; set; } // student = false, teacher = true
        public int Stock { get; set; }
        public bool Voucher { get; set; }

      
    }
}
