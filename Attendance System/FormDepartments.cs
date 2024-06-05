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
    public partial class FormDepartments : System.Windows.Forms.Form
    {

        //CODE TO CONNECT TO DATABASE
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;


        public FormDepartments()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadRecord();
        }

        //OPEN ADD DEPARTENT FORM BUTTON
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddDepartment adddep = new FormAddDepartment(this);
            adddep.btnSave.Enabled = true;
            adddep.btnUpdate.Enabled = false;
            adddep.btnCancel.Enabled = true;
            adddep.ShowDialog();
        }

        //FUNCTION TO LOAD DATA INSIDE DATAGRIDVIEW
        public void LoadRecord()
        {
            int i = 0;
            DGVDepartments.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tblCategory ORDER BY category", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                DGVDepartments.Rows.Add(i, dr["id"].ToString(), dr["Category"].ToString());
            }
            dr.Close();
            cn.Close();
        }


        //PASS DATA FROM DGV TO EDIT OR DELETE
        private void DGVDepartments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = DGVDepartments.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                FormAddDepartment frm = new FormAddDepartment(this);
                frm.btnUpdate.Enabled = true;
                frm.btnSave.Enabled = false;
                frm.lblID.Text = DGVDepartments[1, e.RowIndex].Value.ToString();
                frm.txtName.Text = DGVDepartments[2, e.RowIndex].Value.ToString();
                frm.ShowDialog();
            }
            else if(colName == "Delete")
            {
                try
                {
                    if (MessageBox.Show("Confirm Deleting this item?", "Deleting Department", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cm = new SqlCommand("DELETE FROM tblCategory Where id LIKE '" + DGVDepartments[1, e.RowIndex].Value.ToString() + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Item is deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadRecord();
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
}
