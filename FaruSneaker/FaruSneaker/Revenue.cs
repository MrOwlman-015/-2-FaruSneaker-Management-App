using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace FaruSneaker
{
    public partial class Revenue : Form
    {
        Bill_logic bl = new Bill_logic();
        public Revenue()
        {
            InitializeComponent();
        }

        private void load()
        {
            dgv_Bill.DataSource = bl.load();

        }

        private void btn_Bind_Click(object sender, EventArgs e)
        {
            load();
            txt_TotalCash.Text = bl.getTotalCash().ToString();
        }

        private void Revenue_Load(object sender, EventArgs e)
        {

        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            if (dgv_Bill.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "Output.pdf";
                bool fileError = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Thất bại!" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dgv_Bill.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dgv_Bill.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dgv_Bill.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (cell == null || cell.Value == null)
                                    {
                                        break;
                                    }
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Thành công!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi!" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Thất bại!");
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (bl.removeAll())
            {
                MessageBox.Show("Thành công!");
                load();
            }
            else
            {
                MessageBox.Show("Thất bại!");
                return;
            }
        }
    }
}
