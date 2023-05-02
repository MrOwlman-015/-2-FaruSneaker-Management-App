using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaruSneaker
{
    public partial class Timek : Form
    {
        public Timek()
        {
            InitializeComponent();
        }

        Timek_logic data = new Timek_logic();

        void load()
        {
            dgv_timek.DataSource = data.load(dtp_tk.Value.ToString("dd/MM/yyyy"));
        }


        private void btn_timekp_Click(object sender, EventArgs e)
        {
            if (data.add(dtp_tk.Value.ToString("dd/MM/yyyy"), txt_id.Text))
            {
                load();
            }
        }

        private void dtp_tk_ValueChanged(object sender, EventArgs e)
        {
            load();
        }
    }
}
