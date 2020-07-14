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
    public partial class SettingForm : Form
    {
        private UserSetting us;
        public SettingForm()
        {
            InitializeComponent();
            using (var dbContext = new TODOContext())
            {
                us = dbContext.UserSettings.Find(1);
                switchStartWithWindow.Checked = us.StartWithWin;
                switchNoti.Checked = us.Noti;
            }
        }

        private void switchStartWithWindow_CheckedChanged(object sender, EventArgs e)
        {
            if (switchStartWithWindow.Checked == true)
            {
                AutoStartup.AddApplicationToStartup();
            }
            else
            {
                AutoStartup.RemoveApplicationFromStartup();
            }

            using (var dbContext = new TODOContext())
            {
                us.StartWithWin = switchStartWithWindow.Checked;
                dbContext.UserSettings.AddOrUpdate(us);
                dbContext.SaveChanges();

            }
        }

        private void switchNoti_CheckedChanged(object sender, EventArgs e)
        {
            using (var dbContext = new TODOContext())
            {
                us.Noti = switchNoti.Checked;
                dbContext.UserSettings.AddOrUpdate(us);
                dbContext.SaveChanges();
            }
        }
    }
}
