using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceAppDesktop
{
    public partial class AdminWindow : Form
    {
        string id = LoginForm.Session.loggedInId;
        string email = LoginForm.Session.loggedInEmail;
        string name = LoginForm.Session.loggedInName;
        string role = LoginForm.Session.loggedInRole;

        public AdminWindow()
        {
            InitializeComponent();
        }

        private void AdminWindow_Load(object sender, EventArgs e)
        {
            metroLabelName.Text = $"Name : {name}";
            metroLabelEmail.Text = $"Email : {email}";
            metroLabelRole.Text = $"Role : {role}";
        }

        private void metroLabelAdminWindow_Click(object sender, EventArgs e)
        {

        }

        private void metroButtonLogout_Click(object sender, EventArgs e)
        {
            LoginForm.Session.destroySession();

            this.Close();
            LoginForm loginWindowInstance = new LoginForm();
            loginWindowInstance.Show();
        }

        private void metroButtonManageAccounts_Click(object sender, EventArgs e)
        {
            ManageAccountsWindow manageAccountsWindow = new ManageAccountsWindow();
            manageAccountsWindow.Show();
        }

        private void metroButtonManageEvents_Click(object sender, EventArgs e)
        {
            ManageEventsWindow manageEventsWindow = new ManageEventsWindow();
            manageEventsWindow.Show();
        }

        private void metroButtonManageAttendance_Click(object sender, EventArgs e)
        {
            ManageAttendanceWindow manageAttendanceWindow = new ManageAttendanceWindow();
            manageAttendanceWindow.Show();
        }
    }
}
