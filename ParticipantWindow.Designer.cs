namespace AttendanceAppDesktop
{
    partial class ParticipantWindow
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
            this.metroButtonLogout = new MetroFramework.Controls.MetroButton();
            this.metroLabelName = new MetroFramework.Controls.MetroLabel();
            this.metroLabelEmail = new MetroFramework.Controls.MetroLabel();
            this.metroLabelRole = new MetroFramework.Controls.MetroLabel();
            this.metroLabelParticipant = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroButtonLogout
            // 
            this.metroButtonLogout.Location = new System.Drawing.Point(682, 68);
            this.metroButtonLogout.Name = "metroButtonLogout";
            this.metroButtonLogout.Size = new System.Drawing.Size(106, 25);
            this.metroButtonLogout.TabIndex = 14;
            this.metroButtonLogout.Text = "Logout";
            // 
            // metroLabelName
            // 
            this.metroLabelName.AutoSize = true;
            this.metroLabelName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelName.Location = new System.Drawing.Point(12, 68);
            this.metroLabelName.Name = "metroLabelName";
            this.metroLabelName.Size = new System.Drawing.Size(59, 25);
            this.metroLabelName.TabIndex = 13;
            this.metroLabelName.Text = "Name";
            // 
            // metroLabelEmail
            // 
            this.metroLabelEmail.AutoSize = true;
            this.metroLabelEmail.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelEmail.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelEmail.Location = new System.Drawing.Point(12, 106);
            this.metroLabelEmail.Name = "metroLabelEmail";
            this.metroLabelEmail.Size = new System.Drawing.Size(54, 25);
            this.metroLabelEmail.TabIndex = 12;
            this.metroLabelEmail.Text = "Email";
            // 
            // metroLabelRole
            // 
            this.metroLabelRole.AutoSize = true;
            this.metroLabelRole.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelRole.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelRole.Location = new System.Drawing.Point(12, 144);
            this.metroLabelRole.Name = "metroLabelRole";
            this.metroLabelRole.Size = new System.Drawing.Size(46, 25);
            this.metroLabelRole.TabIndex = 11;
            this.metroLabelRole.Text = "Role";
            // 
            // metroLabelParticipant
            // 
            this.metroLabelParticipant.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelParticipant.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelParticipant.Location = new System.Drawing.Point(12, 9);
            this.metroLabelParticipant.Name = "metroLabelParticipant";
            this.metroLabelParticipant.Size = new System.Drawing.Size(776, 30);
            this.metroLabelParticipant.TabIndex = 10;
            this.metroLabelParticipant.Text = "Dashboard Participant";
            this.metroLabelParticipant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ParticipantWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroButtonLogout);
            this.Controls.Add(this.metroLabelName);
            this.Controls.Add(this.metroLabelEmail);
            this.Controls.Add(this.metroLabelRole);
            this.Controls.Add(this.metroLabelParticipant);
            this.Name = "ParticipantWindow";
            this.Text = "ParticipantWindow";
            this.Load += new System.EventHandler(this.ParticipantWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButtonLogout;
        private MetroFramework.Controls.MetroLabel metroLabelName;
        private MetroFramework.Controls.MetroLabel metroLabelEmail;
        private MetroFramework.Controls.MetroLabel metroLabelRole;
        private MetroFramework.Controls.MetroLabel metroLabelParticipant;
    }
}