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
    public  class Customer_logic
    {
        Customer_Data data = new Customer_Data();

        public int countBillCustomerID(string ID)
        {
            return data.countBillCustomerID(ID);    
        }

        public int typeCustomer(string ID)
        {
            if(countBillCustomerID(ID) >= 3)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public bool add(string Id, string name, string phone)
        {
            return data.add( Id,  name,  phone, countBillCustomerID(Id), typeCustomer(Id));
        }

        public DataTable load()
        {
             return data.load();
        }

        public bool delete(string Id)
        {
            return data.delete(Id);
        }

 
        public bool update(string Id, string name, string phone)
        {
            return data.update(Id, name, phone);
        }

        public DataTable searchByName(string name)
        {
            return data.searchByName(name);
        }



    }
}
