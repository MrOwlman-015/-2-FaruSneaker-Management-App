using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Bill_logic
    {
        Bill_Data data = new Bill_Data();

        public DataTable load()
        {
            return data.load();
        }

        public string getCurrentID()
        {
            return data.getCurrentID();
        }

        public bool add(string id, string cusid, int price, string staffid)
        {
            return data.add(id, cusid, price, staffid);
        }

        public bool remove(string id)
        {
            return data.remove(id);
        }

        public bool update(string id, string cusid, int price, string staffid)
        {
            return data.update(id, cusid, price, staffid) ;
        }
    }
}
