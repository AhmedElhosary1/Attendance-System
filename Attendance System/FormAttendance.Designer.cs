
namespace Attendance_System
{
    partial class FormAttendance
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
            this.pnAttendance = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.lblLoginUsername = new System.Windows.Forms.Label();
            this.lblLoginTime = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblLoginDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLoginRegister = new Guna.UI.WinForms.GunaButton();
            this.txtDepartment = new Guna.UI.WinForms.GunaTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGender = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhone = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoginSearch = new Guna.UI.WinForms.GunaButton();
            this.txtCode = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.gunaGroupBox3 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaGroupBox4 = new Guna.UI.WinForms.GunaGroupBox();
            this.lblLogoutUsername = new System.Windows.Forms.Label();
            this.lblLogoutTime = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblLogoutDate = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnLogoutRegister = new Guna.UI.WinForms.GunaButton();
            this.txtLogoutDepartment = new Guna.UI.WinForms.GunaTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtLogoutGender = new Guna.UI.WinForms.GunaTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtLogoutPhone = new Guna.UI.WinForms.GunaTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtLogoutEmail = new Guna.UI.WinForms.GunaTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtLogoutName = new Guna.UI.WinForms.GunaTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnLogoutSearch = new Guna.UI.WinForms.GunaButton();
            this.txtLogoutCode = new Guna.UI.WinForms.GunaTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.pnAttendance.SuspendLayout();
            this.panel1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            this.gunaGroupBox2.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.gunaGroupBox3.SuspendLayout();
            this.gunaGroupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnAttendance
            // 
            this.pnAttendance.Controls.Add(this.panel1);
            this.pnAttendance.Controls.Add(this.metroTabControl1);
            this.pnAttendance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnAttendance.Location = new System.Drawing.Point(0, 0);
            this.pnAttendance.Name = "pnAttendance";
            this.pnAttendance.Size = new System.Drawing.Size(987, 710);
            this.pnAttendance.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 60);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Attendance";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.metroTabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.metroTabControl1.Location = new System.Drawing.Point(53, 102);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(880, 565);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.gunaGroupBox1);
            this.metroTabPage1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 4);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(872, 523);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Manage Login";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.gunaGroupBox2);
            this.gunaGroupBox1.Controls.Add(this.btnLoginRegister);
            this.gunaGroupBox1.Controls.Add(this.txtDepartment);
            this.gunaGroupBox1.Controls.Add(this.label7);
            this.gunaGroupBox1.Controls.Add(this.txtGender);
            this.gunaGroupBox1.Controls.Add(this.label6);
            this.gunaGroupBox1.Controls.Add(this.txtPhone);
            this.gunaGroupBox1.Controls.Add(this.label5);
            this.gunaGroupBox1.Controls.Add(this.txtEmail);
            this.gunaGroupBox1.Controls.Add(this.label4);
            this.gunaGroupBox1.Controls.Add(this.txtName);
            this.gunaGroupBox1.Controls.Add(this.label2);
            this.gunaGroupBox1.Controls.Add(this.btnLoginSearch);
            this.gunaGroupBox1.Controls.Add(this.txtCode);
            this.gunaGroupBox1.Controls.Add(this.label3);
            this.gunaGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaGroupBox1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 5;
            this.gunaGroupBox1.Size = new System.Drawing.Size(872, 523);
            this.gunaGroupBox1.TabIndex = 2;
            this.gunaGroupBox1.Text = "Login Page";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.BorderSize = 1;
            this.gunaGroupBox2.Controls.Add(this.lblLoginUsername);
            this.gunaGroupBox2.Controls.Add(this.lblLoginTime);
            this.gunaGroupBox2.Controls.Add(this.label11);
            this.gunaGroupBox2.Controls.Add(this.lblLoginDate);
            this.gunaGroupBox2.Controls.Add(this.label8);
            this.gunaGroupBox2.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Location = new System.Drawing.Point(29, 429);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Radius = 5;
            this.gunaGroupBox2.Size = new System.Drawing.Size(819, 82);
            this.gunaGroupBox2.TabIndex = 29;
            this.gunaGroupBox2.Text = "Result";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // lblLoginUsername
            // 
            this.lblLoginUsername.AutoSize = true;
            this.lblLoginUsername.BackColor = System.Drawing.Color.White;
            this.lblLoginUsername.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLoginUsername.ForeColor = System.Drawing.Color.Teal;
            this.lblLoginUsername.Location = new System.Drawing.Point(87, 44);
            this.lblLoginUsername.Name = "lblLoginUsername";
            this.lblLoginUsername.Size = new System.Drawing.Size(90, 24);
            this.lblLoginUsername.TabIndex = 23;
            this.lblLoginUsername.Text = "Username";
            // 
            // lblLoginTime
            // 
            this.lblLoginTime.AutoSize = true;
            this.lblLoginTime.BackColor = System.Drawing.Color.White;
            this.lblLoginTime.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLoginTime.ForeColor = System.Drawing.Color.Teal;
            this.lblLoginTime.Location = new System.Drawing.Point(601, 44);
            this.lblLoginTime.Name = "lblLoginTime";
            this.lblLoginTime.Size = new System.Drawing.Size(130, 24);
            this.lblLoginTime.TabIndex = 22;
            this.lblLoginTime.Text = "000000000000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(554, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 24);
            this.label11.TabIndex = 21;
            this.label11.Text = "at";
            // 
            // lblLoginDate
            // 
            this.lblLoginDate.AutoSize = true;
            this.lblLoginDate.BackColor = System.Drawing.Color.White;
            this.lblLoginDate.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLoginDate.ForeColor = System.Drawing.Color.Teal;
            this.lblLoginDate.Location = new System.Drawing.Point(395, 44);
            this.lblLoginDate.Name = "lblLoginDate";
            this.lblLoginDate.Size = new System.Drawing.Size(130, 24);
            this.lblLoginDate.TabIndex = 20;
            this.lblLoginDate.Text = "000000000000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(196, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "you have registerd in";
            // 
            // btnLoginRegister
            // 
            this.btnLoginRegister.AnimationHoverSpeed = 0.07F;
            this.btnLoginRegister.AnimationSpeed = 0.03F;
            this.btnLoginRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnLoginRegister.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLoginRegister.BorderColor = System.Drawing.Color.Azure;
            this.btnLoginRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoginRegister.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLoginRegister.FocusedColor = System.Drawing.Color.Empty;
            this.btnLoginRegister.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginRegister.ForeColor = System.Drawing.Color.White;
            this.btnLoginRegister.Image = global::Attendance_System.Properties.Resources.SAVE;
            this.btnLoginRegister.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLoginRegister.Location = new System.Drawing.Point(677, 366);
            this.btnLoginRegister.Name = "btnLoginRegister";
            this.btnLoginRegister.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btnLoginRegister.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLoginRegister.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLoginRegister.OnHoverImage = null;
            this.btnLoginRegister.OnPressedColor = System.Drawing.Color.Black;
            this.btnLoginRegister.Radius = 5;
            this.btnLoginRegister.Size = new System.Drawing.Size(171, 42);
            this.btnLoginRegister.TabIndex = 28;
            this.btnLoginRegister.Text = "Register";
            this.btnLoginRegister.Click += new System.EventHandler(this.btnLoginRegister_Click);
            // 
            // txtDepartment
            // 
            this.txtDepartment.BackColor = System.Drawing.Color.Transparent;
            this.txtDepartment.BaseColor = System.Drawing.Color.White;
            this.txtDepartment.BorderColor = System.Drawing.Color.Silver;
            this.txtDepartment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDepartment.Enabled = false;
            this.txtDepartment.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDepartment.FocusedBorderColor = System.Drawing.Color.Teal;
            this.txtDepartment.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDepartment.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDepartment.Location = new System.Drawing.Point(326, 370);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.PasswordChar = '\0';
            this.txtDepartment.Radius = 5;
            this.txtDepartment.SelectedText = "";
            this.txtDepartment.Size = new System.Drawing.Size(334, 38);
            this.txtDepartment.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(211, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 24);
            this.label7.TabIndex = 26;
            this.label7.Text = "Department:";
            // 
            // txtGender
            // 
            this.txtGender.BackColor = System.Drawing.Color.Transparent;
            this.txtGender.BaseColor = System.Drawing.Color.White;
            this.txtGender.BorderColor = System.Drawing.Color.Silver;
            this.txtGender.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGender.Enabled = false;
            this.txtGender.FocusedBaseColor = System.Drawing.Color.White;
            this.txtGender.FocusedBorderColor = System.Drawing.Color.Teal;
            this.txtGender.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtGender.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtGender.Location = new System.Drawing.Point(326, 312);
            this.txtGender.Name = "txtGender";
            this.txtGender.PasswordChar = '\0';
            this.txtGender.Radius = 5;
            this.txtGender.SelectedText = "";
            this.txtGender.Size = new System.Drawing.Size(334, 38);
            this.txtGender.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(211, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 24);
            this.label6.TabIndex = 24;
            this.label6.Text = "Gender:";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.Transparent;
            this.txtPhone.BaseColor = System.Drawing.Color.White;
            this.txtPhone.BorderColor = System.Drawing.Color.Silver;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.Enabled = false;
            this.txtPhone.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPhone.FocusedBorderColor = System.Drawing.Color.Teal;
            this.txtPhone.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPhone.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPhone.Location = new System.Drawing.Point(327, 252);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.Radius = 5;
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(334, 38);
            this.txtPhone.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(211, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "Phone:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BaseColor = System.Drawing.Color.White;
            this.txtEmail.BorderColor = System.Drawing.Color.Silver;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Enabled = false;
            this.txtEmail.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEmail.FocusedBorderColor = System.Drawing.Color.Teal;
            this.txtEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmail.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEmail.Location = new System.Drawing.Point(327, 193);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.Radius = 5;
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(334, 38);
            this.txtEmail.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(212, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Email:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.BaseColor = System.Drawing.Color.White;
            this.txtName.BorderColor = System.Drawing.Color.Silver;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Enabled = false;
            this.txtName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtName.FocusedBorderColor = System.Drawing.Color.Teal;
            this.txtName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.Location = new System.Drawing.Point(326, 137);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.Radius = 5;
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(334, 38);
            this.txtName.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(212, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Name:";
            // 
            // btnLoginSearch
            // 
            this.btnLoginSearch.AnimationHoverSpeed = 0.07F;
            this.btnLoginSearch.AnimationSpeed = 0.03F;
            this.btnLoginSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnLoginSearch.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLoginSearch.BorderColor = System.Drawing.Color.Azure;
            this.btnLoginSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoginSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLoginSearch.FocusedColor = System.Drawing.Color.Empty;
            this.btnLoginSearch.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginSearch.ForeColor = System.Drawing.Color.White;
            this.btnLoginSearch.Image = global::Attendance_System.Properties.Resources.search_48px;
            this.btnLoginSearch.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLoginSearch.Location = new System.Drawing.Point(677, 67);
            this.btnLoginSearch.Name = "btnLoginSearch";
            this.btnLoginSearch.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btnLoginSearch.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLoginSearch.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLoginSearch.OnHoverImage = null;
            this.btnLoginSearch.OnPressedColor = System.Drawing.Color.Black;
            this.btnLoginSearch.Radius = 5;
            this.btnLoginSearch.Size = new System.Drawing.Size(171, 42);
            this.btnLoginSearch.TabIndex = 17;
            this.btnLoginSearch.Text = "Search";
            this.btnLoginSearch.Click += new System.EventHandler(this.btnLoginSearch_Click);
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.Transparent;
            this.txtCode.BaseColor = System.Drawing.Color.White;
            this.txtCode.BorderColor = System.Drawing.Color.Silver;
            this.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCode.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCode.FocusedBorderColor = System.Drawing.Color.Teal;
            this.txtCode.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCode.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCode.Location = new System.Drawing.Point(236, 71);
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.Radius = 5;
            this.txtCode.SelectedText = "";
            this.txtCode.Size = new System.Drawing.Size(423, 38);
            this.txtCode.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(25, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Please Enter Your Code:";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.gunaGroupBox3);
            this.metroTabPage2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 4);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(872, 523);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Manage Logout";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // gunaGroupBox3
            // 
            this.gunaGroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox3.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox3.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox3.BorderSize = 1;
            this.gunaGroupBox3.Controls.Add(this.gunaGroupBox4);
            this.gunaGroupBox3.Controls.Add(this.btnLogoutRegister);
            this.gunaGroupBox3.Controls.Add(this.txtLogoutDepartment);
            this.gunaGroupBox3.Controls.Add(this.label14);
            this.gunaGroupBox3.Controls.Add(this.txtLogoutGender);
            this.gunaGroupBox3.Controls.Add(this.label15);
            this.gunaGroupBox3.Controls.Add(this.txtLogoutPhone);
            this.gunaGroupBox3.Controls.Add(this.label16);
            this.gunaGroupBox3.Controls.Add(this.txtLogoutEmail);
            this.gunaGroupBox3.Controls.Add(this.label17);
            this.gunaGroupBox3.Controls.Add(this.txtLogoutName);
            this.gunaGroupBox3.Controls.Add(this.label18);
            this.gunaGroupBox3.Controls.Add(this.btnLogoutSearch);
            this.gunaGroupBox3.Controls.Add(this.txtLogoutCode);
            this.gunaGroupBox3.Controls.Add(this.label19);
            this.gunaGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaGroupBox3.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaGroupBox3.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox3.Location = new System.Drawing.Point(0, 0);
            this.gunaGroupBox3.Name = "gunaGroupBox3";
            this.gunaGroupBox3.Radius = 5;
            this.gunaGroupBox3.Size = new System.Drawing.Size(872, 523);
            this.gunaGroupBox3.TabIndex = 3;
            this.gunaGroupBox3.Text = "Logout Page";
            this.gunaGroupBox3.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaGroupBox4
            // 
            this.gunaGroupBox4.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox4.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox4.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox4.BorderSize = 1;
            this.gunaGroupBox4.Controls.Add(this.lblLogoutUsername);
            this.gunaGroupBox4.Controls.Add(this.lblLogoutTime);
            this.gunaGroupBox4.Controls.Add(this.label12);
            this.gunaGroupBox4.Controls.Add(this.lblLogoutDate);
            this.gunaGroupBox4.Controls.Add(this.label20);
            this.gunaGroupBox4.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox4.Location = new System.Drawing.Point(29, 429);
            this.gunaGroupBox4.Name = "gunaGroupBox4";
            this.gunaGroupBox4.Radius = 5;
            this.gunaGroupBox4.Size = new System.Drawing.Size(819, 82);
            this.gunaGroupBox4.TabIndex = 29;
            this.gunaGroupBox4.Text = "Result";
            this.gunaGroupBox4.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // lblLogoutUsername
            // 
            this.lblLogoutUsername.AutoSize = true;
            this.lblLogoutUsername.BackColor = System.Drawing.Color.White;
            this.lblLogoutUsername.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLogoutUsername.ForeColor = System.Drawing.Color.Teal;
            this.lblLogoutUsername.Location = new System.Drawing.Point(87, 44);
            this.lblLogoutUsername.Name = "lblLogoutUsername";
            this.lblLogoutUsername.Size = new System.Drawing.Size(90, 24);
            this.lblLogoutUsername.TabIndex = 28;
            this.lblLogoutUsername.Text = "Username";
            // 
            // lblLogoutTime
            // 
            this.lblLogoutTime.AutoSize = true;
            this.lblLogoutTime.BackColor = System.Drawing.Color.White;
            this.lblLogoutTime.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLogoutTime.ForeColor = System.Drawing.Color.Teal;
            this.lblLogoutTime.Location = new System.Drawing.Point(601, 44);
            this.lblLogoutTime.Name = "lblLogoutTime";
            this.lblLogoutTime.Size = new System.Drawing.Size(130, 24);
            this.lblLogoutTime.TabIndex = 27;
            this.lblLogoutTime.Text = "000000000000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(554, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 24);
            this.label12.TabIndex = 26;
            this.label12.Text = "at";
            // 
            // lblLogoutDate
            // 
            this.lblLogoutDate.AutoSize = true;
            this.lblLogoutDate.BackColor = System.Drawing.Color.White;
            this.lblLogoutDate.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLogoutDate.ForeColor = System.Drawing.Color.Teal;
            this.lblLogoutDate.Location = new System.Drawing.Point(395, 44);
            this.lblLogoutDate.Name = "lblLogoutDate";
            this.lblLogoutDate.Size = new System.Drawing.Size(130, 24);
            this.lblLogoutDate.TabIndex = 25;
            this.lblLogoutDate.Text = "000000000000";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(196, 44);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(177, 24);
            this.label20.TabIndex = 24;
            this.label20.Text = "you have registerd in";
            // 
            // btnLogoutRegister
            // 
            this.btnLogoutRegister.AnimationHoverSpeed = 0.07F;
            this.btnLogoutRegister.AnimationSpeed = 0.03F;
            this.btnLogoutRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnLogoutRegister.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogoutRegister.BorderColor = System.Drawing.Color.Azure;
            this.btnLogoutRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogoutRegister.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogoutRegister.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogoutRegister.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoutRegister.ForeColor = System.Drawing.Color.White;
            this.btnLogoutRegister.Image = global::Attendance_System.Properties.Resources.SAVE;
            this.btnLogoutRegister.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLogoutRegister.Location = new System.Drawing.Point(677, 366);
            this.btnLogoutRegister.Name = "btnLogoutRegister";
            this.btnLogoutRegister.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btnLogoutRegister.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogoutRegister.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogoutRegister.OnHoverImage = null;
            this.btnLogoutRegister.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogoutRegister.Radius = 5;
            this.btnLogoutRegister.Size = new System.Drawing.Size(171, 42);
            this.btnLogoutRegister.TabIndex = 28;
            this.btnLogoutRegister.Text = "Register";
            this.btnLogoutRegister.Click += new System.EventHandler(this.btnLogoutRegister_Click);
            // 
            // txtLogoutDepartment
            // 
            this.txtLogoutDepartment.BackColor = System.Drawing.Color.Transparent;
            this.txtLogoutDepartment.BaseColor = System.Drawing.Color.White;
            this.txtLogoutDepartment.BorderColor = System.Drawing.Color.Silver;
            this.txtLogoutDepartment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLogoutDepartment.Enabled = false;
            this.txtLogoutDepartment.FocusedBaseColor = System.Drawing.Color.White;
            this.txtLogoutDepartment.FocusedBorderColor = System.Drawing.Color.Teal;
            this.txtLogoutDepartment.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLogoutDepartment.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLogoutDepartment.Location = new System.Drawing.Point(326, 370);
            this.txtLogoutDepartment.Name = "txtLogoutDepartment";
            this.txtLogoutDepartment.PasswordChar = '\0';
            this.txtLogoutDepartment.Radius = 5;
            this.txtLogoutDepartment.SelectedText = "";
            this.txtLogoutDepartment.Size = new System.Drawing.Size(334, 38);
            this.txtLogoutDepartment.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(211, 384);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 24);
            this.label14.TabIndex = 26;
            this.label14.Text = "Department:";
            // 
            // txtLogoutGender
            // 
            this.txtLogoutGender.BackColor = System.Drawing.Color.Transparent;
            this.txtLogoutGender.BaseColor = System.Drawing.Color.White;
            this.txtLogoutGender.BorderColor = System.Drawing.Color.Silver;
            this.txtLogoutGender.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLogoutGender.Enabled = false;
            this.txtLogoutGender.FocusedBaseColor = System.Drawing.Color.White;
            this.txtLogoutGender.FocusedBorderColor = System.Drawing.Color.Teal;
            this.txtLogoutGender.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLogoutGender.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLogoutGender.Location = new System.Drawing.Point(326, 312);
            this.txtLogoutGender.Name = "txtLogoutGender";
            this.txtLogoutGender.PasswordChar = '\0';
            this.txtLogoutGender.Radius = 5;
            this.txtLogoutGender.SelectedText = "";
            this.txtLogoutGender.Size = new System.Drawing.Size(334, 38);
            this.txtLogoutGender.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(211, 326);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 24);
            this.label15.TabIndex = 24;
            this.label15.Text = "Gender:";
            // 
            // txtLogoutPhone
            // 
            this.txtLogoutPhone.BackColor = System.Drawing.Color.Transparent;
            this.txtLogoutPhone.BaseColor = System.Drawing.Color.White;
            this.txtLogoutPhone.BorderColor = System.Drawing.Color.Silver;
            this.txtLogoutPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLogoutPhone.Enabled = false;
            this.txtLogoutPhone.FocusedBaseColor = System.Drawing.Color.White;
            this.txtLogoutPhone.FocusedBorderColor = System.Drawing.Color.Teal;
            this.txtLogoutPhone.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLogoutPhone.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLogoutPhone.Location = new System.Drawing.Point(327, 252);
            this.txtLogoutPhone.Name = "txtLogoutPhone";
            this.txtLogoutPhone.PasswordChar = '\0';
            this.txtLogoutPhone.Radius = 5;
            this.txtLogoutPhone.SelectedText = "";
            this.txtLogoutPhone.Size = new System.Drawing.Size(334, 38);
            this.txtLogoutPhone.TabIndex = 23;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(211, 266);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 24);
            this.label16.TabIndex = 22;
            this.label16.Text = "Phone:";
            // 
            // txtLogoutEmail
            // 
            this.txtLogoutEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtLogoutEmail.BaseColor = System.Drawing.Color.White;
            this.txtLogoutEmail.BorderColor = System.Drawing.Color.Silver;
            this.txtLogoutEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLogoutEmail.Enabled = false;
            this.txtLogoutEmail.FocusedBaseColor = System.Drawing.Color.White;
            this.txtLogoutEmail.FocusedBorderColor = System.Drawing.Color.Teal;
            this.txtLogoutEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLogoutEmail.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLogoutEmail.Location = new System.Drawing.Point(327, 193);
            this.txtLogoutEmail.Name = "txtLogoutEmail";
            this.txtLogoutEmail.PasswordChar = '\0';
            this.txtLogoutEmail.Radius = 5;
            this.txtLogoutEmail.SelectedText = "";
            this.txtLogoutEmail.Size = new System.Drawing.Size(334, 38);
            this.txtLogoutEmail.TabIndex = 21;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(212, 207);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 24);
            this.label17.TabIndex = 20;
            this.label17.Text = "Email:";
            // 
            // txtLogoutName
            // 
            this.txtLogoutName.BackColor = System.Drawing.Color.Transparent;
            this.txtLogoutName.BaseColor = System.Drawing.Color.White;
            this.txtLogoutName.BorderColor = System.Drawing.Color.Silver;
            this.txtLogoutName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLogoutName.Enabled = false;
            this.txtLogoutName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtLogoutName.FocusedBorderColor = System.Drawing.Color.Teal;
            this.txtLogoutName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLogoutName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLogoutName.Location = new System.Drawing.Point(326, 137);
            this.txtLogoutName.Name = "txtLogoutName";
            this.txtLogoutName.PasswordChar = '\0';
            this.txtLogoutName.Radius = 5;
            this.txtLogoutName.SelectedText = "";
            this.txtLogoutName.Size = new System.Drawing.Size(334, 38);
            this.txtLogoutName.TabIndex = 19;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(212, 151);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 24);
            this.label18.TabIndex = 18;
            this.label18.Text = "Name:";
            // 
            // btnLogoutSearch
            // 
            this.btnLogoutSearch.AnimationHoverSpeed = 0.07F;
            this.btnLogoutSearch.AnimationSpeed = 0.03F;
            this.btnLogoutSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnLogoutSearch.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogoutSearch.BorderColor = System.Drawing.Color.Azure;
            this.btnLogoutSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogoutSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogoutSearch.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogoutSearch.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoutSearch.ForeColor = System.Drawing.Color.White;
            this.btnLogoutSearch.Image = global::Attendance_System.Properties.Resources.search_48px;
            this.btnLogoutSearch.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLogoutSearch.Location = new System.Drawing.Point(677, 67);
            this.btnLogoutSearch.Name = "btnLogoutSearch";
            this.btnLogoutSearch.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btnLogoutSearch.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogoutSearch.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogoutSearch.OnHoverImage = null;
            this.btnLogoutSearch.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogoutSearch.Radius = 5;
            this.btnLogoutSearch.Size = new System.Drawing.Size(171, 42);
            this.btnLogoutSearch.TabIndex = 17;
            this.btnLogoutSearch.Text = "Search";
            this.btnLogoutSearch.Click += new System.EventHandler(this.btnLogoutSearch_Click);
            // 
            // txtLogoutCode
            // 
            this.txtLogoutCode.BackColor = System.Drawing.Color.Transparent;
            this.txtLogoutCode.BaseColor = System.Drawing.Color.White;
            this.txtLogoutCode.BorderColor = System.Drawing.Color.Silver;
            this.txtLogoutCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLogoutCode.FocusedBaseColor = System.Drawing.Color.White;
            this.txtLogoutCode.FocusedBorderColor = System.Drawing.Color.Teal;
            this.txtLogoutCode.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLogoutCode.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLogoutCode.Location = new System.Drawing.Point(236, 71);
            this.txtLogoutCode.Name = "txtLogoutCode";
            this.txtLogoutCode.PasswordChar = '\0';
            this.txtLogoutCode.Radius = 5;
            this.txtLogoutCode.SelectedText = "";
            this.txtLogoutCode.Size = new System.Drawing.Size(423, 38);
            this.txtLogoutCode.TabIndex = 6;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(25, 85);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(205, 24);
            this.label19.TabIndex = 5;
            this.label19.Text = "Please Enter Your Code:";
            // 
            // FormAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(987, 710);
            this.Controls.Add(this.pnAttendance);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAttendance";
            this.Text = "FormAttendance";
            this.pnAttendance.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.gunaGroupBox2.ResumeLayout(false);
            this.gunaGroupBox2.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.gunaGroupBox3.ResumeLayout(false);
            this.gunaGroupBox3.PerformLayout();
            this.gunaGroupBox4.ResumeLayout(false);
            this.gunaGroupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnAttendance;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaTextBox txtCode;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox txtGender;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaTextBox txtPhone;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaTextBox txtName;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton btnLoginSearch;
        private Guna.UI.WinForms.GunaTextBox txtDepartment;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaButton btnLoginRegister;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private System.Windows.Forms.Label lblLoginTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblLoginDate;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox3;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox4;
        private Guna.UI.WinForms.GunaButton btnLogoutRegister;
        private Guna.UI.WinForms.GunaTextBox txtLogoutDepartment;
        private System.Windows.Forms.Label label14;
        private Guna.UI.WinForms.GunaTextBox txtLogoutGender;
        private System.Windows.Forms.Label label15;
        private Guna.UI.WinForms.GunaTextBox txtLogoutPhone;
        private System.Windows.Forms.Label label16;
        private Guna.UI.WinForms.GunaTextBox txtLogoutEmail;
        private System.Windows.Forms.Label label17;
        private Guna.UI.WinForms.GunaTextBox txtLogoutName;
        private System.Windows.Forms.Label label18;
        private Guna.UI.WinForms.GunaButton btnLogoutSearch;
        private Guna.UI.WinForms.GunaTextBox txtLogoutCode;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblLoginUsername;
        private System.Windows.Forms.Label lblLogoutUsername;
        private System.Windows.Forms.Label lblLogoutTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblLogoutDate;
        private System.Windows.Forms.Label label20;
    }
}