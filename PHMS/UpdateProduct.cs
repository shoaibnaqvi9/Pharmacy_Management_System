using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PHMS
{
    public partial class UpdateProduct : System.Windows.Forms.Form
    {
        public static int ok; 
        public UpdateProduct()
        {
            InitializeComponent();
        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            label4.Text = Product.ID.ToString();
            guna2TextBox2.Text = Product.Price.ToString();
            guna2TextBox3.Text = Product.Quantity.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ProductForm io = new ProductForm();
            Product.Price = int.Parse(guna2TextBox2.Text);
            Product.Quantity = int.Parse(guna2TextBox3.Text);
            
            MessageBox.Show("Update SuccessFully");
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}