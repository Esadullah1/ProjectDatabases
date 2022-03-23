using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Activity
    {
        public string ActivityID  { get; set; }
        public string Description { get; set; }
        public string StartDateTime { get; set; }
        public string EndDateTime { get; set; }

        public int ActivityNumber { get; set; }

    }
}
