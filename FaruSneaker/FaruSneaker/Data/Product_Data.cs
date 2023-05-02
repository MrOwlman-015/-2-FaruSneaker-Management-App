using FaruSneaker.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaruSneaker.Data
{
    public class Product_Data
    {
        Dataconnection data = new Dataconnection();

        public void bindGridView(DataGridView dataGridView)
        {
            data.Connection();
            string query = "SELECT * from Item";
            SqlCommand cmd = new SqlCommand(query, data.Conn);
            SqlDataAdapter dv = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dv.Fill(dt);

            dataGridView.DataSource = dt;
            data.Disconnection();
        }

        public void addProduct(Item_Object item)
        {
            /*data.Connection();
   
            string query = "insert into Product values (@ProductID, @ProductName, @ProductPrice; insert into Item values (@ProductID, @ProductName, @ProductPrice, @Itembrand, @ItemColor, @ItemSize, @ItemNum, @ItemImportPrice, @ItemImportDate)";

            SqlCommand cmd = new SqlCommand(query, data.Conn);
            cmd.Parameters.AddWithValue("@ProductID", item.ProductID);
            cmd.Parameters.AddWithValue("@ProductName", item.ProductName);
            cmd.Parameters.AddWithValue("@ProductPrice", item.ProductPrice);
            cmd.Parameters.AddWithValue("@Itembrand", item.Itembrand);
            cmd.Parameters.AddWithValue("@ItemColor", item.ItemColor);
            cmd.Parameters.AddWithValue("@ItemSize", item.ItemSize);
            cmd.Parameters.AddWithValue("@ItemNum", item.ItemNum);
            cmd.Parameters.AddWithValue("@ItemImportPrice", item.ItemImportPrice);
            cmd.Parameters.AddWithValue("@ItemImportDate", item.ItemImportDate);
            int i = cmd.ExecuteNonQuery();
            data.Disconnection();*/



            data.Connection();

            string query1 = "insert into Product values (@ProductID, @ProductName, @ProductPrice)";
            SqlCommand cmd1 = new SqlCommand(query1, data.Conn);
            cmd1.Parameters.AddWithValue("@ProductID", item.ProductID);
            cmd1.Parameters.AddWithValue("@ProductName", item.ProductName);
            cmd1.Parameters.AddWithValue("@ProductPrice", item.ProductPrice);
            int i1 = cmd1.ExecuteNonQuery();

            string query2 = "insert into Item values (@ProductID, @ProductName, @ProductPrice, @Itembrand, @ItemColor, @ItemSize, @ItemNum, @ItemImportPrice, @ItemImportDate)";
            SqlCommand cmd2 = new SqlCommand(query2, data.Conn);
            cmd2.Parameters.AddWithValue("@ProductID", item.ProductID);
            cmd2.Parameters.AddWithValue("@ProductName", item.ProductName);
            cmd2.Parameters.AddWithValue("@ProductPrice", item.ProductPrice);
            cmd2.Parameters.AddWithValue("@Itembrand", item.Itembrand);
            cmd2.Parameters.AddWithValue("@ItemColor", item.ItemColor);
            cmd2.Parameters.AddWithValue("@ItemSize", item.ItemSize);
            cmd2.Parameters.AddWithValue("@ItemNum", item.ItemNum);
            cmd2.Parameters.AddWithValue("@ItemImportPrice", item.ItemImportPrice);
            cmd2.Parameters.AddWithValue("@ItemImportDate", item.ItemImportDate);
            int i2 = cmd2.ExecuteNonQuery();

            data.Disconnection();
        }

        

        public void removeProduct(Item_Object item)
        {
            data.Connection();
            string query0 = "delete from Product where ProductID = " + item.ProductID;
            SqlCommand cmd0 = new SqlCommand(query0, data.Conn);
            int i0 = cmd0.ExecuteNonQuery();
            

            string query = "delete from Item where ItemID = " + item.ProductID;
            SqlCommand cmd = new SqlCommand(@query, data.Conn);
            int i = cmd.ExecuteNonQuery();

            data.Disconnection();
        }

        

        public void updateProduct(Item_Object item)
        {
            data.Connection();

            string query0 = "UPDATE Product SET ProductName = @ProductName, ProductPrice = @ProductPrice WHERE ProductID = @ProductID";
            SqlCommand cmd0 = new SqlCommand(query0, data.Conn);
            cmd0.Parameters.AddWithValue("@ProductName", item.ProductName);
            cmd0.Parameters.AddWithValue("@ProductPrice", item.ProductPrice);
            cmd0.Parameters.AddWithValue("@ProductID", item.ProductID);
            int i0 = cmd0.ExecuteNonQuery();

            string query = "UPDATE Item SET ItemName = @ProductName, ItemPrice = @ProductPrice, ItemBrand = @Itembrand, ItemColor = @ItemColor, ItemSize = @ItemSize, ItemNum = @ItemNum, ItemImportPrice = @ItemImportPrice, ItemImportDate = @ItemImportDate WHERE ItemID = @ProductID";
            SqlCommand cmd = new SqlCommand(query, data.Conn);
            cmd.Parameters.AddWithValue("@ProductName", item.ProductName);
            cmd.Parameters.AddWithValue("@ProductPrice", item.ProductPrice);
            cmd.Parameters.AddWithValue("@Itembrand", item.Itembrand);
            cmd.Parameters.AddWithValue("@ItemColor", item.ItemColor);
            cmd.Parameters.AddWithValue("@ItemSize", item.ItemSize);
            cmd.Parameters.AddWithValue("@ItemNum", item.ItemNum);
            cmd.Parameters.AddWithValue("@ItemImportPrice", item.ItemImportPrice);
            cmd.Parameters.AddWithValue("@ItemImportDate", item.ItemImportDate);
            cmd.Parameters.AddWithValue("@ProductID", item.ProductID);
            int i = cmd.ExecuteNonQuery();
            data.Disconnection();
        }
    }
}
