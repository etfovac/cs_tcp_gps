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
        NetworkStream streamGPS;
        TcpClient gpstcp;
        string poruka ="";
        string hostUri = "10.0.0.11";
        int portNumber = 5555;

        public FormGPS()
        {
            InitializeComponent();

            
            try
            {
                gpstcp = new TcpClient(hostUri, portNumber);
                if (gpstcp.Connected) { streamGPS = gpstcp.GetStream(); }
            }
            catch (SocketException ex)
            {
                MessageBox.Show( "Error connecting to host: " + hostUri + ":" + portNumber.ToString() + ".\n" + ex.ToString() );
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timerGPS.Enabled = true;  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timerGPS.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (gpstcp != null && gpstcp.Connected) gpstcp.Close();
        }

        private void timerGPS_Tick(object sender, EventArgs e)
        {
            if (streamGPS != null && streamGPS.CanRead)
            {
                byte[] bajt = { (byte)streamGPS.ReadByte() };
                if (Encoding.ASCII.GetString(bajt) == "$")
                {
                    richTextBox1.AppendText(poruka);
                    Parsiraj(sender, e);
                    poruka = "$";
                }
                else
                {
                    poruka += Encoding.ASCII.GetString(bajt);
                    textBox1.Text = poruka;
                }
            }
        }

        private void Parsiraj(object sender, EventArgs e)
        {
            string stringToParse = poruka;
            try
            {        // try to parse sentence
                var parsedSentence = NMEAParser.Parse(stringToParse);
	            if (parsedSentence is NMEAStandardSentence)
	            {
		            NMEAStandardSentence sentence = (parsedSentence as NMEAStandardSentence);
                    // Prima sve poruke, a mi cemo citati one sa $GPGGA header-om:
                    // $GPGGA,hhmmss.ss,Latitude,N,Longitude,E,FS,NoSV,HDOP,msl,m,Altref,m,DiffAge,DiffStation*cs<CR><LF>
                	if ((sentence.TalkerID == TalkerIdentifiers.GP) && (sentence.SentenceID == SentenceIdentifiers.GGA))
		            {
                        //
                        // Parsiranje GGA poruka ($GPGGA = Global positioning system fix data) - vidi NMEA-uBlox protocol str37.
                        //  --pazi-- u odnosu na tabelu na str37, redovi su pomereni za -1
                        lbTime.Text = sentence.parameters[0].ToString(); // UTC Time, Current time
                        lbLatitude.Text = sentence.parameters[1].ToString(); // Latitude, Degrees + minutes
                        lbNorthing.Text = sentence.parameters[2].ToString(); // N/S Indicator, N=north or S=south
                        lbLongitude.Text = sentence.parameters[3].ToString(); // Longitude, Degrees + minutes
                        lbEasting.Text = sentence.parameters[4].ToString(); // E/W indicator, E=east or W=west
                        lbFix.Text = sentence.parameters[5].ToString(); // Position Fix Status Indicator
                        lbNoSV.Text = sentence.parameters[6].ToString(); // Satellites Used, Range 0 to 12
                        lbHDOP.Text = sentence.parameters[7].ToString();//  HDOP, Horizontal Dilution of Precision = uticaj geometr. konfiguracije (rasporeda) satelita na tacnost merenja
                        lbHeight.Text = sentence.parameters[8].ToString(); // MSL Altitude = nadmorska visina [m] (ali za WGS84, sa drugom ref. tackom u odnosu na nas GK) 
                        lbuMSL.Text = sentence.parameters[9].ToString(); // Units, Meters (fixed field) -- jedinica za MSL je uvek [m]

                        // Fix Status (str38)
                        // 0 - No Fix / Invalid
                        // 1 - Standard GPS (2D/3D)
                        // 2 - Differential GPS
                        // 6 - Estimated (DR) Fix
		            }

                   
                    // Prima sve poruke, a mi cemo citati one sa $GPVTG header-om:
                    // $GPVTG,cogt,T,cogm,M,sog,N,kph,K,mode*cs<CR><LF>
                    if ((sentence.TalkerID == TalkerIdentifiers.GP) && (sentence.SentenceID == SentenceIdentifiers.VTG))
		                {
                        //
                        // Parsiranje VTG poruka ($GPVTG =  Course over ground and Ground speed) - vidi NMEA-uBlox protocol str44.
                        //  --pazi-- u odnosu na tabelu na str44, redovi su pomereni za -1
                        lbCOG.Text = sentence.parameters[0].ToString(); // Course over ground (true)
                        lbSOG.Text = sentence.parameters[6].ToString(); // Speed over ground

		                }

                    // $GPDTM,LLL,LSD,lat,N/S,lon,E/W,alt,RRR*cs<CR><LF>    str49
            	    }
	            			
        	    }				
                catch 
                {
	            
                }
        }

       
    }
}
