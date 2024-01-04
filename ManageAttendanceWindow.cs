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

        public void loadEventList()
        {
            try
            {
                conn.Open();
                string query = "SELECT event FROM events";
                cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string eventName = reader["event"].ToString();
                    metroComboBoxEvent.Items.Add(eventName);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
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
            loadEventList();
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

            string name = metroTextBoxName.Text.Trim();
            string event_ = metroComboBoxEvent.SelectedItem.ToString();

            // Periksa apakah nama, event, dan status tidak kosong
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(event_) || string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Nama, event, dan status harus diisi!");
                return; // Keluar dari metode jika ada yang kosong
            }

            // Eksekusi kueri SQL
            conn.Open();
            string absen = $"INSERT INTO attendance (name, event, status) VALUES ('{name}', '{event_}', '{status}')";
            cmd = new MySqlCommand(absen, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            metroTextBoxName.Clear();

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
            }
            else
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
