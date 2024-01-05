using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AttendanceAppDesktop
{
    public partial class LoginForm : Form
    {

        public class Session
        {
            public static string loggedInId { get; private set; }
            public static string loggedInEmail { get; private set; }

            public static string loggedInName { get; private set; }
            public static string loggedInRole { get; private set; }

            public static void SetLoggedInUser(string id, string email, string name, string role)
            {
                loggedInId = id;
                loggedInEmail = email;
                loggedInName = name;
                loggedInRole = role;
            }

            public static void destroySession()
            {
                loggedInId = null;
                loggedInEmail = null;
                loggedInName = null;
                loggedInRole=null;
            }
        }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void metroButtonLogin_Click(object sender, EventArgs e)
        {
            string mysqlconn = "server=127.0.0.1;user=root;database=attendance_app;password=";
            using (MySqlConnection mySqlConnection = new MySqlConnection(mysqlconn))
            {
                string email = metroTextBoxEmail.Text.Trim();
                string rawPassword = metroTextBoxPassword.Text.Trim();
                string password = hashPassword(rawPassword);

                if (String.IsNullOrEmpty(email) || String.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Email dan Password Tidak Boleh Kosong!");
                }
                else
                {
                    try
                    {
                        mySqlConnection.Open();
                        string query = "SELECT * FROM users WHERE email = @Email AND password = @Password";
                        MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                        mySqlCommand.Parameters.AddWithValue("@Email", email);
                        mySqlCommand.Parameters.AddWithValue("@Password", password);

                        using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string role = reader.GetString("role");
                                MessageBox.Show("Login Success. Role: " + role);

                                string id = reader.GetString("id");
                                string name = reader.GetString("name");

                                Session.SetLoggedInUser(id, email, name, role);

                                switch (role.ToLower())
                                {
                                    case "participant":
                                        this.Hide();
                                        ParticipantWindow participantWindow = new ParticipantWindow();
                                        participantWindow.Show();
                                        break;
                                    case "admin":
                                        this.Hide();
                                        AdminWindow adminWindow = new AdminWindow();
                                        adminWindow.Show();
                                        break;
                                    case "operator":
                                        this.Hide();
                                        OperatorWindow operatorWindow = new OperatorWindow();
                                        operatorWindow.Show();
                                        break;
                                    default:
                                        MessageBox.Show("Role tidak valid.");
                                        break;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Akun tidak ditemukan. Masukkan data yang benar!");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        mySqlConnection.Close();
                    }
                }
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
                metroTextBoxPassword.PasswordChar = '\0';
            }
            else
            {
                metroTextBoxPassword.PasswordChar = '*';
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
