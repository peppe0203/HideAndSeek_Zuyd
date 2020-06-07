using HideAndSeek.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Shapes;

namespace HideAndSeek
{
    public partial class Play : Form
    {        
        private int _ticks;
        public int time = Settings.time;
        public static string IP = "127.0.0.1:8080";
        public int Count = 0;
        public List<int> lights = new List<int>()
        { 40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56};
        public bool Locate_hider = Settings.Locate_hider;
        public string Location = "Hal";
        public bool plays = true;
        public bool Win = false;

        public Play()
        {
            InitializeComponent();
            textBox4.ReadOnly = true;
            timer1.Start();
            if (Locate_hider == false)
            {
                textBox2.Text = "-";
            }
            textBox3.Text = Location;
        }

        private void Play_Load(object sender, EventArgs e)
        {            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks++;
            textBox1.Text = _ticks.ToString();

            if (_ticks >= time || Win==true)
            {
                textBox1.Text = "Done";
                textBox2.Text = "-";
                plays = false;

                if (Win == false)
                {
                    textBox4.ForeColor = Color.Red;
                    textBox4.BackColor = Color.White;
                    textBox4.Text = "Loser";
                }
                if (Win == true)
                {
                    textBox4.ForeColor = Color.Green;
                    textBox4.BackColor = Color.White;
                    textBox4.Text = "Winner";
                }
                timer1.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form1 = new Form1();
            Form1.Show();
            WindowState = FormWindowState.Normal;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lights.Count; i++)
            {
                HttpWebRequest request =
                    WebRequest.Create("http://" + IP + "/json.htm?type=lightlog&idx=" +lights[i] ) as HttpWebRequest;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);                

                if ((i == 0) && (_ticks != time) && (Locate_hider == true) && (!plays == false))
                {
                    while (Count != 12)
                    {
                        string text = reader.ReadLine();
                        if (text.Contains(@"""Status"" : ""On""") && (i == 0))
                        {
                            textBox2.Text = "Gastkamer";
                        }
                        Count = Count + 1;
                    }
                    response.Close();
                    Count = 0;
                }
                
                if ((i == 1) && (_ticks != time) && (Locate_hider == true) && (!plays == false))
                {
                    while (Count != 12)
                    {
                        string text = reader.ReadLine();
                        if (text.Contains(@"""Status"" : ""On""") && (i == 1))
                        {
                            textBox2.Text = "Controlroom";
                        }
                        Count = Count + 1;
                    }
                    response.Close();
                    Count = 0;
                }

                if ((i == 2) && (_ticks != time) && (Locate_hider == true) && (!plays == false))
                {
                    while (Count!= 12)
                    {
                        string text = reader.ReadLine();
                        if (text.Contains(@"""Status"" : ""On""") && (i == 2))
                        {
                            textBox2.Text = "Halkelder";
                        }
                        Count = Count + 1;
                    }
                    response.Close();
                    Count = 0;
                }

                if ((i == 3) && (_ticks != time) && (Locate_hider == true) && (!plays == false))
                {
                    while (Count != 12)
                    {
                        string text = reader.ReadLine();
                        if (text.Contains(@"""Status"" : ""On""") && (i == 3))
                        {
                            textBox2.Text = "Hal";
                        }
                        Count = Count + 1;
                    }
                    response.Close();
                    Count = 0;
                }

                if ((i == 4) && (_ticks != time) && (Locate_hider == true) && (!plays == false))
                {
                    while (Count != 12)
                    {
                        string text = reader.ReadLine();
                        if (text.Contains(@"""Status"" : ""On""") && (i == 4))
                        {
                            textBox2.Text = "Garage";
                        }
                        Count = Count + 1;
                    }
                    response.Close();
                    Count = 0;
                }

                if ((i == 5) && (_ticks != time) && (Locate_hider == true) && (!plays == false))
                {
                    while (Count != 12)
                    {
                        string text = reader.ReadLine();
                        if (text.Contains(@"""Status"" : ""On""") && (i == 5))
                        {
                            textBox2.Text = "Keuken";
                        }
                        Count = Count + 1;
                    }
                    response.Close();
                    Count = 0;
                }

                if ((i == 6) && (_ticks != time) && (Locate_hider == true) && (!plays == false))
                {
                    while (Count != 12)
                    {
                        string text = reader.ReadLine();
                        if (text.Contains(@"""Status"" : ""On""") && (i == 6))
                        {
                            textBox2.Text = "Eetkamer";
                        }
                        Count = Count + 1;
                    }
                    response.Close();
                    Count = 0;
                }

                if ((i == 7) && (_ticks != time) && (Locate_hider == true) && (!plays == false))
                {
                    while (Count != 12)
                    {
                        string text = reader.ReadLine();
                        if (text.Contains(@"""Status"" : ""On""") && (i == 7))
                        {
                            textBox2.Text = "Woonkamer";
                        }
                        Count = Count + 1;
                    }
                    response.Close();
                    Count = 0;
                }

                if ((i == 8) && (_ticks != time) && (Locate_hider == true) && (!plays == false))
                {
                    while (Count != 12)
                    {
                        string text = reader.ReadLine();
                        if (text.Contains(@"""Status"" : ""On""") && (i == 8))
                        {
                            textBox2.Text = "Wc";
                        }
                        Count = Count + 1;
                    }
                    response.Close();
                    Count = 0;
                }

                if ((i == 9) && (_ticks != time) && (Locate_hider == true) && (!plays == false))
                {
                    while (Count != 12)
                    {
                        string text = reader.ReadLine();
                        if (text.Contains(@"""Status"" : ""On""") && (i == 9))
                        {
                            textBox2.Text = "Halboven";
                        }
                        Count = Count + 1;
                    }
                    response.Close();
                    Count = 0;
                }

                if ((i == 10) && (_ticks != time) && (Locate_hider == true) && (!plays == false))
                {
                    while (Count != 12)
                    {
                        string text = reader.ReadLine();
                        if (text.Contains(@"""Status"" : ""On""") && (i == 10))
                        {
                            textBox2.Text = "Slaapkamer";
                        }
                        Count = Count + 1;
                    }
                    response.Close();
                    Count = 0;
                }

                if ((i == 11) && (_ticks != time) && (Locate_hider == true) && (!plays == false))
                {
                    while (Count != 12)
                    {
                        string text = reader.ReadLine();
                        if (text.Contains(@"""Status"" : ""On""") && (i == 11))
                        {
                            textBox2.Text = "Kinderkamer";
                        }
                        Count = Count + 1;
                    }
                    response.Close();
                    Count = 0;
                }

                if ((i == 12) && (_ticks != time) && (Locate_hider == true) && (!plays == false))
                {
                    while (Count != 12)
                    {
                        string text = reader.ReadLine();
                        if (text.Contains(@"""Status"" : ""On""") && (i == 12))
                        {
                            textBox2.Text = "Logeerkamer";
                        }
                        Count = Count + 1;
                    }
                    response.Close();
                    Count = 0;
                }

                if ((i == 13) && (_ticks != time) && (Locate_hider == true) && (!plays == false))
                {
                    while (Count != 12)
                    {
                        string text = reader.ReadLine();
                        if (text.Contains(@"""Status"" : ""On""") && (i == 13))
                        {
                            textBox2.Text = "Badkamer";
                        }
                        Count = Count + 1;
                    }
                    response.Close();
                    Count = 0;
                }

                if ((i == 14) && (_ticks != time) && (Locate_hider == true) && (!plays == false))
                {
                    while (Count != 12)
                    {
                        string text = reader.ReadLine();
                        if (text.Contains(@"""Status"" : ""On""") && (i == 14))
                        {
                            textBox2.Text = "Zolderkamer";
                        }
                        Count = Count + 1;
                    }
                    response.Close();
                    Count = 0;
                }

                if ((i == 15) && (_ticks != time) && (Locate_hider == true) && (!plays == false))
                {
                    while (Count != 12)
                    {
                        string text = reader.ReadLine();
                        if (text.Contains(@"""Status"" : ""On""") && (i == 15))
                        {
                            textBox2.Text = "Berging 1";
                        }
                        Count = Count + 1;
                    }
                    response.Close();
                    Count = 0;
                }

                if ((i == 16) && (_ticks != time) && (Locate_hider == true) && (!plays == false))
                {
                    while (Count != 12)
                    {
                        string text = reader.ReadLine();
                        if (text.Contains(@"""Status"" : ""On""") && (i == 16))
                        {
                            textBox2.Text = "Berging 2";
                        }
                        Count = Count + 1;
                    }
                    response.Close();
                    Count = 0;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(Form1.message);
        }
       
        private void Berging1_Click(object sender, EventArgs e)
        {
            if ((Location == "Zolderkamer") && (plays == true))
            {
                Location = "Berging 1";
                textBox3.Text = Location;

                HttpWebRequest request =
                    WebRequest.Create("http://" + IP + "/json.htm?type=lightlog&idx=55") as HttpWebRequest;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                while (Count != 12)
                {
                    string text = reader.ReadLine();
                    if (text.Contains(@"""Status"" : ""On"""))
                    {
                        Berging1.BackColor = Color.Green;
                        Win = true;
                    }
                    Count = Count + 1;
                }
                response.Close();
                if (Win == false)
                {
                    if (Form1.message.Contains("Berging 1"))
                    {
                        Berging1.BackColor = Color.Yellow;
                    }
                    else
                    {
                        Berging1.BackColor = Color.Red;
                    }                
                }
                Zolderkamer.BackColor = Color.LightGray;
                _ticks += Settings.Penalty;
                Count = 0;
            }   
        }

        private void Berging2_Click(object sender, EventArgs e)
        {
            if (Location == "Zolderkamer" && plays == true)
            {
                Location = "Berging 2";
                textBox3.Text = Location;

                HttpWebRequest request =
                    WebRequest.Create("http://" + IP + "/json.htm?type=lightlog&idx=56") as HttpWebRequest;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                while (Count != 12)
                {
                    string text = reader.ReadLine();
                    if (text.Contains(@"""Status"" : ""On"""))
                    {
                        Berging2.BackColor = Color.Green;
                        Win = true;
                    }
                    Count = Count + 1;
                }
                response.Close();
                if (Win == false)
                {
                    if (Form1.message.Contains("Berging 2"))
                    {
                        Berging2.BackColor = Color.Yellow;
                    }
                    else
                    {
                        Berging2.BackColor = Color.Red;
                    }
                }

                Zolderkamer.BackColor = Color.LightGray;
                _ticks += Settings.Penalty;
                Count = 0;
            }            
        }

        private void Zolderkamer_Click(object sender, EventArgs e)
        {
            if ((Location == "Berging 1" || Location == "Berging 2" || Location == "Halboven") && (plays == true))
            {
                Location = "Zolderkamer";
                textBox3.Text = Location;

                HttpWebRequest request =
                    WebRequest.Create("http://" + IP + "/json.htm?type=lightlog&idx=54") as HttpWebRequest;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                while (Count != 12)
                {
                    string text = reader.ReadLine();
                    if (text.Contains(@"""Status"" : ""On"""))
                    {
                        Zolderkamer.BackColor = Color.Green;
                        Win = true;
                    }
                    Count = Count + 1;
                }
                response.Close();
                if (Win == false)
                {
                    if (Form1.message.Contains("Zolderkamer"))
                    {
                        Zolderkamer.BackColor = Color.Yellow;
                    }
                    else
                    {
                        Zolderkamer.BackColor = Color.Red;
                    }
                    
                }

                Berging1.BackColor = Color.LightGray;
                Berging2.BackColor = Color.LightGray;
                Halboven1.BackColor = Color.LightGray;
                Halboven2.BackColor = Color.LightGray;
                _ticks += Settings.Penalty;
                Count = 0;
            }            
        }

        private void Slaapkamer_Click(object sender, EventArgs e)
        {
            if ((Location == "Halboven") && (plays == true))
            {
                Location = "Slaapkamer";
                textBox3.Text = Location;

                HttpWebRequest request =
                    WebRequest.Create("http://" + IP + "/json.htm?type=lightlog&idx=50") as HttpWebRequest;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                while (Count != 12)
                {
                    string text = reader.ReadLine();
                    if (text.Contains(@"""Status"" : ""On"""))
                    {
                        Slaapkamer.BackColor = Color.Green;
                        Win = true;
                    }
                    Count = Count + 1;
                }
                response.Close();
                if (Win == false)
                {
                    if (Form1.message.Contains("Slaapkamer"))
                    {
                        Slaapkamer.BackColor = Color.Yellow;
                    }
                    else
                    {
                        Slaapkamer.BackColor = Color.Red;
                    }                    
                }

                Halboven1.BackColor = Color.LightGray;
                Halboven2.BackColor = Color.LightGray;
                _ticks += Settings.Penalty;
                Count = 0;
            }
                
        }

        private void Kinderkamer_Click(object sender, EventArgs e)
        {
            if ((Location == "Halboven") && (plays == true))
            {
                Location = "Kinderkamer";
                textBox3.Text = Location;

                HttpWebRequest request =
                    WebRequest.Create("http://" + IP + "/json.htm?type=lightlog&idx=51") as HttpWebRequest;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                while (Count != 12)
                {
                    string text = reader.ReadLine();
                    if (text.Contains(@"""Status"" : ""On"""))
                    {
                        Kinderkamer.BackColor = Color.Green;
                        Win = true;
                    }
                    Count = Count + 1;
                }
                response.Close();
                if (Win == false)
                {
                    if (Form1.message.Contains("Kinderkamer"))
                    {
                        Kinderkamer.BackColor = Color.Yellow;
                    }
                    else
                    {
                        Kinderkamer.BackColor = Color.Red;
                    }
                }

                Halboven1.BackColor = Color.LightGray;
                Halboven2.BackColor = Color.LightGray;
                _ticks += Settings.Penalty;
                Count = 0;
            }
                
        }

        private void Logeerkamer_Click(object sender, EventArgs e)
        {            
            if ((Location == "Halboven") && (plays == true))
            {
                Location = "Logeerkamer";
                textBox3.Text = Location;

                HttpWebRequest request =
                    WebRequest.Create("http://" + IP + "/json.htm?type=lightlog&idx=52") as HttpWebRequest;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                while (Count != 12)
                {
                    string text = reader.ReadLine();
                    if (text.Contains(@"""Status"" : ""On"""))
                    {
                        Logeerkamer.BackColor = Color.Green;
                        Win = true;
                    }
                    Count = Count + 1;
                }
                response.Close();
                if (Win == false)
                {
                    if (Form1.message.Contains("Logeerkamer"))
                    {
                        Logeerkamer.BackColor = Color.Yellow;
                    }
                    else
                    {
                        Logeerkamer.BackColor = Color.Red;
                    }
                }

                Halboven1.BackColor = Color.LightGray;
                Halboven2.BackColor = Color.LightGray;
                _ticks += Settings.Penalty;
                Count = 0;
            }
        }

        private void Badkamer_Click(object sender, EventArgs e)
        {
            if ((Location == "Halboven") && (plays == true))
            {
                Location = "Badkamer";
                textBox3.Text = Location;

                HttpWebRequest request =
                    WebRequest.Create("http://" + IP + "/json.htm?type=lightlog&idx=53") as HttpWebRequest;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                while (Count != 12)
                {
                    string text = reader.ReadLine();
                    if (text.Contains(@"""Status"" : ""On"""))
                    {
                        Badkamer.BackColor = Color.Green;
                        Win = true;
                    }
                    Count = Count + 1;
                }
                response.Close();
                if (Win == false)
                {
                    if (Form1.message.Contains("Badkamer"))
                    {
                        Badkamer.BackColor = Color.Yellow;
                    }
                    else
                    {
                        Badkamer.BackColor = Color.Red;
                    }
                }

                Halboven1.BackColor = Color.LightGray;
                Halboven2.BackColor = Color.LightGray;
                _ticks += Settings.Penalty;
                Count = 0;
            }
        }

        private void Halboven1_Click(object sender, EventArgs e)
        {
            if ((Location == "Kinderkamer" || Location == "Slaapkamer" || Location == "Zolderkamer" || Location == "Logeerkamer" || Location == "Badkamer" || Location == "Hal") && (plays == true))
            {
                Location = "Halboven";
                textBox3.Text = Location;

                HttpWebRequest request =
                    WebRequest.Create("http://" + IP + "/json.htm?type=lightlog&idx=49") as HttpWebRequest;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                while (Count != 12)
                {
                    string text = reader.ReadLine();
                    if (text.Contains(@"""Status"" : ""On"""))
                    {
                        Halboven1.BackColor = Color.Green;
                        Halboven2.BackColor = Color.Green;
                        Win = true;
                    }
                    Count = Count + 1;
                }
                response.Close();
                if (Win == false)
                {
                    if (Form1.message.Contains("Halboven"))
                    {
                        Halboven1.BackColor = Color.Yellow;
                        Halboven2.BackColor = Color.Yellow;
                    }
                    else
                    {
                        Halboven1.BackColor = Color.Red;
                        Halboven2.BackColor = Color.Red;
                    }
                }

                Kinderkamer.BackColor = Color.LightGray;
                Slaapkamer.BackColor = Color.LightGray;
                Zolderkamer.BackColor = Color.LightGray;
                Logeerkamer.BackColor = Color.LightGray;
                Badkamer.BackColor = Color.LightGray;
                Hal1.BackColor = Color.LightGray;
                Hal2.BackColor = Color.LightGray;
                _ticks += Settings.Penalty;
                Count = 0;
            }
                
        }

        private void Halboven2_Click(object sender, EventArgs e)
        {
            if ((Location == "Kinderkamer" || Location == "Slaapkamer" || Location == "Zolderkamer" || Location == "Logeerkamer" || Location == "Badkamer" || Location == "Hal") && (plays == true))
            {
                Location = "Halboven";
                textBox3.Text = Location;

                HttpWebRequest request =
                    WebRequest.Create("http://" + IP + "/json.htm?type=lightlog&idx=49") as HttpWebRequest;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                while (Count != 12)
                {
                    string text = reader.ReadLine();
                    if (text.Contains(@"""Status"" : ""On"""))
                    {
                        Halboven1.BackColor = Color.Green;
                        Halboven2.BackColor = Color.Green;
                        Win = true;
                    }
                    Count = Count + 1;
                }
                response.Close();
                if (Win == false)
                {
                    if (Form1.message.Contains("Halboven"))
                    {
                        Halboven1.BackColor = Color.Yellow;
                        Halboven2.BackColor = Color.Yellow;
                    }
                    else
                    {
                        Halboven1.BackColor = Color.Red;
                        Halboven2.BackColor = Color.Red;
                    }
                }

                Kinderkamer.BackColor = Color.LightGray;
                Slaapkamer.BackColor = Color.LightGray;
                Zolderkamer.BackColor = Color.LightGray;
                Logeerkamer.BackColor = Color.LightGray;
                Badkamer.BackColor = Color.LightGray;
                Hal1.BackColor = Color.LightGray;
                Hal2.BackColor = Color.LightGray;
                _ticks += Settings.Penalty;
                Count = 0;
            }
        }

        private void Woonkamer_Click(object sender, EventArgs e)
        {
            if ((Location == "Eetkamer" || Location == "Hal") && (plays == true))
            {
                Location = "Woonkamer";
                textBox3.Text = Location;

                HttpWebRequest request =
                    WebRequest.Create("http://" + IP + "/json.htm?type=lightlog&idx=47") as HttpWebRequest;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                while (Count != 12)
                {
                    string text = reader.ReadLine();
                    if (text.Contains(@"""Status"" : ""On"""))
                    {
                        Woonkamer.BackColor = Color.Green;
                        Win = true;
                    }
                    Count = Count + 1;
                }
                response.Close();
                if (Win == false)
                {
                    if (Form1.message.Contains("Woonkamer"))
                    {
                        Woonkamer.BackColor = Color.Yellow;
                    }
                    else
                    {
                        Woonkamer.BackColor = Color.Red;
                    }
                }

                Eetkamer.BackColor = Color.LightGray;
                Hal1.BackColor = Color.LightGray;
                Hal2.BackColor = Color.LightGray;
                _ticks += Settings.Penalty;
                Count = 0;
            }
        }

        private void Eetkamer_Click(object sender, EventArgs e)
        {
            if ((Location == "Woonkamer" || Location == "Keuken") && (plays == true))
            {
                Location = "Eetkamer";
                textBox3.Text = Location;

                HttpWebRequest request =
                    WebRequest.Create("http://" + IP + "/json.htm?type=lightlog&idx=46") as HttpWebRequest;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                while (Count != 12)
                {
                    string text = reader.ReadLine();
                    if (text.Contains(@"""Status"" : ""On"""))
                    {
                        Eetkamer.BackColor = Color.Green;
                        Win = true;
                    }
                    Count = Count + 1;
                }
                response.Close();
                if (Win == false)
                {
                    if (Form1.message.Contains("Eetkamer"))
                    {
                        Eetkamer.BackColor = Color.Yellow;
                    }
                    else
                    {
                        Eetkamer.BackColor = Color.Red;
                    }
                }

                Woonkamer.BackColor = Color.LightGray;
                Keuken.BackColor = Color.LightGray;
                _ticks += Settings.Penalty;
                Count = 0;
            }
        }

        private void Keuken_Click(object sender, EventArgs e)
        {
            if ((Location == "Eetkamer" || Location == "Hal") && (plays == true))
            {
                Location = "Keuken";
                textBox3.Text = Location;

                HttpWebRequest request =
                    WebRequest.Create("http://" + IP + "/json.htm?type=lightlog&idx=45") as HttpWebRequest;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                while (Count != 12)
                {
                    string text = reader.ReadLine();
                    if (text.Contains(@"""Status"" : ""On"""))
                    {
                        Keuken.BackColor = Color.Green;
                        Win = true;
                    }
                    Count = Count + 1;
                }
                response.Close();
                if (Win == false)
                {
                    if (Form1.message.Contains("Keuken"))
                    {
                        Keuken.BackColor = Color.Yellow;
                    }    
                    else
                    {
                        Keuken.BackColor = Color.Red;
                    }
                }

                Eetkamer.BackColor = Color.LightGray;
                Hal1.BackColor = Color.LightGray;
                Hal2.BackColor = Color.LightGray;
                _ticks += Settings.Penalty;
                Count = 0;
            }
        }

        private void Garage_Click(object sender, EventArgs e)
        {
            if ((Location == "Hal") && (plays == true))
            {
                Location = "Garage";
                textBox3.Text = Location;

                HttpWebRequest request =
                    WebRequest.Create("http://" + IP + "/json.htm?type=lightlog&idx=44") as HttpWebRequest;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                while (Count != 12)
                {
                    string text = reader.ReadLine();
                    if (text.Contains(@"""Status"" : ""On"""))
                    {
                        Garage.BackColor = Color.Green;
                        Win = true;
                    }
                    Count = Count + 1;
                }
                response.Close();
                if (Win == false)
                {
                    if (Form1.message.Contains("Garage"))
                    {
                        Garage.BackColor = Color.Yellow;
                    }
                    else
                    {
                        Garage.BackColor = Color.Red;
                    }
                }
                Hal1.BackColor = Color.LightGray;
                Hal2.BackColor = Color.LightGray;
                _ticks += Settings.Penalty;
                Count = 0;
            }
        }

        private void Wc_Click(object sender, EventArgs e)
        {
            if ((Location == "Hal") && (plays == true))
            {
                Location = "Wc";
                textBox3.Text = Location;

                HttpWebRequest request =
                    WebRequest.Create("http://" + IP + "/json.htm?type=lightlog&idx=48") as HttpWebRequest;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                while (Count != 12)
                {
                    string text = reader.ReadLine();
                    if (text.Contains(@"""Status"" : ""On"""))
                    {
                        Wc.BackColor = Color.Green;
                        Win = true;
                    }
                    Count = Count + 1;
                }
                response.Close();
                if (Win == false)
                {
                    if (Form1.message.Contains("Wc"))
                    {
                        Wc.BackColor = Color.Yellow;
                    }
                    else
                    {
                        Wc.BackColor = Color.Red;
                    }                    
                }

                Hal1.BackColor = Color.LightGray;
                Hal2.BackColor = Color.LightGray;
                _ticks += Settings.Penalty;
                Count = 0;
            }
        }

        private void Hal1_Click(object sender, EventArgs e)
        {
            if ((Location == "Keuken" || Location == "Halboven" || Location == "Woonkamer" || Location == "Wc" || Location == "Garage" || Location == "Halkelder") && (plays == true))
            {
                Location = "Hal";
                textBox3.Text = Location;

                HttpWebRequest request =
                    WebRequest.Create("http://" + IP + "/json.htm?type=lightlog&idx=43") as HttpWebRequest;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                while (Count != 12)
                {
                    string text = reader.ReadLine();
                    if (text.Contains(@"""Status"" : ""On"""))
                    {
                        Hal1.BackColor = Color.Green;
                        Hal2.BackColor = Color.Green;
                        Win = true;
                    }
                    Count = Count + 1;
                }
                response.Close();
                if (Win == false)
                {
                    if (Form1.message.Contains("Hal"))
                    {
                        Hal1.BackColor = Color.Yellow;
                        Hal2.BackColor = Color.Yellow;
                    }
                    else
                    {
                        Hal1.BackColor = Color.Red;
                        Hal2.BackColor = Color.Red;
                    }    
                }

                Keuken.BackColor = Color.LightGray;
                Halboven1.BackColor = Color.LightGray;
                Halboven2.BackColor = Color.LightGray;
                Woonkamer.BackColor = Color.LightGray;
                Wc.BackColor = Color.LightGray;
                Garage.BackColor = Color.LightGray;
                Halonder.BackColor = Color.LightGray;
                _ticks += Settings.Penalty;
                Count = 0;
            }
        }

        private void Hal2_Click(object sender, EventArgs e)
        {
            if ((Location == "Keuken" || Location == "Halboven" || Location == "Woonkamer" || Location == "Wc" || Location == "Garage" || Location == "Halkelder") && (plays == true))
            {
                Location = "Hal";
                textBox3.Text = Location;

                HttpWebRequest request =
                    WebRequest.Create("http://" + IP + "/json.htm?type=lightlog&idx=43") as HttpWebRequest;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                while (Count != 12)
                {
                    string text = reader.ReadLine();
                    if (text.Contains(@"""Status"" : ""On"""))
                    {
                        Hal1.BackColor = Color.Green;
                        Hal2.BackColor = Color.Green;
                        Win = true;
                    }
                    Count = Count + 1;
                }
                response.Close();
                if (Win == false)
                {
                    if (Form1.message.Contains("Hal"))
                    {
                        Hal1.BackColor = Color.Yellow;
                        Hal2.BackColor = Color.Yellow;
                    }
                    else
                    {
                        Hal1.BackColor = Color.Red;
                        Hal2.BackColor = Color.Red;
                    }
                }

                Keuken.BackColor = Color.LightGray;
                Halboven1.BackColor = Color.LightGray;
                Halboven2.BackColor = Color.LightGray;
                Woonkamer.BackColor = Color.LightGray;
                Wc.BackColor = Color.LightGray;
                Garage.BackColor = Color.LightGray;
                Halonder.BackColor = Color.LightGray;
                _ticks += Settings.Penalty;
                Count = 0;
            }
        }

        private void Gastkamer_Click(object sender, EventArgs e)
        {
            if ((Location == "Halkelder") && (plays == true))
            {
                Location = "Gastkamer";
                textBox3.Text = Location;

                HttpWebRequest request =
                    WebRequest.Create("http://" + IP + "/json.htm?type=lightlog&idx=40") as HttpWebRequest;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                while (Count != 12)
                {
                    string text = reader.ReadLine();
                    if (text.Contains(@"""Status"" : ""On"""))
                    {
                        Gastkamer.BackColor = Color.Green;
                        Win = true;
                    }
                    Count = Count + 1;
                }
                response.Close();
                if (Win == false)
                {
                    if (Form1.message.Contains("Gaskamer"))
                    {
                        Gastkamer.BackColor = Color.Yellow;
                    }
                    else
                    {
                        Gastkamer.BackColor = Color.Red;
                    }      
                }

                Halonder.BackColor = Color.LightGray;
                _ticks += Settings.Penalty;
                Count = 0;
            }
        }

        private void Halonder_Click(object sender, EventArgs e)
        {
            if ((Location == "Gastkamer" || Location == "Controlroom" || Location == "Hal") && (plays == true))
            {
                Location = "Halkelder";
                textBox3.Text = Location;

                HttpWebRequest request =
                    WebRequest.Create("http://" + IP + "/json.htm?type=lightlog&idx=42") as HttpWebRequest;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                while (Count != 12)
                {
                    string text = reader.ReadLine();
                    if (text.Contains(@"""Status"" : ""On"""))
                    {
                        Halonder.BackColor = Color.Green;
                        Win = true;
                    }
                    Count = Count + 1;
                }
                response.Close();
                if (Win == false)
                {
                    if (Form1.message.Contains("Halkelder"))
                    {
                        Halonder.BackColor = Color.Yellow;
                    }
                    else
                    {
                        Halonder.BackColor = Color.Red;
                    }
                }

                Hal1.BackColor = Color.LightGray;
                Hal2.BackColor = Color.LightGray;
                Gastkamer.BackColor = Color.LightGray;
                Controlroom.BackColor = Color.LightGray;
                button12.BackColor = Color.LightGray;
                _ticks += Settings.Penalty;
                Count = 0;
            }
        }

        private void Controlroom_Click(object sender, EventArgs e)

        {
            if ((Location == "Halkelder") && (plays == true))
            {
                Location = "Controlroom";
                textBox3.Text = Location;

                HttpWebRequest request =
                    WebRequest.Create("http://" + IP + "/json.htm?type=lightlog&idx=41") as HttpWebRequest;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                while (Count != 12)
                {
                    string text = reader.ReadLine();
                    if (text.Contains(@"""Status"" : ""On"""))
                    {
                        Controlroom.BackColor = Color.Green;
                        button12.BackColor = Color.Green;
                        Win = true;
                    }
                    Count = Count + 1;
                }
                response.Close();
                if (Win == false)
                {
                    if (Form1.message.Contains("Controlroom"))
                    {
                        Controlroom.BackColor = Color.Yellow;
                        button12.BackColor = Color.Yellow;
                    }    
                    else
                    {
                        Controlroom.BackColor = Color.Red;
                        button12.BackColor = Color.Red;
                    }                    
                }

                Halonder.BackColor = Color.LightGray;
                _ticks += Settings.Penalty;
                Count = 0;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
