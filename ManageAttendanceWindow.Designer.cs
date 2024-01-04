namespace AttendanceAppDesktop
{
    partial class ManageAttendanceWindow
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
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroButtonAdd = new MetroFramework.Controls.MetroButton();
            this.metroRadioButtonAddAbsent = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButtonAddIzin = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButtonAddTelat = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButtonAddHadir = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabelStatus = new MetroFramework.Controls.MetroLabel();
            this.metroLabelIDEvent = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabelAddAttendance = new MetroFramework.Controls.MetroLabel();
            this.metroButtonEdit = new MetroFramework.Controls.MetroButton();
            this.metroRadioButtonEditAbsent = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButtonEditIzin = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButtonEditTelat = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButtonEditHadir = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxEditIDAttendance = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelEditIDAttendance = new MetroFramework.Controls.MetroLabel();
            this.metroLabelEditAttendance = new MetroFramework.Controls.MetroLabel();
            this.metroButtonDelete = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxDeleteIDAttendace = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelDeleteIDAttendance = new MetroFramework.Controls.MetroLabel();
            this.metroLabelDeleteAttendance = new MetroFramework.Controls.MetroLabel();
            this.metroComboBoxEvent = new MetroFramework.Controls.MetroComboBox();
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
            this.metroLabelWindow.TabIndex = 2;
            this.metroLabelWindow.Text = "Manage Attendance";
            this.metroLabelWindow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(357, 73);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(156, 25);
            this.metroLabel3.TabIndex = 37;
            this.metroLabel3.Text = "Attendance Data";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(357, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(855, 607);
            this.dataGridView1.TabIndex = 36;
            // 
            // metroButtonAdd
            // 
            this.metroButtonAdd.Location = new System.Drawing.Point(12, 272);
            this.metroButtonAdd.Name = "metroButtonAdd";
            this.metroButtonAdd.Size = new System.Drawing.Size(304, 23);
            this.metroButtonAdd.TabIndex = 48;
            this.metroButtonAdd.Text = "Add";
            this.metroButtonAdd.Click += new System.EventHandler(this.metroButtonAdd_Click);
            // 
            // metroRadioButtonAddAbsent
            // 
            this.metroRadioButtonAddAbsent.AutoSize = true;
            this.metroRadioButtonAddAbsent.Location = new System.Drawing.Point(252, 233);
            this.metroRadioButtonAddAbsent.Name = "metroRadioButtonAddAbsent";
            this.metroRadioButtonAddAbsent.Size = new System.Drawing.Size(64, 17);
            this.metroRadioButtonAddAbsent.TabIndex = 47;
            this.metroRadioButtonAddAbsent.TabStop = true;
            this.metroRadioButtonAddAbsent.Text = "Absent";
            this.metroRadioButtonAddAbsent.UseVisualStyleBackColor = true;
            // 
            // metroRadioButtonAddIzin
            // 
            this.metroRadioButtonAddIzin.AutoSize = true;
            this.metroRadioButtonAddIzin.Location = new System.Drawing.Point(175, 233);
            this.metroRadioButtonAddIzin.Name = "metroRadioButtonAddIzin";
            this.metroRadioButtonAddIzin.Size = new System.Drawing.Size(43, 17);
            this.metroRadioButtonAddIzin.TabIndex = 46;
            this.metroRadioButtonAddIzin.TabStop = true;
            this.metroRadioButtonAddIzin.Text = "Izin";
            this.metroRadioButtonAddIzin.UseVisualStyleBackColor = true;
            // 
            // metroRadioButtonAddTelat
            // 
            this.metroRadioButtonAddTelat.AutoSize = true;
            this.metroRadioButtonAddTelat.Location = new System.Drawing.Point(93, 233);
            this.metroRadioButtonAddTelat.Name = "metroRadioButtonAddTelat";
            this.metroRadioButtonAddTelat.Size = new System.Drawing.Size(51, 17);
            this.metroRadioButtonAddTelat.TabIndex = 45;
            this.metroRadioButtonAddTelat.TabStop = true;
            this.metroRadioButtonAddTelat.Text = "Telat";
            this.metroRadioButtonAddTelat.UseVisualStyleBackColor = true;
            // 
            // metroRadioButtonAddHadir
            // 
            this.metroRadioButtonAddHadir.AutoSize = true;
            this.metroRadioButtonAddHadir.Location = new System.Drawing.Point(12, 233);
            this.metroRadioButtonAddHadir.Name = "metroRadioButtonAddHadir";
            this.metroRadioButtonAddHadir.Size = new System.Drawing.Size(56, 17);
            this.metroRadioButtonAddHadir.TabIndex = 44;
            this.metroRadioButtonAddHadir.TabStop = true;
            this.metroRadioButtonAddHadir.Text = "Hadir";
            this.metroRadioButtonAddHadir.UseVisualStyleBackColor = true;
            // 
            // metroLabelStatus
            // 
            this.metroLabelStatus.AutoSize = true;
            this.metroLabelStatus.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelStatus.Location = new System.Drawing.Point(12, 210);
            this.metroLabelStatus.Name = "metroLabelStatus";
            this.metroLabelStatus.Size = new System.Drawing.Size(49, 20);
            this.metroLabelStatus.TabIndex = 43;
            this.metroLabelStatus.Text = "Status";
            // 
            // metroLabelIDEvent
            // 
            this.metroLabelIDEvent.AutoSize = true;
            this.metroLabelIDEvent.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelIDEvent.Location = new System.Drawing.Point(12, 154);
            this.metroLabelIDEvent.Name = "metroLabelIDEvent";
            this.metroLabelIDEvent.Size = new System.Drawing.Size(45, 20);
            this.metroLabelIDEvent.TabIndex = 41;
            this.metroLabelIDEvent.Text = "Event";
            // 
            // metroTextBoxName
            // 
            this.metroTextBoxName.Location = new System.Drawing.Point(12, 128);
            this.metroTextBoxName.Name = "metroTextBoxName";
            this.metroTextBoxName.Size = new System.Drawing.Size(304, 23);
            this.metroTextBoxName.TabIndex = 40;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(12, 105);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 20);
            this.metroLabel1.TabIndex = 39;
            this.metroLabel1.Text = "Name";
            // 
            // metroLabelAddAttendance
            // 
            this.metroLabelAddAttendance.AutoSize = true;
            this.metroLabelAddAttendance.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelAddAttendance.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelAddAttendance.Location = new System.Drawing.Point(12, 71);
            this.metroLabelAddAttendance.Name = "metroLabelAddAttendance";
            this.metroLabelAddAttendance.Size = new System.Drawing.Size(151, 25);
            this.metroLabelAddAttendance.TabIndex = 38;
            this.metroLabelAddAttendance.Text = "Add Attendance";
            // 
            // metroButtonEdit
            // 
            this.metroButtonEdit.Location = new System.Drawing.Point(12, 496);
            this.metroButtonEdit.Name = "metroButtonEdit";
            this.metroButtonEdit.Size = new System.Drawing.Size(304, 23);
            this.metroButtonEdit.TabIndex = 57;
            this.metroButtonEdit.Text = "Edit";
            this.metroButtonEdit.Click += new System.EventHandler(this.metroButtonEdit_Click);
            // 
            // metroRadioButtonEditAbsent
            // 
            this.metroRadioButtonEditAbsent.AutoSize = true;
            this.metroRadioButtonEditAbsent.Location = new System.Drawing.Point(252, 447);
            this.metroRadioButtonEditAbsent.Name = "metroRadioButtonEditAbsent";
            this.metroRadioButtonEditAbsent.Size = new System.Drawing.Size(64, 17);
            this.metroRadioButtonEditAbsent.TabIndex = 56;
            this.metroRadioButtonEditAbsent.TabStop = true;
            this.metroRadioButtonEditAbsent.Text = "Absent";
            this.metroRadioButtonEditAbsent.UseVisualStyleBackColor = true;
            // 
            // metroRadioButtonEditIzin
            // 
            this.metroRadioButtonEditIzin.AutoSize = true;
            this.metroRadioButtonEditIzin.Location = new System.Drawing.Point(179, 447);
            this.metroRadioButtonEditIzin.Name = "metroRadioButtonEditIzin";
            this.metroRadioButtonEditIzin.Size = new System.Drawing.Size(43, 17);
            this.metroRadioButtonEditIzin.TabIndex = 55;
            this.metroRadioButtonEditIzin.TabStop = true;
            this.metroRadioButtonEditIzin.Text = "Izin";
            this.metroRadioButtonEditIzin.UseVisualStyleBackColor = true;
            // 
            // metroRadioButtonEditTelat
            // 
            this.metroRadioButtonEditTelat.AutoSize = true;
            this.metroRadioButtonEditTelat.Location = new System.Drawing.Point(98, 447);
            this.metroRadioButtonEditTelat.Name = "metroRadioButtonEditTelat";
            this.metroRadioButtonEditTelat.Size = new System.Drawing.Size(51, 17);
            this.metroRadioButtonEditTelat.TabIndex = 54;
            this.metroRadioButtonEditTelat.TabStop = true;
            this.metroRadioButtonEditTelat.Text = "Telat";
            this.metroRadioButtonEditTelat.UseVisualStyleBackColor = true;
            // 
            // metroRadioButtonEditHadir
            // 
            this.metroRadioButtonEditHadir.AutoSize = true;
            this.metroRadioButtonEditHadir.Location = new System.Drawing.Point(12, 447);
            this.metroRadioButtonEditHadir.Name = "metroRadioButtonEditHadir";
            this.metroRadioButtonEditHadir.Size = new System.Drawing.Size(56, 17);
            this.metroRadioButtonEditHadir.TabIndex = 53;
            this.metroRadioButtonEditHadir.TabStop = true;
            this.metroRadioButtonEditHadir.Text = "Hadir";
            this.metroRadioButtonEditHadir.UseVisualStyleBackColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(12, 424);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(49, 20);
            this.metroLabel2.TabIndex = 52;
            this.metroLabel2.Text = "Status";
            // 
            // metroTextBoxEditIDAttendance
            // 
            this.metroTextBoxEditIDAttendance.Location = new System.Drawing.Point(12, 398);
            this.metroTextBoxEditIDAttendance.Name = "metroTextBoxEditIDAttendance";
            this.metroTextBoxEditIDAttendance.Size = new System.Drawing.Size(304, 23);
            this.metroTextBoxEditIDAttendance.TabIndex = 51;
            // 
            // metroLabelEditIDAttendance
            // 
            this.metroLabelEditIDAttendance.AutoSize = true;
            this.metroLabelEditIDAttendance.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelEditIDAttendance.Location = new System.Drawing.Point(12, 375);
            this.metroLabelEditIDAttendance.Name = "metroLabelEditIDAttendance";
            this.metroLabelEditIDAttendance.Size = new System.Drawing.Size(104, 20);
            this.metroLabelEditIDAttendance.TabIndex = 50;
            this.metroLabelEditIDAttendance.Text = "ID Attendance";
            // 
            // metroLabelEditAttendance
            // 
            this.metroLabelEditAttendance.AutoSize = true;
            this.metroLabelEditAttendance.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelEditAttendance.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelEditAttendance.Location = new System.Drawing.Point(12, 341);
            this.metroLabelEditAttendance.Name = "metroLabelEditAttendance";
            this.metroLabelEditAttendance.Size = new System.Drawing.Size(149, 25);
            this.metroLabelEditAttendance.TabIndex = 49;
            this.metroLabelEditAttendance.Text = "Edit Attendance";
            // 
            // metroButtonDelete
            // 
            this.metroButtonDelete.Location = new System.Drawing.Point(12, 660);
            this.metroButtonDelete.Name = "metroButtonDelete";
            this.metroButtonDelete.Size = new System.Drawing.Size(304, 23);
            this.metroButtonDelete.TabIndex = 61;
            this.metroButtonDelete.Text = "Delete";
            this.metroButtonDelete.Click += new System.EventHandler(this.metroButtonDelete_Click);
            // 
            // metroTextBoxDeleteIDAttendace
            // 
            this.metroTextBoxDeleteIDAttendace.Location = new System.Drawing.Point(12, 617);
            this.metroTextBoxDeleteIDAttendace.Name = "metroTextBoxDeleteIDAttendace";
            this.metroTextBoxDeleteIDAttendace.Size = new System.Drawing.Size(304, 23);
            this.metroTextBoxDeleteIDAttendace.TabIndex = 60;
            // 
            // metroLabelDeleteIDAttendance
            // 
            this.metroLabelDeleteIDAttendance.AutoSize = true;
            this.metroLabelDeleteIDAttendance.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelDeleteIDAttendance.Location = new System.Drawing.Point(12, 594);
            this.metroLabelDeleteIDAttendance.Name = "metroLabelDeleteIDAttendance";
            this.metroLabelDeleteIDAttendance.Size = new System.Drawing.Size(104, 20);
            this.metroLabelDeleteIDAttendance.TabIndex = 59;
            this.metroLabelDeleteIDAttendance.Text = "ID Attendance";
            // 
            // metroLabelDeleteAttendance
            // 
            this.metroLabelDeleteAttendance.AutoSize = true;
            this.metroLabelDeleteAttendance.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelDeleteAttendance.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelDeleteAttendance.Location = new System.Drawing.Point(12, 560);
            this.metroLabelDeleteAttendance.Name = "metroLabelDeleteAttendance";
            this.metroLabelDeleteAttendance.Size = new System.Drawing.Size(171, 25);
            this.metroLabelDeleteAttendance.TabIndex = 58;
            this.metroLabelDeleteAttendance.Text = "Delete Attendance";
            // 
            // metroComboBoxEvent
            // 
            this.metroComboBoxEvent.FormattingEnabled = true;
            this.metroComboBoxEvent.ItemHeight = 24;
            this.metroComboBoxEvent.Location = new System.Drawing.Point(12, 177);
            this.metroComboBoxEvent.Name = "metroComboBoxEvent";
            this.metroComboBoxEvent.Size = new System.Drawing.Size(304, 30);
            this.metroComboBoxEvent.TabIndex = 62;
            // 
            // ManageAttendanceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1224, 730);
            this.Controls.Add(this.metroComboBoxEvent);
            this.Controls.Add(this.metroButtonDelete);
            this.Controls.Add(this.metroTextBoxDeleteIDAttendace);
            this.Controls.Add(this.metroLabelDeleteIDAttendance);
            this.Controls.Add(this.metroLabelDeleteAttendance);
            this.Controls.Add(this.metroButtonEdit);
            this.Controls.Add(this.metroRadioButtonEditAbsent);
            this.Controls.Add(this.metroRadioButtonEditIzin);
            this.Controls.Add(this.metroRadioButtonEditTelat);
            this.Controls.Add(this.metroRadioButtonEditHadir);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroTextBoxEditIDAttendance);
            this.Controls.Add(this.metroLabelEditIDAttendance);
            this.Controls.Add(this.metroLabelEditAttendance);
            this.Controls.Add(this.metroButtonAdd);
            this.Controls.Add(this.metroRadioButtonAddAbsent);
            this.Controls.Add(this.metroRadioButtonAddIzin);
            this.Controls.Add(this.metroRadioButtonAddTelat);
            this.Controls.Add(this.metroRadioButtonAddHadir);
            this.Controls.Add(this.metroLabelStatus);
            this.Controls.Add(this.metroLabelIDEvent);
            this.Controls.Add(this.metroTextBoxName);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabelAddAttendance);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.metroLabelWindow);
            this.Name = "ManageAttendanceWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageAttendanceWindow";
            this.Load += new System.EventHandler(this.ManageAttendanceWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabelWindow;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton metroButtonAdd;
        private MetroFramework.Controls.MetroRadioButton metroRadioButtonAddAbsent;
        private MetroFramework.Controls.MetroRadioButton metroRadioButtonAddIzin;
        private MetroFramework.Controls.MetroRadioButton metroRadioButtonAddTelat;
        private MetroFramework.Controls.MetroRadioButton metroRadioButtonAddHadir;
        private MetroFramework.Controls.MetroLabel metroLabelStatus;
        private MetroFramework.Controls.MetroLabel metroLabelIDEvent;
        private MetroFramework.Controls.MetroTextBox metroTextBoxName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabelAddAttendance;
        private MetroFramework.Controls.MetroButton metroButtonEdit;
        private MetroFramework.Controls.MetroRadioButton metroRadioButtonEditAbsent;
        private MetroFramework.Controls.MetroRadioButton metroRadioButtonEditIzin;
        private MetroFramework.Controls.MetroRadioButton metroRadioButtonEditTelat;
        private MetroFramework.Controls.MetroRadioButton metroRadioButtonEditHadir;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBoxEditIDAttendance;
        private MetroFramework.Controls.MetroLabel metroLabelEditIDAttendance;
        private MetroFramework.Controls.MetroLabel metroLabelEditAttendance;
        private MetroFramework.Controls.MetroButton metroButtonDelete;
        private MetroFramework.Controls.MetroTextBox metroTextBoxDeleteIDAttendace;
        private MetroFramework.Controls.MetroLabel metroLabelDeleteIDAttendance;
        private MetroFramework.Controls.MetroLabel metroLabelDeleteAttendance;
        private MetroFramework.Controls.MetroComboBox metroComboBoxEvent;
    }
}