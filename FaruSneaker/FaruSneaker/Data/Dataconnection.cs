using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;



namespace FaruSneaker.Data
{
    public class Dataconnection
    {
        /*SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FaruSneaker.mdf");*/
        /*SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FaruSneaker.mdf");*/
        /*SqlConnection conn = new SqlConnection("Data Source=LAPTOP-G0AHHLD3\\JBTAN;Initial Catalog=FaruSneaker;Integrated Security=True");*/
        /*SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""G:\University\HKII năm 2\Software LT\FaruSneaker (4)\FaruSneaker\FaruSneaker\bin\Debug\net6.0-windows\FaruSneaker.mdf"";Integrated Security=True;Connect Timeout=30");*/
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\HOC TAP\PROJECT\FaruSneaker\FaruSneaker_4\FaruSneaker (4)\FaruSneaker\FaruSneaker\bin\Debug\net6.0-windows\FaruSneaker.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlDataAdapter? adap;
        SqlCommand? cmd;

        public SqlConnection Conn { get => conn; set => conn = value; }
        public SqlDataAdapter? Adap { get => adap; set => adap = value; }
        public SqlCommand? Cmd { get => cmd; set => cmd = value; }


        /*internal void Execute(object p)
        {
            throw new NotImplementedException();
        }*/

        // Open connection
        public void Connection()
        {
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();
        }

        // Close connection
        public void Disconnection()
        {
            if (Conn.State == ConnectionState.Open)
                Conn.Close();
        }

        //Fill data in table
        public DataTable fill_Data(string data)
        {
            Adap = new SqlDataAdapter(data, Conn);
            DataTable data_table = new DataTable();
            Adap.Fill(data_table);
            return data_table;
        }

        // execute query
        public void Execute(string query)
        {
            Connection();
            Cmd = new SqlCommand(query, Conn);
            Cmd.ExecuteNonQuery();
            Disconnection();
        }

        public int ExecuteNonQuery(string query)
        {
            int affectedRows = 0;
            Connection();
            cmd = new SqlCommand(query, Conn);
            affectedRows = cmd.ExecuteNonQuery();
            Disconnection();
            return affectedRows;
        }

        public int Sum_table(string data)
        {
            DataTable data_table = new DataTable();
            Adap = new SqlDataAdapter(data, Conn);
            Adap.Fill(data_table);
            int res = data_table.Rows.Count;
            return res;

        }




    }
}
