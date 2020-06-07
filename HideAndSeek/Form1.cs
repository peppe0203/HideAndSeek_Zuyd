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
        public static List<string> ts = new List<string>();
        public static string message;
        public List<int> Sensors = new List<int>()
        {23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39};

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
            for (int i = 0; i < Sensors.Count; i++)
            {
                HttpWebRequest request =
                    WebRequest.Create("http://127.0.0.1:8080/json.htm?type=lightlog&idx=" + Sensors[i]) as HttpWebRequest;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                string text = reader.ReadLine();
                text = reader.ReadLine();

                if (!text.Contains((@"""status"" : ""OK""")))
                {
                    if ((i == 0) && (!ts.Contains("Gaskamer")))
                    {
                        ts.Add("Gastkamer");
                    }
                    if ((i == 1) && (!ts.Contains("Halkelder")))
                    {
                        ts.Add("Halkelder");
                    }
                    if ((i == 2) && (!ts.Contains("Controlroom")))
                    {
                        ts.Add("Controlroom");
                    }
                    if ((i == 3) && (!ts.Contains("Zolderkamer")))
                    {
                        ts.Add("Zolderkamer");
                    }
                    if ((i == 4) && (!ts.Contains("Berging 1")))
                    {
                        ts.Add("Berging 1");
                    }
                    if ((i == 5) && (!ts.Contains("Berging 2")))
                    {
                        ts.Add("Berging 2");
                    }
                    if ((i == 6) && (!ts.Contains("Garage")))
                    {
                        ts.Add("Garage");
                    }
                    if ((i == 7) && (!ts.Contains("Hal")))
                    {
                        ts.Add("Hal");
                    }
                    if ((i == 8) && (!ts.Contains("Keuken")))
                    {
                        ts.Add("Keuken");
                    }
                    if ((i == 9) && (!ts.Contains("Wc")))
                    {
                        ts.Add("Wc");
                    }
                    if ((i == 10) && (!ts.Contains("Woonkamer")))
                    {
                        ts.Add("Woonkamer");
                    }
                    if ((i == 11) && (!ts.Contains("Eetkamer")))
                    {
                        ts.Add("Eetkamer");
                    }
                    if ((i == 12) && (!ts.Contains("Halboven")))
                    {
                        ts.Add("Halboven");
                    }
                    if ((i == 13) && (!ts.Contains("Badkamer")))
                    {
                        ts.Add("Badkamer");
                    }
                    if ((i == 14) && (!ts.Contains("Logeerkamer")))
                    {
                        ts.Add("Logeerkamer");
                    }
                    if ((i == 15) && (!ts.Contains("Kinderkamer")))
                    {
                        ts.Add("Kinderkamer");
                    }
                    if ((i == 16) && (!ts.Contains("Slaapkamer")))
                    {
                        ts.Add("Slaapkamer");
                    }
                }
                response.Close();
            }
            message = string.Join(Environment.NewLine, ts);

            var Play = new Play();
            Play.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Sensors.Count; i++)
            {
                HttpWebRequest request =
                    WebRequest.Create("http://127.0.0.1:8080/json.htm?type=command&param=clearlightlog&idx=" + Sensors[i]) as HttpWebRequest;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;                
            }
            message = string.Empty;
            ts.Clear();

    }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var Hide = new Hide();
            Hide.Show();
            this.Hide();
        }
    }
}
