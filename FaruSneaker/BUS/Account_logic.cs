using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public  class Account_logic
    {
        Account_Data data= new Account_Data();

        public bool check(string username, string password, int roleuser)
        {
            return data.check(username, password, roleuser);
        }


        public DataTable load()
        {
            return data.load();
        }

       
        public bool add(string username, string password, int roleuser)
        {

            return data.add(username, password, roleuser);
            
        }

        public bool update(string username, string password, int roleuser)
        {
            return data.add(username, password, roleuser);
        }

        public bool delete(string username) { return data.delete(username); }

        public DataTable searchByName(string username)
        {
            return data.searchByName(username);
        }


    }
}
