using AttendanceAppDesktop.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AttendanceAppDesktop
{
    public partial class OperatorWindow : Form
    {
        private Koneksi koneksi;
        MySqlConnection conn;

        MySqlCommand cmd = new MySqlCommand();
        private MySqlDataAdapter adapter;
        private DataTable dataTable;

        string id = LoginForm.Session.loggedInId;
        string email = LoginForm.Session.loggedInEmail;
        string name = LoginForm.Session.loggedInName;
        string role = LoginForm.Session.loggedInRole;

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

        public void updateEventsTable()
        {
            conn.Open();
            string query = $"SELECT * FROM events";
            cmd = new MySqlCommand(query, conn);

            adapter = new MySqlDataAdapter(cmd);
            dataTable = new DataTable();

            adapter.Fill(dataTable);

            dataGridView2.DataSource = dataTable;

            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            conn.Close();
        }

        public OperatorWindow()
        {
            InitializeComponent();

            koneksi = new Koneksi();
            conn = koneksi.conn;
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void OperatorWindow_Load(object sender, EventArgs e)
        {
            metroLabelName.Text = $"Name : {name}";
            metroLabelEmail.Text = $"Email : {email}";
            metroLabelRole.Text = $"Role : {role}";

            updateAttendanceTable();
            updateEventsTable();
        }

        private void metroLabelAddAttendance_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBoxName_Click(object sender, EventArgs e)
        {

        }

        private void metroLabelIDEvent_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void metroLabelEditAttendance_Click(object sender, EventArgs e)
        {

        }

        private void metroRadioButtonEditIzin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroButtonAdd_Click(object sender, EventArgs e)
        {
            string status = null;

            if (metroRadioButtonAddHadir.Checked)
            {
                status = "Hadir";
            }
            else if (metroRadioButtonAddTelat.Checked)
            {
                status = "Telat";
            }
            else if (metroRadioButtonAddIzin.Checked)
            {
                status = "Izin";
            }
            else if (metroRadioButtonAddAbsent.Checked)
            {
                status = "Absent";
            }

            string nama = metroTextBoxName.Text.Trim();
            string selectedEventId = metroTextBoxIDEvent.Text.Trim();

            // Periksa apakah nama, event, dan status tidak kosong
            if (string.IsNullOrEmpty(nama) || string.IsNullOrEmpty(selectedEventId) || string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Nama, event, dan status harus diisi!");
                return; // Keluar dari metode jika ada yang kosong
            }

            // Ambil nama event dari database events
            string eventQuery = $"SELECT event FROM events WHERE id = '{selectedEventId}'";

            conn.Open();
            cmd = new MySqlCommand(eventQuery, conn);
            string event_ = cmd.ExecuteScalar()?.ToString();
            conn.Close();

            // Periksa apakah event ditemukan
            if (string.IsNullOrEmpty(event_))
            {
                MessageBox.Show("Event tidak ditemukan!");
                return; // Keluar dari metode jika event tidak ditemukan
            }

            // Eksekusi kueri SQL
            conn.Open();
            string absen = $"INSERT INTO attendance (nama, event, status) VALUES ('{nama}', '{event_}', '{status}')";
            cmd = new MySqlCommand(absen, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            metroTextBoxName.Clear();
            metroTextBoxIDEvent.Clear();

            updateAttendanceTable();
        }

        private void metroButtonEdit_Click(object sender, EventArgs e)
        {
            string status = null;

            if (metroRadioButtonEditHadir.Checked)
            {
                status = "Hadir";
            }
            else if (metroRadioButtonEditTelat.Checked)
            {
                status = "Telat";
            }
            else if (metroRadioButtonEditIzin.Checked)
            {
                status = "Izin";
            }
            else if (metroRadioButtonEditAbsent.Checked)
            {
                status = "Absent";
            }

            string id = metroTextBoxEditIDAttendance.Text.ToString();

            // Periksa apakah nama, event, dan status tidak kosong
            if (string.IsNullOrEmpty(status) || string.IsNullOrEmpty(id))
            {
                MessageBox.Show("ID Attendance dan status harus diisi!");
                return; // Keluar dari metode jika ada yang kosong
            }

            conn.Open();
            string editAbsen = $"UPDATE attendance SET status = '{status}' WHERE id = {id}";
            cmd = new MySqlCommand(editAbsen, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            metroTextBoxEditIDAttendance.Clear();

            updateAttendanceTable();
        }

        private void metroButtonDelete_Click(object sender, EventArgs e)
        {
            string id = metroTextBoxDeleteIDAttendace.Text.ToString();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("ID Attendance harus diisi!");
                return; // Keluar dari metode jika ada yang kosong
            } else
            {
                conn.Open();
                string delAbsen = $"DELETE FROM attendance WHERE id = {id}";
                cmd = new MySqlCommand(delAbsen, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                metroTextBoxDeleteIDAttendace.Clear();

                updateAttendanceTable();
            }
        }
    }
}
