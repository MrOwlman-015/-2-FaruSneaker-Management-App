using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Service_logic
    {
        Service_Data data = new Service_Data();

        public DataTable load()
        {
            return data.load();
        }

        public bool add(string id, string name, int price, string description)
        {
            return data.add(id, name, price, description);
        }

        public bool remove(string id)
        {
            return data.remove(id);
        }

        public bool update(string id, string name, int price, string description)
        {
            return data.update(id, name, price, description);
        }
    }
}
