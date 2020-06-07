using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HideAndSeek
{
    public partial class Hide : Form
    {
        ThreadingClass tc = new ThreadingClass(0);
        public int data1;
        public int data2;

        public Hide()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;         
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


        private void button3_Click(object sender, EventArgs e)
        {
            if ((comboBox1.Text != "Long") && (comboBox1.Text != "Medium") && (comboBox1.Text != "Short"))
            {
                MessageBox.Show("Choose route", "Message");
            }
            else
            {                
                if (comboBox1.Text == "Short")
                {
                    Thread t1 = new Thread(tc.WaitThread);
                    t1.Start(10);
                    Thread t2 = new Thread(tc.DomThread);
                    t2.Start(0);
                    t1.Join();
                    t2.Join();
                }
                if (comboBox1.Text == "Medium")
                {
                    Thread t1 = new Thread(tc.WaitThread);
                    t1.Start(15);
                    Thread t2 = new Thread(tc.DomThread);
                    t2.Start(1);
                    t1.Join();
                    t2.Join();
                }
                if (comboBox1.Text == "Long")
                {
                    Thread t1 = new Thread(tc.WaitThread);
                    t1.Start(20);
                    Thread t2 = new Thread(tc.DomThread);
                    t2.Start(2);
                    t1.Join();
                    t2.Join();
                }
                MessageBox.Show("All threads are ready");

                this.Hide();
                var Form1 = new Form1();
                Form1.Show();
                WindowState = FormWindowState.Normal;
            }
        }
    }
}
