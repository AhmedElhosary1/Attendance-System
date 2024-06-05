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
    public partial class FormRequests : System.Windows.Forms.Form
    {

        //CODE TO CONNECT TO DATABASE
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        public FormRequests()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadLoginWait();
            LoadLogoutWait();
        }


        //FUNCTION TO LOAD WAITING LOGIN DATA
        public void LoadLoginWait()
        {
            int i = 0;
            DGVLoginRequest.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT id, code, username, phone, email, dep, date, intime, che FROM tblLoginWait Where che LIKE 'False' AND date LIKE '"+ DateTime.Now.ToString("dd/MM/yyyy") + "'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                DGVLoginRequest.Rows.Add(i, dr["id"].ToString(), dr["code"].ToString(), dr["username"].ToString(), dr["phone"].ToString(), dr["email"].ToString(), dr["dep"].ToString(), dr["date"].ToString(), dr["intime"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        //SAVE LOGIN REGUEST
        private void btnLoginSave_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                foreach (DataGridViewRow dvr in DGVLoginRequest.Rows)
                {
                    cm = new SqlCommand("UPDATE tblLoginWait SET status=@status, che=@che WHERE date=@date AND username=@username", cn);
                    cm.Parameters.AddWithValue("@username", dvr.Cells[3].Value);
                    cm.Parameters.AddWithValue("@date", dvr.Cells[7].Value);
                    cm.Parameters.AddWithValue("@status", dvr.Cells[9].Value);
                    cm.Parameters.AddWithValue("@che", "True");
                    cm.ExecuteNonQuery();
                }
                cn.Close();
                DGVLoginRequest.Rows.Clear();
                MessageBox.Show("success");
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }


        //FUNCTION TO LOAD WAITING Logout DATA
        public void LoadLogoutWait()
        {
            int i = 0;
            DGVLogoutInfo.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT id, code, username, phone, email, dep, date, outtime, che FROM tblLoginWait Where date LIKE '" + DateTime.Now.ToString("dd/MM/yyyy") + "'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                DGVLogoutInfo.Rows.Add(i, dr["id"].ToString(), dr["code"].ToString(), dr["username"].ToString(), dr["phone"].ToString(), dr["email"].ToString(), dr["dep"].ToString(), dr["date"].ToString(), dr["outtime"].ToString());
            }
            dr.Close();
            cn.Close();
        }
    }
}
