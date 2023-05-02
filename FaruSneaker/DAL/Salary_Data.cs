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
    public class Salary_Data
    {
        Dataconnection data = new Dataconnection();

        


        public DataTable load()
        {
            string query = "SELECT Salary.SalaryID, Salary.StaffID, Staff.StaffName, Salary.TotalSalry from Staff, Salary where Salary.StaffID = Staff.StaffID";
            DataTable table = data.fill_Data(query);
            return table;
        }

        public DataTable getStaffID()
        {
            string query = "SELECT StaffID from Staff";
            DataTable table = data.fill_Data(query);
            return table;
        }


        public bool add( string sid)
        {
            int res = 0;
            data.Connection();
            /*insert into staff values(dbo.auto_StaffID(), 'Trung', '773', '742', '2023/1/1', 'ssd', 12)*/
            string query = "INSERT INTO Salary VALUES (dbo.auto_SalaryID(), @sid,dbo.CalculateTotalSalary(@sid))";
            SqlCommand cmd = new SqlCommand(query, data.Conn);
            cmd.Parameters.AddWithValue("@sid", sid);
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

        public bool deleteAll()
        {
            int res = 0;
            data.Connection();
            string query = "DELETE FROM Salary";
            SqlCommand cmd = new SqlCommand(query, data.Conn);
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


        public bool update(string Id)
        {
            int res = 0;
            data.Connection();
            string query = "UPDATE Salary SET TotalSalry = dbo.CalculateTotalSalary(@Id) WHERE StaffID = @Id";
            SqlCommand cmd = new SqlCommand(query, data.Conn);
            cmd.Parameters.AddWithValue("@Id", Id);
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
