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
using BTL.CustomEventArgs;
using BTL.Models;
using Task = BTL.Models.Task;

namespace BTL.Forms
{
    public partial class BoardForm : Form
    {
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks button")]
        public event EventHandler<BoardEventArgs> BoardClick;

        private List<Board> boards;
        public BoardForm( )
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            flpListBoard.Controls.Clear();
            using (var dbContext = new TODOContext())
            {
                boards = dbContext.Boards.ToList();
            }
            foreach (var board in boards)
            {
                UCBoard ucBoard = new UCBoard(board);
                ucBoard.ButtonClick += new EventHandler(UCBoard_btnClick);
                ucBoard.ClickBoard+= new EventHandler<BoardEventArgs>(UCBoard_Click);
                flpListBoard.Controls.Add(ucBoard);
            }
            UCAddBoard ucAddBoard = new UCAddBoard();
            ucAddBoard.ButtonClick+= new EventHandler(UCAddBoard_btnAddClick);
            flpListBoard.Controls.Add(ucAddBoard);
        }

        protected void UCBoard_btnClick(object sender, EventArgs e)
        {
            loadData();
        }

        protected void UCBoard_Click(object sender, BoardEventArgs e)
        {
            
            if (this.BoardClick != null)
                this.BoardClick(this, new BoardEventArgs(e.board));
        }
        protected void UCAddBoard_btnAddClick(object sender, EventArgs e)
        {
            Board newBoard = new Board();
            newBoard.Name = "My Board";
            using (var dbContext = new TODOContext())
            {
                dbContext.Boards.Add(newBoard);
                dbContext.SaveChanges();
            }
            loadData();
        }
    }
}
