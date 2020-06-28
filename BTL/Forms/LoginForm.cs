using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL.Models;

namespace BTL
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            User user = login(tbUsername.Text, tbPassword.Text);
            if (user!=null)
            {
                this.Hide();
                Main main = new Main(user);
                main.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Cảnh báo", "Tài khoản mật khẩu không chính xác", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private   User  login (string username, string password)
        {

            using (TODOContext dbContext = new TODOContext())
            {
                var user = dbContext.Users.FirstOrDefault<User>(u => u.Username == username);
                if (user!=null&&user.Password==password) return user;
                return null;
            }
        }
    }
}
