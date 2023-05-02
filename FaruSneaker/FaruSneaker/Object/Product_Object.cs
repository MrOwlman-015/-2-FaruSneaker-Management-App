using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaruSneaker.Object
{
    public class Product_Object
    {
        protected string productID;
        protected string productName;
        protected int productPrice;

        public Product_Object(string productID, string productName, int productPrice)
        {
            this.productID = productID;
            this.productName = productName;
            this.productPrice = productPrice;
        }

        public string ProductID { get => productID; set => productID = value; }
        public string ProductName { get => productName; set => productName = value; }
        public int ProductPrice { get => productPrice; set => productPrice = value; }
    }
}
