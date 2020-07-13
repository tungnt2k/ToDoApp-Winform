using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTL.Models;

namespace BTL.CustomEventArgs
{
    public class BoardEventArgs:EventArgs
    {
        public Board board;

        public BoardEventArgs(Board b)
        {
            this.board = b;
        }
    }
}
