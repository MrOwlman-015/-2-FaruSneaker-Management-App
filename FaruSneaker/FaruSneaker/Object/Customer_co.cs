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

namespace FaruSneaker.Object
{
    public partial class Customer_co : UserControl
    {
        public Customer_co()
        {
            InitializeComponent();
            load();
            txt_search.KeyPress += new KeyPressEventHandler(txt_name_KeyPress);
        }
        Customer_logic data = new Customer_logic();
        void load()
        {
            table_C.DataSource = data.load();
        }

        private void btn_add_Click(object sender, EventArgs e)
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

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string id = txt_cid.Text;
            string name = txt_cname.Text;
            string phone = txt_cphone.Text;
            if (MessageBox.Show("Bạn có muốn xóa khách hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (data.delete(id))
                {
                    MessageBox.Show("Xóa thành công");
                    load();
                }
                else
                {
                    MessageBox.Show("Không xóa thành công");
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string id = txt_cid.Text;
            string name = txt_cname.Text;
            string phone = txt_cphone.Text;
            if (data.update(id, name, phone))
            {
                load();
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

        private void btn_search_Click(object sender, EventArgs e)
        {
            string searchname = txt_search.Text;
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

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_search_Click(sender, e);
            }
        }

        private void customer_Load(object sender, EventArgs e)
        {
            txt_cid.ReadOnly = true;
        }
    }
}
