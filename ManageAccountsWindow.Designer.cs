namespace AttendanceAppDesktop
{
    partial class ManageAccountsWindow
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
            this.metroLabelWindow = new MetroFramework.Controls.MetroLabel();
            this.metroButtonFetch = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxAddEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonExport = new MetroFramework.Controls.MetroButton();
            this.metroButtonDelete = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxDeleteIDAccount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelDeleteIDEvent = new MetroFramework.Controls.MetroLabel();
            this.metroLabelDeleteAccount = new MetroFramework.Controls.MetroLabel();
            this.metroButtonEdit = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxEditIDAccount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelEditIDAccount = new MetroFramework.Controls.MetroLabel();
            this.metroLabelEditAccount = new MetroFramework.Controls.MetroLabel();
            this.metroButtonAdd = new MetroFramework.Controls.MetroButton();
            this.metroLabelAddEmail = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxAddName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelAddName = new MetroFramework.Controls.MetroLabel();
            this.metroLabelAddAccount = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroLabelRole = new MetroFramework.Controls.MetroLabel();
            this.metroCheckBoxPassword = new MetroFramework.Controls.MetroCheckBox();
            this.metroTextBoxAddPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelPassword = new MetroFramework.Controls.MetroLabel();
            this.metroComboBoxAddRole = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBoxEditRole = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroCheckBoxEditPassword = new MetroFramework.Controls.MetroCheckBox();
            this.metroTextBoxEditPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxEditEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxEditName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabelWindow
            // 
            this.metroLabelWindow.BackColor = System.Drawing.Color.White;
            this.metroLabelWindow.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelWindow.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelWindow.Location = new System.Drawing.Point(12, 9);
            this.metroLabelWindow.Name = "metroLabelWindow";
            this.metroLabelWindow.Size = new System.Drawing.Size(1200, 30);
            this.metroLabelWindow.TabIndex = 1;
            this.metroLabelWindow.Text = "Manage Accounts";
            this.metroLabelWindow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroButtonFetch
            // 
            this.metroButtonFetch.Location = new System.Drawing.Point(240, 417);
            this.metroButtonFetch.Name = "metroButtonFetch";
            this.metroButtonFetch.Size = new System.Drawing.Size(75, 23);
            this.metroButtonFetch.TabIndex = 136;
            this.metroButtonFetch.Text = "Fetch";
            this.metroButtonFetch.Click += new System.EventHandler(this.metroButtonFetch_Click);
            // 
            // metroTextBoxAddEmail
            // 
            this.metroTextBoxAddEmail.Location = new System.Drawing.Point(12, 158);
            this.metroTextBoxAddEmail.Name = "metroTextBoxAddEmail";
            this.metroTextBoxAddEmail.Size = new System.Drawing.Size(304, 23);
            this.metroTextBoxAddEmail.TabIndex = 123;
            // 
            // metroButtonExport
            // 
            this.metroButtonExport.AutoSize = true;
            this.metroButtonExport.Location = new System.Drawing.Point(997, 58);
            this.metroButtonExport.Name = "metroButtonExport";
            this.metroButtonExport.Size = new System.Drawing.Size(215, 26);
            this.metroButtonExport.TabIndex = 122;
            this.metroButtonExport.Text = "Export Data";
            this.metroButtonExport.Click += new System.EventHandler(this.metroButtonExport_Click);
            // 
            // metroButtonDelete
            // 
            this.metroButtonDelete.Location = new System.Drawing.Point(10, 815);
            this.metroButtonDelete.Name = "metroButtonDelete";
            this.metroButtonDelete.Size = new System.Drawing.Size(304, 23);
            this.metroButtonDelete.TabIndex = 121;
            this.metroButtonDelete.Text = "Delete";
            this.metroButtonDelete.Click += new System.EventHandler(this.metroButtonDelete_Click);
            // 
            // metroTextBoxDeleteIDAccount
            // 
            this.metroTextBoxDeleteIDAccount.Location = new System.Drawing.Point(10, 772);
            this.metroTextBoxDeleteIDAccount.Name = "metroTextBoxDeleteIDAccount";
            this.metroTextBoxDeleteIDAccount.Size = new System.Drawing.Size(304, 23);
            this.metroTextBoxDeleteIDAccount.TabIndex = 120;
            // 
            // metroLabelDeleteIDEvent
            // 
            this.metroLabelDeleteIDEvent.AutoSize = true;
            this.metroLabelDeleteIDEvent.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelDeleteIDEvent.Location = new System.Drawing.Point(10, 749);
            this.metroLabelDeleteIDEvent.Name = "metroLabelDeleteIDEvent";
            this.metroLabelDeleteIDEvent.Size = new System.Drawing.Size(82, 20);
            this.metroLabelDeleteIDEvent.TabIndex = 119;
            this.metroLabelDeleteIDEvent.Text = "ID Account";
            // 
            // metroLabelDeleteAccount
            // 
            this.metroLabelDeleteAccount.AutoSize = true;
            this.metroLabelDeleteAccount.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelDeleteAccount.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelDeleteAccount.Location = new System.Drawing.Point(10, 715);
            this.metroLabelDeleteAccount.Name = "metroLabelDeleteAccount";
            this.metroLabelDeleteAccount.Size = new System.Drawing.Size(143, 25);
            this.metroLabelDeleteAccount.TabIndex = 118;
            this.metroLabelDeleteAccount.Text = "Delete Account";
            // 
            // metroButtonEdit
            // 
            this.metroButtonEdit.Enabled = false;
            this.metroButtonEdit.Location = new System.Drawing.Point(10, 690);
            this.metroButtonEdit.Name = "metroButtonEdit";
            this.metroButtonEdit.Size = new System.Drawing.Size(304, 23);
            this.metroButtonEdit.TabIndex = 117;
            this.metroButtonEdit.Text = "Edit";
            this.metroButtonEdit.Click += new System.EventHandler(this.metroButtonEdit_Click);
            // 
            // metroTextBoxEditIDAccount
            // 
            this.metroTextBoxEditIDAccount.Location = new System.Drawing.Point(11, 417);
            this.metroTextBoxEditIDAccount.Name = "metroTextBoxEditIDAccount";
            this.metroTextBoxEditIDAccount.Size = new System.Drawing.Size(223, 23);
            this.metroTextBoxEditIDAccount.TabIndex = 116;
            // 
            // metroLabelEditIDAccount
            // 
            this.metroLabelEditIDAccount.AutoSize = true;
            this.metroLabelEditIDAccount.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelEditIDAccount.Location = new System.Drawing.Point(11, 394);
            this.metroLabelEditIDAccount.Name = "metroLabelEditIDAccount";
            this.metroLabelEditIDAccount.Size = new System.Drawing.Size(82, 20);
            this.metroLabelEditIDAccount.TabIndex = 115;
            this.metroLabelEditIDAccount.Text = "ID Account";
            // 
            // metroLabelEditAccount
            // 
            this.metroLabelEditAccount.AutoSize = true;
            this.metroLabelEditAccount.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelEditAccount.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelEditAccount.Location = new System.Drawing.Point(11, 360);
            this.metroLabelEditAccount.Name = "metroLabelEditAccount";
            this.metroLabelEditAccount.Size = new System.Drawing.Size(121, 25);
            this.metroLabelEditAccount.TabIndex = 114;
            this.metroLabelEditAccount.Text = "Edit Account";
            // 
            // metroButtonAdd
            // 
            this.metroButtonAdd.Location = new System.Drawing.Point(12, 324);
            this.metroButtonAdd.Name = "metroButtonAdd";
            this.metroButtonAdd.Size = new System.Drawing.Size(304, 23);
            this.metroButtonAdd.TabIndex = 113;
            this.metroButtonAdd.Text = "Add";
            this.metroButtonAdd.Click += new System.EventHandler(this.metroButtonAdd_Click);
            // 
            // metroLabelAddEmail
            // 
            this.metroLabelAddEmail.AutoSize = true;
            this.metroLabelAddEmail.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelAddEmail.Location = new System.Drawing.Point(12, 135);
            this.metroLabelAddEmail.Name = "metroLabelAddEmail";
            this.metroLabelAddEmail.Size = new System.Drawing.Size(46, 20);
            this.metroLabelAddEmail.TabIndex = 112;
            this.metroLabelAddEmail.Text = "Email";
            // 
            // metroTextBoxAddName
            // 
            this.metroTextBoxAddName.Location = new System.Drawing.Point(12, 109);
            this.metroTextBoxAddName.Name = "metroTextBoxAddName";
            this.metroTextBoxAddName.Size = new System.Drawing.Size(304, 23);
            this.metroTextBoxAddName.TabIndex = 111;
            // 
            // metroLabelAddName
            // 
            this.metroLabelAddName.AutoSize = true;
            this.metroLabelAddName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelAddName.Location = new System.Drawing.Point(12, 86);
            this.metroLabelAddName.Name = "metroLabelAddName";
            this.metroLabelAddName.Size = new System.Drawing.Size(49, 20);
            this.metroLabelAddName.TabIndex = 110;
            this.metroLabelAddName.Text = "Name";
            // 
            // metroLabelAddAccount
            // 
            this.metroLabelAddAccount.AutoSize = true;
            this.metroLabelAddAccount.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelAddAccount.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelAddAccount.Location = new System.Drawing.Point(12, 52);
            this.metroLabelAddAccount.Name = "metroLabelAddAccount";
            this.metroLabelAddAccount.Size = new System.Drawing.Size(123, 25);
            this.metroLabelAddAccount.TabIndex = 109;
            this.metroLabelAddAccount.Text = "Add Account";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(357, 52);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(136, 25);
            this.metroLabel3.TabIndex = 108;
            this.metroLabel3.Text = "Accounts Data";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(357, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(855, 759);
            this.dataGridView1.TabIndex = 107;
            // 
            // metroLabelRole
            // 
            this.metroLabelRole.AutoSize = true;
            this.metroLabelRole.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelRole.Location = new System.Drawing.Point(12, 184);
            this.metroLabelRole.Name = "metroLabelRole";
            this.metroLabelRole.Size = new System.Drawing.Size(39, 20);
            this.metroLabelRole.TabIndex = 137;
            this.metroLabelRole.Text = "Role";
            // 
            // metroCheckBoxPassword
            // 
            this.metroCheckBoxPassword.AutoSize = true;
            this.metroCheckBoxPassword.Location = new System.Drawing.Point(11, 301);
            this.metroCheckBoxPassword.Name = "metroCheckBoxPassword";
            this.metroCheckBoxPassword.Size = new System.Drawing.Size(115, 17);
            this.metroCheckBoxPassword.TabIndex = 142;
            this.metroCheckBoxPassword.Text = "Show Password";
            this.metroCheckBoxPassword.UseVisualStyleBackColor = true;
            this.metroCheckBoxPassword.CheckedChanged += new System.EventHandler(this.metroCheckBoxPassword_CheckedChanged);
            // 
            // metroTextBoxAddPassword
            // 
            this.metroTextBoxAddPassword.Location = new System.Drawing.Point(11, 272);
            this.metroTextBoxAddPassword.Name = "metroTextBoxAddPassword";
            this.metroTextBoxAddPassword.PasswordChar = '*';
            this.metroTextBoxAddPassword.Size = new System.Drawing.Size(304, 22);
            this.metroTextBoxAddPassword.TabIndex = 141;
            // 
            // metroLabelPassword
            // 
            this.metroLabelPassword.AutoSize = true;
            this.metroLabelPassword.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelPassword.Location = new System.Drawing.Point(12, 249);
            this.metroLabelPassword.Name = "metroLabelPassword";
            this.metroLabelPassword.Size = new System.Drawing.Size(70, 20);
            this.metroLabelPassword.TabIndex = 143;
            this.metroLabelPassword.Text = "Password";
            // 
            // metroComboBoxAddRole
            // 
            this.metroComboBoxAddRole.FormattingEnabled = true;
            this.metroComboBoxAddRole.ItemHeight = 24;
            this.metroComboBoxAddRole.Location = new System.Drawing.Point(11, 207);
            this.metroComboBoxAddRole.Name = "metroComboBoxAddRole";
            this.metroComboBoxAddRole.Size = new System.Drawing.Size(303, 30);
            this.metroComboBoxAddRole.TabIndex = 144;
            // 
            // metroComboBoxEditRole
            // 
            this.metroComboBoxEditRole.Enabled = false;
            this.metroComboBoxEditRole.FormattingEnabled = true;
            this.metroComboBoxEditRole.ItemHeight = 24;
            this.metroComboBoxEditRole.Location = new System.Drawing.Point(10, 564);
            this.metroComboBoxEditRole.Name = "metroComboBoxEditRole";
            this.metroComboBoxEditRole.Size = new System.Drawing.Size(303, 30);
            this.metroComboBoxEditRole.TabIndex = 153;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(10, 606);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(70, 20);
            this.metroLabel1.TabIndex = 152;
            this.metroLabel1.Text = "Password";
            // 
            // metroCheckBoxEditPassword
            // 
            this.metroCheckBoxEditPassword.AutoSize = true;
            this.metroCheckBoxEditPassword.Enabled = false;
            this.metroCheckBoxEditPassword.Location = new System.Drawing.Point(10, 667);
            this.metroCheckBoxEditPassword.Name = "metroCheckBoxEditPassword";
            this.metroCheckBoxEditPassword.Size = new System.Drawing.Size(115, 17);
            this.metroCheckBoxEditPassword.TabIndex = 151;
            this.metroCheckBoxEditPassword.Text = "Show Password";
            this.metroCheckBoxEditPassword.UseVisualStyleBackColor = true;
            this.metroCheckBoxEditPassword.CheckedChanged += new System.EventHandler(this.metroCheckBoxEditPassword_CheckedChanged);
            // 
            // metroTextBoxEditPassword
            // 
            this.metroTextBoxEditPassword.Enabled = false;
            this.metroTextBoxEditPassword.Location = new System.Drawing.Point(10, 638);
            this.metroTextBoxEditPassword.Name = "metroTextBoxEditPassword";
            this.metroTextBoxEditPassword.PasswordChar = '*';
            this.metroTextBoxEditPassword.Size = new System.Drawing.Size(304, 22);
            this.metroTextBoxEditPassword.TabIndex = 150;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(11, 541);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(39, 20);
            this.metroLabel2.TabIndex = 149;
            this.metroLabel2.Text = "Role";
            // 
            // metroTextBoxEditEmail
            // 
            this.metroTextBoxEditEmail.Enabled = false;
            this.metroTextBoxEditEmail.Location = new System.Drawing.Point(11, 515);
            this.metroTextBoxEditEmail.Name = "metroTextBoxEditEmail";
            this.metroTextBoxEditEmail.Size = new System.Drawing.Size(304, 23);
            this.metroTextBoxEditEmail.TabIndex = 148;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(11, 492);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(46, 20);
            this.metroLabel4.TabIndex = 147;
            this.metroLabel4.Text = "Email";
            // 
            // metroTextBoxEditName
            // 
            this.metroTextBoxEditName.Enabled = false;
            this.metroTextBoxEditName.Location = new System.Drawing.Point(11, 466);
            this.metroTextBoxEditName.Name = "metroTextBoxEditName";
            this.metroTextBoxEditName.Size = new System.Drawing.Size(304, 23);
            this.metroTextBoxEditName.TabIndex = 146;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(11, 443);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(49, 20);
            this.metroLabel5.TabIndex = 145;
            this.metroLabel5.Text = "Name";
            // 
            // ManageAccountsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1224, 848);
            this.Controls.Add(this.metroComboBoxEditRole);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroCheckBoxEditPassword);
            this.Controls.Add(this.metroTextBoxEditPassword);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroTextBoxEditEmail);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroTextBoxEditName);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroComboBoxAddRole);
            this.Controls.Add(this.metroLabelPassword);
            this.Controls.Add(this.metroCheckBoxPassword);
            this.Controls.Add(this.metroTextBoxAddPassword);
            this.Controls.Add(this.metroLabelRole);
            this.Controls.Add(this.metroButtonFetch);
            this.Controls.Add(this.metroTextBoxAddEmail);
            this.Controls.Add(this.metroButtonExport);
            this.Controls.Add(this.metroButtonDelete);
            this.Controls.Add(this.metroTextBoxDeleteIDAccount);
            this.Controls.Add(this.metroLabelDeleteIDEvent);
            this.Controls.Add(this.metroLabelDeleteAccount);
            this.Controls.Add(this.metroButtonEdit);
            this.Controls.Add(this.metroTextBoxEditIDAccount);
            this.Controls.Add(this.metroLabelEditIDAccount);
            this.Controls.Add(this.metroLabelEditAccount);
            this.Controls.Add(this.metroButtonAdd);
            this.Controls.Add(this.metroLabelAddEmail);
            this.Controls.Add(this.metroTextBoxAddName);
            this.Controls.Add(this.metroLabelAddName);
            this.Controls.Add(this.metroLabelAddAccount);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.metroLabelWindow);
            this.Name = "ManageAccountsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Accounts Window";
            this.Load += new System.EventHandler(this.ManageAccountsWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabelWindow;
        private MetroFramework.Controls.MetroButton metroButtonFetch;
        private MetroFramework.Controls.MetroTextBox metroTextBoxAddEmail;
        private MetroFramework.Controls.MetroButton metroButtonExport;
        private MetroFramework.Controls.MetroButton metroButtonDelete;
        private MetroFramework.Controls.MetroTextBox metroTextBoxDeleteIDAccount;
        private MetroFramework.Controls.MetroLabel metroLabelDeleteIDEvent;
        private MetroFramework.Controls.MetroLabel metroLabelDeleteAccount;
        private MetroFramework.Controls.MetroButton metroButtonEdit;
        private MetroFramework.Controls.MetroTextBox metroTextBoxEditIDAccount;
        private MetroFramework.Controls.MetroLabel metroLabelEditIDAccount;
        private MetroFramework.Controls.MetroLabel metroLabelEditAccount;
        private MetroFramework.Controls.MetroButton metroButtonAdd;
        private MetroFramework.Controls.MetroLabel metroLabelAddEmail;
        private MetroFramework.Controls.MetroTextBox metroTextBoxAddName;
        private MetroFramework.Controls.MetroLabel metroLabelAddName;
        private MetroFramework.Controls.MetroLabel metroLabelAddAccount;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroLabel metroLabelRole;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxPassword;
        private MetroFramework.Controls.MetroTextBox metroTextBoxAddPassword;
        private MetroFramework.Controls.MetroLabel metroLabelPassword;
        private MetroFramework.Controls.MetroComboBox metroComboBoxAddRole;
        private MetroFramework.Controls.MetroComboBox metroComboBoxEditRole;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxEditPassword;
        private MetroFramework.Controls.MetroTextBox metroTextBoxEditPassword;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBoxEditEmail;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox metroTextBoxEditName;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}