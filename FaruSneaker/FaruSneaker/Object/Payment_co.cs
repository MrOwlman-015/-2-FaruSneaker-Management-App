using BUS;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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

        public void ReloadForm()
        {
            // Reload all the controls and data on the form
            InitializeComponent();
            RefreshData();
        }

        private void RefreshData()
        {
            rtx_BillID.Text = "";
            cbx_CusID.Text = "";
            cbx_StaffID.Text = "";
            rtx_CusName.Text = "";
            rtx_StaffName.Text = "";

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
            if (bi.checkInBillDetail(id))
            {
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
            else
            {
                if (bi.removeService(id))
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


        }

        private void reset()
        {
            rtx_BillID.Text = "";
            cbx_CusID.Text = "";
            cbx_StaffID.Text = "";
            rtx_CusName.Text = "";
            rtx_StaffName.Text = "";
        }

        private void btn_PayBill_Click(object sender, EventArgs e)
        {
            if (cbx_CusID.Text == "" || cbx_StaffID.Text == "")
            {
                MessageBox.Show("Hãy đảm bảo đầy đủ nội dung!");
            }
            else
            {
                string? cusid = cbx_CusID.SelectedItem.ToString();
                if (bl.update(bl.getCurrentID(), cusid, Convert.ToInt32(rtx_TotalCash.Text), cbx_StaffID.SelectedItem.ToString()))
                {
                    reset();
                    if (dgv_Payment.Rows.Count > 0)
                    {
                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.Filter = "PDF (*.pdf)|*.pdf";
                        sfd.FileName = "Output.pdf";
                        bool fileError = false;
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            if (File.Exists(sfd.FileName))
                            {
                                try
                                {
                                    File.Delete(sfd.FileName);
                                }
                                catch (IOException ex)
                                {
                                    fileError = true;
                                    MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                                }
                            }
                            if (!fileError)
                            {

                                PdfPTable pdfTable = new PdfPTable(dgv_Payment.Columns.Count);
                                pdfTable.DefaultCell.Padding = 3;
                                pdfTable.WidthPercentage = 100;
                                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                                foreach (DataGridViewColumn column in dgv_Payment.Columns)
                                {
                                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                    pdfTable.AddCell(cell);
                                }

                                foreach (DataGridViewRow row in dgv_Payment.Rows)
                                {
                                    foreach (DataGridViewCell cell in row.Cells)
                                    {
                                        if (cell.Value != null)
                                        {
                                            pdfTable.AddCell(cell.Value.ToString());

                                        }
                                    }
                                }

                                using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                                {
                                    Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                    PdfWriter.GetInstance(pdfDoc, stream);
                                    pdfDoc.Open();
                                    pdfDoc.Add(pdfTable);
                                    pdfDoc.Close();
                                    stream.Close();
                                }

                                MessageBox.Show("Data Exported Successfully !!!", "Info");


                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Record To Export !!!", "Info");
                    }
                    MessageBox.Show("Thành công!");
                }
                else
                {
                    reset();
                    MessageBox.Show("Thất bại!");
                }
            }
            
        }

        private void Payment_co_Load(object sender, EventArgs e)
        {
            rtx_BillID.ReadOnly = true;
            loadFile();
        }

        private void Payment_co_Activated(object sender, EventArgs e)
        {
            rtx_BillID.ReadOnly = true;
            loadFile();
        }

        private void btn_Service_Click(object sender, EventArgs e)
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
                servicedetail p = new servicedetail(id);
                this.Hide();
                p.ShowDialog();

                BillDetail_logic bi = new BillDetail_logic();
                rtx_TotalCash.Text = bi.getTotalCashService(id).ToString();
                dgv_Payment.DataSource = bi.loadForService(id);
                this.Show();
            }
        }

        private void cButton7_Click(object sender, EventArgs e)
        {
            if (rtx_Search.Texts != "")
            {
                DataTable dt = bl.searchById(rtx_Search.Texts);
                DataRow row = dt.Rows[0];
                rtx_BillID.Text = row[0].ToString();
                cbx_CusID.Text = row[1].ToString();
                cbx_CusID_SelectedIndexChanged(sender, e);
                cbx_StaffID.Text = row[3].ToString();
                cbx_StaffID_SelectedIndexChanged(sender, e);
                BillDetail_logic bi = new BillDetail_logic();
                string? id = row[0].ToString();
                if (id != null)
                {
                    if (bi.checkInBillDetail(id))
                    {
                        rtx_TotalCash.Text = bi.getTotalCash(id).ToString();
                        dgv_Payment.DataSource = bi.load(id);
                    }
                    else
                    {
                        rtx_TotalCash.Text = bi.getTotalCashService(id).ToString();
                        dgv_Payment.DataSource = bi.loadForService(id);
                    }
                }
            }

        }
    }
}
