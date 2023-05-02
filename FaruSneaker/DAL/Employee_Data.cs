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
    public class Employee_Data
    {
        Dataconnection data = new Dataconnection();

        
        public DataTable load()
        {
            string query = "SELECT * FROM Staff";
            DataTable table = data.fill_Data(query);
            return table;
        }

        public ComboBox getID(ComboBox comboBox)
        {
            data.Connection();
            string query = "SELECT StaffID from Staff";
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
            string query = "SELECT StaffName FROM Staff where StaffID = @id";
            SqlCommand cmd = new SqlCommand(query, data.Conn);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string name = reader.GetString(0);
            data.Disconnection();
            return name;
        }

        public bool add(string Id, string name, string phone, string ci, DateTime DOB, string add, int salary)
        {
            int res = 0;
            data.Connection();
            /*insert into staff values(dbo.auto_StaffID(), 'Trung', '773', '742', '2023/1/1', 'ssd', 12)*/
            string query = "INSERT INTO Staff VALUES (dbo.auto_StaffID(), @Name, @Phone, @CI, @DOB, @Address, @Salary)";
            SqlCommand cmd = new SqlCommand(query, data.Conn);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Phone", phone);
            cmd.Parameters.AddWithValue("@CI", ci);
            cmd.Parameters.AddWithValue("@DOB", DOB);
            cmd.Parameters.AddWithValue("@Address", add);
            cmd.Parameters.AddWithValue("@Salary", salary);
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

        public bool delete(string id)
        {
            int res = 0;
            data.Connection();
            string query = "DELETE FROM Staff WHERE StaffID = @Id";
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

        public bool update(string Id, string name, string phone, string ci, DateTime DOB, string add, int salary)
        {
            int res = 0;
            data.Connection();
            string query = "UPDATE Staff SET StaffName = @Name, StaffPhone = @Phone, StaffCI = @CI, StaffDateOfBirth = @DOB, StaffAddress = @Address, StaffSalary = @Salary WHERE StaffID = @Id";
            SqlCommand cmd = new SqlCommand(query, data.Conn);
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Phone", phone);
            cmd.Parameters.AddWithValue("@CI", ci);
            cmd.Parameters.AddWithValue("@DOB", DOB);
            cmd.Parameters.AddWithValue("@Address", add);
            cmd.Parameters.AddWithValue("@Salary", salary);
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

        public DataTable searchById(string Id)
        {
            string query = "SELECT * FROM Staff WHERE StaffID = @Id";
            data.Connection();
            SqlCommand cmd = new SqlCommand(query, data.Conn);
            cmd.Parameters.AddWithValue("@Id", Id);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            reader.Close();
            data.Disconnection();
            return table;
        }



    }
}
