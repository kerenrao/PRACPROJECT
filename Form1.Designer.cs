namespace AndroidDataViewer
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Dispose method
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgvContacts = new System.Windows.Forms.DataGridView();
            this.dgvSMS = new System.Windows.Forms.DataGridView();
            this.dgvCalls = new System.Windows.Forms.DataGridView();
            this.txtDeviceInfo = new System.Windows.Forms.TextBox();

            this.BtnLoadContacts = new System.Windows.Forms.Button();
            this.BtnSaveContactsToDB = new System.Windows.Forms.Button();
            this.BtnLoadSMS = new System.Windows.Forms.Button();
            this.BtnSaveSMSToDB = new System.Windows.Forms.Button();
            this.BtnLoadCalls = new System.Windows.Forms.Button();
            this.BtnSaveCallsToDB = new System.Windows.Forms.Button();
            this.BtnLoadDeviceInfo = new System.Windows.Forms.Button();
            this.BtnSaveDeviceInfoToDB = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalls)).BeginInit();

            this.SuspendLayout();

            // dgvContacts
            this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacts.Location = new System.Drawing.Point(12, 12);
            this.dgvContacts.Name = "dgvContacts";
            this.dgvContacts.Size = new System.Drawing.Size(500, 150);

            // dgvSMS
            this.dgvSMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSMS.Location = new System.Drawing.Point(12, 180);
            this.dgvSMS.Name = "dgvSMS";
            this.dgvSMS.Size = new System.Drawing.Size(500, 150);

            // dgvCalls
            this.dgvCalls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalls.Location = new System.Drawing.Point(12, 350);
            this.dgvCalls.Name = "dgvCalls";
            this.dgvCalls.Size = new System.Drawing.Size(500, 150);

            // txtDeviceInfo
            this.txtDeviceInfo.Location = new System.Drawing.Point(12, 520);
            this.txtDeviceInfo.Multiline = true;
            this.txtDeviceInfo.Name = "txtDeviceInfo";
            this.txtDeviceInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDeviceInfo.Size = new System.Drawing.Size(500, 100);

            // BtnLoadContacts
            this.BtnLoadContacts.Location = new System.Drawing.Point(530, 12);
            this.BtnLoadContacts.Name = "BtnLoadContacts";
            this.BtnLoadContacts.Size = new System.Drawing.Size(150, 30);
            this.BtnLoadContacts.Text = "Load Contacts";
            this.BtnLoadContacts.Click += new System.EventHandler(this.BtnLoadContacts_Click);

            // BtnSaveContactsToDB
            this.BtnSaveContactsToDB.Location = new System.Drawing.Point(530, 48);
            this.BtnSaveContactsToDB.Name = "BtnSaveContactsToDB";
            this.BtnSaveContactsToDB.Size = new System.Drawing.Size(150, 30);
            this.BtnSaveContactsToDB.Text = "Save Contacts to DB";
            this.BtnSaveContactsToDB.Click += new System.EventHandler(this.BtnSaveContactsToDB_Click);

            // BtnLoadSMS
            this.BtnLoadSMS.Location = new System.Drawing.Point(530, 180);
            this.BtnLoadSMS.Name = "BtnLoadSMS";
            this.BtnLoadSMS.Size = new System.Drawing.Size(150, 30);
            this.BtnLoadSMS.Text = "Load SMS";
            this.BtnLoadSMS.Click += new System.EventHandler(this.BtnLoadSMS_Click);

            // BtnSaveSMSToDB
            this.BtnSaveSMSToDB.Location = new System.Drawing.Point(530, 216);
            this.BtnSaveSMSToDB.Name = "BtnSaveSMSToDB";
            this.BtnSaveSMSToDB.Size = new System.Drawing.Size(150, 30);
            this.BtnSaveSMSToDB.Text = "Save SMS to DB";
            this.BtnSaveSMSToDB.Click += new System.EventHandler(this.BtnSaveSMSToDB_Click);

            // BtnLoadCalls
            this.BtnLoadCalls.Location = new System.Drawing.Point(530, 350);
            this.BtnLoadCalls.Name = "BtnLoadCalls";
            this.BtnLoadCalls.Size = new System.Drawing.Size(150, 30);
            this.BtnLoadCalls.Text = "Load Calls";
            this.BtnLoadCalls.Click += new System.EventHandler(this.BtnLoadCalls_Click);

            // BtnSaveCallsToDB
            this.BtnSaveCallsToDB.Location = new System.Drawing.Point(530, 386);
            this.BtnSaveCallsToDB.Name = "BtnSaveCallsToDB";
            this.BtnSaveCallsToDB.Size = new System.Drawing.Size(150, 30);
            this.BtnSaveCallsToDB.Text = "Save Calls to DB";
            this.BtnSaveCallsToDB.Click += new System.EventHandler(this.BtnSaveCallsToDB_Click);

            // BtnLoadDeviceInfo
            this.BtnLoadDeviceInfo.Location = new System.Drawing.Point(530, 520);
            this.BtnLoadDeviceInfo.Name = "BtnLoadDeviceInfo";
            this.BtnLoadDeviceInfo.Size = new System.Drawing.Size(150, 30);
            this.BtnLoadDeviceInfo.Text = "Load Device Info";
            this.BtnLoadDeviceInfo.Click += new System.EventHandler(this.BtnLoadDeviceInfo_Click);

            // BtnSaveDeviceInfoToDB
            this.BtnSaveDeviceInfoToDB.Location = new System.Drawing.Point(530, 556);
            this.BtnSaveDeviceInfoToDB.Name = "BtnSaveDeviceInfoToDB";
            this.BtnSaveDeviceInfoToDB.Size = new System.Drawing.Size(150, 30);
            this.BtnSaveDeviceInfoToDB.Text = "Save Device Info to DB";
            this.BtnSaveDeviceInfoToDB.Click += new System.EventHandler(this.BtnSaveDeviceInfoToDB_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(700, 640);
            this.Controls.Add(this.dgvContacts);
            this.Controls.Add(this.dgvSMS);
            this.Controls.Add(this.dgvCalls);
            this.Controls.Add(this.txtDeviceInfo);
            this.Controls.Add(this.BtnLoadContacts);
            this.Controls.Add(this.BtnSaveContactsToDB);
            this.Controls.Add(this.BtnLoadSMS);
            this.Controls.Add(this.BtnSaveSMSToDB);
            this.Controls.Add(this.BtnLoadCalls);
            this.Controls.Add(this.BtnSaveCallsToDB);
            this.Controls.Add(this.BtnLoadDeviceInfo);
            this.Controls.Add(this.BtnSaveDeviceInfoToDB);
            this.Name = "Form1";
            this.Text = "Android Data Viewer";

            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalls)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContacts;
        private System.Windows.Forms.DataGridView dgvSMS;
        private System.Windows.Forms.DataGridView dgvCalls;
        private System.Windows.Forms.TextBox txtDeviceInfo;

        private System.Windows.Forms.Button BtnLoadContacts;
        private System.Windows.Forms.Button BtnSaveContactsToDB;
        private System.Windows.Forms.Button BtnLoadSMS;
        private System.Windows.Forms.Button BtnSaveSMSToDB;
        private System.Windows.Forms.Button BtnLoadCalls;
        private System.Windows.Forms.Button BtnSaveCallsToDB;
        private System.Windows.Forms.Button BtnLoadDeviceInfo;
        private System.Windows.Forms.Button BtnSaveDeviceInfoToDB;
    }
}
