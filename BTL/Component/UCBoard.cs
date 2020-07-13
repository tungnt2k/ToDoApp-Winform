using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL.CustomEventArgs;
using BTL.Models;
using Task = BTL.Models.Task;

namespace BTL.Component
{
    public partial class UCBoard : System.Windows.Forms.UserControl
    {
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks button")]
        public event EventHandler ButtonClick;

        public event EventHandler<BoardEventArgs> ClickBoard;
        private Board board;
        public UCBoard(Board b)
        {
            InitializeComponent();
            board = b;
            gunaLabel1.Text = board.Name;
        }

        private void btnEllipsis_Click(object sender, EventArgs e)
        {
            using (var dbContext = new TODOContext())
            {
                var boardInDb = dbContext.Boards.SingleOrDefault(i => i.Id == board.Id);
                if (boardInDb!=null)
                {
                    dbContext.Boards.Remove(boardInDb);
                    dbContext.SaveChanges();
                }
            }
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }

        private void UCBoard_Click(object sender, EventArgs e)
        {
            if (this.ClickBoard != null)
                this.ClickBoard(this, new BoardEventArgs(board));
        }
    }
}
