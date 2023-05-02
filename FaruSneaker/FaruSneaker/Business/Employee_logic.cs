using FaruSneaker.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FaruSneaker.Business
{
    public  class Employee_logic
    {
        Employee_Data data = new Employee_Data();

        public bool add(string Id, string name, string phone, string ci, DateTime DOB, string add, int salary)
        {
            return data.add( Id,  name,  phone,  ci,  DOB,  add,  salary);
        }

        public DataTable load()
        {
             return data.load();
        }

        public bool delete(string Id)
        {
            return data.delete(Id);
        }

        public bool update(string Id, string name, string phone, string ci, DateTime DOB, string add, int salary)
        {
            return data.update(Id, name, phone, ci, DOB, add, salary);
        }

        public DataTable searchById(string id)
        {
            return data.searchById(id);
        }



    }
}
