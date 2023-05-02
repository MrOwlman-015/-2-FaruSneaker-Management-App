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
    public  class Timek_logic
    {
        Timek_Data data = new Timek_Data();



        public DataTable load(string date)
        {
            return data.load(date);
        }


        public bool add(string date, string id)
        {
            return data.add(date, id); 
        }


    }
}
