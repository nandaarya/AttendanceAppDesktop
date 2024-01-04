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
using System.Xml.Linq;

namespace AttendanceAppDesktop
{
    public partial class ManageEventsWindow : Form
    {
        private Koneksi koneksi;
        MySqlConnection conn;

        MySqlCommand cmd = new MySqlCommand();
        private MySqlDataAdapter adapter;
        private DataTable dataTable;

        public void updateEventTable()
        {
            conn.Open();
            string query = $"SELECT * FROM events";
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

        public ManageEventsWindow()
        {
            InitializeComponent();

            koneksi = new Koneksi();
            conn = koneksi.conn;
        }

        private void ManageEventsWindow_Load(object sender, EventArgs e)
        {
            updateEventTable();

            timePickerAdd.Format = DateTimePickerFormat.Custom;
            timePickerAdd.CustomFormat = "HH:mm";
        }

        private void metroButtonAdd_Click(object sender, EventArgs e)
        {
            string event_ = metroTextBoxAddEventName.Text.ToString();
            string location = metroTextBoxAddLocation.Text.ToString();
            string date = datePickerAdd.Value.ToString("yy-MM-dd");
            string time = timePickerAdd.Value.ToString("HH:mm");

            if (string.IsNullOrEmpty(event_) || string.IsNullOrEmpty(location) || string.IsNullOrEmpty(date) || string.IsNullOrEmpty(time))
            {
                MessageBox.Show("Nama event, lokasi, tanggal dan waktu harus diisi!");
                return;
            } else
            {
                conn.Open();
                string addEvent = $"INSERT INTO events (event, location, date, time) VALUES ('{event_}', '{location}', '{date}', '{time}')";
                cmd = new MySqlCommand(addEvent, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                metroTextBoxAddEventName.Clear();
                metroTextBoxAddLocation.Clear();

                updateEventTable();
            }
        }

        private void metroButtonFetch_Click(object sender, EventArgs e)
        {
            string id = metroTextBoxEditIDEvent.Text.ToString();

            conn.Open();
            string query = $"SELECT * FROM events WHERE id = {id}";
            cmd = new MySqlCommand(query, conn);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string event_ = reader["event"].ToString();
                    string location = reader["location"].ToString();
                    DateTime date = Convert.ToDateTime(reader["date"]);
                    TimeSpan time = (TimeSpan)reader["time"];
                    DateTime fullDateTime = date + time;

                    metroTextBoxEditEvent.Text = event_;
                    metroTextBoxEditLocation.Text = location;
                    datePickerEdit.Value = date;

                    timePickerEdit.Value = fullDateTime;
                    timePickerEdit.Format = DateTimePickerFormat.Custom;
                    timePickerEdit.CustomFormat = "HH:mm";

                    metroTextBoxEditEvent.Enabled = true;
                    metroTextBoxEditLocation.Enabled = true;
                    datePickerEdit.Enabled = true;
                    timePickerEdit.Enabled = true;
                    metroButtonEdit.Enabled = true;
                }
                else
                {
                    MessageBox.Show($"Tidak ditemukan Event dengan id: {id}");
                    metroTextBoxEditIDEvent.Clear();
                }
                conn.Close();
            }
        }

        private void metroButtonEdit_Click(object sender, EventArgs e)
        {
            string id = metroTextBoxEditIDEvent.Text.ToString();
            string event_ = metroTextBoxEditEvent.Text.ToString();
            string location = metroTextBoxEditLocation.Text.ToString();
            string date = datePickerEdit.Value.ToString("yy-MM-dd");
            string time = timePickerEdit.Value.ToString("HH:mm");

            if (string.IsNullOrEmpty(event_) || string.IsNullOrEmpty(location) || string.IsNullOrEmpty(date) || string.IsNullOrEmpty(time))
            {
                MessageBox.Show("Nama event, lokasi, tanggal dan waktu harus diisi!");
                return;
            }
            else
            {
                conn.Open();
                string addEvent = $"UPDATE events SET event = '{event_}', location = '{location}', date = '{date}', time = '{time}' WHERE id = {id}";
                cmd = new MySqlCommand(addEvent, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                metroTextBoxEditIDEvent.Clear();
                metroTextBoxAddEventName.Clear();
                metroTextBoxAddLocation.Clear();

                metroTextBoxEditEvent.Enabled = false;
                metroTextBoxEditLocation.Enabled = false;
                datePickerEdit.Enabled = false;
                timePickerEdit.Enabled = false;
                metroButtonEdit.Enabled = false;

                updateEventTable();
            }
        }

        private void metroButtonDelete_Click(object sender, EventArgs e)
        {
            string id = metroTextBoxDeleteIDEvent.Text.ToString();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("ID Event harus diisi!");
                return;
            }
            else
            {
                conn.Open();
                string delEvent = $"DELETE FROM events WHERE id = {id}";
                cmd = new MySqlCommand(delEvent, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                metroTextBoxDeleteIDEvent.Clear();

                updateEventTable();
            }
        }
    }
}
