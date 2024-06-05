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
    public partial class FormForgotPassword : Form
    {
        //CODE TO CONNECT TO DATABASE
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        public FormForgotPassword()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        //CHECK BUTTON
        private void btnCheck_Click(object sender, EventArgs e)
        {
            string _name = "";
            string _password = "";
            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT name, password FROM tblUser WHERE email LIKE '" + txtEmail.Text + "'", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    _name = dr["name"].ToString();
                    _password = dr["password"].ToString();
                }
                cn.Close();
                MessageBox.Show("Your Username is " + _name + " "+"AND Password is"+" "+ _password, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
