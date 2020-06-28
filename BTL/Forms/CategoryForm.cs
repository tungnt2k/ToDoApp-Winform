using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL.Component;
using BTL.Models;

namespace BTL.Forms
{
    public partial class CategoryForm : Form
    {
        private User user;
        private List<Category> categories;
        private int possition = 10;
        public CategoryForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            pnlListCategory.Controls.Clear();
            using (var dbContext = new TODOContext())
            {
                categories = dbContext.Categories.Where(c => c.UserId == user.Id).ToList();
                foreach (var category in categories)
                {
                    CategoryComponent cateComponent = new CategoryComponent(category);
                    cateComponent.Top = possition;
                    possition = cateComponent.Top + cateComponent.Height + 10;
                    pnlListCategory.Controls.Add(cateComponent);
                }

            }

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Category cate = new Category();
            cate.Name = tbNameCate.Text;
            cate.CreatedAt = DateTime.Now;
            cate.UpdatedAt = DateTime.Now;
            cate.UserId = user.Id;
            using (var dbContext = new TODOContext())
            {
                dbContext.Categories.Add(cate);
                dbContext.SaveChanges();
                loadData();
            }
        }
    }
}
