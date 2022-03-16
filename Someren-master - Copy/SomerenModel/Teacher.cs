using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Teacher
    {
        public string TeacherFirstName { get; set; }

        public string TeacherLastName { get; set; }
        public int Number { get; set; } // LecturerNumber, e.g. 47198

        public bool Supervisors { get; set; }
    }
}
