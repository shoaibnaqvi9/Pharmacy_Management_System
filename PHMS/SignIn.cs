using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHMS
{
    public partial class SignIn : System.Windows.Forms.Form
    {
        private Point LocateMouse;
        public SignIn()
        {
            InitializeComponent();
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
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool found = false;
                using (StreamReader sreader = new StreamReader("accountdetails.txt"))
                {
                    string line;
                    while ((line = sreader.ReadLine()) != null)
                    {
                        string[] data = line.Split(new string[] { "|" }, StringSplitOptions.None);
                        string username = data[0];
                        string password = data[1];
                        if (e_address.Text == username && u_pass.Text == password)
                        {
                            found = true;
                            break;
                        }
                    }
                    if (found == true)
                    {
                        MessageBox.Show("Sign In Successfully");
                        Dashboard d = new Dashboard();
                        this.Hide();
                        d.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            
            u_pass.PasswordChar = char.Parse("*");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}