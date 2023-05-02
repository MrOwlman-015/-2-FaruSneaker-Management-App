using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BillDetail_Data
    {
        Dataconnection data = new Dataconnection();

        public DataTable load(string id)
        {
            string query = "select * from BillDetail where BillID = @id";
            SqlCommand cmd = new SqlCommand(query, data.Conn);
            cmd.Parameters.AddWithValue("@id", id);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
            return table;
        }

        public DataTable getCusID()
        {
            string query = "SELECT BillCustomerID from Bill";
            DataTable table = data.fill_Data(query);
            return table;
        }


        public int getTotalCash(string id)
        {
            data.Connection();
            string query = "select NumOfProduct, ProductPrice from BillDetail where BillID = @id";
            SqlCommand cmd = new SqlCommand(@query, data.Conn);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            int cash = 0;
            while (reader.Read())
            {
                cash += Convert.ToInt32(reader[0].ToString()) * Convert.ToInt32(reader[1].ToString());
            }
            data.Disconnection();
            return cash;
        }

        public bool add(string id, string pid, int num, int price, int voucher)
        {
            data.Connection();
            string query = "insert into BillDetail values (@id, @pid, @num, @price, @voucher)";
            SqlCommand cmd = new SqlCommand(query, data.Conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@pid", pid);
            cmd.Parameters.AddWithValue("@num", num);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@voucher", voucher);
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
            string query = "delete from BillDetail where BillID = @id";
            SqlCommand cmd = new SqlCommand(query, data.Conn);
            cmd.Parameters.AddWithValue("@id" , id);
            int res = cmd.ExecuteNonQuery();
            data.Disconnection();
            if (res > 0)
            {
                return true;
            }
            return false;
        }

        public bool removeProduct(string id, string pid)
        {
            data.Connection();
            string query = "delete from BillDetail where BillID = @id and ProductID = @pid";
            SqlCommand cmd = new SqlCommand(query, data.Conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@pid", pid);
            int res = cmd.ExecuteNonQuery();
            data.Disconnection();
            if (res > 0)
            {
                return true;
            }
            return false;
        }

        public bool update(string id, string pid, int num, int price, int voucher)
        {
            data.Connection();
            string query = "update BillDetail set NumOfProduct = @num, ProductPrice = @price, Voucher = @voucher where BillID = @id and ProductID = @pid";
            SqlCommand cmd = new SqlCommand(query, data.Conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@pid", pid);
            cmd.Parameters.AddWithValue("@num", num);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@voucher", voucher);
            int res = cmd.ExecuteNonQuery();
            data.Disconnection();
            if (res > 0)
            {
                return true;
            }
            return false;
        }

        public bool cal_voucher(string id, int voucher)
        {
            data.Connection();
            string query = "EXECUTE spCalculateVoucher @id, @voucher";
            SqlCommand cmd = new SqlCommand(query, data.Conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@voucher", voucher);
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
