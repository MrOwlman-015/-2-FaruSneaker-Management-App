/*using FaruSneaker.Business;
using System.Data;*/
using BUS;
using DAL;

namespace FaruSneaker
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        Account_logic data = new Account_logic();

        bool check(string username, string password, int roleuser)
        {
            return data.check(username, password, 0);
        }


        private void roundpictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!");
                return;
            }
            else
            {
                if (txt_pass.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu!");
                    return;
                }
                else
                {
                    string user_name = txt_username.Text;
                    string password = txt_pass.Text;
                    if (check(user_name, password, 0))
                    {
                        Mainpage mainpage = new Mainpage();
                        this.Hide();
                        mainpage.ShowDialog();
                        this.Close();
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}