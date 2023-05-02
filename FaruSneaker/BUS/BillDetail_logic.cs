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

        public int getTotalCash(string id)
        {
            return data.getTotalCash(id);
        }

        public bool add(string id, string pid, int num, int price, int voucher)
        {
            return data.add(id, pid, num, price, voucher);
        }

        public bool remove(string id)
        {
            return data.remove(id);
        }

        public bool removeProduct(string id, string pid)
        {
            return data.removeProduct(id, pid);
        }

        public bool update(string id, string pid, int num, int price, int voucher)
        {
            return data.update(id, pid, num, price, voucher);
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
