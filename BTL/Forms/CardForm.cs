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
using BTL.UserControl;

namespace BTL.Forms
{
    public partial class CardForm : Form
    {
        private Board board;

        public event EventHandler<CardEventArgs> CardClick;

        public event EventHandler BtnBackClick;

        private List<Card> cards;
        public CardForm(Board b)
        {
            InitializeComponent();
            board = b;
            loadData();
        }

        private void loadData()
        {
            flpCards.Controls.Clear();
            using (var dbContext = new TODOContext())
            {
                cards = dbContext.Cards.ToList();
            }
            foreach (var card in cards)
            {
                UCCollection ucCollection = new UCCollection(card);
                ucCollection.eventLoadData += new EventHandler(UCCard_LoadData);
                ucCollection.ClickCard += new EventHandler<CardEventArgs>(UCCard_Click);
                flpCards.Controls.Add(ucCollection);
            }
            UCAddCard ucAddCollection = new UCAddCard();
            ucAddCollection.BtnAddClick += new EventHandler(UCAddList_btnAddClick);
            flpCards.Controls.Add(ucAddCollection);
        }

        protected void UCCard_LoadData(object sender, EventArgs e)
        {
            loadData();
        }

        protected void UCCard_Click(object sender, CardEventArgs e)
        {

            if (this.CardClick != null)
                this.CardClick(this, new CardEventArgs(e.card));
        }

        protected void UCAddList_btnAddClick(object sender, EventArgs e)
        {
            Card newCard = new Card();
            newCard.Name = "My Card";
            newCard.BoardId = board.Id;
            newCard.StartTime = DateTime.Now;
            newCard.EndTime = DateTime.Now;
            using (var dbContext = new TODOContext())
            {
                dbContext.Cards.Add(newCard);
                dbContext.SaveChanges();
            }
            loadData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (this.BtnBackClick != null)
                this.BtnBackClick(this, e);
        }

    }
}
