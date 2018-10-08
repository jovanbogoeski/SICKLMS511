using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using SICK_LMS5xx_PRO_Library;
using SICK_Work;

// ip adress of sensor 169.254.156.174

namespace SICKLMS511_reader
{
    public partial class Form1 : Form
    {
        public bool CheckIPValidation = true;
        private System.Net.IPAddress IPtest;
        public SICK_Communication.Ethernet.TCP_client LMS_connection = new SICK_Communication.Ethernet.TCP_client();
        public SICK_LMS5xx_PRO_Library.DataProcessing LMS_DataProcess = new SICK_LMS5xx_PRO_Library.DataProcessing();
        public string LMS_Data;
        public SICK_Work.SICK_Laserdevices.Scandata LMS_MEasurementStructure = new SICK_Work.SICK_Laserdevices.Scandata();

        public Form1()
        {
            InitializeComponent();
        }
        // function to check if device is online
        public Boolean pingAddress(string ipadd)
        {
            try
            {
                Ping ping = new Ping();
                PingReply pingresult = ping.Send(ipadd);
                if (pingresult.Status.ToString() == "Success")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }

        }

        private void butConnect_Click(object sender, EventArgs e)
        {
            if (butConnect.Text == "Connect")
            {

                // check if  IPaddress is valid and the device is online
                if (CheckIPValidation == true & pingAddress(textIPAddress.Text) == true)
                {
                    Int32 portNum = Convert.ToInt32(textPort.Text);
                    LMS_connection.Client_Connect(textIPAddress.Text, portNum); // connect the LMS511

                    // enable the buttons
                    butGetData.Enabled = true;
                    textIPAddress.Enabled = false;

                    butConnect.Text = "Disconnect";
                }
                else
                {
                    textData.Text = "Device not avaiable, confirm device ip address and port \n";
                }
            }
            else
            {
                // Disconnect
                LMS_connection.Client_Disconnect();
                butGetData.Enabled = false;
                textIPAddress.Enabled = true;
                butConnect.Text = "Connect";
            }
        }

        private void textIPAddress_TextChanged(object sender, EventArgs e)
        {
            if (System.Net.IPAddress.TryParse(textIPAddress.Text, out IPtest) == true) // check if input text is an ip address
            {
                textIPAddress.BackColor = Color.Lime;
                CheckIPValidation = true;
            }
            else
            {
                textIPAddress.BackColor = Color.Red;
                CheckIPValidation = false;
            }
        }

        private void butGetData_Click(object sender, EventArgs e)
        {
            textData.Text = "";

            LMS_connection.SendString(SICK_LMS5xx_PRO_Library.DeviceFunctions.GetMeasurement(), SICK_Communication.Ethernet.TCP_client.FramingTypes.Stx_Etx);

            // Wait for the Device to respond
            while (!(LMS_connection.Available > 0))
            {
            }

            // Read the raw string data from the sensor
            LMS_Data = LMS_connection.Readavailable_string();

            // Convert data string to the SICK_Work structure
            //LMS_MEasurementStructure = LMS_DataProcess.Process_SRA_LMDscandata(LMS_Data);
            //check for errors in data
            //if (LMS_MEasurementStructure.Error_Occured == false)
            //{
            //    LMS_Data = "Error occur during data conversion\n";
            //}

            // Show the data in HEX format to textview

            textData.Text = LMS_Data;
            /*
            int value;
            LMS_MEasurementStructure = LMS_DataProcess.Process_SRA_LMDscandata(textData.Text);
            ushort[] dist = LMS_MEasurementStructure.Dist1.DataPoints;
            for(int j = 0; j < dist.Length; j++)
            {
                textData.Text = dist[j].ToString();

            }
            */


        }
        private void processDataBtn_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(900, 600);
            Pen pen = new Pen(Color.Silver, 1f);
            Graphics g = Graphics.FromImage(bmp);
            for (int ii = 0; ii < 900; ii += 50)
                g.DrawLine(pen, ii, 0, ii, 599);
            for (int ii = 0; ii < 600; ii += 50)
                g.DrawLine(pen, 0, ii, 899, ii);

            g.DrawLine(pen, 0, 599, 899, 599);
            g.DrawLine(pen, 899, 0, 899, 599);

            pen.Color = Color.Black;
            pen.Width = 3f;

            g.DrawLine(pen, 0, 550, 899, 550);
            g.DrawLine(pen, 75, 0, 75, 599);

            Font font = new Font("Cambria", 13);
            for (int ii = 75; ii < 850; ii += 50)
            {
                g.DrawLine(pen, ii, 550, ii, 565);
                if (ii != 75)
                    g.DrawString("" + ((ii - 75) / 2), font, pen.Brush, new PointF(ii-12.5f, 570));
            }

            for (int ii = 0, jj = 550; jj > 0; jj -= 50, ii += 50)
            {
                g.DrawLine(pen, 65, jj, 75, jj);
                if (ii != 0)
                    g.DrawString("" + (ii/5), font, pen.Brush, new PointF(25, jj-10));
            }

            pen.Color = Color.Red;
            g.DrawString("Angle", font, pen.Brush, new PointF(850, 555));
            g.DrawString("Dist(dm)", font, pen.Brush, new PointF(5, 5));

            string str = textData.Text;
            string pointsStr = "";
            if (str != null && str != "")
            {

                SICK_Laserdevices.Scandata data = LMS_DataProcess.Process_SRA_LMDscandata(str);
                ushort[] dist = data.Dist1.DataPoints;       

                pen.Color = Color.Magenta;
                pen.Width = 1.5f;
                float xp = 75f;

                for (int ii=0; ii< dist.Length; ii++)
                {
                    float yp = 550 - (dist[ii] / 100f)*5;
                    g.DrawEllipse(pen, xp - 2.5f, yp - 2.5f, 5, 5);
                    
                    pointsStr += "(" + (xp-75)/2 + "," + dist[ii] + "),\t";

                    xp += 1;
                }

                pen.Color = Color.Blue;
                pen.Width = 2f;
                xp = 75f;
                for (int ii = 0; ii < (dist.Length - 1); ii++)
                {
                    float yp1 = 550 - (dist[ii] / 100f) * 5;
                    float yp2 = 550 - (dist[ii+1] / 100f) * 5;
                    g.DrawLine(pen, xp, yp1, xp + 1, yp2);
                    xp += 1;
                }
            }

            textData.Text = pointsStr;
            pen.Dispose();
            g.Dispose();
            graphPicBox.BackgroundImage = bmp;
        }

       
    }
}

