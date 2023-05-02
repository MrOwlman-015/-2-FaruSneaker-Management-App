using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DAL
{
    public class Timek_Data
    {
        Dataconnection data = new Dataconnection();

        
        public DataTable load(string Date)
        {
            string query = $"SELECT TimeKeeping.StaffID, Staff.StaffName, Presence FROM TimeKeeping INNER JOIN Staff ON  TimeKeeping.StaffID = Staff.StaffID WHERE DateWork = '{Date}'";
            DataTable table = data.fill_Data(query);
            return table;
        }







        public bool add(string date, string id)
        {
            int res = 0;
            data.Connection();
            string query = "INSERT INTO TimeKeeping VALUES (@Date, @Staffid, @Pre)";
            SqlCommand cmd = new SqlCommand(query, data.Conn);
            cmd.Parameters.AddWithValue("@Date", date);
            cmd.Parameters.AddWithValue("@Staffid", id);
            cmd.Parameters.AddWithValue("@Pre", 1);
            res = cmd.ExecuteNonQuery();
            data.Disconnection();
            if (res > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

  


    }
}
