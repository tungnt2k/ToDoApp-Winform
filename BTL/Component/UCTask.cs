using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL.Forms;
using Task = BTL.Models.Task;

namespace BTL.Component
{
    public partial class UCTask : System.Windows.Forms.UserControl
    {
        private Task task;

        public event EventHandler DataUpdated;
        public UCTask(Task task)
        {
            InitializeComponent();
            this.task = task;
            gunaCheckBox1.Checked = this.task.IsDone;
            loadData();
        }

        private void loadData()
        {
            lbTaskName.Text = this.task.Name;
            ChangeStrikeout(this.task.IsDone);
        }

        private void ChangeStrikeout(bool b)
        {
            if (b)
            {
                lbTaskName.Font = new Font(lbTaskName.Font, FontStyle.Strikeout);
            }
            else
            {
                lbTaskName.Font = new Font(lbTaskName.Font,FontStyle.Regular);
            }
        }

        private void gunaCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            using (var dbContext = new TODOContext())
            {
                task.IsDone = gunaCheckBox1.Checked;
                dbContext.Tasks.AddOrUpdate(task);
                dbContext.SaveChanges();
                loadData();
            }
            
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            EditTask et = new EditTask(task);
            et.DataUpdated += new EventHandler(EditTask_DataUpdated);
            et.Show();
        }

        protected void EditTask_DataUpdated(object sender, EventArgs e)
        {
            if (this.DataUpdated!= null)
            {
                this.DataUpdated(sender, e);
            }
        }
    }
}
