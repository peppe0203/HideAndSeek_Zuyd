using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HideAndSeek
{
    public partial class Hide : Form
    {
        public Hide()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
            progressBar1.Step = 1;            
        }

        private void Hide_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form1 = new Form1();
            Form1.Show();
            WindowState = FormWindowState.Normal;
        }

        private void Map_loader_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Short")
            {
                pictureBox1.Image = Image.FromFile("C:\\Github\\DEV_Zuyd\\HideAndSeek\\Resources\\Route_short.jpg");
                textBox1.Text = "10 Seconds";
            }
            if (comboBox1.Text == "Medium")
            {
                pictureBox1.Image = Image.FromFile("C:\\Github\\DEV_Zuyd\\HideAndSeek\\Resources\\Route_medium.jpg");
                textBox1.Text = "15 Seconds";
            }
            if (comboBox1.Text == "Long")
            {
                pictureBox1.Image = Image.FromFile("C:\\Github\\DEV_Zuyd\\HideAndSeek\\Resources\\Route_long.jpg");
                textBox1.Text = "20 Seconds";
            }
            if ((comboBox1.Text != "Long") && (comboBox1.Text != "Medium") && (comboBox1.Text != "Short"))
            {
                MessageBox.Show("Choose route","Message");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Short")
            {
                HttpWebRequest request =
                    WebRequest.Create("http://"+ Play.IP +"/json.htm?type=command&param=switchscene&idx=7&switchcmd=On") as HttpWebRequest;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                response.Close();
                progressBar1.Maximum = 10;
                progressBar1.PerformStep();
                this.timer1.Start();
                comboBox1.Enabled = false;
                Map_loader.Enabled = false;
                button2.Enabled = false;
            }
            if (comboBox1.Text == "Medium")
            {
                HttpWebRequest request =
                    WebRequest.Create("http://" + Play.IP + "/json.htm?type=command&param=switchscene&idx=6&switchcmd=On") as HttpWebRequest;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                response.Close();
                progressBar1.Maximum = 15;
                progressBar1.PerformStep();
                this.timer1.Start();
                comboBox1.Enabled = false;
                Map_loader.Enabled = false;
                button2.Enabled = false;
            }
            if (comboBox1.Text == "Long")
            {
                HttpWebRequest request =
                    WebRequest.Create("http://"+Play.IP + "/json.htm?type=command&param=switchscene&idx=8&switchcmd=On") as HttpWebRequest;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                response.Close();
                progressBar1.Maximum = 20;
                progressBar1.PerformStep();
                this.timer1.Start();
                comboBox1.Enabled = false;
                Map_loader.Enabled = false;
                button2.Enabled = false;
            }
            if ((comboBox1.Text != "Long") && (comboBox1.Text != "Medium") && (comboBox1.Text != "Short"))
            {
                MessageBox.Show("Choose route","Message");
            }           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            if (progressBar1.Value == progressBar1.Maximum)
            {
                this.timer1.Stop();
                MessageBox.Show(comboBox1.Text + " route has been walked");
                this.Hide();
                var Form1 = new Form1();
                Form1.Show();
                WindowState = FormWindowState.Normal;
            }
        }
    }
}
