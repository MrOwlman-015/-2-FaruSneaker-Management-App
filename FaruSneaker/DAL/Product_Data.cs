using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class Product_Data
    {
        Dataconnection data = new Dataconnection();

        public DataTable load()
        {
            string query = "SELECT * FROM Item";
            DataTable table = data.fill_Data(query);
            return table;
        }

        public bool add(string id, string name, int price, string brand, string color, int size, int num, int importprice, DateTime importdate, byte[] image)
        {
            data.Connection();
            string query1 = "insert into Product values (dbo.auto_ItemID(), @ProductName, @ProductPrice)";
            SqlCommand cmd1 = new SqlCommand(query1, data.Conn);
            cmd1.Parameters.AddWithValue("@ProductName", name);
            cmd1.Parameters.AddWithValue("@ProductPrice", price);
            int res1 = cmd1.ExecuteNonQuery();
            if (res1 > 0)
            {
                string query2 = "insert into Item values (dbo.auto_ItemID(), @ProductName, @ProductPrice, @Itembrand, @ItemColor, @ItemSize, @ItemNum, @ItemImportPrice, @ItemImportDate, @image)";
                SqlCommand cmd2 = new SqlCommand(query2, data.Conn);
                cmd2.Parameters.AddWithValue("@ProductName", name);
                cmd2.Parameters.AddWithValue("@ProductPrice", price);
                cmd2.Parameters.AddWithValue("@Itembrand", brand);
                cmd2.Parameters.AddWithValue("@ItemColor", color);
                cmd2.Parameters.AddWithValue("@ItemSize", size);
                cmd2.Parameters.AddWithValue("@ItemNum", num);
                cmd2.Parameters.AddWithValue("@ItemImportPrice", importprice);
                cmd2.Parameters.AddWithValue("@ItemImportDate", importdate);
                cmd2.Parameters.AddWithValue("@image", image);
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

        public bool afterCancel(string id, int numAdd)
        {
            data.Connection();
            string query = "update Item set ItemNum = ItemNum + @numAdd where ItemID = @id";
            SqlCommand cmd = new SqlCommand(query, data.Conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@numAdd", numAdd);
            int res = cmd.ExecuteNonQuery();
            data.Disconnection();
            if (res > 0)
            {
                return true;
            }
            return false;
        }

        public bool afterAdd(string id, int numAdd)
        {
            data.Connection();
            string query = "update Item set ItemNum = ItemNum - @numAdd where ItemID = @id";
            SqlCommand cmd = new SqlCommand(query, data.Conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@numAdd", numAdd);
            int res = cmd.ExecuteNonQuery();
            data.Disconnection();
            if (res > 0)
            {
                return true;
            }
            return false;
        }

        /*public void addProduct(Item_Object item)
        {
            data.Connection();

            string query1 = "insert into Product values (dbo.auto_ItemID(), @ProductName, @ProductPrice)";
            SqlCommand cmd1 = new SqlCommand(query1, data.Conn);
            cmd1.Parameters.AddWithValue("@ProductName", item.ProductName);
            cmd1.Parameters.AddWithValue("@ProductPrice", item.ProductPrice);
            int i1 = cmd1.ExecuteNonQuery();

            string query2 = "insert into Item values (dbo.auto_ItemID(), @ProductName, @ProductPrice, @Itembrand, @ItemColor, @ItemSize, @ItemNum, @ItemImportPrice, @ItemImportDate)";
            SqlCommand cmd2 = new SqlCommand(query2, data.Conn);
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
        }*/

        public bool remove(string id)
        {
            data.Connection();

            string query1 = "delete from Item where ItemID = @id";
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

        /*public void removeProduct(Item_Object item)
        {
            data.Connection();
            string query0 = "delete from Product where ProductID = " + item.ProductID;
            SqlCommand cmd0 = new SqlCommand(query0, data.Conn);
            int i0 = cmd0.ExecuteNonQuery();
            

            string query = "delete from Item where ItemID = " + item.ProductID;
            SqlCommand cmd = new SqlCommand(@query, data.Conn);
            int i = cmd.ExecuteNonQuery();

            data.Disconnection();
        }*/

        public bool update(string id, string name, int price, string brand, string color, int size, int num, int importprice, DateTime importdate, byte[] image)
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
                string query2 = "update Item set ItemName = @ProductName, ItemPrice = @ProductPrice, ItemBrand = @Itembrand, ItemColor = @ItemColor, ItemSize = @ItemSize, ItemNum = @ItemNum, ItemImportPrice = @ItemImportPrice, ItemImportDate = @ItemImportDate, ImageProduct = @image where ItemID = @ProductID";
                SqlCommand cmd2 = new SqlCommand(query2, data.Conn);
                cmd2.Parameters.AddWithValue("@ProductName", name);
                cmd2.Parameters.AddWithValue("@ProductPrice", price);
                cmd2.Parameters.AddWithValue("@Itembrand", brand);
                cmd2.Parameters.AddWithValue("@ItemColor", color);
                cmd2.Parameters.AddWithValue("@ItemSize", size);
                cmd2.Parameters.AddWithValue("@ItemNum", num);
                cmd2.Parameters.AddWithValue("@ItemImportPrice", importprice);
                cmd2.Parameters.AddWithValue("@ItemImportDate", importdate);
                cmd2.Parameters.AddWithValue("@image", image);
                cmd2.Parameters.AddWithValue("@ProductID", id);
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

        /*public void updateProduct(Item_Object item)
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
        }*/
    }
}
