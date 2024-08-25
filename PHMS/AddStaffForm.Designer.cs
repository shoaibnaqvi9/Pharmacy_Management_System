namespace PHMS
{
    partial class AddStaffForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.s_age = new Guna.UI2.WinForms.Guna2TextBox();
            this.staff_registration = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.s_salary = new Guna.UI2.WinForms.Guna2ComboBox();
            this.s_full_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.s_contact = new Guna.UI2.WinForms.Guna2TextBox();
            this.s_working_hours = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.guna2Button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.SteelBlue;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 46);
            this.panel1.TabIndex = 12;
            // 
            // guna2Button2
            // 
            this.guna2Button2.DefaultAutoSize = true;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = global::PHMS.Properties.Resources.icons8_close_30;
            this.guna2Button2.Location = new System.Drawing.Point(586, 0);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(46, 46);
            this.guna2Button2.TabIndex = 10;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(204, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register - Member";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(143, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Age";
            // 
            // s_age
            // 
            this.s_age.BorderRadius = 5;
            this.s_age.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.s_age.DefaultText = "";
            this.s_age.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.s_age.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.s_age.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.s_age.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.s_age.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.s_age.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.s_age.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.s_age.Location = new System.Drawing.Point(140, 212);
            this.s_age.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.s_age.Name = "s_age";
            this.s_age.PasswordChar = '\0';
            this.s_age.PlaceholderText = "";
            this.s_age.SelectedText = "";
            this.s_age.Size = new System.Drawing.Size(163, 36);
            this.s_age.TabIndex = 20;
            // 
            // staff_registration
            // 
            this.staff_registration.BorderRadius = 10;
            this.staff_registration.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.staff_registration.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.staff_registration.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.staff_registration.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.staff_registration.FillColor = System.Drawing.Color.SteelBlue;
            this.staff_registration.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staff_registration.ForeColor = System.Drawing.Color.White;
            this.staff_registration.Location = new System.Drawing.Point(139, 350);
            this.staff_registration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.staff_registration.Name = "staff_registration";
            this.staff_registration.Size = new System.Drawing.Size(163, 46);
            this.staff_registration.TabIndex = 19;
            this.staff_registration.Text = "Register";
            this.staff_registration.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(141, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Working Hrs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(327, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Salary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Full Name";
            // 
            // s_salary
            // 
            this.s_salary.BackColor = System.Drawing.Color.Transparent;
            this.s_salary.BorderRadius = 5;
            this.s_salary.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.s_salary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.s_salary.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.s_salary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.s_salary.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.s_salary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.s_salary.ItemHeight = 30;
            this.s_salary.Items.AddRange(new object[] {
            "30000.00",
            "40000.00",
            "50000.00",
            "60000.00"});
            this.s_salary.Location = new System.Drawing.Point(323, 212);
            this.s_salary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.s_salary.Name = "s_salary";
            this.s_salary.Size = new System.Drawing.Size(199, 36);
            this.s_salary.TabIndex = 14;
            // 
            // s_full_name
            // 
            this.s_full_name.BorderRadius = 5;
            this.s_full_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.s_full_name.DefaultText = "";
            this.s_full_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.s_full_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.s_full_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.s_full_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.s_full_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.s_full_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.s_full_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.s_full_name.Location = new System.Drawing.Point(140, 129);
            this.s_full_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.s_full_name.Name = "s_full_name";
            this.s_full_name.PasswordChar = '\0';
            this.s_full_name.PlaceholderText = "";
            this.s_full_name.SelectedText = "";
            this.s_full_name.Size = new System.Drawing.Size(379, 44);
            this.s_full_name.TabIndex = 13;
            this.s_full_name.TextChanged += new System.EventHandler(this.full_name_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(325, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Contact";
            // 
            // s_contact
            // 
            this.s_contact.BorderRadius = 5;
            this.s_contact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.s_contact.DefaultText = "";
            this.s_contact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.s_contact.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.s_contact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.s_contact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.s_contact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.s_contact.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.s_contact.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.s_contact.Location = new System.Drawing.Point(323, 288);
            this.s_contact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.s_contact.Name = "s_contact";
            this.s_contact.PasswordChar = '\0';
            this.s_contact.PlaceholderText = "";
            this.s_contact.SelectedText = "";
            this.s_contact.Size = new System.Drawing.Size(163, 36);
            this.s_contact.TabIndex = 22;
            // 
            // s_working_hours
            // 
            this.s_working_hours.BackColor = System.Drawing.Color.Transparent;
            this.s_working_hours.BorderRadius = 5;
            this.s_working_hours.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.s_working_hours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.s_working_hours.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.s_working_hours.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.s_working_hours.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.s_working_hours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.s_working_hours.ItemHeight = 30;
            this.s_working_hours.Items.AddRange(new object[] {
            "9:00 A.M - 5:00 P.M",
            "10:00 A.M - 11:00 A.M"});
            this.s_working_hours.Location = new System.Drawing.Point(139, 288);
            this.s_working_hours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.s_working_hours.Name = "s_working_hours";
            this.s_working_hours.Size = new System.Drawing.Size(163, 36);
            this.s_working_hours.TabIndex = 24;
            // 
            // AddStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 482);
            this.Controls.Add(this.s_working_hours);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.s_contact);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.s_age);
            this.Controls.Add(this.staff_registration);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.s_salary);
            this.Controls.Add(this.s_full_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddStaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStaffForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox s_age;
        private Guna.UI2.WinForms.Guna2Button staff_registration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox s_salary;
        private Guna.UI2.WinForms.Guna2TextBox s_full_name;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox s_contact;
        private Guna.UI2.WinForms.Guna2ComboBox s_working_hours;
    }
}