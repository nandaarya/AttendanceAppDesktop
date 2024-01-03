using MySqlX.XDevAPI;
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
    public partial class ParticipantWindow : Form
    {
        string id = LoginForm.Session.loggedInId;
        string email = LoginForm.Session.loggedInEmail;
        string name = LoginForm.Session.loggedInName;
        string role = LoginForm.Session.loggedInRole;

        public ParticipantWindow()
        {
            InitializeComponent();
        }

        private void ParticipantWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
