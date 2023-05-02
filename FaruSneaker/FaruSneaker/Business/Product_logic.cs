using FaruSneaker.Data;
using FaruSneaker.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaruSneaker.Business
{
    public class Product_logic
    {
        Product_Data data = new Product_Data();

        public void bindGridView(DataGridView gridView)
        {
            data.bindGridView(gridView);
        }
        public void addItem(Item_Object item)
        {
            data.addProduct(item);
        }

        public void removeItem(Item_Object item)
        {
            data.removeProduct(item);
        }

        public void updateItem(Item_Object item)
        {
            data.updateProduct(item);
        }
    }
}
