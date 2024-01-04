using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceAppDesktop.Class
{
    public class Koneksi
    {
        private string server = "127.0.0.1";
        private string user = "root";
        private string database = "attendance_app";
        private string password = "";

        public MySqlConnection conn;

        public Koneksi()
        {
            conn = new MySqlConnection(
                $"server={server};" +
                $"user={user};" +
                $"database={database};" +
                $"password={password}"
            );
        }
    }
}
