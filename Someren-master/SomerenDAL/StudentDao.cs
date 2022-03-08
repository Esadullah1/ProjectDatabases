using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;

namespace SomerenDAL
{
    public class StudentDao : BaseDao
    {      
        public List<Student> GetAllStudents()
        {
<<<<<<< Updated upstream
            string query = "SELECT StudentID, FirstName FROM [Students]";
=======
            string query = "SELECT StudentID, FirstName FROM [Students]";
>>>>>>> Stashed changes
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Student> ReadTables(DataTable dataTable)
        {
            List<Student> students = new List<Student>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Student student = new Student()
                {
                    Number = (int)dr["StudentID"],
                    Name = (string)(dr["FirstName"].ToString())
                };
                students.Add(student);
            }
            return students;
        }
    }
}
