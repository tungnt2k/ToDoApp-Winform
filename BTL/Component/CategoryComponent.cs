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
    public partial class CategoryComponent : UserControl
    {
        private Category category;
        public CategoryComponent(Category cate)
        {
            InitializeComponent();
            category = cate;
            gunaLabel1.Text = cate.Name;
        }
    }
}
