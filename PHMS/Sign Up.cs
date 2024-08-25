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
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Policy;
using System.Collections;
using System.Runtime.ConstrainedExecution;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Windows.Forms.VisualStyles;

namespace PHMS
{
    public partial class Sign_Up : System.Windows.Forms.Form
    {
        private Point LocateMouse;
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string filname = "accountdetails.txt";
                Account user = new Account(filname);
                user.Username = e_address.Text;
                user.Password= pass.Text;
                user.SignUp();
                List<Tuple<string, string>> str_val = new List<Tuple<string, string>>();
                using (StreamReader sr = new StreamReader(filname))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split('|');
                        string username = parts[0];
                        string password = parts[1];
                        str_val.Add(Tuple.Create(username, password));
                    }
                }
                List<Tuple<string, string>> sorted = user.BubbleSort(str_val);
                File.WriteAllText(filname, string.Empty);
                using (StreamWriter sw = File.AppendText(filname))
                {
                    foreach (var item in sorted)
                    {
                        sw.WriteLine($"{item.Item1}|{item.Item2}");
                    }
                }
                SignIn next = new SignIn();
                next.Show();
                this.Close();
                MessageBox.Show("SignUp SuccessFully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            pass.PasswordChar = char.Parse("*");
        }
    }
}
