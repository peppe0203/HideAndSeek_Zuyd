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

            if (_ticks == 20)
            {
                textBox1.Text = "Done";
                timer1.Stop();
            }
        }
    }
}
