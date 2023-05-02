using FaruSneaker.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaruSneaker.Business
{
    public  class Account_logic
    {
        Account_Data data= new Account_Data();

        public bool check(string username, string password, int roleuser)
        {
            return data.check(username, password, roleuser);
        }

    }
}
