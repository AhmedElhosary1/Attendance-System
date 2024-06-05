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
    public partial class FormMain : System.Windows.Forms.Form
    {

        //CODE TO CONNECT TO DATABASE
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();


        public FormMain()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        //OPEN DEPARTMENTS FORM BUTTON
        private void btnDepartments_Click(object sender, EventArgs e)
        {
            FormDepartments departments = new FormDepartments();
            pnContainer.Controls.Clear();
            pnContainer.Controls.Add(departments.pnDepartments);
        }

        //OPEN USERS FORM BUTTON
        private void btnUser_Click(object sender, EventArgs e)
        {
            FormUsers users = new FormUsers();
            pnContainer.Controls.Clear();
            pnContainer.Controls.Add(users.pnUsers);
        }

        //OPEN ATTENDANCE FORM BUTTON
        private void btnAttendance_Click(object sender, EventArgs e)
        {
            FormAttendance att = new FormAttendance();
            pnContainer.Controls.Clear();
            pnContainer.Controls.Add(att.pnAttendance);
        }

        //OPEN REQUESTS FORM BUTTON
        private void btnRequests_Click(object sender, EventArgs e)
        {
            FormRequests requests = new FormRequests();
            pnContainer.Controls.Clear();
            pnContainer.Controls.Add(requests.pnRequest);
        }

        //MINIMIZE FORM BUTTON
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //OPEN REPORTS FORM BUTTON
        private void btnReports_Click(object sender, EventArgs e)
        {
            FormReports reports = new FormReports();
            pnContainer.Controls.Clear();
            pnContainer.Controls.Add(reports.pnReports);
        }

        //OPEN DASHBOARD FORM BUTTON
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FormDashboard dashboard = new FormDashboard();
            pnContainer.Controls.Clear();
            dashboard.LoadNumbers();
            pnContainer.Controls.Add(dashboard.pnDashboard);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            FormDashboard dashboard = new FormDashboard();
            pnContainer.Controls.Clear();
            dashboard.LoadNumbers();
            pnContainer.Controls.Add(dashboard.pnDashboard);
        }


        //EXIT BUTTON
        private void btnExit_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            this.Dispose();
            login.ShowDialog();
        }
    }
}
