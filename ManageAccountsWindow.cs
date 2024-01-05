using AttendanceAppDesktop.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace AttendanceAppDesktop
{
    public partial class ManageAccountsWindow : Form
    {
        private Koneksi koneksi;
        MySqlConnection conn;

        MySqlCommand checkUname = new MySqlCommand();
        MySqlCommand cmd = new MySqlCommand();
        private MySqlDataAdapter adapter;
        private DataTable dataTable;

        public void updateAccountTable()
        {
            conn.Open();
            string query = $"SELECT * FROM users";
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


        public ManageAccountsWindow()
        {
            InitializeComponent();

            koneksi = new Koneksi();
            conn = koneksi.conn;
        }

        private void ManageAccountsWindow_Load(object sender, EventArgs e)
        {
            updateAccountTable();
            metroComboBoxAddRole.Items.Add("admin");
            metroComboBoxAddRole.Items.Add("operator");
            metroComboBoxAddRole.Items.Add("participant");
        }

        private void metroButtonAdd_Click(object sender, EventArgs e)
        {
            string name = metroTextBoxAddName.Text.Trim().ToString();
            string email = metroTextBoxAddEmail.Text.Trim().ToString();
            string role = metroComboBoxAddRole.SelectedItem?.ToString();
            string rawPassword = metroTextBoxAddPassword.Text.Trim().ToString();
            string password = hashPassword(rawPassword);

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(role) || string.IsNullOrEmpty(rawPassword))
            {
                MessageBox.Show("Semua Data Harus diisi!");
            }
            else
            {
                conn.Open();
                string check = $"SELECT COUNT(*) FROM users WHERE email = '{email}'";
                checkUname = new MySqlCommand(check, conn);
                int userCount = Convert.ToInt32(checkUname.ExecuteScalar());

                if (userCount > 0)
                {
                    MessageBox.Show("Email ini sudah terdaftar!");
                }
                else
                {
                    string register = $"INSERT INTO users (name, email, password, role) VALUES ('{name}', '{email}', '{password}', '{role}')";
                    cmd = new MySqlCommand(register, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Berhasil Ditambahkan!");

                    metroTextBoxAddName.Clear();
                    metroTextBoxAddEmail.Clear();
                    metroTextBoxAddPassword.Clear();
                }
                conn.Close();

                updateAccountTable();
            }
        }

        private string hashPassword(string password)
        {
            // Gunakan algoritma hash kriptografis, misalnya SHA-256
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Konversi password menjadi byte array
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Ubah byte array menjadi string hex
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }

        private void metroCheckBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBoxPassword.Checked)
            {
                metroTextBoxAddPassword.PasswordChar = '\0';
            }
            else
            {
                metroTextBoxAddPassword.PasswordChar = '*';
            }
        }
    }
}
