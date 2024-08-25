using System;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PHMS
{
    public partial class ProductForm : System.Windows.Forms.Form
    {
        public static int index;
        public ProductForm()
        {
            InitializeComponent();
        }

        private void Mouse_Down(object sender, MouseEventArgs e)
        {

        }

        private void Mouse_Move(object sender, MouseEventArgs e)
        {

        }

        private void Mouse_Up(object sender, MouseEventArgs e)
        {

        }
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            AddProduct AddProduct = new AddProduct();
            AddProduct.Show();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard move = new Dashboard();
            move.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffForm move = new StaffForm();
            move.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void DataRefresh()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Product.Productshow();
        }
              

        public void Datawrite()
        {
            TextWriter sr = new StreamWriter("productdetails.txt");
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (!dataGridView1.Rows[i].IsNewRow)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        sr.Write(dataGridView1.Rows[i].Cells[j].Value.ToString());
                        if (j == dataGridView1.Columns.Count - 1)
                        {
                            continue;
                        }
                        sr.Write("|");
                    }
                    sr.WriteLine();
                }
            }
            sr.Close();
        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Product.Productshow();
            label5.Text = Product.count.ToString();
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void guna2Button5_Click_1(object sender, EventArgs e)
        {
            AddProduct add = new AddProduct();
            add.Show();
        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard showDashboard = new Dashboard();
            showDashboard.Show();
        }
        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            StaffForm movestaff = new StaffForm();
            movestaff.Show();
        }
        private void EnterSearch(object sender, EventArgs e)
        {

        }
        private void guna2TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    Product.ID = int.Parse(guna2TextBox1.Text);
                    dataGridView1.DataSource = Product.Search();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Product.Productshow();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void guna2Button7_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure?", MessageBoxIcon.Exclamation.ToString(), MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                DataRefresh();
                index = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(index);
                Datawrite();
                DataRefresh();
                
            }
        }
        private void guna2Button6_Click(object sender, EventArgs e)
        {
            DataRefresh();
            DataGridViewRow obj1 = dataGridView1.Rows[index];
            obj1.Cells[0].Value = label1.Text;
            obj1.Cells[1].Value = Product.Name;
            obj1.Cells[2].Value = Product.Category;
            obj1.Cells[3].Value = guna2TextBox2.Text;
            obj1.Cells[4].Value = guna2TextBox3.Text;
            Datawrite();
            DataRefresh();

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow obj = dataGridView1.Rows[index];
            label1.Text = obj.Cells[0].Value.ToString();
            Product.Name = obj.Cells[1].Value.ToString();
            Product.Category = obj.Cells[2].Value.ToString();
            guna2TextBox2.Text = obj.Cells[3].Value.ToString();
            guna2TextBox3.Text = obj.Cells[4].Value.ToString();
            
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}