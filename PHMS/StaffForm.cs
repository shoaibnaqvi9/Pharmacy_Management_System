using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PHMS
{
    public partial class StaffForm : System.Windows.Forms.Form
    {
        private Point LocateMouse;
        int Rowindex;
        public StaffForm()
        {
            InitializeComponent();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Mouse_Down(object sender, MouseEventArgs e)
        {
            LocateMouse = new Point(-e.X, -e.Y);
        }

        private void Mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(LocateMouse.X, LocateMouse.Y);
                Location = mousePose;
            }
        }

        private void Mouse_Up(object sender, MouseEventArgs e)
        {
            LocateMouse = new Point(-e.X, -e.Y);
        }

        public void DataRefresh()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Staff.Staffshow();
        }
        public void Datawrite()
        {
            TextWriter sr = new StreamWriter("staffdetails.txt");
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
        private void Form1_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = Staff.Staffshow();
            label2.Text = Staff.count.ToString();
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

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductForm move = new ProductForm();
            move.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            AddStaffForm add = new AddStaffForm();
            add.Show();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Staff.Staffshow();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void guna2TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    Staff.Id = int.Parse(guna2TextBox1.Text);
                    dataGridView1.DataSource = Staff.SearchId();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } 
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            DataRefresh();
            DataGridViewRow newdata = dataGridView1.Rows[Rowindex];
            newdata.Cells[0].Value = label5.Text;
            newdata.Cells[1].Value = Staff.Name.ToString();
            newdata.Cells[2].Value = Staff.Age.ToString();
            newdata.Cells[3].Value = guna2ComboBox1.Text;
            newdata.Cells[4].Value = guna2ComboBox2.Text;
            Datawrite();
            DataRefresh();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure", MessageBoxIcon.Exclamation.ToString(),MessageBoxButtons.OKCancel);
            if (dr==DialogResult.OK)
            {
                DataRefresh();
                Rowindex = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(Rowindex);
                Datawrite();
                DataRefresh();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Rowindex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[Rowindex];
            label5.Text = row.Cells[0].Value.ToString();
            Staff.Name = row.Cells[1].Value.ToString();
            Staff.Age = int.Parse(row.Cells[2].Value.ToString());
            guna2ComboBox1.Text = row.Cells[3].Value.ToString();
            guna2ComboBox2.Text = row.Cells[4].Value.ToString();
        }
    }
}