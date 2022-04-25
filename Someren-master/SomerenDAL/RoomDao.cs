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
    public class RoomDao : BaseDao
    {
        public List<Room> GetAllRooms()
        {

            string query = "SELECT RoomID, Capacity, Type FROM [Rooms]";
            var sqlCommand = new SqlCommand(query);
            return ReadTables(ExecuteSelectQuery(sqlCommand));
        }

        private List<Room> ReadTables(DataTable dataTable)
        {
            List<Room> Rooms = new List<Room>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Room Room = new Room()
                {
                    RoomID = (int)dr["RoomID"],
                    Capacity = (int)dr["Capacity"],
                    Type = (bool)dr["Type"]


                };
                Rooms.Add(Room);
            }
            return Rooms;
        }
    }
}
