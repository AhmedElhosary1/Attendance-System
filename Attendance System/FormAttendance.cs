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
    public partial class FormAttendance : System.Windows.Forms.Form
    {

        //CODE TO CONNECT TO DATABASE
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;


        public FormAttendance()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }


        //SEARCH ABOUT USER DATA  FOR LOGIN BUTTON
        private void btnLoginSearch_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT u.name, u.email, u.phone, u.gender, d.category  FROM tblUser AS u INNER JOIN tblCategory AS d  ON u.dep = d.id  WHERE code LIKE '" + txtCode.Text + "'", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    txtName.Text = dr["name"].ToString();
                    txtEmail.Text = dr["email"].ToString();
                    txtPhone.Text = dr["phone"].ToString();
                    txtGender.Text = dr["gender"].ToString();
                    txtDepartment.Text = dr["category"].ToString();
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }



        //SEARCH ABOUT USER DATA  FOR LOGOUT BUTTON
        private void btnLogoutSearch_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT u.name, u.email, u.phone, u.gender, d.category  FROM tblUser AS u INNER JOIN tblCategory AS d  ON u.dep = d.id  WHERE code LIKE '" + txtLogoutCode.Text + "'", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    txtLogoutName.Text = dr["name"].ToString();
                    txtLogoutEmail.Text = dr["email"].ToString();
                    txtLogoutPhone.Text = dr["phone"].ToString();
                    txtLogoutGender.Text = dr["gender"].ToString();
                    txtLogoutDepartment.Text = dr["category"].ToString();
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }


        //LOGIN ATTENDANCE REGISTER BUTTON
        private void btnLoginRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string date = DateTime.Now.ToString("dd/MM/yyyy");
                string time = DateTime.Now.ToLongTimeString();
                lblLoginDate.Text = date;
                lblLoginTime.Text = time;
                lblLoginUsername.Text = txtName.Text;
                if (txtCode.Text == string.Empty)
                {
                    MessageBox.Show("You have to enter Your CODE!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblLoginWait (code, username, phone, email, dep, date, intime, che) VALUES (@code, @username, @phone, @email, @dep, @date, @intime, @che)", cn);
                    cm.Parameters.AddWithValue("@code", txtCode.Text);
                    cm.Parameters.AddWithValue("@username", txtName.Text);
                    cm.Parameters.AddWithValue("@phone", txtPhone.Text);
                    cm.Parameters.AddWithValue("@email", txtEmail.Text);
                    cm.Parameters.AddWithValue("@dep", txtDepartment.Text);
                    cm.Parameters.AddWithValue("@date", lblLoginDate.Text);
                    cm.Parameters.AddWithValue("@intime", lblLoginTime.Text);
                    cm.Parameters.AddWithValue("@che", "False");
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record is Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clearin();
                }
            }
            catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        //CLEAR TXTBOXS DATA FUNCTION
        private void Clearin()
        {
            txtCode.Clear();
            txtDepartment.Clear();
            txtEmail.Clear();
            txtGender.Clear();
            txtName.Clear();
            txtPhone.Clear();
            lblLoginDate.Text = "000000000000";
            lblLoginTime.Text = "000000000000";
            txtCode.Focus();
        }

        //CLEAR TXTBOXS DATA FUNCTION
        private void Clearout()
        {
            txtLogoutCode.Clear();
            txtLogoutDepartment.Clear();
            txtLogoutEmail.Clear();
            txtLogoutGender.Clear();
            txtLogoutName.Clear();
            txtLogoutPhone.Clear();
            lblLogoutDate.Text = "000000000000";
            lblLogoutTime.Text = "000000000000";
            txtLogoutCode.Focus();
        }


        //LOGOUT ATTENDANCE REGISTER BUTTON
        private void btnLogoutRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string date = DateTime.Now.ToString("dd/MM/yyyy");
                string time = DateTime.Now.ToLongTimeString();
                lblLogoutDate.Text = date;
                lblLogoutTime.Text = time;
                lblLogoutUsername.Text = txtName.Text;
                if (txtLogoutCode.Text == string.Empty)
                {
                    MessageBox.Show("You have to enter Your CODE!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblLoginWait SET outtime=@outtime WHERE username=@username AND date LIKE '"+ DateTime.Now.ToString("dd/MM/yyyy") + "'", cn);
                    cm.Parameters.AddWithValue("@username", txtLogoutName.Text);
                    cm.Parameters.AddWithValue("@date", lblLogoutDate.Text);
                    cm.Parameters.AddWithValue("@outtime", lblLogoutTime.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record is Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clearout();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
