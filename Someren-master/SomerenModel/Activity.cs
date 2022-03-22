using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Activity
    {


        public string ActivityID { get; set; }
        public string Description { get; set; } // RoomNumber, e.g. 206
        public string StartDate { get; set; } // number of beds, either 4,6,8,12 or 16
        public string EndDate { get; set; } // student = false, teacher = true

    }
}
