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
    public partial class UCAddComment : System.Windows.Forms.UserControl
    {
        private Card card;
        public event EventHandler CmtAdded;
        public UCAddComment(Card c)
        {
            InitializeComponent();
            card = c;
        }

        private void btnAddCmt_Click(object sender, EventArgs e)
        {
            Comment cmt = new Comment();
            cmt.CardId = card.Id;
            cmt.Content = tbCmtContent.Text;
            using (var dbContext = new TODOContext())
            {
                dbContext.Comments.Add(cmt);
                dbContext.SaveChanges();
            }

            if (CmtAdded!=null)
            {
                CmtAdded(sender,e);
            }
        }
    }
}
