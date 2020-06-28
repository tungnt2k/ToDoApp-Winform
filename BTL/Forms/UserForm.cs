using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL.Models;

namespace BTL.Forms
{
    public partial class UserForm : Form
    {
        private User user { get; set; }
        public UserForm(User u)
        {
            InitializeComponent();
            user = u;
            tbFullname.Text = user.FullName;
            tbEmail.Text = user.Email;
            tbPhone.Text = user.Phone;
            dtpBirthday.Value = user.BirthDay;
            tbAddress.Text = user.Address;

        }

        private void tbFullname_TextChanged(object sender, EventArgs e)
        {
            user.FullName = tbFullname.Text;
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            user.Email = tbEmail.Text;
        }

        private void dtpBirthday_ValueChanged(object sender, EventArgs e)
        {
            user.BirthDay = dtpBirthday.Value;
        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {
            user.Address = tbAddress.Text;
        }

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {
            user.Phone = tbPhone.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var dbContext = new TODOContext())
            {
                dbContext.Users.AddOrUpdate(user);
                dbContext.SaveChanges();
            }

        }
    }
}
