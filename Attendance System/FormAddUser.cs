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
    public partial class FormAddUser : System.Windows.Forms.Form
    {

        //CODE TO CONNECT TO DATABASE
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        FormUsers frmlist;

        public FormAddUser(FormUsers flist)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frmlist = flist;
        }


        //EXIT BUTTON
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        //FUNCTION TO GENERATE NEXT CODE
        private void GetCode()
        {
            try
            {
                string sdate = DateTime.Now.ToString("yyyyMMdd");
                string code;
                int count;
                cn.Open();
                cm = new SqlCommand("SELECT TOP 1 code FROM tblUser WHERE code LIKE '" + sdate + "%'ORDER BY id DESC", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    code = dr[0].ToString();
                    count = int.Parse(code.Substring(8, 4));
                    txtCode.Text = sdate + (count + 1);
                }
                else
                {
                    code = sdate + "1001";
                    txtCode.Text = code;
                }
                dr.Close();
                cn.Close();
            }
            catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }


        //GENERATE CODE BUTTON
        private void btnGenerateCode_Click(object sender, EventArgs e)
        {
            GetCode();
        }



        //SAVE USER DATA BUTTON
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirm adding this item?", "Adding User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (txtCode.Text == string.Empty)
                    {
                        MessageBox.Show("Code Must be Generated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string depid = "";
                        cn.Open();
                        cm = new SqlCommand("SELECT id FROM tblCategory WHERE category LIKE '" + CBDepartment.Text + "'", cn);
                        dr = cm.ExecuteReader();
                        dr.Read();
                        if (dr.HasRows)
                        {
                            depid = dr[0].ToString();
                        }
                        dr.Close();
                        cn.Close();

                        cn.Open();
                        cm = new SqlCommand("INSERT INTO tblUser (code, name, password, email, phone, dep, gender, role) VALUES (@code, @name, @password, @email, @phone, @dep, @gender, @role)", cn);
                        cm.Parameters.AddWithValue("@code", txtCode.Text);
                        cm.Parameters.AddWithValue("@name", txtName.Text);
                        cm.Parameters.AddWithValue("@password", txtPassword.Text);
                        cm.Parameters.AddWithValue("@email", txtEmail.Text);
                        cm.Parameters.AddWithValue("@phone", txtPhone.Text);
                        cm.Parameters.AddWithValue("@dep", depid);
                        cm.Parameters.AddWithValue("@gender", CBGender.Text);
                        cm.Parameters.AddWithValue("@role", CBRole.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Item is added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        frmlist.LoadUser();
                    }
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }



        //FUNCTION TO CLEAR TXTBOX DATA
        private void Clear()
        {
            txtCode.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtPhone.Clear();
            txtCode.Focus();
        }



        //FUNCTION TO LOAD DATA INSIDE CBCATEGORY
        public void LoadDepartments()
        {
            CBDepartment.Items.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT category FROM tblCategory", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                CBDepartment.Items.Add(dr[0].ToString());
            }
            dr.Close();
            cn.Close();
        }


        //UPDATE USER DATA BUTTON
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirm updating this item?", "Updating User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string depid = "";
                    cn.Open();
                    cm = new SqlCommand("SELECT id FROM tblCategory WHERE category LIKE '" + CBDepartment.Text + "'", cn);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        depid = dr[0].ToString();
                    }
                    dr.Close();
                    cn.Close();

                    cn.Open();
                    cm = new SqlCommand("UPDATE tblUser SET code=@code, name=@name, password=@password, email=@email, phone=@phone, dep=@dep, gender=@gender, role=@role WHERE code LIKE @code", cn);
                    cm.Parameters.AddWithValue("@code", txtCode.Text);
                    cm.Parameters.AddWithValue("@name", txtName.Text);
                    cm.Parameters.AddWithValue("@password", txtPassword.Text);
                    cm.Parameters.AddWithValue("@email", txtEmail.Text);
                    cm.Parameters.AddWithValue("@phone", txtPhone.Text);
                    cm.Parameters.AddWithValue("@dep", depid);
                    cm.Parameters.AddWithValue("@gender", CBGender.Text);
                    cm.Parameters.AddWithValue("@role", CBRole.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Item is updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    frmlist.LoadUser();
                    this.Dispose();
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
