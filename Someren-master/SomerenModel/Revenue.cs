using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Revenue
    {
        public string price { get; set; } // RoomNumber, e.g. 206
        
        public string drink { get; set; }
        public string date { get; set; } // number of beds, either 4,6,8,12 or 16
        public int student { get; set; } // student = false, teacher = true

        

        
    }
}
