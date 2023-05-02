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
            return data.check(username, password, roleuser);
        }

        /*private void btn_SignIn_Click(object sender, EventArgs e)
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
                        txt_username.Text = "";
                        txt_pass.Text = "";
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản không chính xác!");
                    }
                }
            }
        }*/

        private void btn_SignIn_Click_1(object sender, EventArgs e)
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
                        txt_username.Text = "";
                        txt_pass.Text = "";
                        this.Show();
                    }
                    else
                    {
                        if (check(user_name, password, 1))
                        {
                            Mainpage_staff mp = new Mainpage_staff();
                            this.Hide();
                            mp.ShowDialog();
                            txt_username.Text = "";
                            txt_pass.Text = "";
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("Tài khoản không chính xác!");
                        }
                    }
                }
            }
        }
    }
}
