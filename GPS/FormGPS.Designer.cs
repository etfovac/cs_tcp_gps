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
            this.Stop = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
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
            this.LastMessage = new System.Windows.Forms.TextBox();
            this.COG = new System.Windows.Forms.Label();
            this.lbCOG = new System.Windows.Forms.Label();
            this.SOG = new System.Windows.Forms.Label();
            this.lbSOG = new System.Windows.Forms.Label();
            this.VTG = new System.Windows.Forms.GroupBox();
            this.IPConfig = new System.Windows.Forms.GroupBox();
            this.Connect = new System.Windows.Forms.Button();
            this.Port = new System.Windows.Forms.NumericUpDown();
            this.IPAddress = new System.Windows.Forms.TextBox();
            this.Stream = new System.Windows.Forms.GroupBox();
            this.IPA_label = new System.Windows.Forms.Label();
            this.Port_label = new System.Windows.Forms.Label();
            this.GGA_WGS84.SuspendLayout();
            this.VTG.SuspendLayout();
            this.IPConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Port)).BeginInit();
            this.Stream.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimerGPS
            // 
            this.TimerGPS.Interval = 1;
            this.TimerGPS.Tick += new System.EventHandler(this.TimerGPS_Tick);
            // 
            // Stop
            // 
            this.Stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop.Location = new System.Drawing.Point(6, 81);
            this.Stop.Margin = new System.Windows.Forms.Padding(4);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(159, 28);
            this.Stop.TabIndex = 2;
            this.Stop.Text = "Stop";
            this.Stop.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Start
            // 
            this.Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(7, 22);
            this.Start.Margin = new System.Windows.Forms.Padding(4);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(159, 28);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // lbuMSL
            // 
            this.lbuMSL.AutoSize = true;
            this.lbuMSL.Location = new System.Drawing.Point(275, 174);
            this.lbuMSL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbuMSL.Name = "lbuMSL";
            this.lbuMSL.Size = new System.Drawing.Size(13, 17);
            this.lbuMSL.TabIndex = 20;
            this.lbuMSL.Text = "-";
            // 
            // DateTime
            // 
            this.DateTime.AutoSize = true;
            this.DateTime.Location = new System.Drawing.Point(71, 52);
            this.DateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(105, 17);
            this.DateTime.TabIndex = 14;
            this.DateTime.Text = "Date and Time:";
            // 
            // lbHeight
            // 
            this.lbHeight.AutoSize = true;
            this.lbHeight.Location = new System.Drawing.Point(223, 174);
            this.lbHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHeight.Name = "lbHeight";
            this.lbHeight.Size = new System.Drawing.Size(28, 17);
            this.lbHeight.TabIndex = 13;
            this.lbHeight.Text = "----";
            // 
            // NumOfSatellites
            // 
            this.NumOfSatellites.AutoSize = true;
            this.NumOfSatellites.Location = new System.Drawing.Point(55, 217);
            this.NumOfSatellites.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumOfSatellites.Name = "NumOfSatellites";
            this.NumOfSatellites.Size = new System.Drawing.Size(121, 17);
            this.NumOfSatellites.TabIndex = 15;
            this.NumOfSatellites.Text = "Num Of Satellites:";
            // 
            // Altitude
            // 
            this.Altitude.AutoSize = true;
            this.Altitude.Location = new System.Drawing.Point(20, 174);
            this.Altitude.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Altitude.Name = "Altitude";
            this.Altitude.Size = new System.Drawing.Size(156, 17);
            this.Altitude.TabIndex = 12;
            this.Altitude.Text = "Mean Sea Level (MSL):";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(223, 52);
            this.lbTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(58, 17);
            this.lbTime.TabIndex = 16;
            this.lbTime.Text = "- -:- -:- -";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(27, 296);
            this.Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(149, 17);
            this.Status.TabIndex = 11;
            this.Status.Text = "GGA Quality Indicator:";
            // 
            // lbNoSV
            // 
            this.lbNoSV.AutoSize = true;
            this.lbNoSV.Location = new System.Drawing.Point(197, 217);
            this.lbNoSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNoSV.Name = "lbNoSV";
            this.lbNoSV.Size = new System.Drawing.Size(22, 17);
            this.lbNoSV.TabIndex = 17;
            this.lbNoSV.Text = "- -";
            // 
            // lbFix
            // 
            this.lbFix.AutoSize = true;
            this.lbFix.Location = new System.Drawing.Point(197, 296);
            this.lbFix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFix.Name = "lbFix";
            this.lbFix.Size = new System.Drawing.Size(28, 17);
            this.lbFix.TabIndex = 10;
            this.lbFix.Text = "----";
            // 
            // HDOP
            // 
            this.HDOP.AutoSize = true;
            this.HDOP.Location = new System.Drawing.Point(124, 258);
            this.HDOP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HDOP.Name = "HDOP";
            this.HDOP.Size = new System.Drawing.Size(52, 17);
            this.HDOP.TabIndex = 18;
            this.HDOP.Text = "HDOP:";
            // 
            // lbEasting
            // 
            this.lbEasting.AutoSize = true;
            this.lbEasting.Location = new System.Drawing.Point(179, 129);
            this.lbEasting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEasting.Name = "lbEasting";
            this.lbEasting.Size = new System.Drawing.Size(28, 17);
            this.lbEasting.TabIndex = 9;
            this.lbEasting.Text = "----";
            // 
            // lbHDOP
            // 
            this.lbHDOP.AutoSize = true;
            this.lbHDOP.Location = new System.Drawing.Point(197, 258);
            this.lbHDOP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHDOP.Name = "lbHDOP";
            this.lbHDOP.Size = new System.Drawing.Size(22, 17);
            this.lbHDOP.TabIndex = 19;
            this.lbHDOP.Text = "- -";
            // 
            // lbNorthing
            // 
            this.lbNorthing.AutoSize = true;
            this.lbNorthing.Location = new System.Drawing.Point(179, 86);
            this.lbNorthing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNorthing.Name = "lbNorthing";
            this.lbNorthing.Size = new System.Drawing.Size(28, 17);
            this.lbNorthing.TabIndex = 8;
            this.lbNorthing.Text = "----";
            // 
            // Meridian
            // 
            this.Meridian.AutoSize = true;
            this.Meridian.Location = new System.Drawing.Point(8, 129);
            this.Meridian.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Meridian.Name = "Meridian";
            this.Meridian.Size = new System.Drawing.Size(170, 17);
            this.Meridian.TabIndex = 7;
            this.Meridian.Text = "Meridian (geo. longitude):";
            // 
            // Parallel
            // 
            this.Parallel.AutoSize = true;
            this.Parallel.Location = new System.Drawing.Point(25, 86);
            this.Parallel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Parallel.Name = "Parallel";
            this.Parallel.Size = new System.Drawing.Size(151, 17);
            this.Parallel.TabIndex = 6;
            this.Parallel.Text = "Parallel (geo. latitude):";
            // 
            // lbLongitude
            // 
            this.lbLongitude.AutoSize = true;
            this.lbLongitude.Location = new System.Drawing.Point(223, 129);
            this.lbLongitude.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLongitude.Name = "lbLongitude";
            this.lbLongitude.Size = new System.Drawing.Size(40, 17);
            this.lbLongitude.TabIndex = 5;
            this.lbLongitude.Text = "- -.- -";
            // 
            // lbLatitude
            // 
            this.lbLatitude.AutoSize = true;
            this.lbLatitude.Location = new System.Drawing.Point(223, 86);
            this.lbLatitude.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLatitude.Name = "lbLatitude";
            this.lbLatitude.Size = new System.Drawing.Size(40, 17);
            this.lbLatitude.TabIndex = 4;
            this.lbLatitude.Text = "- -.- -";
            // 
            // GGA_WGS84
            // 
            this.GGA_WGS84.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
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
            this.GGA_WGS84.Location = new System.Drawing.Point(5, 5);
            this.GGA_WGS84.Margin = new System.Windows.Forms.Padding(4);
            this.GGA_WGS84.Name = "GGA_WGS84";
            this.GGA_WGS84.Padding = new System.Windows.Forms.Padding(4);
            this.GGA_WGS84.Size = new System.Drawing.Size(413, 326);
            this.GGA_WGS84.TabIndex = 24;
            this.GGA_WGS84.TabStop = false;
            this.GGA_WGS84.Text = "GGA message, WGS84 standard";
            // 
            // ReceivedStream
            // 
            this.ReceivedStream.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReceivedStream.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ReceivedStream.Location = new System.Drawing.Point(425, 2);
            this.ReceivedStream.Margin = new System.Windows.Forms.Padding(4);
            this.ReceivedStream.Name = "ReceivedStream";
            this.ReceivedStream.ReadOnly = true;
            this.ReceivedStream.Size = new System.Drawing.Size(458, 531);
            this.ReceivedStream.TabIndex = 25;
            this.ReceivedStream.Text = "";
            // 
            // LastMessage
            // 
            this.LastMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastMessage.Location = new System.Drawing.Point(425, 539);
            this.LastMessage.Margin = new System.Windows.Forms.Padding(4);
            this.LastMessage.Name = "LastMessage";
            this.LastMessage.Size = new System.Drawing.Size(458, 22);
            this.LastMessage.TabIndex = 26;
            // 
            // COG
            // 
            this.COG.AutoSize = true;
            this.COG.Location = new System.Drawing.Point(32, 29);
            this.COG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.COG.Name = "COG";
            this.COG.Size = new System.Drawing.Size(144, 17);
            this.COG.TabIndex = 27;
            this.COG.Text = "Course Over Ground:";
            // 
            // lbCOG
            // 
            this.lbCOG.AutoSize = true;
            this.lbCOG.Location = new System.Drawing.Point(197, 29);
            this.lbCOG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCOG.Name = "lbCOG";
            this.lbCOG.Size = new System.Drawing.Size(32, 17);
            this.lbCOG.TabIndex = 28;
            this.lbCOG.Text = "--.--";
            // 
            // SOG
            // 
            this.SOG.AutoSize = true;
            this.SOG.Location = new System.Drawing.Point(36, 67);
            this.SOG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SOG.Name = "SOG";
            this.SOG.Size = new System.Drawing.Size(140, 17);
            this.SOG.TabIndex = 29;
            this.SOG.Text = "Speed Over Ground:";
            // 
            // lbSOG
            // 
            this.lbSOG.AutoSize = true;
            this.lbSOG.Location = new System.Drawing.Point(197, 67);
            this.lbSOG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSOG.Name = "lbSOG";
            this.lbSOG.Size = new System.Drawing.Size(32, 17);
            this.lbSOG.TabIndex = 30;
            this.lbSOG.Text = "--.--";
            // 
            // VTG
            // 
            this.VTG.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.VTG.Controls.Add(this.COG);
            this.VTG.Controls.Add(this.lbSOG);
            this.VTG.Controls.Add(this.lbCOG);
            this.VTG.Controls.Add(this.SOG);
            this.VTG.Location = new System.Drawing.Point(5, 335);
            this.VTG.Name = "VTG";
            this.VTG.Size = new System.Drawing.Size(413, 100);
            this.VTG.TabIndex = 31;
            this.VTG.TabStop = false;
            this.VTG.Text = "VTG message";
            // 
            // IPConfig
            // 
            this.IPConfig.Controls.Add(this.Port_label);
            this.IPConfig.Controls.Add(this.IPA_label);
            this.IPConfig.Controls.Add(this.Connect);
            this.IPConfig.Controls.Add(this.Port);
            this.IPConfig.Controls.Add(this.IPAddress);
            this.IPConfig.Location = new System.Drawing.Point(5, 450);
            this.IPConfig.Name = "IPConfig";
            this.IPConfig.Size = new System.Drawing.Size(189, 116);
            this.IPConfig.TabIndex = 32;
            this.IPConfig.TabStop = false;
            this.IPConfig.Text = "IP Config";
            // 
            // Connect
            // 
            this.Connect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connect.Location = new System.Drawing.Point(6, 83);
            this.Connect.Margin = new System.Windows.Forms.Padding(4);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(170, 28);
            this.Connect.TabIndex = 5;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(87, 44);
            this.Port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Port.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(91, 22);
            this.Port.TabIndex = 4;
            this.Port.Tag = "TCP";
            this.Port.Value = new decimal(new int[] {
            5555,
            0,
            0,
            0});
            this.Port.ValueChanged += new System.EventHandler(this.Port_ValueChanged);
            // 
            // IPAddress
            // 
            this.IPAddress.Location = new System.Drawing.Point(87, 18);
            this.IPAddress.Name = "IPAddress";
            this.IPAddress.Size = new System.Drawing.Size(91, 22);
            this.IPAddress.TabIndex = 3;
            this.IPAddress.Text = "127.0.0.1";
            this.IPAddress.KeyUp += new System.Windows.Forms.KeyEventHandler(this.IPAddress_KeyUp);
            // 
            // Stream
            // 
            this.Stream.Controls.Add(this.Start);
            this.Stream.Controls.Add(this.Stop);
            this.Stream.Location = new System.Drawing.Point(246, 452);
            this.Stream.Name = "Stream";
            this.Stream.Size = new System.Drawing.Size(172, 114);
            this.Stream.TabIndex = 33;
            this.Stream.TabStop = false;
            this.Stream.Text = "Stream";
            // 
            // IPA_label
            // 
            this.IPA_label.AutoSize = true;
            this.IPA_label.Location = new System.Drawing.Point(8, 21);
            this.IPA_label.Name = "IPA_label";
            this.IPA_label.Size = new System.Drawing.Size(76, 17);
            this.IPA_label.TabIndex = 6;
            this.IPA_label.Text = "IP Address";
            // 
            // Port_label
            // 
            this.Port_label.AutoSize = true;
            this.Port_label.Location = new System.Drawing.Point(19, 44);
            this.Port_label.Name = "Port_label";
            this.Port_label.Size = new System.Drawing.Size(65, 17);
            this.Port_label.TabIndex = 7;
            this.Port_label.Text = "TCP Port";
            // 
            // FormGPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(888, 568);
            this.Controls.Add(this.Stream);
            this.Controls.Add(this.IPConfig);
            this.Controls.Add(this.VTG);
            this.Controls.Add(this.LastMessage);
            this.Controls.Add(this.ReceivedStream);
            this.Controls.Add(this.GGA_WGS84);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormGPS";
            this.Text = "GPS coordinates";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.GGA_WGS84.ResumeLayout(false);
            this.GGA_WGS84.PerformLayout();
            this.VTG.ResumeLayout(false);
            this.VTG.PerformLayout();
            this.IPConfig.ResumeLayout(false);
            this.IPConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Port)).EndInit();
            this.Stream.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TimerGPS;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Start;
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
        private System.Windows.Forms.TextBox LastMessage;
        private System.Windows.Forms.Label COG;
        private System.Windows.Forms.Label lbCOG;
        private System.Windows.Forms.Label SOG;
        private System.Windows.Forms.Label lbSOG;
        private System.Windows.Forms.GroupBox VTG;
        private System.Windows.Forms.GroupBox IPConfig;
        private System.Windows.Forms.TextBox IPAddress;
        private System.Windows.Forms.NumericUpDown Port;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.GroupBox Stream;
        private System.Windows.Forms.Label Port_label;
        private System.Windows.Forms.Label IPA_label;
    }
}

