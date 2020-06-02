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
        public static int test = 300;

        public Settings()
        {
            InitializeComponent();
            textBox2.Text = test.ToString();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

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
            test = int.Parse(textBox2.Text);
            string title = "Message";
            MessageBox.Show(message + " Hide" + "\n" + message2 + " Search", title);
        }
    }
}
