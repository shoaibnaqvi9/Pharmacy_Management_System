using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHMS
{
    public partial class AddProduct : System.Windows.Forms.Form
    {
        private static Random r = new Random();
        public AddProduct()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Product.ID = r.Next(100000, 500000);
                Product.Name = guna2TextBox1.Text;
                Product.Price = double.Parse(guna2TextBox2.Text);
                Product.Category = guna2ComboBox1.Text;
                Product.Quantity = int.Parse(guna2TextBox3.Text);
                Product.Enter();
                guna2TextBox1.Text = string.Empty;
                guna2TextBox2.Text = string.Empty;
                guna2ComboBox1.Text = string.Empty;
                guna2TextBox3.Text = string.Empty;
                ProductForm refr = new ProductForm();
                refr.DataRefresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
