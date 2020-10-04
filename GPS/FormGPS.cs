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
        private string message;
        private string IpAddress;
        private int TcpPort;

        public FormGPS()
        {
            InitializeComponent();
            message = "";
        }

        private void TimerGPS_Tick(object sender, EventArgs e)
        {
            if (streamGPS != null && streamGPS.CanRead)
            {
                byte[] ByteRd = { (byte)streamGPS.ReadByte() };
                if (Encoding.ASCII.GetString(ByteRd) == "$")
                {
                    ReceivedStream.AppendText(message);
                    Parse(sender, e);
                    message = "$";
                }
                else
                {
                    message += Encoding.ASCII.GetString(ByteRd);
                    LastMessage.Text = message;
                }
            }
        }

        private void Parse(object sender, EventArgs e)
        {
            string stringToParse = message;
            try
            {
                var parsedSentence = NMEAParser.Parse(stringToParse);
	            if (parsedSentence is NMEAStandardSentence)
	            {
		            NMEAStandardSentence sentence = (parsedSentence as NMEAStandardSentence);
                    // It receives all the messages
                    // only $GPGGA header messages are parsed here:
                    // $GPGGA,hhmmss.ss,Latitude,N,Longitude,E,FS,NoSV,HDOP,msl,m,Altref,m,DiffAge,DiffStation*cs<CR><LF>
                    if ((sentence.TalkerID == TalkerIdentifiers.GP) && (sentence.SentenceID == SentenceIdentifiers.GGA))
		            {
                        // Parsing GGA message ($GPGGA = Global positioning system fix data) - see: NMEA-uBlox protocol table on page 47.
                        lbTime.Text = sentence.parameters[0].ToString(); // UTC Time, Current time
                        lbLatitude.Text = sentence.parameters[1].ToString(); // Latitude, Degrees + minutes
                        lbNorthing.Text = sentence.parameters[2].ToString(); // N/S Indicator, N=north or S=south
                        lbLongitude.Text = sentence.parameters[3].ToString(); // Longitude, Degrees + minutes
                        lbEasting.Text = sentence.parameters[4].ToString(); // E/W indicator, E=east or W=west
                        lbFix.Text = sentence.parameters[5].ToString(); // Position Fix Status Indicator
                        lbNoSV.Text = sentence.parameters[6].ToString(); // Satellites Used, Range 0 to 12
                        lbHDOP.Text = sentence.parameters[7].ToString();//  HDOP, Horizontal Dilution of Precision = uticaj geometr. konfiguracije (rasporeda) satelita na tacnost merenja
                        lbHeight.Text = sentence.parameters[8].ToString(); // MSL Altitude [m] (but for WGS84; Gauss-Kruger has different ref.point) 
                        lbuMSL.Text = sentence.parameters[9].ToString(); // Units, Meters (fixed field) - MSL unit is always [m]
                        // Quality Indicator (page 48)
                        // 0 - No Fix / Invalid
                        // 1 - Standard GPS (2D/3D)
                        // 2 - Differential GPS
                        // 6 - Estimated (DR) Fix
                    }

                    // only $GPVTG header messages are parsed here:
                    // $GPVTG,cogt,T,cogm,M,sog,N,kph,K,mode*cs<CR><LF>
                    if ((sentence.TalkerID == TalkerIdentifiers.GP) && (sentence.SentenceID == SentenceIdentifiers.VTG))
		                {
                        // Parsing VTG message ($GPVTG =  Course over ground and Ground speed) - see: NMEA-uBlox protocol table on page 57.
                        lbCOG.Text = sentence.parameters[0].ToString(); // Course over ground (true)
                        lbSOG.Text = sentence.parameters[6].ToString(); // Speed over ground

		                }

                    // $GPDTM,LLL,LSD,lat,N/S,lon,E/W,alt,RRR*cs<CR><LF>    see: NMEA-uBlox protocol manual
                }

            }				
                catch 
                {
	            
                }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            TimerGPS.Enabled = true;
        }
        private void Stop_Click(object sender, EventArgs e)
        {
            TimerGPS.Enabled = false;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (gpstcp != null && gpstcp.Connected) gpstcp.Close();
        }
        private void Connect_Click(object sender, EventArgs e)
        {
            try
            {
                IpAddress = IPAddress.Text;
                TcpPort = (int)Port.Value;
                gpstcp = new TcpClient(IpAddress, TcpPort);
                if (gpstcp.Connected) { streamGPS = gpstcp.GetStream(); }
            }
            catch (SocketException ex)
            {
                MessageBox.Show("Error connecting to host: " + IpAddress + ":" + TcpPort.ToString() + ".\n" + ex.ToString());
            }
        }
        private void IPAddress_KeyUp(object sender, KeyEventArgs e)
        {
            IpAddress = IPAddress.Text;
        }
        private void Port_ValueChanged(object sender, EventArgs e)
        {
            TcpPort = (int)Port.Value;
        }
    }
}