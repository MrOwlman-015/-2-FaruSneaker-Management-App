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

        private void setEditingMode(bool enable)
        {
            if (!enable)
            {
                table_E.ClearSelection();
            }
            btn_add.Enabled = !enable;
            btn_remove.Enabled = enable;
            btn_update.Enabled = enable;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int checkphone = 0;
            long checkci = 0;
            int checksalary = 0;
            if (!int.TryParse(txt_ephone.Text, out checkphone))
            {
                MessageBox.Show("Số điện thoại không bao gồm kí tự chữ cái");
                error.SetError(txt_ephone, "Số điện thoại không bao gồm kí tự chữ cái");
                return;
            }
            else
            {
                if (!long.TryParse(txt_ci.Text, out checkci))
                {
                    MessageBox.Show("Căn cước công dân không bao gồm kí tự chữ cái và gồm 12 số");
                    error.SetError(txt_salary, "Căn cước công dân không bao gồm kí tự chữ cái");
                    MessageBox.Show("Căn cước công dân không bao gồm kí tự chữ cái");
                    error.SetError(txt_ci, "Căn cước công dân không bao gồm kí tự chữ cái");
                    return;
                }
                else
                {
                    if (!int.TryParse(txt_salary.Text, out checksalary))
                    {
                        MessageBox.Show("Giá trị lương không bao gồm kí tự chữ cái");
                        error.SetError(txt_salary, "Giá trị lương không bao gồm kí tự chữ cái");
                        return;
                    }
                    else
                    {
                        error.Clear();
                        string Id = txt_eid.Text;
                        string name = txt_ename.Text;
                        string phone = txt_ephone.Text;
                        string ci = txt_ci.Text;
                        DateTime DOB = dob.Value;
                        string add = txt_add.Text;
                        int salary = Int32.Parse(txt_salary.Text);
                        if (data.update(Id, name, phone, ci, DOB, add, salary))
                        {
                            setEditingMode(false);
                            MessageBox.Show("Thành công!");
                            reset();
                            load();
                        }
                        else
                        {
                            setEditingMode(false);
                            reset();
                            MessageBox.Show("Thất bại!");
                            return;
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txt_eid.Text == "")
            {
                MessageBox.Show("Hãy đảm bảo bạn đã chọn id của nhân viên!");
                return;
            }
            else
            {
                string id = txt_eid.Text;
                if (MessageBox.Show("Bạn có muốn xóa nhân viên vừa chọn không?", "Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (data.delete(id))
                    {
                        setEditingMode(false);
                        reset();
                        MessageBox.Show("Xóa thành công");
                        load();
                    }
                    else
                    {
                        setEditingMode(false);
                        MessageBox.Show("Xóa không thành công");
                        return;
                    }
                }
            }

        }

        private void reset()
        {
            txt_eid.Text = "";
            txt_ename.Text = "";
            txt_ephone.Text = "";
            txt_ci.Text = "";
            txt_add.Text = "";
            txt_salary.Text = "";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int checkphone = 0;
            long checkci = 0;
            int checksalary = 0;
            if (!int.TryParse(txt_ephone.Text, out checkphone))
            {
                MessageBox.Show("Số điện thoại không bao gồm kí tự chữ cái");
                error.SetError(txt_ephone, "Số điện thoại không bao gồm kí tự chữ cái");
                return;
            }
            if (!long.TryParse(txt_ci.Text, out checkci))
            {
                MessageBox.Show("Căn cước công dân không bao gồm kí tự chữ cái");
                error.SetError(txt_ci, "Căn cước công dân không bao gồm kí tự chữ cái");
                return;
            }
            if (!int.TryParse(txt_salary.Text, out checksalary))
            {
                MessageBox.Show("Giá trị lương không bao gồm kí tự chữ cái");
                error.SetError(txt_salary, "Giá trị lương không bao gồm kí tự chữ cái");
                return;
            }

            error.Clear();
            string Id = txt_eid.Text;
            string name = txt_ename.Text;
            string phone = txt_ephone.Text;
            string ci = txt_ci.Text;
            DateTime DOB = dob.Value;
            string add = txt_add.Text;
            int salary = Int32.Parse(txt_salary.Text);

            bool result = data.add(Id, name, phone, ci, DOB, add, salary);
            if (result)
            {
                MessageBox.Show("Thêm nhân viên thành công");
                reset();
                load();
            }
            else
            {
                MessageBox.Show("Thêm nhân viên không thành công");
                if (!long.TryParse(txt_ci.Text, out checkci))
                {
                    MessageBox.Show("Căn cước công dân không bao gồm kí tự chữ cái");
                    error.SetError(txt_ci, "Căn cước công dân không bao gồm kí tự chữ cái");
                    return;
                }
                else
                {
                    if (!int.TryParse(txt_salary.Text, out checksalary))
                    {
                        MessageBox.Show("Giá trị lương không bao gồm kí tự chữ cái");
                        error.SetError(txt_salary, "Giá trị lương không bao gồm kí tự chữ cái");
                        return;
                    }
                    else
                    {
                        error.Clear();
             
                        if (data.add(Id, name, phone, ci, DOB, add, salary))
                        {
                            setEditingMode(false);
                            MessageBox.Show("Thành công!");
                            reset();
                            load();
                        }
                        else
                        {
                            setEditingMode(false);
                            reset();
                            MessageBox.Show("Thất bại!");
                            return;
                        }
                    }
                }
            }
        }
        private void table_E_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setEditingMode(true);
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
                MessageBox.Show("Không tìm thấy nhân viên!");
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

        private void Employee_co_Load(object sender, EventArgs e)
        {
            setEditingMode(false);
            txt_eid.ReadOnly = true;
            load();
        }
    }
}
