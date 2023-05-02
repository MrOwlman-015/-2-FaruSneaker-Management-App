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
    public partial class paymentdetail : Form
    {
        private List<string> listId;
        public List<string> ListIdCus { get => listId; set => listId = value; }
        BillDetail_logic bl = new BillDetail_logic();
        Product_logic pd = new Product_logic();
        int numRestore = 0;
        private string id;

        public paymentdetail(string id)
        {
            InitializeComponent();
            this.id = id;
            GetCusId();
            cal_voucher();
        }

        private void paymentdetail_Load(object sender, EventArgs e)
        {
            setEditingMode(false);

            dgv_product.DataSource = pd.load();
            rtx_PID.ReadOnly = true;
            rtx_PName.ReadOnly = true;
            rtx_Price.ReadOnly = true;
            rtx_IntoCash.ReadOnly = true;
            rtx_Discount.ReadOnly = true;
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
                dgv_choose.ClearSelection();
            }
            btn_Add.Enabled = enable;
            btn_Remove.Enabled = enable;
            btn_Update.Enabled = enable;
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
            }
        }

        private void load()
        {
            dgv_product.DataSource = pd.load();
            dgv_choose.DataSource = bl.load(this.id);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            numRestore = Convert.ToInt32(nbr_Num.Value);
            string id = rtx_PID.Text;
            string name = rtx_PName.Text;
            int num = Convert.ToInt32(nbr_Num.Value);
            int price = Convert.ToInt32(rtx_Price.Text);
            int voucher = 0;
            if (rtx_Discount.Text != "")
            {
                voucher = Convert.ToInt32(rtx_Discount.Text);

            }
            if (bl.add(this.id, id, num, price, voucher))
            {
                Product_logic pl = new Product_logic();
                pl.afterAdd(id, num);
                load();
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            string pid = rtx_PID.Text;
            int numRestore = Convert.ToInt32(nbr_Num.Value);
            if (bl.removeProduct(id, pid))
            {
                Product_logic pl = new Product_logic();
                pl.afterCancel(id, numRestore);
                load();
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string id = rtx_PID.Text;
            string name = rtx_PName.Text;
            int num = Convert.ToInt32(nbr_Num.Value);
            int price = Convert.ToInt32(rtx_Price.Text);
            int voucher = 0;
            if (rtx_Discount.Text != "")
            {
                voucher = Convert.ToInt32(rtx_Discount.Text);

            }

            if (bl.update(this.id, id, num, price, voucher))
            {
                Product_logic pl = new Product_logic();
                pl.afterCancel(id, numRestore);
                pl.afterAdd(id, num);
                load();
            }
        }

        private void nbr_Num_ValueChanged(object sender, EventArgs e)
        {
            rtx_IntoCash.Text = (Convert.ToInt32(rtx_Price.Text) * (Convert.ToInt32(nbr_Num.Value))).ToString();

        }

        void GetCusId()
        {
            DataTable dt = bl.getCusID();

            if (dt != null && dt.Columns.Count > 0)
            {
                listId = new List<string>();

                foreach (DataRow row in dt.Rows)
                {
                    listId.Add(row[0].ToString());
                }

                ListIdCus = listId;
            }
        }

        private void cal_voucher()
        {
            foreach (string id in ListIdCus)
            {
                if (id != null)
                {
                    bl.cal_voucher(id, 0);
                }

            }
        }


    }
}
