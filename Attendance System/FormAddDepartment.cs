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
    public partial class FormAddDepartment : System.Windows.Forms.Form
    {
        //CODE TO CONNECT TO DATABASE
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        FormDepartments frmlist;


        public FormAddDepartment(FormDepartments flist)
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

        //SAVE DEPARTMENT BUTTON
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Confirm adding this item?","Adding Department", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblCategory(category)VALUES(@category)", cn);
                    cm.Parameters.AddWithValue("@category", txtName.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    Clear();
                    MessageBox.Show("Item is added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmlist.LoadRecord();
                }
            }
            catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        //FUNCTION TO REMOVE TXTBOX DATA
        private void Clear()
        {
            txtName.Clear();
            txtName.Focus();
        }

        //CANCEL BUTTON 
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        //UPDATE DEPARTMENT BUTTON
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirm updating this item?", "Updating Department", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblCategory SET category=@category WHERE id LIKE '"+lblID.Text+"'", cn);
                    cm.Parameters.AddWithValue("@category", txtName.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    Clear();
                    MessageBox.Show("Item is Updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmlist.LoadRecord();
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
