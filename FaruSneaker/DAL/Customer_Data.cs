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
    public class Customer_Data
    {
        Dataconnection data = new Dataconnection();

        
        public DataTable load()
        {
            string query = "SELECT * FROM Customer";
            DataTable table = data.fill_Data(query);
            return table;
        }

        public string getCurrentID()
        {
            data.Connection();
            string query = "SELECT MAX(CustomerID) FROM Customer";
            SqlCommand cmd = new SqlCommand(query, data.Conn);
            string id = cmd.ExecuteScalar().ToString();
            data.Disconnection();
            return id;

        }

        public ComboBox getID(ComboBox comboBox)
        {
            data.Connection();
            string query = "SELECT CustomerID from Customer";
            /*DataTable table = data.fill_Data(query);
            ComboBox comboBox = new ComboBox();
*/
            SqlCommand cmd = new SqlCommand(query, data.Conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                comboBox.Items.Add(reader[0].ToString());
            }
            return comboBox;
        }

        public string getNamebyID(string id)
        {
            data.Connection();
            string query = "SELECT CustomerName FROM Customer where CustomerID = @id";
            SqlCommand cmd = new SqlCommand(query, data.Conn);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            /*reader.Read();
            string name = reader[1].ToString();
            data.Disconnection();
            return name;*/
            reader.Read();
            string name = reader.GetString(0);
            data.Disconnection();
            return name;
        }

         public bool add(string Id, string name, string phone, int numofPur, int type)
        {
            int res = 0;
            data.Connection();
            string query = "INSERT INTO Customer VALUES (dbo.auto_CustomerID(), @Name, @Phone, @NumofPur, @Type)";
            SqlCommand cmd = new SqlCommand(query, data.Conn);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Phone", phone);
            cmd.Parameters.AddWithValue("@NumofPur", numofPur);
            cmd.Parameters.AddWithValue("@Type", type);
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

        public int countBillCustomerID(string ID)
        {
            int count = 0;
            string query = "SELECT COUNT(*) FROM Bill WHERE BillCustomerID = @ID";
            data.Connection();
            SqlCommand cmd = new SqlCommand(query, data.Conn);
            cmd.Parameters.AddWithValue("@ID", ID);
            count = (int)cmd.ExecuteScalar();
            data.Disconnection();
            return count;
        }


        
        public bool delete(string id)
        {
            int res = 0;
            data.Connection();
            string query = "DELETE FROM Customer WHERE CustomerID = @Id";
            SqlCommand cmd = new SqlCommand(query, data.Conn);
            cmd.Parameters.AddWithValue("@Id", id);
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
        
        public bool update(string Id, string name, string phone)
        { 
            int res = 0;
            data.Connection();
            string query = "UPDATE Customer SET CustomerName = @Name, CustomerPhone = @Phone WHERE CustomerID = @Id";
            SqlCommand cmd = new SqlCommand(query, data.Conn);
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Phone", phone);

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

        public DataTable searchByName(string name)
        {
            string query = $"SELECT * FROM Customer WHERE CustomerName LIKE N'%{name}%'";
            data.Connection();
            SqlCommand cmd = new SqlCommand(query, data.Conn);
            cmd.Parameters.AddWithValue("@Name", name);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            reader.Close();
            data.Disconnection();
            return table;
        }
     


    }
}
