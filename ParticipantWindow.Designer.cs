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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButtonLogout
            // 
            this.metroButtonLogout.Location = new System.Drawing.Point(1174, 68);
            this.metroButtonLogout.Name = "metroButtonLogout";
            this.metroButtonLogout.Size = new System.Drawing.Size(106, 25);
            this.metroButtonLogout.TabIndex = 14;
            this.metroButtonLogout.Text = "Logout";
            this.metroButtonLogout.Click += new System.EventHandler(this.metroButtonLogout_Click);
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
            this.metroLabelParticipant.Size = new System.Drawing.Size(1268, 30);
            this.metroLabelParticipant.TabIndex = 10;
            this.metroLabelParticipant.Text = "Dashboard Participant";
            this.metroLabelParticipant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(702, 220);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(578, 367);
            this.dataGridView2.TabIndex = 41;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(702, 182);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(113, 25);
            this.metroLabel4.TabIndex = 40;
            this.metroLabel4.Text = "Events Data";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(12, 182);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(156, 25);
            this.metroLabel3.TabIndex = 39;
            this.metroLabel3.Text = "Attendance Data";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(665, 367);
            this.dataGridView1.TabIndex = 38;
            // 
            // ParticipantWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1292, 599);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.metroButtonLogout);
            this.Controls.Add(this.metroLabelName);
            this.Controls.Add(this.metroLabelEmail);
            this.Controls.Add(this.metroLabelRole);
            this.Controls.Add(this.metroLabelParticipant);
            this.Name = "ParticipantWindow";
            this.Text = "ParticipantWindow";
            this.Load += new System.EventHandler(this.ParticipantWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButtonLogout;
        private MetroFramework.Controls.MetroLabel metroLabelName;
        private MetroFramework.Controls.MetroLabel metroLabelEmail;
        private MetroFramework.Controls.MetroLabel metroLabelRole;
        private MetroFramework.Controls.MetroLabel metroLabelParticipant;
        private System.Windows.Forms.DataGridView dataGridView2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}