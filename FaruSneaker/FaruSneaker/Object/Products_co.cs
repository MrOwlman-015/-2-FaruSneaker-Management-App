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
    public partial class Products_co : UserControl
    {
        Product_logic pl = new Product_logic();
        byte[]? imageBytes = null;

        public Products_co()
        {
            InitializeComponent();
        }

        private void setEditingMode(bool enable)
        {
            if (!enable)
            {
                dgv_product.ClearSelection();
            }
            btn_add.Enabled = !enable;
            btn_delete.Enabled = enable;
            btn_update.Enabled = enable;
            btn_Clear.Enabled = enable;
            btn_Image.Enabled = !enable;
        }

        private void load()
        {
            dgv_product.DataSource = pl.load();
        }
        private void loadFile()
        {
            string[] lines = File.ReadAllLines("color-list.txt");
            foreach (string line in lines)
            {
                cbx_productColor.Items.Add(line);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = txt_pid.Text;
            string name = txt_pname.Text;
            int price = Convert.ToInt32(txt_price.Text);
            string brand = txt_pbrand.Text;
            string? color = cbx_productColor.SelectedItem.ToString();
            if (color == null)
            {
                MessageBox.Show("Vui lòng chọn màu sắc!");
                return;
            }
            if (imageBytes == null)
            {
                MessageBox.Show("Vui lòng chọn hình ảnh!");
                return;
            }
            int size = Convert.ToInt32(nbr_productSize.Value);
            int num = Convert.ToInt32(nbr_productNum.Value);
            int importprice = Convert.ToInt32(txt_importprice.Text);
            DateTime dt = dtm_productImportDate.Value;
            if (pl.add(id, name, price, brand, color, size, num, importprice, dt, imageBytes))
            {
                btn_Clear_Click(sender, e);
                load();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string id = txt_pid.Text;
            if (pl.remove(id))
            {
                btn_Clear_Click(sender, e);
                load();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string id = txt_pid.Text;
            string name = txt_pname.Text;
            int price = Convert.ToInt32(txt_price.Text);
            string brand = txt_pbrand.Text;
            string? color = cbx_productColor.SelectedItem.ToString();
            if (color == null)
            {
                MessageBox.Show("Vui lòng chọn màu sắc!");
                return;
            }
            int size = Convert.ToInt32(nbr_productSize.Value);
            int num = Convert.ToInt32(nbr_productNum.Value);
            int importprice = Convert.ToInt32(txt_importprice.Text);
            DateTime dt = dtm_productImportDate.Value;
            if (pl.update(id, name, price, brand, color, size, num, importprice, dt, imageBytes))
            {
                btn_Clear_Click(sender, e);
                load();
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

        private void dgv_product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setEditingMode(true);
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && !isRowNullOrEmpty(dgv_product.Rows[e.RowIndex]))
            {
                DataGridViewRow row = dgv_product.Rows[e.RowIndex];

                txt_pid.Text = row.Cells[0].Value.ToString();
                txt_pname.Text = row.Cells[1].Value.ToString();
                txt_price.Text = row.Cells[2].Value.ToString();
                txt_pbrand.Text = row.Cells[3].Value.ToString();
                cbx_productColor.Text = row.Cells[4].Value.ToString();
                nbr_productSize.Value = Convert.ToDecimal(row.Cells[5].Value);
                nbr_productNum.Value = Convert.ToDecimal(row.Cells[6].Value);
                txt_importprice.Text = Convert.ToString(row.Cells[7].Value);
                dtm_productImportDate.Value = Convert.ToDateTime(row.Cells[8].Value);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            setEditingMode(false);
            dgv_product.ClearSelection();
            txt_pid.Text = "";
            txt_pname.Text = "";
            txt_price.Text = "";
            txt_pbrand.Text = "";
            txt_importprice.Text = "";
            nbr_productNum.Value = 0;
            nbr_productSize.Value = 0;
            dtm_productImportDate.Value = DateTime.Today;
        }

        private void ptb_Image_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog1.FileName; // Lấy đường dẫn đầy đủ của file hình ảnh

                // Đọc dữ liệu của file hình ảnh vào một mảng byte
                imageBytes = File.ReadAllBytes(imagePath);

            }

        }

        private void Products_co_Load(object sender, EventArgs e)
        {
            loadFile();
            load();
            txt_pid.ReadOnly = true;
            setEditingMode(false);
        }
    }
}
