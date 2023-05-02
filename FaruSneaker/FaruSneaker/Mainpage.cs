using FaruSneaker.Object;
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
    public partial class Mainpage : Form
    {
        public Mainpage()
        {
            InitializeComponent();
        }

        private void btn_employ_Click(object sender, EventArgs e)
        {
            employee_co1.BringToFront();
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
            payment_co1.BringToFront();

        }

        private void btn_home_Click(object sender, EventArgs e)
        {

        }

        private void btn_ser_Click_1(object sender, EventArgs e)
        {
            service_co1.BringToFront();

        }

        private void payment_co1_Load(object sender, EventArgs e)
        {
            /*payment_co1.BringToFront();*/
        }

        private void btn_account_Click(object sender, EventArgs e)
        {
            account_co1.BringToFront();
        }
    }
}
