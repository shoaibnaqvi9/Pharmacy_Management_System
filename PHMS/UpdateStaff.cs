using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace PHMS
{
    public partial class UpdateStaff : System.Windows.Forms.Form
    {
        public UpdateStaff()
        {
            InitializeComponent();
        }

        private void UpdateStaff_Load(object sender, EventArgs e)
        {
            label2.Text = Staff.Id.ToString();
            guna2ComboBox1.Text = Staff.Salary.ToString();
            guna2ComboBox2.Text = Staff.Wrk_hrs;

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Staff.Salary = decimal.Parse(guna2ComboBox1.Text);
                Staff.Wrk_hrs = guna2ComboBox2.Text;
                StaffForm obj = new StaffForm();
                MessageBox.Show("Updated Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /*private Staff GetStaffByContactFromFile(long contact)
        {
            StreamReader sr = new StreamReader("staffdetails.txt");
            Staff stf = null;
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                if (parts[4] == contact.ToString())
                {
                    stf = new Staff
                    {
                        Name = parts[0],
                        Age = int.Parse(parts[1]),
                        Salary = decimal.Parse(parts[2]),
                        Wrk_hrs = parts[3],
                        Contact = long.Parse(parts[4])
                    };
                }
            }
            sr.Close();
            return stf;
        }*/

        /*private void SaveStaffToFile(Staff staff)
        {
            StreamWriter sw = new StreamWriter("staffdetails.txt");
            sw.WriteLine($"{staff.Name}|{staff.Age}|{staff.Salary}|{staff.Wrk_hrs}|{staff.Contact}");
            sw.Close();
        }*/
    }
}
