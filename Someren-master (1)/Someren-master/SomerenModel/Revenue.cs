using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Revenue
    {
        public int price { get; set; } // RoomNumber, e.g. 206
        public int turnover { get; set; } // number of beds, either 4,6,8,12 or 16
        public bool customers { get; set; } // student = false, teacher = true

        public DateTime startdate { get; set; }

        public DateTime enddate { get; set; }
    }
}
