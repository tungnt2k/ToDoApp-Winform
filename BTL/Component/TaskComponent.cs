using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task = BTL.Models.Task;

namespace BTL.Component
{
    public partial class TaskComponent : UserControl
    {
        private Task task;
        public TaskComponent(Task t)
        {
            InitializeComponent();
            task = t;
            gunaLabel1.Text = task.Title;
            gunaCheckBox1.Checked = task.Completed;
        }
    }
}
