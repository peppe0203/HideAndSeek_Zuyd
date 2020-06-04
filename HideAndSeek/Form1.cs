using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HideAndSeek
{
    public partial class Form1 : Form
    {
        public static bool Door = false;
        public static List<string> ts = new List<string>()
        { };
        public static string message;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> ts = new List<string> { };
            HttpWebRequest request =
               WebRequest.Create("http://" + Play.IP + "/json.htm?type=command&param=getlog&lastlogtime=LASTLOGTIME&loglevel=") as HttpWebRequest;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            string text = reader.ReadLine();
            text = reader.ReadLine();

            while (Door == false)
            {
                text = reader.ReadLine();
                if (text == null)
                {
                    Door = true;
                    response.Close();
                }
                if ((Door != true) && (reader.ReadLine() != null) && (text != null))
                {
                    if (text.Contains(("Status")))
                    {
                        Door = true;
                        response.Close();
                    }
                    if (text.Contains("[M]"))
                    {
                        if (text.Contains("Eetkamer") && (!ts.Contains("Eetkamer")))
                        {
                            ts.Add("Eetkamer");
                        }
                        if (text.Contains("Keuken") && (!ts.Contains("Keuken")))
                        {
                            ts.Add("Keuken");
                        }
                        if (text.Contains("Gaskamer") && (!ts.Contains("Gaskamer")))
                        {
                            ts.Add("Gaskamer");
                        }
                        if (text.Contains("Halkelder") && (!ts.Contains("Halkelder")))
                        {
                            ts.Add("Halkelder");
                        }
                        if (text.Contains("Controlroom") && (!ts.Contains("Controlroom")))
                        {
                            ts.Add("Controlroom");
                        }
                        if (text.Contains("Garage") && (!ts.Contains("Garage")))
                        {
                            ts.Add("Garage");
                        }
                        if (text.Contains("Woonkamer") && (!ts.Contains("Woonkamer")))
                        {
                            ts.Add("Woonkamer");
                        }
                        if (text.Contains("Hal") && (!ts.Contains("Hal")))
                        {
                            ts.Add("Hal");
                        }
                        if (text.Contains("Wc") && (!ts.Contains("Wc")))
                        {
                            ts.Add("Wc");
                        }
                        if (text.Contains("Halboven") && (!ts.Contains("Halboven")))
                        {
                            ts.Add("Halboven");
                        }
                        if (text.Contains("Slaapkamer") && (!ts.Contains("Slaapkamer")))
                        {
                            ts.Add("Slaapkamer");
                        }
                        if (text.Contains("Kinderkamer") && (!ts.Contains("Kinderkamer")))
                        {
                            ts.Add("Kinderkamer");
                        }
                        if (text.Contains("Logeerkamer") && (!ts.Contains("Logeerkamer")))
                        {
                            ts.Add("Logeerkamer");
                        }
                        if (text.Contains("Badkamer") && (!ts.Contains("Badkamer")))
                        {
                            ts.Add("Badkamer");
                        }
                        if (text.Contains("Zolderkamer") && (!ts.Contains("Zolderkamer")))
                        {
                            ts.Add("Zolderkamer");
                        }
                        if (text.Contains("Berging 1") && (!ts.Contains("Berging 1")))
                        {
                            ts.Add("Berging 1");
                        }
                        if (text.Contains("Berging 2") && (!ts.Contains("Berging 2")))
                        {
                            ts.Add("Berging 2");
                        }
                    }
                }
            }
            Door = false;
            message = string.Join(Environment.NewLine, ts);
            response.Close();
        }
    

        private void button2_Click(object sender, EventArgs e)
        {
            var Map = new Map();
            Map.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var Settings = new Settings();
            Settings.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var Play = new Play();
            Play.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form1 = new Form1();
            Form1.Show();
            WindowState = FormWindowState.Normal;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
