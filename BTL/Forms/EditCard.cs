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
    public partial class EditCard : Form
    {
        private Card card;
        public event EventHandler DataUpdated;
        public EditCard(Card c)
        {
            InitializeComponent();
            card = c;
            tbCardName.Text = card.Name;
            dateStartTime.Value = card.StartTime.Date;
            dateEndTime.Value = card.EndTime.Date;
            timeStartTime.Value = card.StartTime;
            timeEndTime.Value = card.EndTime;
            cbIsDone.Checked = card.IsDone;
            switchNoti.Checked = card.Notification;
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var dbContext = new TODOContext())
            {
                card.Name = tbCardName.Text;
                card.StartTime = dateStartTime.Value.Date + timeStartTime.Value.TimeOfDay;
                card.EndTime = dateEndTime.Value.Date + timeEndTime.Value.TimeOfDay;
                card.IsDone = cbIsDone.Checked;
                card.Notification = switchNoti.Checked;
                card.UpdatedAt = DateTime.Now;
                dbContext.Cards.AddOrUpdate(card);
                dbContext.SaveChanges();
            }
            if (this.DataUpdated != null)
                this.DataUpdated(this, e);
            this.Close();
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
            if (this.DataUpdated != null)
                this.DataUpdated(this, e);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
