using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaruSneaker.Data
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

        public bool add(string Id, string name, string phone, string ci, DateTime DOB, string add, int salary)
        {
            int res = 0;
            data.Connection();
            string query = "INSERT INTO Staff (StaffID,StaffName,StaffPhone,StaffCI,StaffDateOfBirth,StaffAddress,StaffSalary,ImageProduct) VALUES (dbo.auto_StaffID(), @Name, @Phone, @CI, @DOB, @Address, @Salary)";
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
