using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BUS
{
    public  class Salary_logic

    {
        Salary_Data data = new Salary_Data();

        public bool add(string sid)
        {
            return data.add(sid);
        }

        public DataTable load()
        {
            return data.load();
        }


        public DataTable getStaffID()
        {
            return data.getStaffID();
        }



        public bool update(string Id)
        {
            return data.update(Id);
        }

        public bool deleteAll()
        {
            return data.deleteAll();
        }



    }
}
