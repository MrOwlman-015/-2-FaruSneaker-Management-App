using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BillDetail_Data
    {
        Dataconnection data = new Dataconnection();

        public bool checkInBillDetail(string id)
        {
            data.Connection();
            string query = "select * from BillDetail where BillID = @id";
            SqlCommand cmd = new SqlCommand(query, data.Conn);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                data.Disconnection();
                return true;
            }
            data.Disconnection();
            return false;
        }

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

        public DataTable loadForService(string id)
        {
            string query = "select * from BillDetailForService where BillID = @id";
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

        public bool checkBillID(string id, string pid)
        {
            data.Connection();
            string query = "SELECT ProductID FROM BillDetail WHERE BillID = @id AND ProductID = @pid";
            SqlCommand cmd = new SqlCommand(query, data.Conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@pid", pid);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                data.Disconnection();
                return true;
            }
            data.Disconnection();
            return false;
        }

        public DataTable getProductByID(string id, string pid)
        {
            data.Connection();
            string query = "select * from BillDetail where BillID = @id and ProductID = @pid";
            SqlCommand cmd = new SqlCommand(query, data.Conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@pid", pid);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            data.Disconnection();
            return dt;
        }

        public double getTotalCash(string id)
        {
            data.Connection();
            string query = "select NumOfProduct, ProductPrice, Voucher from BillDetail where BillID = @id";
            SqlCommand cmd = new SqlCommand(@query, data.Conn);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            double cash = 0;
            while (reader.Read())
            {
                cash += Convert.ToInt32(reader[0].ToString()) * Convert.ToInt32(reader[1].ToString()) - (Convert.ToInt32(reader[0].ToString()) * Convert.ToInt32(reader[1].ToString()) * (0.01 * Convert.ToInt32(reader[2].ToString())));
            }
            data.Disconnection();
            return cash;
        }

        public int getTotalCashService(string id)
        {
            data.Connection();
            string query = "select ServicePrice from BillDetailForService where BillID = @id";
            SqlCommand cmd = new SqlCommand(query, data.Conn);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            int cash = 0;
            while (reader.Read())
            {
                cash += Convert.ToInt32(reader[0].ToString());
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

        public bool add(string id, string sid, int price, string des)
        {
            data.Connection();
            string query = "insert into BillDetailForService values (@id, @sid, @price, @des)";
            SqlCommand cmd = new SqlCommand(query, data.Conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@sid", sid);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@des", des);
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
            cmd.Parameters.AddWithValue("@id", id);
            int res = cmd.ExecuteNonQuery();
            data.Disconnection();
            if (res > 0)
            {
                return true;
            }
            return false;
        }

        public bool removeService(string id)
        {
            data.Connection();
            string query = "delete from BillDetailForService where BillID = @id";
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

        public bool removeService(string id, string sid)
        {
            data.Connection();
            string query = "delete from BillDetailForService where BillID = @id and ServiceID = @sid";
            SqlCommand cmd = new SqlCommand(query, data.Conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@sid", sid);
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

        public bool update(string id, string sid, int price, string des)
        {
            data.Connection();
            string query = "update BillDetailForService set ServicePrice = @price, ServiceDes = @des where BillID = @id and ServiceID = @sid";
            SqlCommand cmd = new SqlCommand(query, data.Conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@sid", sid);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@des", des);
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
