
namespace Attendance_System
{
    partial class FormMain
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDashboard = new Guna.UI.WinForms.GunaButton();
            this.btnDepartments = new Guna.UI.WinForms.GunaButton();
            this.btnAttendance = new Guna.UI.WinForms.GunaButton();
            this.btnUser = new Guna.UI.WinForms.GunaButton();
            this.btnRequests = new Guna.UI.WinForms.GunaButton();
            this.btnReports = new Guna.UI.WinForms.GunaButton();
            this.btnMinimize = new Guna.UI.WinForms.GunaButton();
            this.btnExit = new Guna.UI.WinForms.GunaButton();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.pnContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.gunaCirclePictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 710);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnDashboard);
            this.flowLayoutPanel1.Controls.Add(this.btnDepartments);
            this.flowLayoutPanel1.Controls.Add(this.btnAttendance);
            this.flowLayoutPanel1.Controls.Add(this.btnUser);
            this.flowLayoutPanel1.Controls.Add(this.btnRequests);
            this.flowLayoutPanel1.Controls.Add(this.btnReports);
            this.flowLayoutPanel1.Controls.Add(this.btnMinimize);
            this.flowLayoutPanel1.Controls.Add(this.btnExit);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 296);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 388);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // btnDashboard
            // 
            this.btnDashboard.AnimationHoverSpeed = 0.07F;
            this.btnDashboard.AnimationSpeed = 0.03F;
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDashboard.BorderColor = System.Drawing.Color.Azure;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDashboard.FocusedColor = System.Drawing.Color.Empty;
            this.btnDashboard.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::Attendance_System.Properties.Resources.dashboard;
            this.btnDashboard.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDashboard.Location = new System.Drawing.Point(3, 3);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btnDashboard.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDashboard.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDashboard.OnHoverImage = null;
            this.btnDashboard.OnPressedColor = System.Drawing.Color.Black;
            this.btnDashboard.Radius = 5;
            this.btnDashboard.Size = new System.Drawing.Size(197, 42);
            this.btnDashboard.TabIndex = 16;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnDepartments
            // 
            this.btnDepartments.AnimationHoverSpeed = 0.07F;
            this.btnDepartments.AnimationSpeed = 0.03F;
            this.btnDepartments.BackColor = System.Drawing.Color.Transparent;
            this.btnDepartments.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDepartments.BorderColor = System.Drawing.Color.Azure;
            this.btnDepartments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepartments.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDepartments.FocusedColor = System.Drawing.Color.Empty;
            this.btnDepartments.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartments.ForeColor = System.Drawing.Color.White;
            this.btnDepartments.Image = global::Attendance_System.Properties.Resources.categorize_48px;
            this.btnDepartments.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDepartments.Location = new System.Drawing.Point(3, 51);
            this.btnDepartments.Name = "btnDepartments";
            this.btnDepartments.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btnDepartments.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDepartments.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDepartments.OnHoverImage = null;
            this.btnDepartments.OnPressedColor = System.Drawing.Color.Black;
            this.btnDepartments.Radius = 5;
            this.btnDepartments.Size = new System.Drawing.Size(197, 42);
            this.btnDepartments.TabIndex = 15;
            this.btnDepartments.Text = "Departments";
            this.btnDepartments.Click += new System.EventHandler(this.btnDepartments_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.AnimationHoverSpeed = 0.07F;
            this.btnAttendance.AnimationSpeed = 0.03F;
            this.btnAttendance.BackColor = System.Drawing.Color.Transparent;
            this.btnAttendance.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAttendance.BorderColor = System.Drawing.Color.Azure;
            this.btnAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttendance.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAttendance.FocusedColor = System.Drawing.Color.Empty;
            this.btnAttendance.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendance.ForeColor = System.Drawing.Color.White;
            this.btnAttendance.Image = global::Attendance_System.Properties.Resources.attendance;
            this.btnAttendance.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAttendance.Location = new System.Drawing.Point(3, 99);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btnAttendance.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAttendance.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAttendance.OnHoverImage = null;
            this.btnAttendance.OnPressedColor = System.Drawing.Color.Black;
            this.btnAttendance.Radius = 5;
            this.btnAttendance.Size = new System.Drawing.Size(197, 42);
            this.btnAttendance.TabIndex = 13;
            this.btnAttendance.Text = "Attendance";
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // btnUser
            // 
            this.btnUser.AnimationHoverSpeed = 0.07F;
            this.btnUser.AnimationSpeed = 0.03F;
            this.btnUser.BackColor = System.Drawing.Color.Transparent;
            this.btnUser.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUser.BorderColor = System.Drawing.Color.Azure;
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUser.FocusedColor = System.Drawing.Color.Empty;
            this.btnUser.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Image = global::Attendance_System.Properties.Resources.user_folder_48px;
            this.btnUser.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUser.Location = new System.Drawing.Point(3, 147);
            this.btnUser.Name = "btnUser";
            this.btnUser.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btnUser.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUser.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUser.OnHoverImage = null;
            this.btnUser.OnPressedColor = System.Drawing.Color.Black;
            this.btnUser.Radius = 5;
            this.btnUser.Size = new System.Drawing.Size(197, 42);
            this.btnUser.TabIndex = 14;
            this.btnUser.Text = "Users";
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnRequests
            // 
            this.btnRequests.AnimationHoverSpeed = 0.07F;
            this.btnRequests.AnimationSpeed = 0.03F;
            this.btnRequests.BackColor = System.Drawing.Color.Transparent;
            this.btnRequests.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRequests.BorderColor = System.Drawing.Color.Azure;
            this.btnRequests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRequests.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRequests.FocusedColor = System.Drawing.Color.Empty;
            this.btnRequests.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequests.ForeColor = System.Drawing.Color.White;
            this.btnRequests.Image = global::Attendance_System.Properties.Resources.request;
            this.btnRequests.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRequests.Location = new System.Drawing.Point(3, 195);
            this.btnRequests.Name = "btnRequests";
            this.btnRequests.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btnRequests.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRequests.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRequests.OnHoverImage = null;
            this.btnRequests.OnPressedColor = System.Drawing.Color.Black;
            this.btnRequests.Radius = 5;
            this.btnRequests.Size = new System.Drawing.Size(197, 42);
            this.btnRequests.TabIndex = 11;
            this.btnRequests.Text = "Requests";
            this.btnRequests.Click += new System.EventHandler(this.btnRequests_Click);
            // 
            // btnReports
            // 
            this.btnReports.AnimationHoverSpeed = 0.07F;
            this.btnReports.AnimationSpeed = 0.03F;
            this.btnReports.BackColor = System.Drawing.Color.Transparent;
            this.btnReports.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReports.BorderColor = System.Drawing.Color.Azure;
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReports.FocusedColor = System.Drawing.Color.Empty;
            this.btnReports.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Image = global::Attendance_System.Properties.Resources.reports;
            this.btnReports.ImageSize = new System.Drawing.Size(30, 30);
            this.btnReports.Location = new System.Drawing.Point(3, 243);
            this.btnReports.Name = "btnReports";
            this.btnReports.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btnReports.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReports.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReports.OnHoverImage = null;
            this.btnReports.OnPressedColor = System.Drawing.Color.Black;
            this.btnReports.Radius = 5;
            this.btnReports.Size = new System.Drawing.Size(197, 42);
            this.btnReports.TabIndex = 12;
            this.btnReports.Text = "Reports";
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.AnimationHoverSpeed = 0.07F;
            this.btnMinimize.AnimationSpeed = 0.03F;
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimize.BorderColor = System.Drawing.Color.Azure;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMinimize.FocusedColor = System.Drawing.Color.Empty;
            this.btnMinimize.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = global::Attendance_System.Properties.Resources.minimize_window_48px;
            this.btnMinimize.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMinimize.Location = new System.Drawing.Point(3, 291);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btnMinimize.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMinimize.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMinimize.OnHoverImage = null;
            this.btnMinimize.OnPressedColor = System.Drawing.Color.Black;
            this.btnMinimize.Radius = 5;
            this.btnMinimize.Size = new System.Drawing.Size(197, 42);
            this.btnMinimize.TabIndex = 10;
            this.btnMinimize.Text = "Minimize";
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.AnimationHoverSpeed = 0.07F;
            this.btnExit.AnimationSpeed = 0.03F;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.BorderColor = System.Drawing.Color.Azure;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExit.FocusedColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::Attendance_System.Properties.Resources.exit;
            this.btnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit.Location = new System.Drawing.Point(3, 339);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Radius = 5;
            this.btnExit.Size = new System.Drawing.Size(197, 42);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(83, 198);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(74, 19);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Attendance System";
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = global::Attendance_System.Properties.Resources.logo;
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(60, 37);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(120, 120);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 0;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // pnContainer
            // 
            this.pnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainer.Location = new System.Drawing.Point(240, 0);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(987, 710);
            this.pnContainer.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1227, 710);
            this.Controls.Add(this.pnContainer);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnContainer;
        public Guna.UI.WinForms.GunaButton btnDashboard;
        public Guna.UI.WinForms.GunaButton btnDepartments;
        public Guna.UI.WinForms.GunaButton btnUser;
        public Guna.UI.WinForms.GunaButton btnAttendance;
        public Guna.UI.WinForms.GunaButton btnReports;
        public Guna.UI.WinForms.GunaButton btnRequests;
        public Guna.UI.WinForms.GunaButton btnMinimize;
        public Guna.UI.WinForms.GunaButton btnExit;
        public System.Windows.Forms.Label lblUsername;
    }
}

