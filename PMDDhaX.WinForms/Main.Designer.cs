
namespace PMDDhaX.WinForms
{
    partial class Main
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
            this.TextBoxIP = new System.Windows.Forms.TextBox();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.GroupSysBotConnection = new System.Windows.Forms.GroupBox();
            this.LabelPort = new System.Windows.Forms.Label();
            this.LabelIP = new System.Windows.Forms.Label();
            this.TextBoxPort = new System.Windows.Forms.TextBox();
            this.GroupSysBotStatus = new System.Windows.Forms.GroupBox();
            this.StatusConnection = new System.Windows.Forms.Label();
            this.StatusConnectionLabel = new System.Windows.Forms.Label();
            this.ButtonSysbotRead = new System.Windows.Forms.Button();
            this.TabSysBot4Log = new System.Windows.Forms.TabPage();
            this.SysBotLog = new System.Windows.Forms.RichTextBox();
            this.SysBotTabControl = new System.Windows.Forms.TabControl();
            this.SysBotGeneral = new System.Windows.Forms.TabPage();
            this.TeamGroupBox = new System.Windows.Forms.GroupBox();
            this.PointsTotalNumeric = new System.Windows.Forms.NumericUpDown();
            this.TotalPointsLabel = new System.Windows.Forms.Label();
            this.GroupSysBotConnection.SuspendLayout();
            this.GroupSysBotStatus.SuspendLayout();
            this.TabSysBot4Log.SuspendLayout();
            this.SysBotTabControl.SuspendLayout();
            this.SysBotGeneral.SuspendLayout();
            this.TeamGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PointsTotalNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxIP
            // 
            this.TextBoxIP.AccessibleName = "TextBoxIP";
            this.TextBoxIP.Location = new System.Drawing.Point(44, 28);
            this.TextBoxIP.Name = "TextBoxIP";
            this.TextBoxIP.Size = new System.Drawing.Size(96, 20);
            this.TextBoxIP.TabIndex = 0;
            this.TextBoxIP.Text = "192.168.0.1";
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.AccessibleName = "ButtonConnect";
            this.ButtonConnect.Location = new System.Drawing.Point(44, 81);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(84, 24);
            this.ButtonConnect.TabIndex = 2;
            this.ButtonConnect.Text = "Connect";
            this.ButtonConnect.UseVisualStyleBackColor = true;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // GroupSysBotConnection
            // 
            this.GroupSysBotConnection.AccessibleName = "GroupSysBotConnection";
            this.GroupSysBotConnection.Controls.Add(this.LabelPort);
            this.GroupSysBotConnection.Controls.Add(this.LabelIP);
            this.GroupSysBotConnection.Controls.Add(this.TextBoxPort);
            this.GroupSysBotConnection.Controls.Add(this.ButtonConnect);
            this.GroupSysBotConnection.Controls.Add(this.TextBoxIP);
            this.GroupSysBotConnection.Location = new System.Drawing.Point(370, 436);
            this.GroupSysBotConnection.Name = "GroupSysBotConnection";
            this.GroupSysBotConnection.Size = new System.Drawing.Size(163, 119);
            this.GroupSysBotConnection.TabIndex = 3;
            this.GroupSysBotConnection.TabStop = false;
            this.GroupSysBotConnection.Text = "Connection";
            // 
            // LabelPort
            // 
            this.LabelPort.AccessibleName = "LabelPort";
            this.LabelPort.AutoSize = true;
            this.LabelPort.Location = new System.Drawing.Point(9, 57);
            this.LabelPort.Name = "LabelPort";
            this.LabelPort.Size = new System.Drawing.Size(29, 13);
            this.LabelPort.TabIndex = 5;
            this.LabelPort.Text = "Port:";
            // 
            // LabelIP
            // 
            this.LabelIP.AccessibleName = "LabelIP";
            this.LabelIP.AutoSize = true;
            this.LabelIP.Location = new System.Drawing.Point(18, 31);
            this.LabelIP.Name = "LabelIP";
            this.LabelIP.Size = new System.Drawing.Size(20, 13);
            this.LabelIP.TabIndex = 4;
            this.LabelIP.Text = "IP:";
            // 
            // TextBoxPort
            // 
            this.TextBoxPort.AccessibleName = "TextBoxPort";
            this.TextBoxPort.Location = new System.Drawing.Point(44, 54);
            this.TextBoxPort.Name = "TextBoxPort";
            this.TextBoxPort.Size = new System.Drawing.Size(96, 20);
            this.TextBoxPort.TabIndex = 3;
            this.TextBoxPort.Text = "6000";
            // 
            // GroupSysBotStatus
            // 
            this.GroupSysBotStatus.AccessibleName = "GroupSysBotStatus";
            this.GroupSysBotStatus.Controls.Add(this.StatusConnection);
            this.GroupSysBotStatus.Controls.Add(this.StatusConnectionLabel);
            this.GroupSysBotStatus.Controls.Add(this.ButtonSysbotRead);
            this.GroupSysBotStatus.Location = new System.Drawing.Point(12, 436);
            this.GroupSysBotStatus.Name = "GroupSysBotStatus";
            this.GroupSysBotStatus.Size = new System.Drawing.Size(352, 119);
            this.GroupSysBotStatus.TabIndex = 4;
            this.GroupSysBotStatus.TabStop = false;
            this.GroupSysBotStatus.Text = "Status";
            // 
            // StatusConnection
            // 
            this.StatusConnection.AccessibleName = "StatusConnection";
            this.StatusConnection.AutoSize = true;
            this.StatusConnection.ForeColor = System.Drawing.Color.Red;
            this.StatusConnection.Location = new System.Drawing.Point(67, 16);
            this.StatusConnection.Name = "StatusConnection";
            this.StatusConnection.Size = new System.Drawing.Size(73, 13);
            this.StatusConnection.TabIndex = 15;
            this.StatusConnection.Text = "Disconnected";
            // 
            // StatusConnectionLabel
            // 
            this.StatusConnectionLabel.AccessibleName = "StatusConnectionLabel";
            this.StatusConnectionLabel.AutoSize = true;
            this.StatusConnectionLabel.Location = new System.Drawing.Point(6, 16);
            this.StatusConnectionLabel.Name = "StatusConnectionLabel";
            this.StatusConnectionLabel.Size = new System.Drawing.Size(64, 13);
            this.StatusConnectionLabel.TabIndex = 10;
            this.StatusConnectionLabel.Text = "Connection:";
            // 
            // ButtonSysbotRead
            // 
            this.ButtonSysbotRead.AccessibleName = "ButtonSysbotRead";
            this.ButtonSysbotRead.Enabled = false;
            this.ButtonSysbotRead.Location = new System.Drawing.Point(271, 90);
            this.ButtonSysbotRead.Name = "ButtonSysbotRead";
            this.ButtonSysbotRead.Size = new System.Drawing.Size(75, 23);
            this.ButtonSysbotRead.TabIndex = 14;
            this.ButtonSysbotRead.Text = "Refresh All";
            this.ButtonSysbotRead.UseVisualStyleBackColor = true;
            this.ButtonSysbotRead.Click += new System.EventHandler(this.ButtonSysbotRead_Click);
            // 
            // TabSysBot4Log
            // 
            this.TabSysBot4Log.AccessibleName = "TabSysBot4Log";
            this.TabSysBot4Log.Controls.Add(this.SysBotLog);
            this.TabSysBot4Log.Location = new System.Drawing.Point(4, 22);
            this.TabSysBot4Log.Name = "TabSysBot4Log";
            this.TabSysBot4Log.Padding = new System.Windows.Forms.Padding(3);
            this.TabSysBot4Log.Size = new System.Drawing.Size(532, 405);
            this.TabSysBot4Log.TabIndex = 3;
            this.TabSysBot4Log.Text = "Log";
            this.TabSysBot4Log.UseVisualStyleBackColor = true;
            // 
            // SysBotLog
            // 
            this.SysBotLog.AccessibleName = "SysBotLog";
            this.SysBotLog.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SysBotLog.Location = new System.Drawing.Point(6, 6);
            this.SysBotLog.Name = "SysBotLog";
            this.SysBotLog.Size = new System.Drawing.Size(521, 399);
            this.SysBotLog.TabIndex = 5;
            this.SysBotLog.Text = "Started application.";
            // 
            // SysBotTabControl
            // 
            this.SysBotTabControl.AccessibleName = "SysBotTabControl";
            this.SysBotTabControl.Controls.Add(this.SysBotGeneral);
            this.SysBotTabControl.Controls.Add(this.TabSysBot4Log);
            this.SysBotTabControl.Location = new System.Drawing.Point(2, 3);
            this.SysBotTabControl.Name = "SysBotTabControl";
            this.SysBotTabControl.SelectedIndex = 0;
            this.SysBotTabControl.Size = new System.Drawing.Size(540, 431);
            this.SysBotTabControl.TabIndex = 0;
            // 
            // SysBotGeneral
            // 
            this.SysBotGeneral.AccessibleName = "SysBotGeneral";
            this.SysBotGeneral.Controls.Add(this.TeamGroupBox);
            this.SysBotGeneral.Location = new System.Drawing.Point(4, 22);
            this.SysBotGeneral.Name = "SysBotGeneral";
            this.SysBotGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.SysBotGeneral.Size = new System.Drawing.Size(532, 405);
            this.SysBotGeneral.TabIndex = 4;
            this.SysBotGeneral.Text = "General";
            this.SysBotGeneral.UseVisualStyleBackColor = true;
            // 
            // TeamGroupBox
            // 
            this.TeamGroupBox.AccessibleName = "TeamGroupBox";
            this.TeamGroupBox.Controls.Add(this.PointsTotalNumeric);
            this.TeamGroupBox.Controls.Add(this.TotalPointsLabel);
            this.TeamGroupBox.Location = new System.Drawing.Point(313, 6);
            this.TeamGroupBox.Name = "TeamGroupBox";
            this.TeamGroupBox.Size = new System.Drawing.Size(213, 125);
            this.TeamGroupBox.TabIndex = 2;
            this.TeamGroupBox.TabStop = false;
            this.TeamGroupBox.Text = "Rescue Team";
            // 
            // PointsTotalNumeric
            // 
            this.PointsTotalNumeric.AccessibleName = "PointsTotalNumeric";
            this.PointsTotalNumeric.Enabled = false;
            this.PointsTotalNumeric.Location = new System.Drawing.Point(87, 99);
            this.PointsTotalNumeric.Name = "PointsTotalNumeric";
            this.PointsTotalNumeric.Size = new System.Drawing.Size(120, 20);
            this.PointsTotalNumeric.TabIndex = 0;
            this.PointsTotalNumeric.ValueChanged += new System.EventHandler(this.PointsTotalNumeric_ValueChanged);
            // 
            // TotalPointsLabel
            // 
            this.TotalPointsLabel.AccessibleName = "TotalPointsLabel";
            this.TotalPointsLabel.AutoSize = true;
            this.TotalPointsLabel.Location = new System.Drawing.Point(10, 101);
            this.TotalPointsLabel.Name = "TotalPointsLabel";
            this.TotalPointsLabel.Size = new System.Drawing.Size(66, 13);
            this.TotalPointsLabel.TabIndex = 1;
            this.TotalPointsLabel.Text = "Points Total:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 562);
            this.Controls.Add(this.SysBotTabControl);
            this.Controls.Add(this.GroupSysBotStatus);
            this.Controls.Add(this.GroupSysBotConnection);
            this.Icon = global::PMDDhaX.WinForms.Properties.Resources.icon;
            this.Name = "Main";
            this.Text = "PMDDhaX";
            this.Load += new System.EventHandler(this.SysBotUI_Load);
            this.GroupSysBotConnection.ResumeLayout(false);
            this.GroupSysBotConnection.PerformLayout();
            this.GroupSysBotStatus.ResumeLayout(false);
            this.GroupSysBotStatus.PerformLayout();
            this.TabSysBot4Log.ResumeLayout(false);
            this.SysBotTabControl.ResumeLayout(false);
            this.SysBotGeneral.ResumeLayout(false);
            this.TeamGroupBox.ResumeLayout(false);
            this.TeamGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PointsTotalNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxIP;
        private System.Windows.Forms.Button ButtonConnect;
        private System.Windows.Forms.GroupBox GroupSysBotConnection;
        private System.Windows.Forms.Label LabelPort;
        private System.Windows.Forms.Label LabelIP;
        private System.Windows.Forms.TextBox TextBoxPort;
        private System.Windows.Forms.GroupBox GroupSysBotStatus;
        private System.Windows.Forms.Button ButtonSysbotRead;
        private System.Windows.Forms.Label StatusConnection;
        private System.Windows.Forms.Label StatusConnectionLabel;
        private System.Windows.Forms.TabPage TabSysBot4Log;
        private System.Windows.Forms.RichTextBox SysBotLog;
        private System.Windows.Forms.TabControl SysBotTabControl;
        private System.Windows.Forms.TabPage SysBotGeneral;
        private System.Windows.Forms.GroupBox TeamGroupBox;
        private System.Windows.Forms.NumericUpDown PointsTotalNumeric;
        private System.Windows.Forms.Label TotalPointsLabel;
    }
}