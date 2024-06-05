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

namespace Attendance_System
{
    public partial class FormLogin : System.Windows.Forms.Form
    {
        //CODE TO CONNECT TO DATABASE
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        public FormLogin()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        //LOGIN BUTTON
        private void btnSave_Click(object sender, EventArgs e)
        {
            string _name = "";
            string _role = "";
            string _password = "";
            try
            {
                bool found = false;
                cn.Open();
                cm = new SqlCommand("SELECT * FROM tblUser WHERE name=@name AND password=@password", cn);
                cm.Parameters.AddWithValue("@name", txtUsername.Text);
                cm.Parameters.AddWithValue("@password", txtPassword.Text);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    found = true;
                    _name = dr["name"].ToString();
                    _role = dr["role"].ToString();
                    _password = dr["password"].ToString();
                }
                else
                {
                    found = false;
                }
                dr.Close();
                cn.Close();

                if(found == true)
                {
                    if (_role == "User")
                    {
                        MessageBox.Show("Welcome" + _name, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUsername.Clear();
                        txtPassword.Clear();
                        txtUsername.Focus();
                        this.Hide();
                        FormMain main = new FormMain();
                        main.btnDepartments.Visible = false;
                        main.btnRequests.Visible = false;
                        main.btnUser.Visible = false;
                        main.lblUsername.Text = _name + "|" + _role;
                        main.ShowDialog();
                    }
                    else if(_role == "Admin")
                    {
                        MessageBox.Show("Welcome" + _name, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUsername.Clear();
                        txtPassword.Clear();
                        txtUsername.Focus();
                        this.Hide();
                        FormMain main = new FormMain();
                        main.lblUsername.Text = _name + "|" + _role;
                        main.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Username Or Password", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        //CANCEL BUTTON
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        //link forgot password
        private void lblForgotpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormForgotPassword forgotPassword = new FormForgotPassword();
            forgotPassword.ShowDialog();
        }
    }
}
