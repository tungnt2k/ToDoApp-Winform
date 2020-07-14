using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL.CustomEventArgs;
using BTL.Forms;
using BTL.Models;

namespace BTL.UserControl
{
    public partial class UCCollection : System.Windows.Forms.UserControl
    {
        private Card card;

        public event EventHandler eventLoadData;

        public event EventHandler<CardEventArgs> ClickCard;
        public UCCollection(Card c)
        {
            InitializeComponent();
            this.card = c;
            lbName.Text = card.Name;
            cbIsDone.Checked = card.IsDone;
            lbStartDate.Text = card.StartTime.ToString();
            lbEndDate.Text = card.EndTime.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            EditCard ec = new EditCard(card);
            ec.DataUpdated += new EventHandler(EditCard_DataUpdated);
            ec.Show();
        }

        protected void EditCard_DataUpdated(object sender, EventArgs e)
        {
            if (this.eventLoadData != null)
                this.eventLoadData(this, e);
        }

        private void UCCollection_Click(object sender, EventArgs e)
        {
            if (this.ClickCard != null)
                this.ClickCard(this, new CardEventArgs(card));
        }


        private void cbIsDone_CheckedChanged_1(object sender, EventArgs e)
        {
            using (var dbContext = new TODOContext())
            {
                card.IsDone = cbIsDone.Checked;
                card.UpdatedAt = DateTime.Now;
                dbContext.Cards.AddOrUpdate(card);
                dbContext.SaveChanges();
            }

            if (this.eventLoadData != null)
                this.eventLoadData(this, e);
        }
    }
}
