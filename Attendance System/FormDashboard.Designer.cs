
namespace Attendance_System
{
    partial class FormDashboard
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
            this.pnDashboard = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.shadowlogin = new Guna.UI.WinForms.GunaShadowPanel();
            this.PBLogin = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.lblLog = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gunaShadowPanel2 = new Guna.UI.WinForms.GunaShadowPanel();
            this.PBEmployee = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.lblEmp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.PBDepartment = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.lblDep = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnDashboard.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.shadowlogin.SuspendLayout();
            this.PBLogin.SuspendLayout();
            this.gunaShadowPanel2.SuspendLayout();
            this.PBEmployee.SuspendLayout();
            this.gunaShadowPanel1.SuspendLayout();
            this.PBDepartment.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDashboard
            // 
            this.pnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnDashboard.Controls.Add(this.flowLayoutPanel1);
            this.pnDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnDashboard.Name = "pnDashboard";
            this.pnDashboard.Size = new System.Drawing.Size(987, 710);
            this.pnDashboard.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.shadowlogin);
            this.flowLayoutPanel1.Controls.Add(this.gunaShadowPanel2);
            this.flowLayoutPanel1.Controls.Add(this.gunaShadowPanel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(108, 200);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(771, 310);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // shadowlogin
            // 
            this.shadowlogin.BackColor = System.Drawing.Color.Transparent;
            this.shadowlogin.BaseColor = System.Drawing.Color.White;
            this.shadowlogin.Controls.Add(this.PBLogin);
            this.shadowlogin.Controls.Add(this.label5);
            this.shadowlogin.Location = new System.Drawing.Point(3, 3);
            this.shadowlogin.Name = "shadowlogin";
            this.shadowlogin.Radius = 5;
            this.shadowlogin.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.shadowlogin.Size = new System.Drawing.Size(250, 301);
            this.shadowlogin.TabIndex = 18;
            // 
            // PBLogin
            // 
            this.PBLogin.AnimationSpeed = 0.6F;
            this.PBLogin.BaseColor = System.Drawing.Color.White;
            this.PBLogin.Controls.Add(this.lblLog);
            this.PBLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.PBLogin.IdleColor = System.Drawing.Color.Gainsboro;
            this.PBLogin.IdleOffset = 20;
            this.PBLogin.Image = null;
            this.PBLogin.ImageSize = new System.Drawing.Size(52, 52);
            this.PBLogin.Location = new System.Drawing.Point(0, 0);
            this.PBLogin.Name = "PBLogin";
            this.PBLogin.ProgressMaxColor = System.Drawing.Color.Teal;
            this.PBLogin.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PBLogin.ProgressOffset = 20;
            this.PBLogin.Size = new System.Drawing.Size(250, 250);
            this.PBLogin.TabIndex = 5;
            // 
            // lblLog
            // 
            this.lblLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLog.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLog.Location = new System.Drawing.Point(0, 0);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(250, 250);
            this.lblLog.TabIndex = 9;
            this.lblLog.Text = "00";
            this.lblLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(16, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 39);
            this.label5.TabIndex = 6;
            this.label5.Text = "Login Requests";
            // 
            // gunaShadowPanel2
            // 
            this.gunaShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel2.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel2.Controls.Add(this.PBEmployee);
            this.gunaShadowPanel2.Controls.Add(this.label2);
            this.gunaShadowPanel2.Location = new System.Drawing.Point(259, 3);
            this.gunaShadowPanel2.Name = "gunaShadowPanel2";
            this.gunaShadowPanel2.Radius = 5;
            this.gunaShadowPanel2.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gunaShadowPanel2.Size = new System.Drawing.Size(250, 301);
            this.gunaShadowPanel2.TabIndex = 17;
            // 
            // PBEmployee
            // 
            this.PBEmployee.AnimationSpeed = 0.6F;
            this.PBEmployee.BaseColor = System.Drawing.Color.White;
            this.PBEmployee.Controls.Add(this.lblEmp);
            this.PBEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.PBEmployee.IdleColor = System.Drawing.Color.Gainsboro;
            this.PBEmployee.IdleOffset = 20;
            this.PBEmployee.Image = null;
            this.PBEmployee.ImageSize = new System.Drawing.Size(52, 52);
            this.PBEmployee.Location = new System.Drawing.Point(0, 0);
            this.PBEmployee.Name = "PBEmployee";
            this.PBEmployee.ProgressMaxColor = System.Drawing.Color.Teal;
            this.PBEmployee.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PBEmployee.ProgressOffset = 20;
            this.PBEmployee.Size = new System.Drawing.Size(250, 250);
            this.PBEmployee.TabIndex = 5;
            // 
            // lblEmp
            // 
            this.lblEmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmp.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmp.Location = new System.Drawing.Point(0, 0);
            this.lblEmp.Name = "lblEmp";
            this.lblEmp.Size = new System.Drawing.Size(250, 250);
            this.lblEmp.TabIndex = 8;
            this.lblEmp.Text = "00";
            this.lblEmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(48, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "Employees";
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.PBDepartment);
            this.gunaShadowPanel1.Controls.Add(this.label1);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(515, 3);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Radius = 5;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Teal;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(250, 301);
            this.gunaShadowPanel1.TabIndex = 16;
            // 
            // PBDepartment
            // 
            this.PBDepartment.AnimationSpeed = 0.6F;
            this.PBDepartment.BaseColor = System.Drawing.Color.White;
            this.PBDepartment.Controls.Add(this.lblDep);
            this.PBDepartment.Dock = System.Windows.Forms.DockStyle.Top;
            this.PBDepartment.IdleColor = System.Drawing.Color.Gainsboro;
            this.PBDepartment.IdleOffset = 20;
            this.PBDepartment.Image = null;
            this.PBDepartment.ImageSize = new System.Drawing.Size(52, 52);
            this.PBDepartment.Location = new System.Drawing.Point(0, 0);
            this.PBDepartment.Name = "PBDepartment";
            this.PBDepartment.ProgressMaxColor = System.Drawing.Color.Teal;
            this.PBDepartment.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PBDepartment.ProgressOffset = 20;
            this.PBDepartment.Size = new System.Drawing.Size(250, 250);
            this.PBDepartment.TabIndex = 5;
            // 
            // lblDep
            // 
            this.lblDep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDep.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDep.Location = new System.Drawing.Point(0, 0);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(250, 250);
            this.lblDep.TabIndex = 7;
            this.lblDep.Text = "00";
            this.lblDep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Departments";
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(987, 710);
            this.Controls.Add(this.pnDashboard);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDashboard";
            this.Text = "FormDashboard";
            this.pnDashboard.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.shadowlogin.ResumeLayout(false);
            this.shadowlogin.PerformLayout();
            this.PBLogin.ResumeLayout(false);
            this.gunaShadowPanel2.ResumeLayout(false);
            this.gunaShadowPanel2.PerformLayout();
            this.PBEmployee.ResumeLayout(false);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            this.PBDepartment.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnDashboard;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaCircleProgressBar PBLogin;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel2;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaCircleProgressBar PBEmployee;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaCircleProgressBar PBDepartment;
        public System.Windows.Forms.Label lblLog;
        public System.Windows.Forms.Label lblEmp;
        public System.Windows.Forms.Label lblDep;
        public Guna.UI.WinForms.GunaShadowPanel shadowlogin;
    }
}