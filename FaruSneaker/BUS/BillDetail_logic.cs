using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BillDetail_logic
    {
        BillDetail_Data data = new BillDetail_Data();

        public DataTable load(string id)
        {
            return data.load(id);
        }

        public DataTable loadForService(string id)
        {
            return data.loadForService(id);
        }

        public bool checkInBillDetail(string id)
        {
            return data.checkInBillDetail(id);
        }

        public double getTotalCash(string id)
        {
            return data.getTotalCash(id);
        }

        public int getTotalCashService(string id)
        {
            return data.getTotalCashService(id);
        }

        public bool checkBillID(string id, string pid)
        {
            return data.checkBillID(id, pid);
        }

        public DataTable getProductByID(string id, string pid)
        {
            return data.getProductByID(id, pid);
        }

        public bool add(string id, string pid, int num, int price, int voucher)
        {
            return data.add(id, pid, num, price, voucher);
        }

        public bool add(string id, string sid, int price, string des)
        {
            return data.add(id, sid, price, des);
        }

        public bool remove(string id)
        {
            return data.remove(id);
        }

        public bool removeService(string id)
        {
            return data.removeService(id);
        }

        public bool removeProduct(string id, string pid)
        {
            return data.removeProduct(id, pid);
        }

        public bool removeService(string id, string sid)
        {
            return data.removeService(id, sid);
        }

        public bool update(string id, string pid, int num, int price, int voucher)
        {
            return data.update(id, pid, num, price, voucher);
        }

        public bool update(string id, string sid, int price, string des)
        {
            return data.update(id, sid, price, des);
        }

        public bool cal_voucher(string id, int voucher)
        {
            return data.cal_voucher(id, voucher);
        }

        public DataTable getCusID()
        {
            return data.getCusID();
        }
    }
}
