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

namespace BTL.UserControl
{
    public partial class UCCollection : System.Windows.Forms.UserControl
    {
        private Card card;

        public event EventHandler eventLoadData;

        public event EventHandler<CardEventArgs> ClickCard;
        public UCCollection(Card card)
        {
            InitializeComponent();
            this.card = card;
            lbName.Text = this.card.Name;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var dbContext = new TODOContext())
            {
                var cardInDb = dbContext.Cards.SingleOrDefault(i => i.Id == card.Id);
                if (cardInDb != null)
                {
                    dbContext.Cards.Remove(cardInDb);
                    dbContext.SaveChanges();
                }
            }
            if (this.eventLoadData != null)
                this.eventLoadData(this, e);
        }

        private void UCCollection_Click(object sender, EventArgs e)
        {
            if (this.ClickCard != null)
                this.ClickCard(this, new CardEventArgs(card));
        }
    }
}
