using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL.Models;

namespace BTL.Component
{
    public partial class UCComment : System.Windows.Forms.UserControl
    {
        private Comment cmt;
        public UCComment(Comment c)
        {
            InitializeComponent();
            this.cmt = c;
            lbContentCmt.Text = c.Content;
            lbTime.Text = c.CreatedAt.ToShortDateString();
        }
    }
}
