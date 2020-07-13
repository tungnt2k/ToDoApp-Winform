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
        private Card card;
        private List<Comment> comments;
        private List<Task> tasks;
        public TaskForm(Card c)
        {
            InitializeComponent();
            card = c;
            loadTask();
            loadComment();
        }

        private void loadComment()
        {
            flpComments.Controls.Clear();
            using (var dbContext = new TODOContext())
            {
                comments = dbContext.Comments.Where(c => c.CardId == card.Id).ToList();
            }

            foreach (var comment in comments)
            {
                UCComment ucComment = new UCComment(comment);
                flpComments.Controls.Add(ucComment);
            }

            UCAddComment ucAddComment = new UCAddComment(card);
            ucAddComment.CmtAdded += new EventHandler(UCAddCmt_CmtAdded);
            flpComments.Controls.Add(ucAddComment);
        }

        protected void UCAddCmt_CmtAdded(object sender, EventArgs e)
        {
            loadComment();
        }

        private void loadTask()
        {
            flpTasks.Controls.Clear();
            using (var dbContext = new TODOContext())
            {
                tasks = dbContext.Tasks.Where(c => c.CardId == card.Id).ToList();
            }

            foreach (var task in tasks)
            {
                UCTask ucTask = new UCTask(task);
                flpTasks.Controls.Add(ucTask);
            }

            UCAddCard ucAdd = new UCAddCard();
            ucAdd.BtnAddClick += new EventHandler(UCAdd_BtnAddClick);
            flpTasks.Controls.Add(ucAdd);
           
        }

        protected void UCAdd_BtnAddClick(object sender, EventArgs e)
        {
            Task task = new Task();
            task.CardId = card.Id;
            task.Name = "My task";
            using (var dbContext = new TODOContext())
            {
                dbContext.Tasks.Add(task);
                dbContext.SaveChanges();
            }
            loadTask();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
