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
using BTL.Forms;
using BTL.Models;
using Task = BTL.Models.Task;

namespace BTL.Component
{
    public partial class UCBoard : System.Windows.Forms.UserControl
    {
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks button")]
        public event EventHandler LoadData;

        public event EventHandler<BoardEventArgs> ClickBoard;
        private Board board;
        public UCBoard(Board b)
        {
            InitializeComponent();
            board = b;
            gunaLabel1.Text = board.Name;
        }


        protected void EditBoard_UpdatedData(object sender, EventArgs e)
        {
            if (this.LoadData != null)
                this.LoadData(this, e);
        }

        private void UCBoard_Click(object sender, EventArgs e)
        {
            if (this.ClickBoard != null)
                this.ClickBoard(this, new BoardEventArgs(board));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            EditBoard eb = new EditBoard(board);
            eb.DataUpdated += new EventHandler(EditBoard_UpdatedData);
            eb.Show();
        }
    }
}
