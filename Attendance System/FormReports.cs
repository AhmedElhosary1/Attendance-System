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
    public partial class FormReports : Form
    {

        //CODE TO CONNECT TO DATABASE
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;



        public FormReports()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void LoadReport()
        {
            int i = 0;
            DGVReports.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT u.code, u.name, u.email, u.phone, n.dep, n.date, n.intime, n.outtime, n.status FROM tblUser AS u INNER JOIN tblLoginWait AS n ON u.name = n.username  WHERE u.name Like '" + txtSearch.Text + "%'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                DGVReports.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadReport();
        }
    }
}
