using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL.Component
{
    public partial class UCAddCard : System.Windows.Forms.UserControl
    {
        public event EventHandler BtnAddClick;
        public UCAddCard()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.BtnAddClick != null)
                this.BtnAddClick(this, e);
        }
    }
}
