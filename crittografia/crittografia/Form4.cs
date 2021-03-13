using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace crittografia
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int i = 0;
            string s = textBox1.Text;
            bool result = int.TryParse(s, out i);
            if(i!=0)
            {
                label8.Text = "";
                progressBar1.Value = 1;
                progressBar1.PerformStep();
                this.timer1.Start();
                label13.Text = "";
                string b = "";
                while (i > 0)
                {
                    if (i % 2 == 0)
                        b = '0' + b;
                    else
                        b = '1' + b;
                    i = i / 2;
                }
                textBox2.Text = Convert.ToString(b);
            }
            else
            {
                label13.Text = "Input errato(è possibile inserire solo numeri)";
                textBox2.Text = "";
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form9 d = new Form9();
            d.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1000);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            string s = textBox4.Text;
            bool result = int.TryParse(s, out i);
            if(i!=0)
            {
                label14.Text = "";
                progressBar2.Value = 1;
                progressBar2.PerformStep();
                this.timer2.Start();
                string input = textBox4.Text;
                char[] array = input.ToCharArray();
                Array.Reverse(array);
                int sum = 0;
                for (i = 0; i < array.Length; i++)
                {
                    if (array[i] == '1')
                    {
                        if (i == 0)
                        {
                            sum += 1;
                        }
                        else
                        {
                            sum += (int)Math.Pow(2, i);
                        }
                    }
                }
                textBox3.Text = Convert.ToString(sum);
            }
            else
            {
                label14.Text = "Input errato(è possibile inserire solo numeri)";
                textBox3.Text = "";
            }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.progressBar2.Increment(1000);
        }
    }
}
