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
    public partial class Employee_co : UserControl
    {
        public Employee_co()
        {
            InitializeComponent();
            load();
            txt_search.KeyPress += new KeyPressEventHandler(txt_search_KeyPress);
        }

        Employee_logic data = new Employee_logic();

        void load()
        {
            table_E.DataSource = data.load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Id = txt_eid.Text;
            string name = txt_ename.Text;
            string phone = txt_ephone.Text;
            string ci = txt_ci.Text;
            DateTime DOB = dob.Value;
            string add = txt_add.Text;
            int salary = Int32.Parse(txt_salary.Text);

            if (!int.TryParse(txt_salary.Text, out salary))
            {
                error.SetError(txt_salary, "Giá trị lương không bao gồm kí tự chữ cái");
                return;
            }
            else
            {
                error.Clear();
            }

            if (data.update(Id, name, phone, ci, DOB, add, salary))
            {
                load();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = txt_eid.Text;
            if (MessageBox.Show("Bạn có muốn xóa nhân viên vừa chọn không?", "Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (data.delete(id))
                {
                    MessageBox.Show("Xóa thành công");
                    load();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string Id = txt_eid.Text;
            string name = txt_ename.Text;
            string phone = txt_ephone.Text;
            string ci = txt_ci.Text;
            DateTime DOB = dob.Value;
            string add = txt_add.Text;
            int salary = Int32.Parse(txt_salary.Text);

            if (!int.TryParse(txt_salary.Text, out salary))
            {
                error.SetError(txt_salary, "Giá trị lương không bao gồm kí tự chữ cái");
                return;
            }
            else
            {
                error.Clear();
            }

            if (data.add(Id, name, phone, ci, DOB, add, salary))
            {
                load();
            }
        }

        private void table_E_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= table_E.RowCount)
            {
                return;
            }

            DataGridViewRow row = this.table_E.Rows[e.RowIndex];
            txt_eid.Text = row.Cells["StaffID"].Value.ToString();
            txt_ename.Text = row.Cells["StaffName"].Value.ToString();
            txt_ephone.Text = row.Cells["StaffPhone"].Value.ToString();
            txt_ci.Text = row.Cells["StaffCI"].Value.ToString();
            dob.Value = (DateTime)row.Cells["StaffDateOfBirth"].Value;
            txt_add.Text = row.Cells["StaffAddress"].Value.ToString();
            txt_salary.Text = row.Cells["StaffSalary"].Value.ToString();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string searchid = txt_search.Text;
            DataTable res = data.searchById(searchid);
            if (res.Rows.Count == 0)
            {
                MessageBox.Show("No employee found");
                load();
            }
            else
            {
                table_E.DataSource = res;
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

        private void button4_Click(object sender, EventArgs e)
        {
            Salary s = new Salary();
            s.ShowDialog();
        }



        private void button5_Click(object sender, EventArgs e)
        {
                Timek f = new Timek();
                f.ShowDialog();


        }






    }
}
