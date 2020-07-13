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
using Task = BTL.Models.Task;

namespace BTL.Component
{
    public partial class UCTask : System.Windows.Forms.UserControl
    {
        private Task task;
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
    }
}
