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

namespace HideAndSeek
{
    public partial class Play : Form
    {
        private int _ticks;
        public int time = Settings.time;
        public string IP = "127.0.0.1:8080";
        public int Count = 0;
        public List<int> lights = new List<int>()
        { 40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56};

        public Play()
        {
            InitializeComponent();
            timer1.Start();
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

            if (_ticks == time)
            {
                textBox1.Text = "Done";
                textBox2.Text = "-";
                radioButton1.Checked = true;
                radioButton1.ForeColor = Color.Red;
                radioButton1.Text = "Loser";
                radioButton1.Location = new Point(550, 117);
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

                if ((i == 0) && (_ticks != time))
                {
                    while (Count != 12)
                    {
                        string text = reader.ReadLine();
                        if (text.Contains(@"""Status"" : ""On""") && (i == 0))
                        {
                            textBox2.Text = "Gaskamer";
                        }
                        Count = Count + 1;
                    }
                    response.Close();
                    Count = 0;
                }
                
                if ((i == 1) && (_ticks != time))
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

                if ((i == 2) && (_ticks != time))
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

                if ((i == 3) && (_ticks != time))
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

                if ((i == 4) && (_ticks != time))
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

                if ((i == 5) && (_ticks != time))
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

                if ((i == 6) && (_ticks != time))
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

                if ((i == 7) && (_ticks != time))
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

                if ((i == 8) && (_ticks != time))
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

                if ((i == 9) && (_ticks != time))
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

                if ((i == 10) && (_ticks != time))
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

                if ((i == 11) && (_ticks != time))
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

                if ((i == 12) && (_ticks != time))
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

                if ((i == 13) && (_ticks != time))
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

                if ((i == 14) && (_ticks != time))
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

                if ((i == 15) && (_ticks != time))
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

                if ((i == 16) && (_ticks != time))
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
    }
}
