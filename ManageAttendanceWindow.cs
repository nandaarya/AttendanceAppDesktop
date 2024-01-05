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

            
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(event_) || string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Nama, event, dan status harus diisi!");
                return;
            }

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

            if (string.IsNullOrEmpty(status) || string.IsNullOrEmpty(id))
            {
                MessageBox.Show("ID Attendance dan status harus diisi!");
                return;
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
                return;
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

        private void metroButtonExport_Click(object sender, EventArgs e)
        {
            DataGridView dataGridView = dataGridView1;
            Type excelType = Type.GetTypeFromProgID("Excel.Application");

            if (excelType != null)
            {
                dynamic excel = Activator.CreateInstance(excelType);
                excel.Visible = true;
                dynamic workbook = excel.Workbooks.Add();
                dynamic sheet = workbook.ActiveSheet;

                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    sheet.Cells[1, i + 1] = dataGridView.Columns[i].HeaderText;
                }

                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        dynamic cellValue = dataGridView.Rows[i].Cells[j].Value;
                        sheet.Cells[i + 2, j + 1].Value = cellValue?.ToString();
                    }
                }
                for (int i = 1; i <= dataGridView.Columns.Count; i++)
                {
                    sheet.Columns[i].AutoFit();
                }
            }
        }
    }
}
