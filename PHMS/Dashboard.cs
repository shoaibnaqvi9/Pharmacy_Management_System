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
    public partial class Dashboard : System.Windows.Forms.Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffForm move = new StaffForm();
            move.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductForm move = new ProductForm();
            move.Show();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            label1.Text = DateTime.Now.ToString("dd-MM-yyyy");
            label6.Text = "Good";
            label7.Text = Product.count.ToString();
            label8.Text = Staff.count.ToString();
            guna2DataGridView1.DataSource = Product.Productshow();
            guna2DataGridView2.DataSource = Staff.Staffshow();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
