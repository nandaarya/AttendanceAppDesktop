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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabelAdminWindow
            // 
            this.metroLabelAdminWindow.AutoSize = true;
            this.metroLabelAdminWindow.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelAdminWindow.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelAdminWindow.Location = new System.Drawing.Point(304, 9);
            this.metroLabelAdminWindow.Name = "metroLabelAdminWindow";
            this.metroLabelAdminWindow.Size = new System.Drawing.Size(165, 25);
            this.metroLabelAdminWindow.TabIndex = 0;
            this.metroLabelAdminWindow.Text = "Dashboard Admin";
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
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(12, 202);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(776, 42);
            this.metroButton1.TabIndex = 7;
            this.metroButton1.Text = "Manage Account";
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(12, 259);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(776, 42);
            this.metroButton2.TabIndex = 8;
            this.metroButton2.Text = "Manage Events";
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(12, 316);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(776, 42);
            this.metroButton3.TabIndex = 9;
            this.metroButton3.Text = "Manage Attendance";
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 385);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
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
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
    }
}