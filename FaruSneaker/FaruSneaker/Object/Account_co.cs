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
    public partial class Account_co : UserControl
    {
        public Account_co()
        {
            InitializeComponent();
            load();
            txt_search.KeyPress += new KeyPressEventHandler(txt_search_KeyPress);
        }

        Account_logic data = new Account_logic();
        void load()
        {
            table_ACC.DataSource = data.load();
        }

        private void reset()
        {
            txt_accname.Text = "";
            txt_accpass.Text = "";
            txt_accrole.Text = "";
            table_ACC.ClearSelection();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_accname.Text == "" || txt_accpass.Text == "" || txt_accrole.Text == "")
            {
                MessageBox.Show("Hãy đảm bảo đầy đủ nội dung trước khi thực hiện!");
                return;
            }
            else
            {
                string name = txt_accname.Text;
                string pass = txt_accpass.Text;
                int checkrole = 0;

                if (!int.TryParse(txt_accrole.Text, out checkrole))
                {
                    error.SetError(txt_accrole, "Xin nhập chữ số");
                    return;
                }
                else
                {
                    error.Clear();
                }
                int role = Int32.Parse(txt_accrole.Text);
                if (data.add(name, pass, role))
                {
                    MessageBox.Show("Thành công!");
                    reset();
                    load();

                }
                else
                {
                    MessageBox.Show("Trùng tên tài khoản");
                    return;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = txt_accname.Text;
            if (MessageBox.Show("Bạn có muốn xóa tài khoản này?", "Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (data.delete(name))
                {
                    reset();
                    MessageBox.Show("Xóa thành công");
                    load();
                }
                else
                {
                    MessageBox.Show("Không xóa thành công");
                    return;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txt_accname.Text;
            string pass = txt_accpass.Text;
            int checkrole = 0;

            if (!int.TryParse(txt_accrole.Text, out checkrole))
            {
                error.SetError(txt_accrole, "Xin nhập chữ số");
                return;
            }
            else
            {
                error.Clear();
            }
            int role = Int32.Parse(txt_accrole.Text);
            if (data.update(name, pass, role))
            {
                MessageBox.Show("Thành công!");
                reset();
                load();

            }
            else
            {
                MessageBox.Show("Trùng tên tài khoản, không thể cập nhật");
                return;
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string searchid = txt_search.Text;
            DataTable res = data.searchByName(searchid);
            if (res.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy tài khoản!");
                load();
            }
            else
            {
                table_ACC.DataSource = res;
            }
            if (txt_search.Text == "")
            {
                load();
            }
        }

        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_search_Click(sender, e);
            }
        }

        private void table_ACC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= table_ACC.RowCount)
            {
                return;
            }

            DataGridViewRow row = this.table_ACC.Rows[e.RowIndex];
            txt_accname.Text = row.Cells["UserName"].Value.ToString();
            txt_accpass.Text = row.Cells["UserPassword"].Value.ToString();
            txt_accrole.Text = row.Cells["Roleuser"].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
