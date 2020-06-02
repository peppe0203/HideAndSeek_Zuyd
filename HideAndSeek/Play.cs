using HideAndSeek.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HideAndSeek
{
    public partial class Play : Form
    {
        private int _ticks;
        public int test = Settings.test;

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

            if (_ticks == test)
            {
                textBox1.Text = "Done";
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
    }
}
