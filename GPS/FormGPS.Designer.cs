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
            this.timerGPS = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.lbuMSL = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.Vreme = new System.Windows.Forms.Label();
            this.lbHeight = new System.Windows.Forms.Label();
            this.BrSatelita = new System.Windows.Forms.Label();
            this.Visina = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.lbNoSV = new System.Windows.Forms.Label();
            this.lbFix = new System.Windows.Forms.Label();
            this.HDOP = new System.Windows.Forms.Label();
            this.lbEasting = new System.Windows.Forms.Label();
            this.lbHDOP = new System.Windows.Forms.Label();
            this.lbNorthing = new System.Windows.Forms.Label();
            this.Meridijan = new System.Windows.Forms.Label();
            this.Paralela = new System.Windows.Forms.Label();
            this.lbLongitude = new System.Windows.Forms.Label();
            this.lbLatitude = new System.Windows.Forms.Label();
            this.GGA_WGS84 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.COG = new System.Windows.Forms.Label();
            this.lbCOG = new System.Windows.Forms.Label();
            this.SOG = new System.Windows.Forms.Label();
            this.lbSOG = new System.Windows.Forms.Label();
            this.GGA_WGS84.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerGPS
            // 
            this.timerGPS.Interval = 1;
            this.timerGPS.Tick += new System.EventHandler(this.timerGPS_Tick);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(262, 452);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Stani";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // start
            // 
            this.start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(24, 452);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(132, 23);
            this.start.TabIndex = 0;
            this.start.Text = "Čitaj";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbuMSL
            // 
            this.lbuMSL.AutoSize = true;
            this.lbuMSL.Location = new System.Drawing.Point(206, 141);
            this.lbuMSL.Name = "lbuMSL";
            this.lbuMSL.Size = new System.Drawing.Size(10, 13);
            this.lbuMSL.TabIndex = 20;
            this.lbuMSL.Text = "-";
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(0, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 495);
            this.splitter2.TabIndex = 23;
            this.splitter2.TabStop = false;
            // 
            // Vreme
            // 
            this.Vreme.AutoSize = true;
            this.Vreme.Location = new System.Drawing.Point(75, 42);
            this.Vreme.Name = "Vreme";
            this.Vreme.Size = new System.Drawing.Size(78, 13);
            this.Vreme.TabIndex = 14;
            this.Vreme.Text = "Datum i vreme:";
            // 
            // lbHeight
            // 
            this.lbHeight.AutoSize = true;
            this.lbHeight.Location = new System.Drawing.Point(167, 141);
            this.lbHeight.Name = "lbHeight";
            this.lbHeight.Size = new System.Drawing.Size(19, 13);
            this.lbHeight.TabIndex = 13;
            this.lbHeight.Text = "----";
            // 
            // BrSatelita
            // 
            this.BrSatelita.AutoSize = true;
            this.BrSatelita.Location = new System.Drawing.Point(69, 176);
            this.BrSatelita.Name = "BrSatelita";
            this.BrSatelita.Size = new System.Drawing.Size(64, 13);
            this.BrSatelita.TabIndex = 15;
            this.BrSatelita.Text = "Broj satelita:";
            // 
            // Visina
            // 
            this.Visina.AutoSize = true;
            this.Visina.Location = new System.Drawing.Point(12, 141);
            this.Visina.Name = "Visina";
            this.Visina.Size = new System.Drawing.Size(130, 13);
            this.Visina.TabIndex = 12;
            this.Visina.Text = "Nadmorska visina antene:";
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
            this.Status.Location = new System.Drawing.Point(12, 247);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(119, 13);
            this.Status.TabIndex = 11;
            this.Status.Text = "GGA indikator kvaliteta:";
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
            this.lbFix.Location = new System.Drawing.Point(148, 247);
            this.lbFix.Name = "lbFix";
            this.lbFix.Size = new System.Drawing.Size(19, 13);
            this.lbFix.TabIndex = 10;
            this.lbFix.Text = "----";
            // 
            // HDOP
            // 
            this.HDOP.AutoSize = true;
            this.HDOP.Location = new System.Drawing.Point(69, 210);
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
            // Meridijan
            // 
            this.Meridijan.AutoSize = true;
            this.Meridijan.Location = new System.Drawing.Point(12, 105);
            this.Meridijan.Name = "Meridijan";
            this.Meridijan.Size = new System.Drawing.Size(116, 13);
            this.Meridijan.TabIndex = 7;
            this.Meridijan.Text = "Meridijan (geo. dužina):";
            // 
            // Paralela
            // 
            this.Paralela.AutoSize = true;
            this.Paralela.Location = new System.Drawing.Point(23, 70);
            this.Paralela.Name = "Paralela";
            this.Paralela.Size = new System.Drawing.Size(105, 13);
            this.Paralela.TabIndex = 6;
            this.Paralela.Text = "Paralela (geo. širina):";
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
            this.GGA_WGS84.Controls.Add(this.lbLatitude);
            this.GGA_WGS84.Controls.Add(this.lbLongitude);
            this.GGA_WGS84.Controls.Add(this.Paralela);
            this.GGA_WGS84.Controls.Add(this.Meridijan);
            this.GGA_WGS84.Controls.Add(this.lbuMSL);
            this.GGA_WGS84.Controls.Add(this.lbNorthing);
            this.GGA_WGS84.Controls.Add(this.lbHDOP);
            this.GGA_WGS84.Controls.Add(this.lbEasting);
            this.GGA_WGS84.Controls.Add(this.HDOP);
            this.GGA_WGS84.Controls.Add(this.lbFix);
            this.GGA_WGS84.Controls.Add(this.lbNoSV);
            this.GGA_WGS84.Controls.Add(this.Status);
            this.GGA_WGS84.Controls.Add(this.lbTime);
            this.GGA_WGS84.Controls.Add(this.Visina);
            this.GGA_WGS84.Controls.Add(this.BrSatelita);
            this.GGA_WGS84.Controls.Add(this.lbHeight);
            this.GGA_WGS84.Controls.Add(this.Vreme);
            this.GGA_WGS84.Location = new System.Drawing.Point(24, 12);
            this.GGA_WGS84.Name = "GGA_WGS84";
            this.GGA_WGS84.Size = new System.Drawing.Size(357, 277);
            this.GGA_WGS84.TabIndex = 24;
            this.GGA_WGS84.TabStop = false;
            this.GGA_WGS84.Text = "GGA poruke, WGS84 standard";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(404, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(423, 419);
            this.richTextBox1.TabIndex = 25;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(404, 452);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(423, 20);
            this.textBox1.TabIndex = 26;
            // 
            // COG
            // 
            this.COG.AutoSize = true;
            this.COG.Location = new System.Drawing.Point(39, 339);
            this.COG.Name = "COG";
            this.COG.Size = new System.Drawing.Size(107, 13);
            this.COG.TabIndex = 27;
            this.COG.Text = "Course Over Ground:";
            // 
            // lbCOG
            // 
            this.lbCOG.AutoSize = true;
            this.lbCOG.Location = new System.Drawing.Point(172, 339);
            this.lbCOG.Name = "lbCOG";
            this.lbCOG.Size = new System.Drawing.Size(22, 13);
            this.lbCOG.TabIndex = 28;
            this.lbCOG.Text = "--.--";
            // 
            // SOG
            // 
            this.SOG.AutoSize = true;
            this.SOG.Location = new System.Drawing.Point(42, 370);
            this.SOG.Name = "SOG";
            this.SOG.Size = new System.Drawing.Size(105, 13);
            this.SOG.TabIndex = 29;
            this.SOG.Text = "Speed Over Ground:";
            // 
            // lbSOG
            // 
            this.lbSOG.AutoSize = true;
            this.lbSOG.Location = new System.Drawing.Point(172, 370);
            this.lbSOG.Name = "lbSOG";
            this.lbSOG.Size = new System.Drawing.Size(22, 13);
            this.lbSOG.TabIndex = 30;
            this.lbSOG.Text = "--.--";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 495);
            this.Controls.Add(this.lbSOG);
            this.Controls.Add(this.SOG);
            this.Controls.Add(this.lbCOG);
            this.Controls.Add(this.COG);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.GGA_WGS84);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "GPS koordinate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.GGA_WGS84.ResumeLayout(false);
            this.GGA_WGS84.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerGPS;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label lbuMSL;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Label Vreme;
        private System.Windows.Forms.Label lbHeight;
        private System.Windows.Forms.Label BrSatelita;
        private System.Windows.Forms.Label Visina;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label lbNoSV;
        private System.Windows.Forms.Label lbFix;
        private System.Windows.Forms.Label HDOP;
        private System.Windows.Forms.Label lbEasting;
        private System.Windows.Forms.Label lbHDOP;
        private System.Windows.Forms.Label lbNorthing;
        private System.Windows.Forms.Label Meridijan;
        private System.Windows.Forms.Label Paralela;
        private System.Windows.Forms.Label lbLongitude;
        private System.Windows.Forms.Label lbLatitude;
        private System.Windows.Forms.GroupBox GGA_WGS84;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label COG;
        private System.Windows.Forms.Label lbCOG;
        private System.Windows.Forms.Label SOG;
        private System.Windows.Forms.Label lbSOG;
    }
}

