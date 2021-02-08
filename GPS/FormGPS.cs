using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net.Sockets;
using NMEA;
using System.Net;

namespace GPS
{
    public partial class FormGPS : Form
    {
        private NetworkStream streamGPS;
        private TcpClient gpstcp;
        private string message = string.Empty;
        int RecBufferSize = 0;
        int Bps = 2 * 9600 / 8; //1200*2 bytes per sec
        double RecBufferFracFull = 0;

        public FormGPS()
        {
            InitializeComponent();
            MinimumSize = new Size(680,440);

            IP_ToolStripMenuItem.Width = 60;
            TCP_ToolStripMenuItem.Width = 40;
            aboutToolStripMenuItem.Width = 50;

            StartToolStripMenuItem.Enabled = false;

            toolStripStatusLabel1.Text = "Not connected";
            toolStripStatusLabel1.BackColor = Color.Transparent;
            toolStripStatusLabel1.ForeColor = Color.Black;

            toolStripStatusLabel2.Text = "";
            toolStripStatusLabel2.BackColor = Color.Transparent;
            toolStripStatusLabel2.ForeColor = Color.Black;

        }

        private void TimerGPS_Tick(object sender, EventArgs e)
        {
            RecBufferFracFull = 100.0 * gpstcp.Available / RecBufferSize;
            toolStripProgressBar1.Value = Convert.ToInt32(RecBufferFracFull);

            if (streamGPS != null && streamGPS.CanRead && streamGPS.DataAvailable)
            {
                toolStripStatusLabel1.Text = string.Format("Connected. Buffer @ {0:N2}%.", RecBufferFracFull);
                byte[] ByteRd = { (byte)streamGPS.ReadByte() };
                if (Encoding.ASCII.GetString(ByteRd) == "$" && message.Length > 6) // $ + GP + GGA|RMC|VTG...
                {
                    ReceivedStream.AppendText(message);
                    Parse(message);
                    message = Encoding.ASCII.GetString(ByteRd); //"$"
                }
                else
                {
                    if (message.StartsWith("$") || message == string.Empty)
                    {
                        message += Encoding.ASCII.GetString(ByteRd);
                        toolStripStatusLabel2.Text = message;
                    }
                    else
                    {
                        message = string.Empty;
                    }
                    
                }
            }
            else
            {
                toolStripStatusLabel1.Text = "No data available.";
            }
        }

        private string GetParameterStr(NMEAStandardSentence sentence, int index)
        {
            string param;
            if (sentence.parameters[index] != null)
                param = sentence.parameters[index].ToString();
            else
                param = string.Empty;
            return param;
        }

        private void Parse(string stringToParse)
        {
            // It receives all the messages
            //string stringToParse = message;

            NMEASentence parsedSentence = NMEAParser.Parse(stringToParse);
	        if (parsedSentence is NMEAStandardSentence)
	        {
		        NMEAStandardSentence sentence = (parsedSentence as NMEAStandardSentence);
                if (sentence.parameters.Length > 0 && sentence.parameters != null)
                {
                    // $GPGGA header messages are parsed here:
                    // $GPGGA,hhmmss.ss,Latitude,N,Longitude,E,FS,NoSV,HDOP,msl,m,Altref,m,DiffAge,DiffStation*cs<CR><LF>
                    if ((sentence.TalkerID == TalkerIdentifiers.GP) && (sentence.SentenceID == SentenceIdentifiers.GGA))
                    {
                        // Parsing GGA message ($GPGGA = Global positioning system fix data) - see: NMEA-uBlox protocol table on page 47.
                        lbTime.Text = GetParameterStr(sentence, 0); // UTC Time, Current time
                        lbLatitude.Text = GetParameterStr(sentence, 1); // Latitude, Degrees + minutes
                        lbNorthing.Text = GetParameterStr(sentence, 2); // N/S Indicator, N=north or S=south
                        lbLongitude.Text = GetParameterStr(sentence, 3); // Longitude, Degrees + minutes
                        lbEasting.Text = GetParameterStr(sentence, 4); // E/W indicator, E=east or W=west
                        lbFix.Text = GetParameterStr(sentence, 5); // Position Fix Status Indicator
                        lbNoSV.Text = GetParameterStr(sentence, 6); // Satellites Used, Range 0 to 12
                        lbHDOP.Text = GetParameterStr(sentence, 7);//  HDOP, Horizontal Dilution of Precision = influence of satelit geometric configuration (layout) on measurement accuracy
                        lbHeight.Text = GetParameterStr(sentence, 8); // MSL Altitude [m] (but for WGS84; Gauss-Kruger has different ref.point) 
                        lbuMSL.Text = GetParameterStr(sentence, 9); // Units, Meters (fixed field) - MSL unit is always [m]
                        // Quality Indicator (page 48)
                        // 0 - No Fix / Invalid
                        // 1 - Standard GPS (2D/3D)
                        // 2 - Differential GPS
                        // 6 - Estimated (DR) Fix
                    }

                    // $GPVTG header messages are parsed here:
                    // $GPVTG,cogt,T,cogm,M,sog,N,kph,K,mode*cs<CR><LF>
                    if ((sentence.TalkerID == TalkerIdentifiers.GP) && (sentence.SentenceID == SentenceIdentifiers.VTG))
                    {
                        // Parsing VTG message ($GPVTG =  Course over ground and Ground speed) - see: NMEA-uBlox protocol table on page 57.

                        lbCOG.Text = GetParameterStr(sentence, 0); ; // Course over ground (true)
                        lbSOG.Text = GetParameterStr(sentence, 6); ; // Speed over ground
                    }
                    // $GPDTM,LLL,LSD,lat,N/S,lon,E/W,alt,RRR*cs<CR><LF>    see: NMEA-uBlox protocol manual

                    if ((sentence.TalkerID == TalkerIdentifiers.GP) && (sentence.SentenceID == SentenceIdentifiers.RMC))
                    {
                        lbTime.Text = GetParameterStr(sentence, 0); // UTC Time, Current time
                    }

                    if ((sentence.TalkerID == TalkerIdentifiers.GP) && (sentence.SentenceID == SentenceIdentifiers.GLL))
                    {
                        lbTime.Text = GetParameterStr(sentence, 4); // UTC Time, Current time
                    }
                }
            }

        }

        private void Start_Click(object sender, EventArgs e)
        {
            if(!TimerGPS.Enabled)
            {
                TimerGPS.Start();
                StartToolStripMenuItem.Text = "Stop";
            }
            else
            {
                TimerGPS.Stop();
                StartToolStripMenuItem.Text = "Start";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Disconnect();
        }

        private void Disconnect()
        {
            if (gpstcp != null && gpstcp.Connected)
            {
                TimerGPS.Stop();
                message = string.Empty;
                StartToolStripMenuItem.Text = "Start";
                StartToolStripMenuItem.Enabled = false;
                streamGPS.Close();
                streamGPS.Dispose();
                gpstcp.Close();
                gpstcp.Dispose();
                reConnectToolStripMenuItem.Text = "Connect";
                toolStripStatusLabel1.Text = "Disconnected";
            }
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            if (gpstcp == null || !gpstcp.Connected)
            {
                ReConnect();
            }
            else
            {
                Disconnect();
            }

            
        }

        private void ReConnect()
        {
            string IpAddress = IP_ToolStripMenuItem.Text.Trim();
            int TcpPort = Convert.ToInt32(TCP_ToolStripMenuItem.Text.Trim());
            try
            {
                gpstcp = new TcpClient(IpAddress, TcpPort);
                RecBufferSize = gpstcp.ReceiveBufferSize; // 65536
                if (gpstcp.Connected)
                {
                    streamGPS = gpstcp.GetStream();
                    toolStripStatusLabel1.Text = "Connected";
                    double dt_ms = 1.0 / Bps * 1000 * RecBufferSize / Bps; // 11.3777ms (19200bps), 45.5111ms (9600bps)
                    TimerGPS.Interval = (int)Math.Floor(dt_ms / 2);
                    //19200: 11 - slowest, 5 - @ half full
                    //9600: 45 - slowest, 22 - @ half full
                    // TODO: add buffer monitoring 
                    RecBufferFracFull = 100.0 * gpstcp.Available / RecBufferSize;
                    toolStripProgressBar1.Value = Convert.ToInt32(RecBufferFracFull);

                    TimerGPS.Start();
                    StartToolStripMenuItem.Text = "Stop";
                    StartToolStripMenuItem.Enabled = true;
                    reConnectToolStripMenuItem.Text = "Disconnect";
                }
            }
            catch (SocketException ex)
            {
                MessageBox.Show("Error connecting to host: " + IpAddress + ":" + TcpPort.ToString() + ".\n" + ex.ToString());
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Go to the github link
            System.Diagnostics.Process.Start("https://etfovac.github.io/gps/");
        }
    }
}