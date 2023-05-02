using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Service_Data
    {
        Dataconnection data = new Dataconnection();

        public DataTable load()
        {
            string query = "SELECT * FROM ServiceForItem";
            DataTable table = data.fill_Data(query);
            return table;
        }

        public bool add(string id, string name, int price, string description)
        {
            data.Connection();
            string query1 = "insert into Product values (dbo.auto_ServiceID(), @ProductName, @ProductPrice)";
            SqlCommand cmd1 = new SqlCommand(query1, data.Conn);
            cmd1.Parameters.AddWithValue("@ProductName", name);
            cmd1.Parameters.AddWithValue("@ProductPrice", price);
            int res1 = cmd1.ExecuteNonQuery();
            if (res1 > 0)
            {
                string query2 = "insert into ServiceForItem values (dbo.auto_ServiceID(), @ProductName, @ProductPrice, @ServiceDescription)";
                SqlCommand cmd2 = new SqlCommand(query2, data.Conn);
                cmd2.Parameters.AddWithValue("@ProductName", name);
                cmd2.Parameters.AddWithValue("@ProductPrice", price);
                cmd2.Parameters.AddWithValue("@ServiceDescription", description);
                int res2 = cmd2.ExecuteNonQuery();
                data.Disconnection();
                if (res2 > 0)
                {
                    return true;
                }
                else { return false; }
            }
            else
            {
                data.Disconnection();
                return false;
            }
        }

        public bool remove(string id)
        {
            data.Connection();

            string query1 = "delete from ServiceForItem where ServiceID = @id";
            SqlCommand cmd1 = new SqlCommand(query1, data.Conn);
            cmd1.Parameters.AddWithValue("@id", id);
            int res1 = cmd1.ExecuteNonQuery();
            if (res1 > 0)
            {
                string query2 = "delete from Product where ProductID = @id";
                SqlCommand cmd2 = new SqlCommand(query2, data.Conn);
                cmd2.Parameters.AddWithValue("id", id);
                int res2 = cmd2.ExecuteNonQuery();
                data.Disconnection();
                if (res2 > 0)
                {
                    return true;
                }
                else { return false; }
            }
            else
            {
                data.Disconnection();
                return false;
            }
        }

        public bool update(string id, string name, int price, string description)
        {
            data.Connection();
            string query1 = "update Product set ProductName = @ProductName, ProductPrice = @ProductPrice where ProductID = @ProductID";
            SqlCommand cmd1 = new SqlCommand(query1, data.Conn);
            cmd1.Parameters.AddWithValue("@ProductName", name);
            cmd1.Parameters.AddWithValue("@ProductPrice", price);
            cmd1.Parameters.AddWithValue("@ProductID", id);
            int res1 = cmd1.ExecuteNonQuery();
            if (res1 > 0)
            {
                string query2 = "update ServiceForItem set ServiceName = @ProductName, ServicePrice = @ProductPrice, ServiceDescription = @ServiceDescription where ServiceID = @ServiceID ";
                SqlCommand cmd2 = new SqlCommand(query2, data.Conn);
                cmd2.Parameters.AddWithValue("@ProductName", name);
                cmd2.Parameters.AddWithValue("@ProductPrice", price);
                cmd2.Parameters.AddWithValue("@ServiceDescription", description);
                cmd2.Parameters.AddWithValue("@ServiceID", id);
                int res2 = cmd2.ExecuteNonQuery();
                data.Disconnection();
                if (res2 > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                data.Disconnection();
                return false;
            }
        }
    }
}
