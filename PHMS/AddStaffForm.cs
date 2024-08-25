using System;
using System.Windows.Forms;

namespace PHMS
{
    public partial class AddStaffForm : System.Windows.Forms.Form
    {
        private static Random r = new Random();
        public AddStaffForm()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                StaffForm refresh = new StaffForm();
                Staff.Id = r.Next(10000,50000);
                Staff.Name= s_full_name.Text;
                Staff.Age = int.Parse(s_age.Text);
                Staff.Salary = Convert.ToDecimal(s_salary.Text);
                Staff.Wrk_hrs = s_working_hours.Text;
                Staff.Contact = long.Parse(s_contact.Text);
                Staff.Register();
                s_full_name.Text = string.Empty;
                s_age.Text = string.Empty;
                s_salary.Text = string.Empty;
                s_working_hours.Text = string.Empty;
                s_contact.Text = string.Empty;
                refresh.DataRefresh();

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

        private void full_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}