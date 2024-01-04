namespace AttendanceAppDesktop
{
    partial class ManageEventsWindow
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
            this.metroButtonExport = new MetroFramework.Controls.MetroButton();
            this.metroButtonDelete = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxDeleteIDEvent = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelDeleteIDEvent = new MetroFramework.Controls.MetroLabel();
            this.metroLabelDeleteEvent = new MetroFramework.Controls.MetroLabel();
            this.metroButtonEdit = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxEditIDEvent = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelEditIDEvent = new MetroFramework.Controls.MetroLabel();
            this.metroLabelEditAttendance = new MetroFramework.Controls.MetroLabel();
            this.metroButtonAdd = new MetroFramework.Controls.MetroButton();
            this.metroLabelLocation = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxAddEventName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabelAddEvent = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroTextBoxAddLocation = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelDate = new MetroFramework.Controls.MetroLabel();
            this.metroLabelTime = new MetroFramework.Controls.MetroLabel();
            this.datePickerAdd = new System.Windows.Forms.DateTimePicker();
            this.timePickerAdd = new System.Windows.Forms.DateTimePicker();
            this.timePickerEdit = new System.Windows.Forms.DateTimePicker();
            this.datePickerEdit = new System.Windows.Forms.DateTimePicker();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxEditLocation = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxEditEvent = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroButtonFetch = new MetroFramework.Controls.MetroButton();
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
            this.metroLabelWindow.Text = "Manage Events";
            this.metroLabelWindow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroButtonExport
            // 
            this.metroButtonExport.AutoSize = true;
            this.metroButtonExport.Location = new System.Drawing.Point(997, 79);
            this.metroButtonExport.Name = "metroButtonExport";
            this.metroButtonExport.Size = new System.Drawing.Size(215, 26);
            this.metroButtonExport.TabIndex = 90;
            this.metroButtonExport.Text = "Export Data";
            // 
            // metroButtonDelete
            // 
            this.metroButtonDelete.Location = new System.Drawing.Point(12, 806);
            this.metroButtonDelete.Name = "metroButtonDelete";
            this.metroButtonDelete.Size = new System.Drawing.Size(304, 23);
            this.metroButtonDelete.TabIndex = 88;
            this.metroButtonDelete.Text = "Delete";
            this.metroButtonDelete.Click += new System.EventHandler(this.metroButtonDelete_Click);
            // 
            // metroTextBoxDeleteIDEvent
            // 
            this.metroTextBoxDeleteIDEvent.Location = new System.Drawing.Point(12, 763);
            this.metroTextBoxDeleteIDEvent.Name = "metroTextBoxDeleteIDEvent";
            this.metroTextBoxDeleteIDEvent.Size = new System.Drawing.Size(304, 23);
            this.metroTextBoxDeleteIDEvent.TabIndex = 87;
            // 
            // metroLabelDeleteIDEvent
            // 
            this.metroLabelDeleteIDEvent.AutoSize = true;
            this.metroLabelDeleteIDEvent.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelDeleteIDEvent.Location = new System.Drawing.Point(12, 740);
            this.metroLabelDeleteIDEvent.Name = "metroLabelDeleteIDEvent";
            this.metroLabelDeleteIDEvent.Size = new System.Drawing.Size(64, 20);
            this.metroLabelDeleteIDEvent.TabIndex = 86;
            this.metroLabelDeleteIDEvent.Text = "ID Event";
            // 
            // metroLabelDeleteEvent
            // 
            this.metroLabelDeleteEvent.AutoSize = true;
            this.metroLabelDeleteEvent.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelDeleteEvent.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelDeleteEvent.Location = new System.Drawing.Point(12, 706);
            this.metroLabelDeleteEvent.Name = "metroLabelDeleteEvent";
            this.metroLabelDeleteEvent.Size = new System.Drawing.Size(120, 25);
            this.metroLabelDeleteEvent.TabIndex = 85;
            this.metroLabelDeleteEvent.Text = "Delete Event";
            // 
            // metroButtonEdit
            // 
            this.metroButtonEdit.Enabled = false;
            this.metroButtonEdit.Location = new System.Drawing.Point(12, 659);
            this.metroButtonEdit.Name = "metroButtonEdit";
            this.metroButtonEdit.Size = new System.Drawing.Size(304, 23);
            this.metroButtonEdit.TabIndex = 84;
            this.metroButtonEdit.Text = "Edit";
            this.metroButtonEdit.Click += new System.EventHandler(this.metroButtonEdit_Click);
            // 
            // metroTextBoxEditIDEvent
            // 
            this.metroTextBoxEditIDEvent.Location = new System.Drawing.Point(12, 419);
            this.metroTextBoxEditIDEvent.Name = "metroTextBoxEditIDEvent";
            this.metroTextBoxEditIDEvent.Size = new System.Drawing.Size(223, 23);
            this.metroTextBoxEditIDEvent.TabIndex = 78;
            // 
            // metroLabelEditIDEvent
            // 
            this.metroLabelEditIDEvent.AutoSize = true;
            this.metroLabelEditIDEvent.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelEditIDEvent.Location = new System.Drawing.Point(12, 396);
            this.metroLabelEditIDEvent.Name = "metroLabelEditIDEvent";
            this.metroLabelEditIDEvent.Size = new System.Drawing.Size(70, 20);
            this.metroLabelEditIDEvent.TabIndex = 77;
            this.metroLabelEditIDEvent.Text = "ID Events";
            // 
            // metroLabelEditAttendance
            // 
            this.metroLabelEditAttendance.AutoSize = true;
            this.metroLabelEditAttendance.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelEditAttendance.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelEditAttendance.Location = new System.Drawing.Point(12, 362);
            this.metroLabelEditAttendance.Name = "metroLabelEditAttendance";
            this.metroLabelEditAttendance.Size = new System.Drawing.Size(98, 25);
            this.metroLabelEditAttendance.TabIndex = 76;
            this.metroLabelEditAttendance.Text = "Edit Event";
            // 
            // metroButtonAdd
            // 
            this.metroButtonAdd.Location = new System.Drawing.Point(12, 318);
            this.metroButtonAdd.Name = "metroButtonAdd";
            this.metroButtonAdd.Size = new System.Drawing.Size(304, 23);
            this.metroButtonAdd.TabIndex = 75;
            this.metroButtonAdd.Text = "Add";
            this.metroButtonAdd.Click += new System.EventHandler(this.metroButtonAdd_Click);
            // 
            // metroLabelLocation
            // 
            this.metroLabelLocation.AutoSize = true;
            this.metroLabelLocation.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelLocation.Location = new System.Drawing.Point(12, 156);
            this.metroLabelLocation.Name = "metroLabelLocation";
            this.metroLabelLocation.Size = new System.Drawing.Size(66, 20);
            this.metroLabelLocation.TabIndex = 69;
            this.metroLabelLocation.Text = "Location";
            // 
            // metroTextBoxAddEventName
            // 
            this.metroTextBoxAddEventName.Location = new System.Drawing.Point(12, 130);
            this.metroTextBoxAddEventName.Name = "metroTextBoxAddEventName";
            this.metroTextBoxAddEventName.Size = new System.Drawing.Size(304, 23);
            this.metroTextBoxAddEventName.TabIndex = 68;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(12, 107);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 20);
            this.metroLabel1.TabIndex = 67;
            this.metroLabel1.Text = "Event Name";
            // 
            // metroLabelAddEvent
            // 
            this.metroLabelAddEvent.AutoSize = true;
            this.metroLabelAddEvent.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelAddEvent.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelAddEvent.Location = new System.Drawing.Point(12, 73);
            this.metroLabelAddEvent.Name = "metroLabelAddEvent";
            this.metroLabelAddEvent.Size = new System.Drawing.Size(100, 25);
            this.metroLabelAddEvent.TabIndex = 66;
            this.metroLabelAddEvent.Text = "Add Event";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(357, 73);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(105, 25);
            this.metroLabel3.TabIndex = 65;
            this.metroLabel3.Text = "Event Data";
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
            this.dataGridView1.Size = new System.Drawing.Size(855, 718);
            this.dataGridView1.TabIndex = 64;
            // 
            // metroTextBoxAddLocation
            // 
            this.metroTextBoxAddLocation.Location = new System.Drawing.Point(12, 179);
            this.metroTextBoxAddLocation.Name = "metroTextBoxAddLocation";
            this.metroTextBoxAddLocation.Size = new System.Drawing.Size(304, 23);
            this.metroTextBoxAddLocation.TabIndex = 91;
            // 
            // metroLabelDate
            // 
            this.metroLabelDate.AutoSize = true;
            this.metroLabelDate.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelDate.Location = new System.Drawing.Point(12, 205);
            this.metroLabelDate.Name = "metroLabelDate";
            this.metroLabelDate.Size = new System.Drawing.Size(41, 20);
            this.metroLabelDate.TabIndex = 92;
            this.metroLabelDate.Text = "Date";
            // 
            // metroLabelTime
            // 
            this.metroLabelTime.AutoSize = true;
            this.metroLabelTime.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelTime.Location = new System.Drawing.Point(12, 254);
            this.metroLabelTime.Name = "metroLabelTime";
            this.metroLabelTime.Size = new System.Drawing.Size(42, 20);
            this.metroLabelTime.TabIndex = 94;
            this.metroLabelTime.Text = "Time";
            // 
            // datePickerAdd
            // 
            this.datePickerAdd.Location = new System.Drawing.Point(12, 228);
            this.datePickerAdd.Name = "datePickerAdd";
            this.datePickerAdd.Size = new System.Drawing.Size(303, 22);
            this.datePickerAdd.TabIndex = 96;
            // 
            // timePickerAdd
            // 
            this.timePickerAdd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePickerAdd.Location = new System.Drawing.Point(12, 277);
            this.timePickerAdd.Name = "timePickerAdd";
            this.timePickerAdd.ShowUpDown = true;
            this.timePickerAdd.Size = new System.Drawing.Size(303, 22);
            this.timePickerAdd.TabIndex = 97;
            // 
            // timePickerEdit
            // 
            this.timePickerEdit.Enabled = false;
            this.timePickerEdit.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePickerEdit.Location = new System.Drawing.Point(12, 615);
            this.timePickerEdit.Name = "timePickerEdit";
            this.timePickerEdit.ShowUpDown = true;
            this.timePickerEdit.Size = new System.Drawing.Size(303, 22);
            this.timePickerEdit.TabIndex = 105;
            // 
            // datePickerEdit
            // 
            this.datePickerEdit.Enabled = false;
            this.datePickerEdit.Location = new System.Drawing.Point(12, 566);
            this.datePickerEdit.Name = "datePickerEdit";
            this.datePickerEdit.Size = new System.Drawing.Size(303, 22);
            this.datePickerEdit.TabIndex = 104;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(12, 592);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(42, 20);
            this.metroLabel2.TabIndex = 103;
            this.metroLabel2.Text = "Time";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(12, 543);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(41, 20);
            this.metroLabel4.TabIndex = 102;
            this.metroLabel4.Text = "Date";
            // 
            // metroTextBoxEditLocation
            // 
            this.metroTextBoxEditLocation.Enabled = false;
            this.metroTextBoxEditLocation.Location = new System.Drawing.Point(12, 517);
            this.metroTextBoxEditLocation.Name = "metroTextBoxEditLocation";
            this.metroTextBoxEditLocation.Size = new System.Drawing.Size(304, 23);
            this.metroTextBoxEditLocation.TabIndex = 101;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(12, 494);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(66, 20);
            this.metroLabel5.TabIndex = 100;
            this.metroLabel5.Text = "Location";
            // 
            // metroTextBoxEditEvent
            // 
            this.metroTextBoxEditEvent.Enabled = false;
            this.metroTextBoxEditEvent.Location = new System.Drawing.Point(12, 468);
            this.metroTextBoxEditEvent.Name = "metroTextBoxEditEvent";
            this.metroTextBoxEditEvent.Size = new System.Drawing.Size(304, 23);
            this.metroTextBoxEditEvent.TabIndex = 99;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(12, 445);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(89, 20);
            this.metroLabel6.TabIndex = 98;
            this.metroLabel6.Text = "Event Name";
            // 
            // metroButtonFetch
            // 
            this.metroButtonFetch.Location = new System.Drawing.Point(241, 419);
            this.metroButtonFetch.Name = "metroButtonFetch";
            this.metroButtonFetch.Size = new System.Drawing.Size(75, 23);
            this.metroButtonFetch.TabIndex = 106;
            this.metroButtonFetch.Text = "Fetch";
            this.metroButtonFetch.Click += new System.EventHandler(this.metroButtonFetch_Click);
            // 
            // ManageEventsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1224, 848);
            this.Controls.Add(this.metroButtonFetch);
            this.Controls.Add(this.timePickerEdit);
            this.Controls.Add(this.datePickerEdit);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroTextBoxEditLocation);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroTextBoxEditEvent);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.timePickerAdd);
            this.Controls.Add(this.datePickerAdd);
            this.Controls.Add(this.metroLabelTime);
            this.Controls.Add(this.metroLabelDate);
            this.Controls.Add(this.metroTextBoxAddLocation);
            this.Controls.Add(this.metroButtonExport);
            this.Controls.Add(this.metroButtonDelete);
            this.Controls.Add(this.metroTextBoxDeleteIDEvent);
            this.Controls.Add(this.metroLabelDeleteIDEvent);
            this.Controls.Add(this.metroLabelDeleteEvent);
            this.Controls.Add(this.metroButtonEdit);
            this.Controls.Add(this.metroTextBoxEditIDEvent);
            this.Controls.Add(this.metroLabelEditIDEvent);
            this.Controls.Add(this.metroLabelEditAttendance);
            this.Controls.Add(this.metroButtonAdd);
            this.Controls.Add(this.metroLabelLocation);
            this.Controls.Add(this.metroTextBoxAddEventName);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabelAddEvent);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.metroLabelWindow);
            this.Name = "ManageEventsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageEventsWindow";
            this.Load += new System.EventHandler(this.ManageEventsWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabelWindow;
        private MetroFramework.Controls.MetroButton metroButtonExport;
        private MetroFramework.Controls.MetroButton metroButtonDelete;
        private MetroFramework.Controls.MetroTextBox metroTextBoxDeleteIDEvent;
        private MetroFramework.Controls.MetroLabel metroLabelDeleteIDEvent;
        private MetroFramework.Controls.MetroLabel metroLabelDeleteEvent;
        private MetroFramework.Controls.MetroButton metroButtonEdit;
        private MetroFramework.Controls.MetroTextBox metroTextBoxEditIDEvent;
        private MetroFramework.Controls.MetroLabel metroLabelEditIDEvent;
        private MetroFramework.Controls.MetroLabel metroLabelEditAttendance;
        private MetroFramework.Controls.MetroButton metroButtonAdd;
        private MetroFramework.Controls.MetroLabel metroLabelLocation;
        private MetroFramework.Controls.MetroTextBox metroTextBoxAddEventName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabelAddEvent;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxAddLocation;
        private MetroFramework.Controls.MetroLabel metroLabelDate;
        private MetroFramework.Controls.MetroLabel metroLabelTime;
        private System.Windows.Forms.DateTimePicker datePickerAdd;
        private System.Windows.Forms.DateTimePicker timePickerAdd;
        private System.Windows.Forms.DateTimePicker timePickerEdit;
        private System.Windows.Forms.DateTimePicker datePickerEdit;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox metroTextBoxEditLocation;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox metroTextBoxEditEvent;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton metroButtonFetch;
    }
}