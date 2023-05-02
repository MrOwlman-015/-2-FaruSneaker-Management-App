using FaruSneaker.Business;
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
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
            load();
            txt_name.KeyPress += new KeyPressEventHandler(txt_name_KeyPress);

        }

        Customer_logic data = new Customer_logic();
        void load()
        {
            table_C.DataSource = data.load();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void rjTextBox3__TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rjTextBox2__TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rjTextBox3__TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rjTextBox4__TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void rjTextBox5__TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Id = txt_cid.Text;
            string name = txt_cname.Text;
            string phone = txt_cphone.Text;
            if (data.add(Id, name, phone))
            {
                load();
                if (data.typeCustomer(Id) == 1)
                {
                    txt_type.Text = "Khách hàng VIP";
                }
                else
                {
                    txt_type.Text = "Khách hàng";
                }
            }

        }

        private void table_C_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = table_C.Rows[e.RowIndex];
                txt_cid.Text = row.Cells["CustomerID"].Value.ToString();
                txt_cname.Text = row.Cells["CustomerName"].Value.ToString();
                txt_cphone.Text = row.Cells["CustomerPhone"].Value.ToString();
                if (row.Cells["Typecustomer"].Value.ToString() == "1")
                {
                    txt_type.Text = "Khách hàng VIP";
                }
                else
                {
                    txt_type.Text = "Khách hàng";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = txt_cid.Text;
            string name = txt_cname.Text;
            string phone = txt_cphone.Text;
            if (MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (data.delete(id))
                {
                    MessageBox.Show("Customer deleted successfully.");
                    load();
                }
                else
                {
                    MessageBox.Show("Failed to delete employee.");
                }
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string id = txt_cid.Text;
            string name = txt_cname.Text;
            string phone = txt_cphone.Text;
            if (data.update(id, name, phone))
            {
                load();
            }


        }

        private void cButton7_Click(object sender, EventArgs e)
        {
            string searchname = txt_name.Text;
            DataTable res = data.searchByName(searchname);
            if (res.Rows.Count == 0)
            {
                MessageBox.Show("No Customer found");
                load();
            }
            else
            {
                table_C.DataSource = res;
            }
            if (searchname == "")
            {
                load();
            }
        }

        private void txt_name_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cButton7_Click(sender, e);
            }
        }

        private void customer_Load(object sender, EventArgs e)
        {
            txt_cid.ReadOnly = true;
        }
    }
}
