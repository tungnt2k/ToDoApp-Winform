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
using Task = BTL.Models.Task;

namespace BTL.Forms
{
    public partial class EditTask : Form
    {

        private Task task;
        public event EventHandler DataUpdated;
        public EditTask(Task t)
        {
            InitializeComponent();
            task = t;
            gunaTextBox1.Text = task.Name;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var dbContext = new TODOContext())
            {
                task.Name = gunaTextBox1.Text;
                task.UpdatedAt = DateTime.Now;
                dbContext.Tasks.AddOrUpdate(task);
                dbContext.SaveChanges();
            }
            if (this.DataUpdated != null)
                this.DataUpdated(this, e);
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var dbContext = new TODOContext())
            {
                var taskInDb = dbContext.Tasks.SingleOrDefault(i => i.Id == task.Id);
                if (taskInDb != null)
                {
                    dbContext.Tasks.Remove(taskInDb);
                    dbContext.SaveChanges();
                }
            }
            if (this.DataUpdated != null)
                this.DataUpdated(this, e);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
