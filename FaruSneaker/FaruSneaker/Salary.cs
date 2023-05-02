using BUS;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Document = iTextSharp.text.Document;

namespace FaruSneaker
{

    public partial class Salary : Form
    {
        private List<string> listId;
        public List<string> ListIdStaff { get => listId; set => listId = value; }
        public Salary()
        {
            InitializeComponent();
            GetStaffId();
            add_salary();
            load();
        }

        Salary_logic data = new Salary_logic();
        void load()
        {
            dgv_salary.DataSource = data.load();
        }



        /* bool update(string id)
         {
             return data.update(id);

         }*/
        void GetStaffId()
        {
            DataTable dt = data.getStaffID();

            if (dt != null && dt.Columns.Count > 0)
            {
                listId = new List<string>();

                foreach (DataRow row in dt.Rows)
                {
                    listId.Add(row[0].ToString());
                }

                ListIdStaff = listId;
            }
        }

        private void add_salary()
        {
            data.deleteAll();
            foreach (string id in ListIdStaff)
            {
                if (id != null)
                {
                    data.add(id);
                }

            }
                

             

        }

        private void btn_timekp_Click(object sender, EventArgs e)
        {
            if (dgv_salary.Rows.Count > 0)
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

                        PdfPTable pdfTable = new PdfPTable(dgv_salary.Columns.Count);
                        pdfTable.DefaultCell.Padding = 3;
                        pdfTable.WidthPercentage = 100;
                        pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                        foreach (DataGridViewColumn column in dgv_salary.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                            pdfTable.AddCell(cell);
                        }

                        foreach (DataGridViewRow row in dgv_salary.Rows)
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
        }

        private void btn_blank_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa bảng lương này?", "Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (data.deleteAll())
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




        /*
       void UpdateSalary()
        {
            GetStaffId();
            foreach (string id in ListIdStaff)
            {

                update(id);


            }
        }

      void AddDataForListIdStaff()
        {
            UpdateSalary();
            load();

            if (dgv_salary.Rows.Count == 1)

            {
                GetStaffId();
                foreach (string id in ListIdStaff)
                {

                    add(id).ToString();


                }
                load();

            }


        }*/



    }
}

