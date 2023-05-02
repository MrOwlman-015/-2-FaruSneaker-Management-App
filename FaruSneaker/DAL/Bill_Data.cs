using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Bill_Data
    {
        Dataconnection data = new Dataconnection();

        public DataTable load()
        {
            string query = "select * from Bill";
            DataTable table = data.fill_Data(query);
            return table;
        }

        public string getCurrentID()
        {
            data.Connection();
            string query = "SELECT MAX(BillID) FROM Bill";
            SqlCommand cmd = new SqlCommand(query, data.Conn);
            string id = cmd.ExecuteScalar().ToString();
            data.Disconnection();
            return id;
        }

        public bool add(string id, string cusid, int price, string staffid)
        {
            data.Connection();
            string query = "insert into Bill values (dbo.auto_BillID(), @cusid, @price, @staffid)";
            SqlCommand cmd = new SqlCommand(query, data.Conn);
            cmd.Parameters.AddWithValue("@cusid", cusid);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@staffid", staffid);
            int res = cmd.ExecuteNonQuery();
            data.Disconnection();
            if (res > 0)
            {
                return true;
            }
            return false;
        }

        public bool remove(string id)
        {
            data.Connection();
            string query = "delete from Bill where BillID = @id";
            SqlCommand cmd = new SqlCommand(query, data.Conn);
            cmd.Parameters.AddWithValue("@id", id);
            int res = cmd.ExecuteNonQuery();
            data.Disconnection();
            if (res > 0)
            {
                return true;
            }
            return false;
        }

        public bool update(string id, string cusid, int price, string staffid)
        {
            data.Connection();
            string query = "update Bill set BillCustomerID = @cusid, BillPrice = @price, BillStaffID = @staffid where BillID = @id";
            SqlCommand cmd = new SqlCommand(query, data.Conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@cusid", cusid);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@staffid", staffid);
            int res = cmd.ExecuteNonQuery();
            data.Disconnection();
            if (res > 0)
            {
                return true;
            }
            return false;
        }
    }
}
