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
    public partial class Settings : Form
    {
        public static int time = 300;
        public static bool Locate_hider = false;

        public Settings()
        {
            InitializeComponent();
            textBox2.Text = time.ToString();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            if (Locate_hider == false)
            {
                button3.BackColor = Color.DarkGray;
            }
            else
            {
                button4.BackColor = Color.DarkGray;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form1 = new Form1();
            Form1.Show();
            WindowState = FormWindowState.Normal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = textBox1.Text;
            string message2 = textBox2.Text;
            time = int.Parse(textBox2.Text);
            string title = "Message";
            MessageBox.Show(message + " Hide" + "\n" + message2 + " Search", title);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Locate_hider = false;
            button3.BackColor = Color.DarkGray;
            button4.BackColor = Color.LightGray;
            MessageBox.Show("Locate hider is turned Off", "Update");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Locate_hider = true;
            button4.BackColor = Color.DarkGray;
            button3.BackColor = Color.LightGray;
            MessageBox.Show("Locate hider is turned On", "Update");
        }
    }
}
