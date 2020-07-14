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
    public partial class EditBoard : Form
    {
        private Board board;
        public event EventHandler DataUpdated;
        public EditBoard(Board b)
        {
            InitializeComponent();
            board = b;
            gunaTextBox1.Text = board.Name;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var dbContext = new TODOContext())
            {
                var boardInDb = dbContext.Boards.SingleOrDefault(i => i.Id == board.Id);
                if (boardInDb != null)
                {
                    dbContext.Boards.Remove(boardInDb);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var dbContext = new TODOContext())
            {
                board.Name = gunaTextBox1.Text;
                board.UpdatedAt = DateTime.Now;
                dbContext.Boards.AddOrUpdate(board);
                dbContext.SaveChanges();
            }
            if (this.DataUpdated != null)
                this.DataUpdated(this, e);
            this.Close();
        }
    }
}
