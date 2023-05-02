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
    public partial class Payment_co : UserControl
    {
        Bill_logic bl = new Bill_logic();
        Customer_logic cs = new Customer_logic();
        public Payment_co()
        {
            InitializeComponent();
        }

        private void load(string id)
        {
            BillDetail_logic bd = new BillDetail_logic();
            dgv_Payment.DataSource = bd.load(id);
        }

        private void loadFile()
        {
            Customer_logic cs = new Customer_logic();
            cs.getID(cbx_CusID);
            Employee_logic el = new Employee_logic();
            el.getID(cbx_StaffID);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (cbx_StaffID.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn mã nhân viên");
                return;
            }
            else
            {
                Customer_logic cs = new Customer_logic();
                string? cusid = cbx_CusID.SelectedItem.ToString();
                if (cbx_CusID.SelectedItem == null)
                {
                    cs.add(null, "user", "user");
                    cusid = cs.getCurrentID();
                }
                bl.add(null, cusid, 0, cbx_StaffID.SelectedItem.ToString());

                string id = bl.getCurrentID();
                paymentdetail p = new paymentdetail(id);
                this.Hide();
                p.ShowDialog();

                BillDetail_logic bi = new BillDetail_logic();
                rtx_TotalCash.Text = bi.getTotalCash(id).ToString();
                dgv_Payment.DataSource = bi.load(id);
                this.Show();
            }


        }

        private void cbx_CusID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer_logic cs = new Customer_logic();
            if (cbx_CusID.SelectedItem != null)
            {
                string? id = cbx_CusID.SelectedItem.ToString();
                if (id != null)
                {
                    rtx_CusName.Text = cs.getNamebyID(id);
                }
            }
        }

        private void cbx_StaffID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee_logic el = new Employee_logic();
            if (cbx_StaffID.SelectedItem != null)
            {
                string? id = cbx_StaffID.SelectedItem.ToString();
                if (id != null)
                {
                    rtx_StaffName.Text = el.getNamebyID(id);
                }
            }
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

        public void setEditingMode(bool enable)
        {
            if (!enable)
            {
                dgv_Payment.ClearSelection();
            }
        }
        private void dgv_Payment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setEditingMode(true);
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && !isRowNullOrEmpty(dgv_Payment.Rows[e.RowIndex]))
            {
                DataGridViewRow row = dgv_Payment.Rows[e.RowIndex];

                rtx_PID.Text = row.Cells[0].Value.ToString();
                rtx_PName.Text = row.Cells[1].Value.ToString();
                nbr_Num.Value = Convert.ToDecimal(row.Cells[2].Value);
                rtx_Price.Text = row.Cells[3].Value.ToString();
                rtx_IntoCash.Text = (Convert.ToInt32(rtx_Price.Text) * (Convert.ToInt32(nbr_Num.Value))).ToString();
            }
        }

        private void btn_AddBill_Click(object sender, EventArgs e)
        {
            string? cusid = cbx_CusID.SelectedItem.ToString();
            bl.update(bl.getCurrentID(), cusid, Convert.ToInt32(rtx_TotalCash.Text), cbx_StaffID.SelectedItem.ToString());
        }

        private void btn_CancelBill_Click(object sender, EventArgs e)
        {
            string id = bl.getCurrentID();


            BillDetail_logic bi = new BillDetail_logic();
            if (bi.remove(id))
            {
                if (bl.remove(id))
                {
                    load(id);
                    MessageBox.Show("Thành công!");
                }
                else
                {
                    MessageBox.Show("Thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Thất bại!");
            }

        }

        private void btn_PayBill_Click(object sender, EventArgs e)
        {
            string? cusid = cbx_CusID.SelectedItem.ToString();
            int voucher = 0;
            if (rtx_Discount.Text != "")
            {
                voucher = Convert.ToInt32(rtx_Discount.Text);
            }
            bl.update(bl.getCurrentID(), cusid, Convert.ToInt32(rtx_TotalCash.Text) - voucher, cbx_StaffID.SelectedItem.ToString());
        }

        private void Payment_co_Load(object sender, EventArgs e)
        {
            rtx_BillID.ReadOnly = true;
            loadFile();
        }
    }
}
