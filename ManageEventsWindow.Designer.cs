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
            this.SuspendLayout();
            // 
            // metroLabelWindow
            // 
            this.metroLabelWindow.BackColor = System.Drawing.Color.White;
            this.metroLabelWindow.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelWindow.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelWindow.Location = new System.Drawing.Point(12, 9);
            this.metroLabelWindow.Name = "metroLabelWindow";
            this.metroLabelWindow.Size = new System.Drawing.Size(776, 30);
            this.metroLabelWindow.TabIndex = 2;
            this.metroLabelWindow.Text = "Manage Events";
            this.metroLabelWindow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManageEventsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroLabelWindow);
            this.Name = "ManageEventsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageEventsWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabelWindow;
    }
}