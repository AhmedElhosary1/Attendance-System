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
    public partial class FormUsers : System.Windows.Forms.Form
    {

        //CODE TO CONNECT TO DATABASE
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        public FormUsers()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadUser();
        }

        //OPEN ADD USER FORM BUTTON
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddUser adduser = new FormAddUser(this);
            adduser.btnGenerateCode.Enabled = true;
            adduser.btnUpdate.Enabled = false;
            adduser.btnCancel.Enabled = true;
            adduser.LoadDepartments();
            adduser.ShowDialog();
        }

        //FUNCTION TO LOAD USER DATA
        public void LoadUser()
        {
            int i = 0;
            DGVUsers.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT u.id, u.code, u.name, u.password, u.email, u.phone, d.category, u.gender, u.role FROM tblUser AS u INNER JOIN tblCategory AS d  ON u.dep = d.id WHERE u.name Like '" + txtSearch.Text + "%'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                DGVUsers.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString());
            }
            dr.Close();
            cn.Close();
        }


        //PASS DATA FROM DGV TO EDIT OR DELETE
        private void DGVUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = DGVUsers.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                FormAddUser frm = new FormAddUser(this);
                frm.btnUpdate.Enabled = true;
                frm.btnSave.Enabled = false;
                frm.btnGenerateCode.Enabled = false;
                frm.LoadDepartments();
                frm.txtCode.Text = DGVUsers[2, e.RowIndex].Value.ToString();
                frm.txtName.Text = DGVUsers[3, e.RowIndex].Value.ToString();
                frm.txtPassword.Text = DGVUsers[4, e.RowIndex].Value.ToString();
                frm.txtEmail.Text = DGVUsers[5, e.RowIndex].Value.ToString();
                frm.txtPhone.Text = DGVUsers[6, e.RowIndex].Value.ToString();
                frm.CBDepartment.Text = DGVUsers[7, e.RowIndex].Value.ToString();
                frm.CBGender.Text = DGVUsers[8, e.RowIndex].Value.ToString();
                frm.CBRole.Text = DGVUsers[9, e.RowIndex].Value.ToString();
                frm.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Confirm Deleting this item?", "Deleting User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblUser WHERE name LIKE '" + DGVUsers.Rows[e.RowIndex].Cells[3].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Item is Deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUser();
                }
            }
        }

        //SEARCH USER
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadUser();
        }
    }
}
