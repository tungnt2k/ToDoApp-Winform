using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL.Component;
using BTL.Models;
using Task = BTL.Models.Task;

namespace BTL.Forms
{
    public partial class TaskForm : Form
    {
        private User user;
        private List<Category> categories;
        private List<Task> tasks;
        private int possition = 10;
        public TaskForm(User u)
        {
            InitializeComponent();
            user = u;
            loadData();
        }

        private void loadData()
        {
            cbbCategory.DisplayMember = "Text";
            cbbCategory.ValueMember = "Value";
            pnlListTask.Controls.Clear();
            using (var dbContext = new TODOContext())
            {
                categories = dbContext.Categories.Where(c => c.UserId == user.Id).ToList();
                tasks = dbContext.Tasks.Where(t => t.UserId == user.Id).ToList();
                foreach (var task in tasks)
                {
                    TaskComponent taskComponent = new TaskComponent(task);
                    taskComponent.Top = possition;
                    possition = taskComponent.Top + taskComponent.Height + 10;
                    pnlListTask.Controls.Add(taskComponent);
                }
                categories.ForEach(c =>
                {
                    cbbCategory.Items.Add(new {Text = c.Name, Value = c.Id});
                });

            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Task task = new Task();
            task.CategoryId = (cbbCategory.SelectedItem as dynamic).Value;
            task.Content = tbContent.Text;
            task.Title = tbTitle.Text;
            task.Completed = false;
            task.EstimateTime = int.Parse(numEstimateTime.Value.ToString());
            task.CreatedAt = DateTime.Now;
            task.UpdatedAt = DateTime.Now;
            task.UserId = user.Id;
            using (var dbContext = new TODOContext())
            {
                dbContext.Tasks.Add(task);
                dbContext.SaveChanges();
                loadData();
            }
        }
    }
}
