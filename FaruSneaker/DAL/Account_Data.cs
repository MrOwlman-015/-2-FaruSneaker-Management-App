using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DAL
{
    public class Account_Data
    {
        Dataconnection data = new Dataconnection();

        public bool check(string username, string password, int roleuser)
        {
            /*int res = data.Sum_table("SELECT * FROM UserRole WHERE UserName = N'" + username + "' AND UserPassword = N'" + password);
            if(res > 0)
            {
                return true;
            }
            else
            {
                return false;
            }*/
            data.Connection();
            string query = "SELECT * FROM UserRole WHERE UserName = @username and UserPassword = @password";
            SqlCommand cmd = new SqlCommand(query, data.Conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int role = Convert.ToInt32(reader[2].ToString());
            if (role == roleuser)
            {
                reader.Close();
                return true;
            }
            else
            {
                reader.Close();
                return false;
            }
        }

        public DataTable load()
        {
            string query = "SELECT * FROM UserRole";
            DataTable table = data.fill_Data(query);
            return table;
        }

        public bool add(string username, string password, int roleusere)
        {
            int res = 0;
            data.Connection();
            string query = "SELECT COUNT(*) FROM UserRole WHERE UserName = @Name";
            SqlCommand cmd = new SqlCommand(query, data.Conn);
            cmd.Parameters.AddWithValue("@Name", username);
            res = (int)cmd.ExecuteScalar();

            if (res > 0)
            {
                data.Disconnection();
                return false;
            }
            else
            {
                query = "INSERT INTO UserRole VALUES (@Name, @Pass, @Role)";
                cmd = new SqlCommand(query, data.Conn);
                cmd.Parameters.AddWithValue("@Name", username);
                cmd.Parameters.AddWithValue("@Pass", password);
                cmd.Parameters.AddWithValue("@Role", roleusere);
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
         
        public bool update(string username, string password, int roleuser)
        {
            data.Connection();
            string query = "UPDATE UserRole SET UserPassword = @Pass, Roleuser = @Role WHERE UserName = @Name";
            SqlCommand cmd = new SqlCommand(query, data.Conn);
            cmd.Parameters.AddWithValue("@Name", username);
            cmd.Parameters.AddWithValue("@Pass", password);
            cmd.Parameters.AddWithValue("@Role", roleuser);
            int res = cmd.ExecuteNonQuery();
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

        public bool delete(string username)
        {
            int res = 0;
            data.Connection();
            string query = "DELETE FROM UserRole WHERE UserName = @Name";
            SqlCommand cmd = new SqlCommand(query, data.Conn);
            cmd.Parameters.AddWithValue("@Name", username);
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

        public DataTable searchByName(string username)
        {
            string query = $"SELECT * FROM UserRole WHERE UserName LIKE '%{username}%'";
            data.Connection();
            SqlCommand cmd = new SqlCommand(query, data.Conn);
            cmd.Parameters.AddWithValue("@Name", username);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            reader.Close();
            data.Disconnection();
            return table;
        }







    }
}
