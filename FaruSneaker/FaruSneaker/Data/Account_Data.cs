using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaruSneaker.Data
{
    public class Account_Data
    {
        Dataconnection data = new Dataconnection();

        public bool check(string username, string password, int roleuser)
        {
            int res = data.Sum_table("SELECT * FROM UserRole WHERE UserName = N'" + username + "' AND UserPassword = N'" + password + "' AND Roleuser = '" + roleuser + "'");
            if(res > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
