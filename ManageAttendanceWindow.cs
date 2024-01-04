using AttendanceAppDesktop.Class;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace AttendanceAppDesktop
{
    public partial class ManageAttendanceWindow : Form
    {
        private Koneksi koneksi;
        MySqlConnection conn;

        MySqlCommand cmd = new MySqlCommand();
        private MySqlDataAdapter adapter;
        private DataTable dataTable;

        public void updateAttendanceTable()
        {
            conn.Open();
            string query = $"SELECT * FROM attendance";
            cmd = new MySqlCommand(query, conn);

            adapter = new MySqlDataAdapter(cmd);
            dataTable = new DataTable();

            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            conn.Close();
        }

        public ManageAttendanceWindow()
        {
            InitializeComponent();

            koneksi = new Koneksi();
            conn = koneksi.conn;
        }

        private void ManageAttendanceWindow_Load(object sender, EventArgs e)
        {
            updateAttendanceTable();
        }

        private void metroButtonAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
