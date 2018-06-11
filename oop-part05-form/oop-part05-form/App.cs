using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using oop_part05_form.Model;

namespace oop_part05_form
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
            foreach (var item in Entity.Categories)
            {
                categoryList.Items.Add(item.Name);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var name = productName.Text;
            var price = Convert.ToInt32(productPrice.Text);
            var category = categoryList.SelectedItem.ToString();
            ProductController.Create(name, price, category);



        }

        private void showButton_Click(object sender, EventArgs e)
        {
            productListView.Text = string.Empty;
            foreach (var item in Entity.Products)
            {
                productListView.Text += item.Id + " . " + item.Name + " / "+ item.CategoryName + " / " +item.Price + "\r\n";
            }
        }

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            var name = categoryName.Text;
            var cat = new Category();
            cat.Name = name;
            Entity.Categories.Add(cat);
            categoryList.Items.Clear();
            foreach (var item in Entity.Categories)
            {
                categoryList.Items.Add(item.Name);
            }
        }
    }
}
