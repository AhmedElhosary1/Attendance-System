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
    public partial class FormDashboard : Form
    {

        //CODE TO CONNECT TO DATABASE
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();


        public FormDashboard()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            LoadNumbers();
        }


        public void LoadNumbers()
        {
            FormDepartments dep = new FormDepartments();
            int n = dep.DGVDepartments.Rows.Count;
            PBDepartment.Value = n;
            lblDep.Text = n.ToString();

            FormUsers users = new FormUsers();
            int m = users.DGVUsers.Rows.Count;
            PBEmployee.Value = m;
            lblEmp.Text = m.ToString();

            FormRequests requests = new FormRequests();
            int o = requests.DGVLoginRequest.Rows.Count;
            PBLogin.Value = o;
            lblLog.Text = o.ToString();
        }
    }
}
