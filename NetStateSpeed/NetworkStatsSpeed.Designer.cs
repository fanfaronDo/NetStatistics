
namespace NetStateSpeed
{
    partial class NetworkStatsSpeed
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCheckSpeed = new System.Windows.Forms.Button();
            this.cmbInterface = new System.Windows.Forms.ComboBox();
            this.lblBytesSent = new System.Windows.Forms.Label();
            this.lblBytesReceived = new System.Windows.Forms.Label();
            this.lblUpload = new System.Windows.Forms.Label();
            this.lblDownload = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblInterfaceType = new System.Windows.Forms.Label();
            this.checkPing = new System.Windows.Forms.Label();
            this.cmbTranslateData = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblUploadInSec = new System.Windows.Forms.Label();
            this.lblDownloadInSec = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCheckSpeed
            // 
            this.buttonCheckSpeed.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonCheckSpeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCheckSpeed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCheckSpeed.Location = new System.Drawing.Point(56, 318);
            this.buttonCheckSpeed.Name = "buttonCheckSpeed";
            this.buttonCheckSpeed.Size = new System.Drawing.Size(141, 29);
            this.buttonCheckSpeed.TabIndex = 1;
            this.buttonCheckSpeed.Text = "go test";
            this.buttonCheckSpeed.UseVisualStyleBackColor = false;
            this.buttonCheckSpeed.Click += new System.EventHandler(this.buttonCheckSpeed_Click);
            // 
            // cmbInterface
            // 
            this.cmbInterface.FormattingEnabled = true;
            this.cmbInterface.Location = new System.Drawing.Point(184, 15);
            this.cmbInterface.Name = "cmbInterface";
            this.cmbInterface.Size = new System.Drawing.Size(107, 23);
            this.cmbInterface.TabIndex = 4;
            // 
            // lblBytesSent
            // 
            this.lblBytesSent.AutoSize = true;
            this.lblBytesSent.BackColor = System.Drawing.Color.Transparent;
            this.lblBytesSent.Location = new System.Drawing.Point(184, 101);
            this.lblBytesSent.Name = "lblBytesSent";
            this.lblBytesSent.Size = new System.Drawing.Size(13, 15);
            this.lblBytesSent.TabIndex = 5;
            this.lblBytesSent.Text = "0";
            this.lblBytesSent.Click += new System.EventHandler(this.lblBytesSent_Click);
            // 
            // lblBytesReceived
            // 
            this.lblBytesReceived.AutoSize = true;
            this.lblBytesReceived.BackColor = System.Drawing.Color.Transparent;
            this.lblBytesReceived.Location = new System.Drawing.Point(184, 116);
            this.lblBytesReceived.Name = "lblBytesReceived";
            this.lblBytesReceived.Size = new System.Drawing.Size(13, 15);
            this.lblBytesReceived.TabIndex = 6;
            this.lblBytesReceived.Text = "0";
            // 
            // lblUpload
            // 
            this.lblUpload.AutoSize = true;
            this.lblUpload.BackColor = System.Drawing.Color.Transparent;
            this.lblUpload.Location = new System.Drawing.Point(184, 151);
            this.lblUpload.Name = "lblUpload";
            this.lblUpload.Size = new System.Drawing.Size(13, 15);
            this.lblUpload.TabIndex = 7;
            this.lblUpload.Text = "0";
            // 
            // lblDownload
            // 
            this.lblDownload.AutoSize = true;
            this.lblDownload.BackColor = System.Drawing.Color.Transparent;
            this.lblDownload.Location = new System.Drawing.Point(184, 166);
            this.lblDownload.Name = "lblDownload";
            this.lblDownload.Size = new System.Drawing.Size(13, 15);
            this.lblDownload.TabIndex = 8;
            this.lblDownload.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Выбор интерфейса:";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.BackColor = System.Drawing.Color.Transparent;
            this.lblSpeed.Location = new System.Drawing.Point(184, 76);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(13, 15);
            this.lblSpeed.TabIndex = 10;
            this.lblSpeed.Text = "0";
            // 
            // lblInterfaceType
            // 
            this.lblInterfaceType.AutoSize = true;
            this.lblInterfaceType.BackColor = System.Drawing.Color.Transparent;
            this.lblInterfaceType.Location = new System.Drawing.Point(10, 76);
            this.lblInterfaceType.Name = "lblInterfaceType";
            this.lblInterfaceType.Size = new System.Drawing.Size(38, 15);
            this.lblInterfaceType.TabIndex = 11;
            this.lblInterfaceType.Text = "label2";
            // 
            // checkPing
            // 
            this.checkPing.AutoSize = true;
            this.checkPing.BackColor = System.Drawing.Color.Transparent;
            this.checkPing.Location = new System.Drawing.Point(184, 197);
            this.checkPing.Name = "checkPing";
            this.checkPing.Size = new System.Drawing.Size(13, 15);
            this.checkPing.TabIndex = 12;
            this.checkPing.Text = "0";
            // 
            // cmbTranslateData
            // 
            this.cmbTranslateData.AutoCompleteCustomSource.AddRange(new string[] {
            "Kb/s",
            "Mb/s"});
            this.cmbTranslateData.FormattingEnabled = true;
            this.cmbTranslateData.Items.AddRange(new object[] {
            "Kb/s",
            "Mb/s",
            "KB/s",
            "MB/s"});
            this.cmbTranslateData.Location = new System.Drawing.Point(184, 44);
            this.cmbTranslateData.Name = "cmbTranslateData";
            this.cmbTranslateData.Size = new System.Drawing.Size(107, 23);
            this.cmbTranslateData.TabIndex = 13;
            this.cmbTranslateData.SelectedIndexChanged += new System.EventHandler(this.cmbTranslateData_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(10, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Выбрать еденицу измерения:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(10, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Отправлено всего:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(10, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Получено всего:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(10, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Отправлено за одну секунду";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(10, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Получено за одну секунду";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(10, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Задержка:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(10, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Upload";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(10, 252);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "Download";
            // 
            // lblUploadInSec
            // 
            this.lblUploadInSec.AutoSize = true;
            this.lblUploadInSec.BackColor = System.Drawing.Color.Transparent;
            this.lblUploadInSec.Location = new System.Drawing.Point(184, 228);
            this.lblUploadInSec.Name = "lblUploadInSec";
            this.lblUploadInSec.Size = new System.Drawing.Size(13, 15);
            this.lblUploadInSec.TabIndex = 22;
            this.lblUploadInSec.Text = "0";
            // 
            // lblDownloadInSec
            // 
            this.lblDownloadInSec.AutoSize = true;
            this.lblDownloadInSec.BackColor = System.Drawing.Color.Transparent;
            this.lblDownloadInSec.Location = new System.Drawing.Point(184, 252);
            this.lblDownloadInSec.Name = "lblDownloadInSec";
            this.lblDownloadInSec.Size = new System.Drawing.Size(13, 15);
            this.lblDownloadInSec.TabIndex = 23;
            this.lblDownloadInSec.Text = "0";
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.BackColor = System.Drawing.Color.Transparent;
            this.Error.Location = new System.Drawing.Point(10, 280);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(35, 15);
            this.Error.TabIndex = 24;
            this.Error.Text = "Error:";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(184, 280);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 25;
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.BackColor = System.Drawing.Color.Transparent;
            this.cartesianChart1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cartesianChart1.ForeColor = System.Drawing.Color.DarkRed;
            this.cartesianChart1.Location = new System.Drawing.Point(313, 12);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(472, 344);
            this.cartesianChart1.TabIndex = 26;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.buttonCheckSpeed);
            this.panel1.Controls.Add(this.lblError);
            this.panel1.Controls.Add(this.Error);
            this.panel1.Controls.Add(this.lblDownloadInSec);
            this.panel1.Controls.Add(this.lblUploadInSec);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbTranslateData);
            this.panel1.Controls.Add(this.checkPing);
            this.panel1.Controls.Add(this.lblInterfaceType);
            this.panel1.Controls.Add(this.lblSpeed);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblDownload);
            this.panel1.Controls.Add(this.lblUpload);
            this.panel1.Controls.Add(this.lblBytesReceived);
            this.panel1.Controls.Add(this.lblBytesSent);
            this.panel1.Controls.Add(this.cmbInterface);
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 358);
            this.panel1.TabIndex = 27;
            // 
            // NetworkStatsSpeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::NetStateSpeed.Properties.Resources.fon_it;
            this.ClientSize = new System.Drawing.Size(797, 372);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cartesianChart1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NetworkStatsSpeed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NetStateSpeed";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCheckSpeed;
        
        public System.Windows.Forms.ComboBox cmbInterface;
        public System.Windows.Forms.Label lblBytesSent;
        public System.Windows.Forms.Label lblBytesReceived;
        public System.Windows.Forms.Label lblUpload;
        public System.Windows.Forms.Label lblDownload;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblSpeed;
        public System.Windows.Forms.Label lblInterfaceType;
        private System.Windows.Forms.Label checkPing;
        public System.Windows.Forms.ComboBox cmbTranslateData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblUploadInSec;
        private System.Windows.Forms.Label lblDownloadInSec;
        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.Label lblError;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.Panel panel1;
    }
}

