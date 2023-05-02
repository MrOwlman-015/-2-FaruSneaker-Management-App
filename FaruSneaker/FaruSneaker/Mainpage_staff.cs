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
    public partial class Mainpage_staff : Form
    {
        public Mainpage_staff()
        {
            InitializeComponent();
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            customer_co1.BringToFront();
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            products_co1.BringToFront();
        }

        private void btn_ser_Click(object sender, EventArgs e)
        {
            service_co1.BringToFront();
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            payment_co2.BringToFront();
        }
    }
}
