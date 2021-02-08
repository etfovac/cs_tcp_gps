namespace GPS
{
    partial class FormGPS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGPS));
            this.TimerGPS = new System.Windows.Forms.Timer(this.components);
            this.lbuMSL = new System.Windows.Forms.Label();
            this.DateTime = new System.Windows.Forms.Label();
            this.lbHeight = new System.Windows.Forms.Label();
            this.NumOfSatellites = new System.Windows.Forms.Label();
            this.Altitude = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.lbNoSV = new System.Windows.Forms.Label();
            this.lbFix = new System.Windows.Forms.Label();
            this.HDOP = new System.Windows.Forms.Label();
            this.lbEasting = new System.Windows.Forms.Label();
            this.lbHDOP = new System.Windows.Forms.Label();
            this.lbNorthing = new System.Windows.Forms.Label();
            this.Meridian = new System.Windows.Forms.Label();
            this.Parallel = new System.Windows.Forms.Label();
            this.lbLongitude = new System.Windows.Forms.Label();
            this.lbLatitude = new System.Windows.Forms.Label();
            this.GGA_WGS84 = new System.Windows.Forms.GroupBox();
            this.ReceivedStream = new System.Windows.Forms.RichTextBox();
            this.COG = new System.Windows.Forms.Label();
            this.lbCOG = new System.Windows.Forms.Label();
            this.SOG = new System.Windows.Forms.Label();
            this.lbSOG = new System.Windows.Forms.Label();
            this.VTG = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IpAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IP_ToolStripMenuItem = new System.Windows.Forms.ToolStripTextBox();
            this.TcpPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TCP_ToolStripMenuItem = new System.Windows.Forms.ToolStripTextBox();
            this.reConnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nMEAGGAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nMEAVTGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.GGA_WGS84.SuspendLayout();
            this.VTG.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimerGPS
            // 
            this.TimerGPS.Interval = 1;
            this.TimerGPS.Tick += new System.EventHandler(this.TimerGPS_Tick);
            // 
            // lbuMSL
            // 
            this.lbuMSL.AutoSize = true;
            this.lbuMSL.Location = new System.Drawing.Point(188, 141);
            this.lbuMSL.Name = "lbuMSL";
            this.lbuMSL.Size = new System.Drawing.Size(10, 13);
            this.lbuMSL.TabIndex = 20;
            this.lbuMSL.Text = "-";
            // 
            // DateTime
            // 
            this.DateTime.AutoSize = true;
            this.DateTime.Location = new System.Drawing.Point(53, 42);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(80, 13);
            this.DateTime.TabIndex = 14;
            this.DateTime.Text = "Date and Time:";
            // 
            // lbHeight
            // 
            this.lbHeight.AutoSize = true;
            this.lbHeight.Location = new System.Drawing.Point(148, 141);
            this.lbHeight.Name = "lbHeight";
            this.lbHeight.Size = new System.Drawing.Size(19, 13);
            this.lbHeight.TabIndex = 13;
            this.lbHeight.Text = "----";
            // 
            // NumOfSatellites
            // 
            this.NumOfSatellites.AutoSize = true;
            this.NumOfSatellites.Location = new System.Drawing.Point(41, 176);
            this.NumOfSatellites.Name = "NumOfSatellites";
            this.NumOfSatellites.Size = new System.Drawing.Size(91, 13);
            this.NumOfSatellites.TabIndex = 15;
            this.NumOfSatellites.Text = "Num Of Satellites:";
            // 
            // Altitude
            // 
            this.Altitude.AutoSize = true;
            this.Altitude.Location = new System.Drawing.Point(15, 141);
            this.Altitude.Name = "Altitude";
            this.Altitude.Size = new System.Drawing.Size(119, 13);
            this.Altitude.TabIndex = 12;
            this.Altitude.Text = "Mean Sea Level (MSL):";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(167, 42);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(40, 13);
            this.lbTime.TabIndex = 16;
            this.lbTime.Text = "- -:- -:- -";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(20, 240);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(112, 13);
            this.Status.TabIndex = 11;
            this.Status.Text = "GGA Quality Indicator:";
            // 
            // lbNoSV
            // 
            this.lbNoSV.AutoSize = true;
            this.lbNoSV.Location = new System.Drawing.Point(148, 176);
            this.lbNoSV.Name = "lbNoSV";
            this.lbNoSV.Size = new System.Drawing.Size(16, 13);
            this.lbNoSV.TabIndex = 17;
            this.lbNoSV.Text = "- -";
            // 
            // lbFix
            // 
            this.lbFix.AutoSize = true;
            this.lbFix.Location = new System.Drawing.Point(148, 240);
            this.lbFix.Name = "lbFix";
            this.lbFix.Size = new System.Drawing.Size(19, 13);
            this.lbFix.TabIndex = 10;
            this.lbFix.Text = "----";
            // 
            // HDOP
            // 
            this.HDOP.AutoSize = true;
            this.HDOP.Location = new System.Drawing.Point(93, 210);
            this.HDOP.Name = "HDOP";
            this.HDOP.Size = new System.Drawing.Size(41, 13);
            this.HDOP.TabIndex = 18;
            this.HDOP.Text = "HDOP:";
            // 
            // lbEasting
            // 
            this.lbEasting.AutoSize = true;
            this.lbEasting.Location = new System.Drawing.Point(134, 105);
            this.lbEasting.Name = "lbEasting";
            this.lbEasting.Size = new System.Drawing.Size(19, 13);
            this.lbEasting.TabIndex = 9;
            this.lbEasting.Text = "----";
            // 
            // lbHDOP
            // 
            this.lbHDOP.AutoSize = true;
            this.lbHDOP.Location = new System.Drawing.Point(148, 210);
            this.lbHDOP.Name = "lbHDOP";
            this.lbHDOP.Size = new System.Drawing.Size(16, 13);
            this.lbHDOP.TabIndex = 19;
            this.lbHDOP.Text = "- -";
            // 
            // lbNorthing
            // 
            this.lbNorthing.AutoSize = true;
            this.lbNorthing.Location = new System.Drawing.Point(134, 70);
            this.lbNorthing.Name = "lbNorthing";
            this.lbNorthing.Size = new System.Drawing.Size(19, 13);
            this.lbNorthing.TabIndex = 8;
            this.lbNorthing.Text = "----";
            // 
            // Meridian
            // 
            this.Meridian.AutoSize = true;
            this.Meridian.Location = new System.Drawing.Point(6, 105);
            this.Meridian.Name = "Meridian";
            this.Meridian.Size = new System.Drawing.Size(126, 13);
            this.Meridian.TabIndex = 7;
            this.Meridian.Text = "Meridian (geo. longitude):";
            // 
            // Parallel
            // 
            this.Parallel.AutoSize = true;
            this.Parallel.Location = new System.Drawing.Point(19, 70);
            this.Parallel.Name = "Parallel";
            this.Parallel.Size = new System.Drawing.Size(111, 13);
            this.Parallel.TabIndex = 6;
            this.Parallel.Text = "Parallel (geo. latitude):";
            // 
            // lbLongitude
            // 
            this.lbLongitude.AutoSize = true;
            this.lbLongitude.Location = new System.Drawing.Point(167, 105);
            this.lbLongitude.Name = "lbLongitude";
            this.lbLongitude.Size = new System.Drawing.Size(28, 13);
            this.lbLongitude.TabIndex = 5;
            this.lbLongitude.Text = "- -.- -";
            // 
            // lbLatitude
            // 
            this.lbLatitude.AutoSize = true;
            this.lbLatitude.Location = new System.Drawing.Point(167, 70);
            this.lbLatitude.Name = "lbLatitude";
            this.lbLatitude.Size = new System.Drawing.Size(28, 13);
            this.lbLatitude.TabIndex = 4;
            this.lbLatitude.Text = "- -.- -";
            // 
            // GGA_WGS84
            // 
            this.GGA_WGS84.BackColor = System.Drawing.Color.Black;
            this.GGA_WGS84.Controls.Add(this.lbLatitude);
            this.GGA_WGS84.Controls.Add(this.lbLongitude);
            this.GGA_WGS84.Controls.Add(this.Parallel);
            this.GGA_WGS84.Controls.Add(this.Meridian);
            this.GGA_WGS84.Controls.Add(this.lbuMSL);
            this.GGA_WGS84.Controls.Add(this.lbNorthing);
            this.GGA_WGS84.Controls.Add(this.lbHDOP);
            this.GGA_WGS84.Controls.Add(this.lbEasting);
            this.GGA_WGS84.Controls.Add(this.HDOP);
            this.GGA_WGS84.Controls.Add(this.lbFix);
            this.GGA_WGS84.Controls.Add(this.lbNoSV);
            this.GGA_WGS84.Controls.Add(this.Status);
            this.GGA_WGS84.Controls.Add(this.lbTime);
            this.GGA_WGS84.Controls.Add(this.Altitude);
            this.GGA_WGS84.Controls.Add(this.NumOfSatellites);
            this.GGA_WGS84.Controls.Add(this.lbHeight);
            this.GGA_WGS84.Controls.Add(this.DateTime);
            this.GGA_WGS84.ForeColor = System.Drawing.SystemColors.Control;
            this.GGA_WGS84.Location = new System.Drawing.Point(4, 27);
            this.GGA_WGS84.Name = "GGA_WGS84";
            this.GGA_WGS84.Size = new System.Drawing.Size(310, 265);
            this.GGA_WGS84.TabIndex = 24;
            this.GGA_WGS84.TabStop = false;
            this.GGA_WGS84.Text = "GGA message, WGS84 standard";
            // 
            // ReceivedStream
            // 
            this.ReceivedStream.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReceivedStream.BackColor = System.Drawing.Color.Black;
            this.ReceivedStream.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReceivedStream.ForeColor = System.Drawing.SystemColors.Info;
            this.ReceivedStream.Location = new System.Drawing.Point(319, 27);
            this.ReceivedStream.Name = "ReceivedStream";
            this.ReceivedStream.ReadOnly = true;
            this.ReceivedStream.Size = new System.Drawing.Size(342, 347);
            this.ReceivedStream.TabIndex = 25;
            this.ReceivedStream.Text = "";
            // 
            // COG
            // 
            this.COG.AutoSize = true;
            this.COG.Location = new System.Drawing.Point(24, 24);
            this.COG.Name = "COG";
            this.COG.Size = new System.Drawing.Size(107, 13);
            this.COG.TabIndex = 27;
            this.COG.Text = "Course Over Ground:";
            // 
            // lbCOG
            // 
            this.lbCOG.AutoSize = true;
            this.lbCOG.Location = new System.Drawing.Point(148, 24);
            this.lbCOG.Name = "lbCOG";
            this.lbCOG.Size = new System.Drawing.Size(22, 13);
            this.lbCOG.TabIndex = 28;
            this.lbCOG.Text = "--.--";
            // 
            // SOG
            // 
            this.SOG.AutoSize = true;
            this.SOG.Location = new System.Drawing.Point(27, 54);
            this.SOG.Name = "SOG";
            this.SOG.Size = new System.Drawing.Size(105, 13);
            this.SOG.TabIndex = 29;
            this.SOG.Text = "Speed Over Ground:";
            // 
            // lbSOG
            // 
            this.lbSOG.AutoSize = true;
            this.lbSOG.Location = new System.Drawing.Point(148, 54);
            this.lbSOG.Name = "lbSOG";
            this.lbSOG.Size = new System.Drawing.Size(22, 13);
            this.lbSOG.TabIndex = 30;
            this.lbSOG.Text = "--.--";
            // 
            // VTG
            // 
            this.VTG.BackColor = System.Drawing.Color.Black;
            this.VTG.Controls.Add(this.COG);
            this.VTG.Controls.Add(this.lbSOG);
            this.VTG.Controls.Add(this.lbCOG);
            this.VTG.Controls.Add(this.SOG);
            this.VTG.ForeColor = System.Drawing.SystemColors.Control;
            this.VTG.Location = new System.Drawing.Point(4, 295);
            this.VTG.Margin = new System.Windows.Forms.Padding(2);
            this.VTG.Name = "VTG";
            this.VTG.Padding = new System.Windows.Forms.Padding(2);
            this.VTG.Size = new System.Drawing.Size(310, 81);
            this.VTG.TabIndex = 31;
            this.VTG.TabStop = false;
            this.VTG.Text = "VTG message";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem,
            this.parseToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(664, 24);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IpAddressToolStripMenuItem,
            this.TcpPortToolStripMenuItem,
            this.reConnectToolStripMenuItem});
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.connectionToolStripMenuItem.Text = "Connection";
            // 
            // IpAddressToolStripMenuItem
            // 
            this.IpAddressToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IP_ToolStripMenuItem});
            this.IpAddressToolStripMenuItem.Name = "IpAddressToolStripMenuItem";
            this.IpAddressToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.IpAddressToolStripMenuItem.Text = "IP address";
            // 
            // IP_ToolStripMenuItem
            // 
            this.IP_ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IP_ToolStripMenuItem.Name = "IP_ToolStripMenuItem";
            this.IP_ToolStripMenuItem.Size = new System.Drawing.Size(180, 23);
            this.IP_ToolStripMenuItem.Text = "192.168.0.19";
            // 
            // TcpPortToolStripMenuItem
            // 
            this.TcpPortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TCP_ToolStripMenuItem});
            this.TcpPortToolStripMenuItem.Name = "TcpPortToolStripMenuItem";
            this.TcpPortToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.TcpPortToolStripMenuItem.Text = "TCP port";
            // 
            // TCP_ToolStripMenuItem
            // 
            this.TCP_ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TCP_ToolStripMenuItem.Name = "TCP_ToolStripMenuItem";
            this.TCP_ToolStripMenuItem.Size = new System.Drawing.Size(180, 23);
            this.TCP_ToolStripMenuItem.Text = "6000";
            // 
            // reConnectToolStripMenuItem
            // 
            this.reConnectToolStripMenuItem.Name = "reConnectToolStripMenuItem";
            this.reConnectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reConnectToolStripMenuItem.Text = "Connect";
            this.reConnectToolStripMenuItem.Click += new System.EventHandler(this.Connect_Click);
            // 
            // parseToolStripMenuItem
            // 
            this.parseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartToolStripMenuItem,
            this.nMEAGGAToolStripMenuItem,
            this.nMEAVTGToolStripMenuItem});
            this.parseToolStripMenuItem.Name = "parseToolStripMenuItem";
            this.parseToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.parseToolStripMenuItem.Text = "Parse";
            this.parseToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.Start_Click);
            // 
            // StartToolStripMenuItem
            // 
            this.StartToolStripMenuItem.Name = "StartToolStripMenuItem";
            this.StartToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.StartToolStripMenuItem.Text = "Start";
            this.StartToolStripMenuItem.Click += new System.EventHandler(this.Start_Click);
            // 
            // nMEAGGAToolStripMenuItem
            // 
            this.nMEAGGAToolStripMenuItem.Checked = true;
            this.nMEAGGAToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.nMEAGGAToolStripMenuItem.Enabled = false;
            this.nMEAGGAToolStripMenuItem.Name = "nMEAGGAToolStripMenuItem";
            this.nMEAGGAToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.nMEAGGAToolStripMenuItem.Text = "NMEA GGA";
            // 
            // nMEAVTGToolStripMenuItem
            // 
            this.nMEAVTGToolStripMenuItem.Checked = true;
            this.nMEAVTGToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.nMEAVTGToolStripMenuItem.Enabled = false;
            this.nMEAVTGToolStripMenuItem.Name = "nMEAVTGToolStripMenuItem";
            this.nMEAVTGToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.nMEAVTGToolStripMenuItem.Text = "NMEA VTG";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 379);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(664, 22);
            this.statusStrip1.TabIndex = 35;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.Info;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.MarqueeAnimationSpeed = 10;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Step = 1;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ForeColor = System.Drawing.SystemColors.Info;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // FormGPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(664, 401);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.VTG);
            this.Controls.Add(this.ReceivedStream);
            this.Controls.Add(this.GGA_WGS84);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormGPS";
            this.Text = "GPS Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.GGA_WGS84.ResumeLayout(false);
            this.GGA_WGS84.PerformLayout();
            this.VTG.ResumeLayout(false);
            this.VTG.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TimerGPS;
        private System.Windows.Forms.Label lbuMSL;
        private System.Windows.Forms.Label DateTime;
        private System.Windows.Forms.Label lbHeight;
        private System.Windows.Forms.Label NumOfSatellites;
        private System.Windows.Forms.Label Altitude;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label lbNoSV;
        private System.Windows.Forms.Label lbFix;
        private System.Windows.Forms.Label HDOP;
        private System.Windows.Forms.Label lbEasting;
        private System.Windows.Forms.Label lbHDOP;
        private System.Windows.Forms.Label lbNorthing;
        private System.Windows.Forms.Label Meridian;
        private System.Windows.Forms.Label Parallel;
        private System.Windows.Forms.Label lbLongitude;
        private System.Windows.Forms.Label lbLatitude;
        private System.Windows.Forms.GroupBox GGA_WGS84;
        private System.Windows.Forms.RichTextBox ReceivedStream;
        private System.Windows.Forms.Label COG;
        private System.Windows.Forms.Label lbCOG;
        private System.Windows.Forms.Label SOG;
        private System.Windows.Forms.Label lbSOG;
        private System.Windows.Forms.GroupBox VTG;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IpAddressToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox IP_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TcpPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox TCP_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reConnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nMEAGGAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nMEAVTGToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

