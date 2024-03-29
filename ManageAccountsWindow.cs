﻿using AttendanceAppDesktop.Class;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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

            metroComboBoxEditRole.Items.Add("admin");
            metroComboBoxEditRole.Items.Add("operator");
            metroComboBoxEditRole.Items.Add("participant");
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
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

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

        private void metroButtonFetch_Click(object sender, EventArgs e)
        {
            string id = metroTextBoxEditIDAccount.Text.ToString();

            conn.Open();
            string query = $"SELECT * FROM users WHERE id = {id}";
            cmd = new MySqlCommand(query, conn);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string name = reader["name"].ToString();
                    string email = reader["email"].ToString();

                    metroTextBoxEditName.Text = name;
                    metroTextBoxEditEmail.Text = email;

                    metroTextBoxEditName.Enabled = true;
                    metroTextBoxEditEmail.Enabled = true;
                    metroComboBoxEditRole.Enabled = true;
                    metroTextBoxEditPassword.Enabled = true;
                    metroCheckBoxEditPassword.Enabled = true;
                    metroButtonEdit.Enabled = true;
                }
                else
                {
                    MessageBox.Show($"Tidak ditemukan Account dengan id: {id}");
                    metroTextBoxEditIDAccount.Clear();
                }
                conn.Close();
            }
        }

        private void metroButtonEdit_Click(object sender, EventArgs e)
        {
            string id = metroTextBoxEditIDAccount.Text.Trim().ToString();
            string name = metroTextBoxEditName.Text.Trim().ToString();
            string email = metroTextBoxEditEmail.Text.Trim().ToString();
            string role = metroComboBoxEditRole.SelectedItem?.ToString();
            string rawPassword = metroTextBoxEditPassword.Text.Trim().ToString();
            string password = hashPassword(rawPassword);

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(role) || string.IsNullOrEmpty(rawPassword))
            {
                MessageBox.Show("Semua Data Harus diisi!");
            }
            else
            {
                conn.Open();
                string register = $"UPDATE users SET name = '{name}',email = '{email}', password = '{password}', role = '{role}' WHERE id = {id}";
                cmd = new MySqlCommand(register, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Berhasil Diedit!");
                conn.Close();

                metroTextBoxEditIDAccount.Clear();
                metroTextBoxEditName.Clear();
                metroTextBoxEditEmail.Clear();
                metroTextBoxEditPassword.Clear();

                metroTextBoxEditName.Enabled = false;
                metroTextBoxEditEmail.Enabled = false;
                metroComboBoxEditRole.Enabled = false;
                metroTextBoxEditPassword.Enabled = false;
                metroCheckBoxEditPassword.Enabled = false;
                metroButtonEdit.Enabled = false;

                updateAccountTable();
            }
        }

        private void metroCheckBoxEditPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBoxEditPassword.Checked)
            {
                metroTextBoxEditPassword.PasswordChar = '\0';
            }
            else
            {
                metroTextBoxEditPassword.PasswordChar = '*';
            }
        }

        private void metroButtonDelete_Click(object sender, EventArgs e)
        {
            string id = metroTextBoxDeleteIDAccount.Text.ToString();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("ID Account Harus diisi!");
            }
            else
            {
                conn.Open();
                string deleletAccount = $"DELETE FROM users WHERE id = {id}";
                cmd = new MySqlCommand(deleletAccount, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                metroTextBoxDeleteIDAccount.Clear();

                updateAccountTable();
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
