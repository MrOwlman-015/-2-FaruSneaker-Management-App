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

        public int getTotalCash()
        {
            data.Connection();
            string query = "select BillPrice from Bill";
            SqlCommand cmd = new SqlCommand(query, data.Conn);
            SqlDataReader reader = cmd.ExecuteReader();
            int total = 0;
            while (reader.Read())
            {
                total += Convert.ToInt32(reader[0].ToString());
            }
            data.Disconnection();
            return total;
        }

        public bool removeAll()
        {
            data.Connection();
            string query0 = "delete from BillDetailForService";
            SqlCommand cmd0 = new SqlCommand(query0, data.Conn);
            int res0 = cmd0.ExecuteNonQuery();
            if (res0 > 0)
            {
                string query1 = "delete from BillDetail";
                SqlCommand cmd1 = new SqlCommand(query1, data.Conn);
                int res1 = cmd1.ExecuteNonQuery();
                if (res1 > 0)
                {
                    string query = "delete from Bill";
                    SqlCommand cmd = new SqlCommand(query, data.Conn);
                    int res = cmd.ExecuteNonQuery();
                    data.Disconnection();
                    if (res > 0)
                    {
                        return true;
                    }
                    MessageBox.Show("3");
                    return false;
                }
                else
                {
                    MessageBox.Show("2");
                    data.Disconnection();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("1");
                data.Disconnection();
                return false;
            }
            
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

        public DataTable searchById(string Id)
        {
            string query = "SELECT * FROM Bill WHERE BillID = @Id";
            data.Connection();
            SqlCommand cmd = new SqlCommand(query, data.Conn);
            cmd.Parameters.AddWithValue("@Id", Id);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            data.Disconnection();
            return dt;
        }
    }
}
