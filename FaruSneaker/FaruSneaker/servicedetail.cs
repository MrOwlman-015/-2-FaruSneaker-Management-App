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
    public partial class servicedetail : Form
    {
        BillDetail_logic bl = new BillDetail_logic();
        Service_logic sv = new Service_logic();
        private string id;
        public servicedetail(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void servicedetail_Load(object sender, EventArgs e)
        {
            setEditingMode(false);

            rtx_PID.ReadOnly = true;
            rtx_PName.ReadOnly = true;
            rtx_Price.ReadOnly = true;
            rtx_Des.ReadOnly = true;
            load();
        }

        public void setEditingMode(bool enable)
        {
            if (!enable)
            {
                dgv_choose.ClearSelection();
            }
            btn_Add.Enabled = enable;
            btn_Remove.Enabled = enable;
            btn_Update.Enabled = enable;
        }

        private bool isRowNullOrEmpty(DataGridViewRow row)
        {
            foreach (DataGridViewCell cell in row.Cells)
            {
                if (cell.Value == null || cell.Value == DBNull.Value)
                {
                    return true;
                }

                if (cell.Value is string str && string.IsNullOrEmpty(str))
                {
                    return true;
                }
            }

            return false;
        }

        private void dgv_product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setEditingMode(true);
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && !isRowNullOrEmpty(dgv_product.Rows[e.RowIndex]))
            {
                DataGridViewRow row = dgv_product.Rows[e.RowIndex];

                rtx_PID.Text = row.Cells[0].Value.ToString();
                rtx_PName.Text = row.Cells[1].Value.ToString();
                rtx_Price.Text = row.Cells[2].Value.ToString();
                rtx_Des.Text = row.Cells[3].Value.ToString();
            }
        }

        private void load()
        {
            dgv_product.DataSource = sv.load();
            dgv_choose.DataSource = bl.loadForService(this.id);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string id = rtx_PID.Text;
            string name = rtx_PName.Text;
            if (!bl.checkBillID(this.id, id))
            {
                int price = Convert.ToInt32(rtx_Price.Text);
                string des = rtx_Des.Text;
                if (bl.add(this.id, id, price, des))
                {
                    MessageBox.Show("Thành công!");
                    dgv_choose.DataSource = sv.load();
                    load();
                }
            }
            else
            {
                MessageBox.Show("Dịch vụ đã được chọn");
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            string sid = rtx_PID.Text;
            if (bl.removeService(this.id, sid))
            {
                load();
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string id = rtx_PID.Text;
            string name = rtx_PName.Text;
            int price = Convert.ToInt32(rtx_Price.Text);
            string des = rtx_Des.Text;

            if (bl.update(this.id, id, price, des))
            {
                load();
            }
        }
    }
}
