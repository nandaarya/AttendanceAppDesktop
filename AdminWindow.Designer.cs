namespace AttendanceAppDesktop
{
    partial class AdminWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabelAdminWindow = new MetroFramework.Controls.MetroLabel();
            this.metroLabelRole = new MetroFramework.Controls.MetroLabel();
            this.metroLabelEmail = new MetroFramework.Controls.MetroLabel();
            this.metroLabelName = new MetroFramework.Controls.MetroLabel();
            this.metroButtonLogout = new MetroFramework.Controls.MetroButton();
            this.metroButtonManageEvents = new MetroFramework.Controls.MetroButton();
            this.metroButtonManageAttendance = new MetroFramework.Controls.MetroButton();
            this.metroButtonManageAccounts = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabelAdminWindow
            // 
            this.metroLabelAdminWindow.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelAdminWindow.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelAdminWindow.Location = new System.Drawing.Point(12, 9);
            this.metroLabelAdminWindow.Name = "metroLabelAdminWindow";
            this.metroLabelAdminWindow.Size = new System.Drawing.Size(776, 30);
            this.metroLabelAdminWindow.TabIndex = 0;
            this.metroLabelAdminWindow.Text = "Dashboard Admin";
            this.metroLabelAdminWindow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabelAdminWindow.Click += new System.EventHandler(this.metroLabelAdminWindow_Click);
            // 
            // metroLabelRole
            // 
            this.metroLabelRole.AutoSize = true;
            this.metroLabelRole.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelRole.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelRole.Location = new System.Drawing.Point(12, 143);
            this.metroLabelRole.Name = "metroLabelRole";
            this.metroLabelRole.Size = new System.Drawing.Size(46, 25);
            this.metroLabelRole.TabIndex = 3;
            this.metroLabelRole.Text = "Role";
            // 
            // metroLabelEmail
            // 
            this.metroLabelEmail.AutoSize = true;
            this.metroLabelEmail.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelEmail.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelEmail.Location = new System.Drawing.Point(12, 105);
            this.metroLabelEmail.Name = "metroLabelEmail";
            this.metroLabelEmail.Size = new System.Drawing.Size(54, 25);
            this.metroLabelEmail.TabIndex = 4;
            this.metroLabelEmail.Text = "Email";
            // 
            // metroLabelName
            // 
            this.metroLabelName.AutoSize = true;
            this.metroLabelName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelName.Location = new System.Drawing.Point(12, 67);
            this.metroLabelName.Name = "metroLabelName";
            this.metroLabelName.Size = new System.Drawing.Size(59, 25);
            this.metroLabelName.TabIndex = 5;
            this.metroLabelName.Text = "Name";
            // 
            // metroButtonLogout
            // 
            this.metroButtonLogout.Location = new System.Drawing.Point(682, 67);
            this.metroButtonLogout.Name = "metroButtonLogout";
            this.metroButtonLogout.Size = new System.Drawing.Size(106, 25);
            this.metroButtonLogout.TabIndex = 6;
            this.metroButtonLogout.Text = "Logout";
            this.metroButtonLogout.Click += new System.EventHandler(this.metroButtonLogout_Click);
            // 
            // metroButtonManageEvents
            // 
            this.metroButtonManageEvents.Location = new System.Drawing.Point(12, 259);
            this.metroButtonManageEvents.Name = "metroButtonManageEvents";
            this.metroButtonManageEvents.Size = new System.Drawing.Size(776, 42);
            this.metroButtonManageEvents.TabIndex = 8;
            this.metroButtonManageEvents.Text = "Manage Events";
            this.metroButtonManageEvents.Click += new System.EventHandler(this.metroButtonManageEvents_Click);
            // 
            // metroButtonManageAttendance
            // 
            this.metroButtonManageAttendance.Location = new System.Drawing.Point(12, 316);
            this.metroButtonManageAttendance.Name = "metroButtonManageAttendance";
            this.metroButtonManageAttendance.Size = new System.Drawing.Size(776, 42);
            this.metroButtonManageAttendance.TabIndex = 9;
            this.metroButtonManageAttendance.Text = "Manage Attendance";
            this.metroButtonManageAttendance.Click += new System.EventHandler(this.metroButtonManageAttendance_Click);
            // 
            // metroButtonManageAccounts
            // 
            this.metroButtonManageAccounts.Location = new System.Drawing.Point(12, 200);
            this.metroButtonManageAccounts.Name = "metroButtonManageAccounts";
            this.metroButtonManageAccounts.Size = new System.Drawing.Size(776, 42);
            this.metroButtonManageAccounts.TabIndex = 10;
            this.metroButtonManageAccounts.Text = "Manage Accounts";
            this.metroButtonManageAccounts.Click += new System.EventHandler(this.metroButtonManageAccounts_Click);
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 385);
            this.Controls.Add(this.metroButtonManageAccounts);
            this.Controls.Add(this.metroButtonManageAttendance);
            this.Controls.Add(this.metroButtonManageEvents);
            this.Controls.Add(this.metroButtonLogout);
            this.Controls.Add(this.metroLabelName);
            this.Controls.Add(this.metroLabelEmail);
            this.Controls.Add(this.metroLabelRole);
            this.Controls.Add(this.metroLabelAdminWindow);
            this.Name = "AdminWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminWindow";
            this.Load += new System.EventHandler(this.AdminWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabelAdminWindow;
        private MetroFramework.Controls.MetroLabel metroLabelRole;
        private MetroFramework.Controls.MetroLabel metroLabelEmail;
        private MetroFramework.Controls.MetroLabel metroLabelName;
        private MetroFramework.Controls.MetroButton metroButtonLogout;
        private MetroFramework.Controls.MetroButton metroButtonManageEvents;
        private MetroFramework.Controls.MetroButton metroButtonManageAttendance;
        private MetroFramework.Controls.MetroButton metroButtonManageAccounts;
    }
}