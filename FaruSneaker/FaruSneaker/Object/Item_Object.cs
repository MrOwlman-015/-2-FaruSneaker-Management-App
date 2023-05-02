using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaruSneaker.Object
{
    public class Item_Object : Product_Object
    {
        private string itemBrand;
        private string itemColor;
        private string itemSize;
        private int itemNum;
        private int itemImportPrice;
        private DateTime itemImportDate;


        public Item_Object(string productID, string productName, int productPrice, string itembrand, string itemColor, string itemSize, int itemNum, int itemImportPrice, DateTime itemImportDate) : base(productID, productName, productPrice)
        {
            this.productID = productID;
            this.productName = productName;
            this.productPrice = productPrice;
            this.itemBrand = itembrand;
            this.itemColor = itemColor ?? "";
            this.itemSize = itemSize;
            this.itemNum = itemNum;
            this.itemImportPrice = itemImportPrice;
            this.itemImportDate = itemImportDate;
        }

        public string Itembrand { get => itemBrand; set => itemBrand = value; }
        public string ItemColor { get => itemColor; set => itemColor = value; }
        public string ItemSize { get => itemSize; set => itemSize = value; }
        public int ItemNum { get => itemNum; set => itemNum = value; }
        public int ItemImportPrice { get => itemImportPrice; set => itemImportPrice = value; }
        public DateTime ItemImportDate { get => itemImportDate; set => itemImportDate = value; }
    }
}
