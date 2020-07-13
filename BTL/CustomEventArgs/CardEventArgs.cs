using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTL.Models;

namespace BTL.CustomEventArgs
{
    public class CardEventArgs:EventArgs

    {
    public Card card;

    public CardEventArgs(Card c)
    {
        this.card = c;
    }
    }
}
