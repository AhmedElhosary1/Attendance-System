
namespace Attendance_System
{
    partial class FormAddUser
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new Guna.UI.WinForms.GunaLineTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerateCode = new Guna.UI.WinForms.GunaButton();
            this.txtName = new Guna.UI.WinForms.GunaLineTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI.WinForms.GunaLineTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI.WinForms.GunaLineTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhone = new Guna.UI.WinForms.GunaLineTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CBDepartment = new Guna.UI.WinForms.GunaComboBox();
            this.CBGender = new Guna.UI.WinForms.GunaComboBox();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.btnCancel = new Guna.UI.WinForms.GunaButton();
            this.btnUpdate = new Guna.UI.WinForms.GunaButton();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.btnExit = new Guna.UI.WinForms.GunaImageButton();
            this.CBRole = new Guna.UI.WinForms.GunaComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 60);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add User";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.White;
            this.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCode.Enabled = false;
            this.txtCode.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtCode.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCode.Location = new System.Drawing.Point(164, 108);
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.SelectedText = "";
            this.txtCode.Size = new System.Drawing.Size(424, 38);
            this.txtCode.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "User Code:";
            // 
            // btnGenerateCode
            // 
            this.btnGenerateCode.AnimationHoverSpeed = 0.07F;
            this.btnGenerateCode.AnimationSpeed = 0.03F;
            this.btnGenerateCode.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerateCode.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGenerateCode.BorderColor = System.Drawing.Color.Azure;
            this.btnGenerateCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateCode.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGenerateCode.FocusedColor = System.Drawing.Color.Empty;
            this.btnGenerateCode.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateCode.ForeColor = System.Drawing.Color.White;
            this.btnGenerateCode.Image = null;
            this.btnGenerateCode.ImageSize = new System.Drawing.Size(30, 30);
            this.btnGenerateCode.Location = new System.Drawing.Point(605, 108);
            this.btnGenerateCode.Name = "btnGenerateCode";
            this.btnGenerateCode.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btnGenerateCode.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGenerateCode.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGenerateCode.OnHoverImage = null;
            this.btnGenerateCode.OnPressedColor = System.Drawing.Color.Black;
            this.btnGenerateCode.Radius = 5;
            this.btnGenerateCode.Size = new System.Drawing.Size(180, 42);
            this.btnGenerateCode.TabIndex = 18;
            this.btnGenerateCode.Text = "Generate Code";
            this.btnGenerateCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGenerateCode.Click += new System.EventHandler(this.btnGenerateCode_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.Location = new System.Drawing.Point(164, 171);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(424, 38);
            this.txtName.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 28);
            this.label3.TabIndex = 19;
            this.label3.Text = "User name:";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtPassword.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.Location = new System.Drawing.Point(164, 234);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(424, 38);
            this.txtPassword.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 28);
            this.label4.TabIndex = 21;
            this.label4.Text = "Password:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtEmail.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.Location = new System.Drawing.Point(164, 297);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(424, 38);
            this.txtEmail.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 28);
            this.label5.TabIndex = 23;
            this.label5.Text = "Email:";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtPhone.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPhone.Location = new System.Drawing.Point(164, 354);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(424, 38);
            this.txtPhone.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 28);
            this.label6.TabIndex = 25;
            this.label6.Text = "Phone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 435);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 28);
            this.label7.TabIndex = 27;
            this.label7.Text = "Department:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(42, 492);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 28);
            this.label8.TabIndex = 28;
            this.label8.Text = "Gender:";
            // 
            // CBDepartment
            // 
            this.CBDepartment.BackColor = System.Drawing.Color.Transparent;
            this.CBDepartment.BaseColor = System.Drawing.Color.White;
            this.CBDepartment.BorderColor = System.Drawing.Color.Silver;
            this.CBDepartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBDepartment.FocusedColor = System.Drawing.Color.Empty;
            this.CBDepartment.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBDepartment.ForeColor = System.Drawing.Color.Black;
            this.CBDepartment.FormattingEnabled = true;
            this.CBDepartment.Location = new System.Drawing.Point(175, 427);
            this.CBDepartment.Name = "CBDepartment";
            this.CBDepartment.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CBDepartment.OnHoverItemForeColor = System.Drawing.Color.White;
            this.CBDepartment.Radius = 5;
            this.CBDepartment.Size = new System.Drawing.Size(413, 36);
            this.CBDepartment.TabIndex = 32;
            // 
            // CBGender
            // 
            this.CBGender.BackColor = System.Drawing.Color.Transparent;
            this.CBGender.BaseColor = System.Drawing.Color.White;
            this.CBGender.BorderColor = System.Drawing.Color.Silver;
            this.CBGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBGender.FocusedColor = System.Drawing.Color.Empty;
            this.CBGender.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBGender.ForeColor = System.Drawing.Color.Black;
            this.CBGender.FormattingEnabled = true;
            this.CBGender.Items.AddRange(new object[] {
            "-----------------------",
            "Male",
            "Female"});
            this.CBGender.Location = new System.Drawing.Point(175, 484);
            this.CBGender.Name = "CBGender";
            this.CBGender.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CBGender.OnHoverItemForeColor = System.Drawing.Color.White;
            this.CBGender.Radius = 5;
            this.CBGender.Size = new System.Drawing.Size(413, 36);
            this.CBGender.TabIndex = 33;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.panel1;
            // 
            // btnCancel
            // 
            this.btnCancel.AnimationHoverSpeed = 0.07F;
            this.btnCancel.AnimationSpeed = 0.03F;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.BorderColor = System.Drawing.Color.Azure;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancel.FocusedColor = System.Drawing.Color.Empty;
            this.btnCancel.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::Attendance_System.Properties.Resources.CANCEL;
            this.btnCancel.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCancel.Location = new System.Drawing.Point(519, 619);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btnCancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCancel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCancel.OnHoverImage = null;
            this.btnCancel.OnPressedColor = System.Drawing.Color.Black;
            this.btnCancel.Radius = 5;
            this.btnCancel.Size = new System.Drawing.Size(197, 42);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Cancel";
            // 
            // btnUpdate
            // 
            this.btnUpdate.AnimationHoverSpeed = 0.07F;
            this.btnUpdate.AnimationSpeed = 0.03F;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.BorderColor = System.Drawing.Color.Azure;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdate.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdate.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::Attendance_System.Properties.Resources.UPDATE;
            this.btnUpdate.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUpdate.Location = new System.Drawing.Point(309, 619);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdate.OnHoverImage = null;
            this.btnUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdate.Radius = 5;
            this.btnUpdate.Size = new System.Drawing.Size(197, 42);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.AnimationHoverSpeed = 0.07F;
            this.btnSave.AnimationSpeed = 0.03F;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.BorderColor = System.Drawing.Color.Azure;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.FocusedColor = System.Drawing.Color.Empty;
            this.btnSave.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::Attendance_System.Properties.Resources.SAVE;
            this.btnSave.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSave.Location = new System.Drawing.Point(98, 619);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Radius = 5;
            this.btnSave.Size = new System.Drawing.Size(197, 42);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExit.Image = global::Attendance_System.Properties.Resources.exit;
            this.btnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit.Location = new System.Drawing.Point(767, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnExit.Size = new System.Drawing.Size(35, 35);
            this.btnExit.TabIndex = 2;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // CBRole
            // 
            this.CBRole.BackColor = System.Drawing.Color.Transparent;
            this.CBRole.BaseColor = System.Drawing.Color.White;
            this.CBRole.BorderColor = System.Drawing.Color.Silver;
            this.CBRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBRole.FocusedColor = System.Drawing.Color.Empty;
            this.CBRole.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBRole.ForeColor = System.Drawing.Color.Black;
            this.CBRole.FormattingEnabled = true;
            this.CBRole.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.CBRole.Location = new System.Drawing.Point(175, 534);
            this.CBRole.Name = "CBRole";
            this.CBRole.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CBRole.OnHoverItemForeColor = System.Drawing.Color.White;
            this.CBRole.Radius = 5;
            this.CBRole.Size = new System.Drawing.Size(413, 36);
            this.CBRole.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(42, 542);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 28);
            this.label9.TabIndex = 34;
            this.label9.Text = "Role:";
            // 
            // FormAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(814, 696);
            this.Controls.Add(this.CBRole);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CBGender);
            this.Controls.Add(this.CBDepartment);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGenerateCode);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddUser";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaImageButton btnExit;
        private System.Windows.Forms.Label label1;
        public Guna.UI.WinForms.GunaLineTextBox txtCode;
        private System.Windows.Forms.Label label2;
        public Guna.UI.WinForms.GunaButton btnGenerateCode;
        public Guna.UI.WinForms.GunaLineTextBox txtName;
        private System.Windows.Forms.Label label3;
        public Guna.UI.WinForms.GunaLineTextBox txtPassword;
        private System.Windows.Forms.Label label4;
        public Guna.UI.WinForms.GunaLineTextBox txtEmail;
        private System.Windows.Forms.Label label5;
        public Guna.UI.WinForms.GunaLineTextBox txtPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public Guna.UI.WinForms.GunaButton btnCancel;
        public Guna.UI.WinForms.GunaButton btnUpdate;
        public Guna.UI.WinForms.GunaButton btnSave;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        public Guna.UI.WinForms.GunaComboBox CBDepartment;
        public Guna.UI.WinForms.GunaComboBox CBGender;
        public Guna.UI.WinForms.GunaComboBox CBRole;
        private System.Windows.Forms.Label label9;
    }
}