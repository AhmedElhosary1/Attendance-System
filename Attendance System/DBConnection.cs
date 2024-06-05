using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_System
{
    class DBConnection
    {
        public string MyConnection()
        {
            string con = @"Data Source=DESKTOP-OQFAECB;Initial Catalog=AttendanceSystem;Integrated Security=True";
            return con;
        }
    }
}
