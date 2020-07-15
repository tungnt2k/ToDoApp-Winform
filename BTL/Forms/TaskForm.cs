using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
        }

        protected void UCAddCmt_CmtAdded(object sender, EventArgs e)
        {
            loadTask();
        }

        private void loadTask()
        {
            flpTasks.Controls.Clear();
            using (var dbContext = new TODOContext())
            {
                tasks = dbContext.Tasks.Where(c => c.CardId == card.Id).ToList();
                comments = dbContext.Comments.Where(c => c.CardId == card.Id).ToList();
            }

            foreach (var task in tasks)
            {
                UCTask ucTask = new UCTask(task);
                ucTask.DataUpdated += new EventHandler(UCTask_DataUpdated);
                flpTasks.Controls.Add(ucTask);
            }

            UCAddCard ucAdd = new UCAddCard();
            ucAdd.BtnAddClick += new EventHandler(UCAdd_BtnAddClick);
            flpTasks.Controls.Add(ucAdd);

            foreach (var comment in comments)
            {
                UCComment ucComment = new UCComment(comment);
                flpTasks.Controls.Add(ucComment);
            }

            UCAddComment ucAddComment = new UCAddComment(card);
            ucAddComment.CmtAdded += new EventHandler(UCAddCmt_CmtAdded);
            flpTasks.Controls.Add(ucAddComment);

        }

        protected void UCTask_DataUpdated(object sender, EventArgs e)
        {
            loadTask();
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


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void gunaPanel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
