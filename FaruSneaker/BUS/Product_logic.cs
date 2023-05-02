using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Runtime.Remoting.Messaging;

namespace BUS
{
    public class Product_logic
    {
        Product_Data data = new Product_Data();

        public DataTable load()
        {
            return data.load();
        }

        public bool add(string id, string name, int price, string brand, string color, int size, int num, int importprice, DateTime importdate, byte[] image)
        {
            return data.add(id, name, price, brand, color, size, num, importprice, importdate, image);
        }

        public bool afterCancel(string id, int numAdd)
        {
            return data.afterCancel(id, numAdd);
        }

        public bool afterAdd(string id, int numAdd)
        {
            return data.afterAdd(id, numAdd);
        }

        public bool remove(string id)
        {
            return data.remove(id);
        }

        public bool update(string id, string name, int price, string brand, string color, int size, int num, int importprice, DateTime importdate, byte[] image)
        {
            return data.update(id, name, price, brand, color, size, num, importprice, importdate, image);
        }
    }
}
