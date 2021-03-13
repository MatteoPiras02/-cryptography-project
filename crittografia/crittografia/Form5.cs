using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace crittografia
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ndec = 0;
            string s = textBox1.Text;
            bool result = int.TryParse(s, out ndec);
            if(ndec!=0)
            {
                progressBar1.Value = 1;
                progressBar1.PerformStep();
                this.timer1.Start();
                label9.Text = "";
                String temp = "";
                String nhex = "";
                for (; ; )
                {
                    switch (ndec % 16)
                    {
                        case 0:
                            temp = "0";
                            break;
                        case 1:
                            temp = "1";
                            break;
                        case 2:
                            temp = "2";
                            break;
                        case 3:
                            temp = "3";
                            break;
                        case 4:
                            temp = "4";
                            break;
                        case 5:
                            temp = "5";
                            break;
                        case 6:
                            temp = "6";
                            break;
                        case 7:
                            temp = "7";
                            break;
                        case 8:
                            temp = "8";
                            break;
                        case 9:
                            temp = "9";
                            break;
                        case 10:
                            temp = "A";
                            break;
                        case 11:
                            temp = "B";
                            break;
                        case 12:
                            temp = "C";
                            break;
                        case 13:
                            temp = "D";
                            break;
                        case 14:
                            temp = "E";
                            break;
                        case 15:
                            temp = "F";
                            break;
                        default:
                            break;
                    }
                    if (ndec > 15)
                    {

                        String newhex = nhex.Insert(0, temp);
                        nhex = newhex;
                        ndec = ndec - ndec % 16;
                        ndec = ndec / 16;
                    }
                    else
                    {
                        String newhex = nhex.Insert(0, temp);
                        nhex = newhex;
                        textBox2.Text = Convert.ToString(nhex);
                        break;
                    }
                }
            }
            else
            {
                label9.Text = "Input errato(è possibile inserire solo numeri)";
                textBox2.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string hex = textBox4.Text;
            int intero = Convert.ToInt32(hex, 16);
            textBox3.Text = Convert.ToString(intero);
            progressBar2.Value = 1;
            progressBar2.PerformStep();
            this.timer2.Start();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form10 g = new Form10();
            g.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1000);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.progressBar2.Increment(1000);
        }
    }
}
