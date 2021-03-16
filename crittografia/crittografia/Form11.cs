using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace crittografia
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int p = 0;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            label7.Text = "";
            label9.Text = "";
            textBox2.Text = "";
            label5.Text = "";
            int z=0;
            richTextBox1.Clear();
            int t = 0;
            string Parola = textBox1.Text;
            int lunghezza = Parola.Length;
            string aa = "";
            string[] x = { "", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "!", "$", "#", "@", "-", "_", ";", "," };
            if(radioButton1.Checked==true | radioButton2.Checked==true | radioButton3.Checked==true | radioButton4.Checked==true)
            {
                if (radioButton1.Checked==true)
                {
                    z = 11;
                }
                else if(radioButton2.Checked==true)
                {
                    z = 37;
                }
                else if (radioButton3.Checked == true)
                {
                    z = 63;
                }
                else if (radioButton4.Checked == true)
                {
                    z = 71;
                }
                if(lunghezza<=10)
                {
                    for (int j = 0; j < z; j++)
                    {
                        for (int i = 0; i < z; i++)
                        {
                            for (int h = 0; h < z; h++)
                            {
                                for (int g = 0; g < z; g++)
                                {
                                    for (int f = 0; f < z; f++)
                                    {
                                        for (int k = 0; k < z; k++)
                                        {
                                            for (int d = 0; d < z; d++)
                                            {
                                                for (int c = 0; c < z; c++)
                                                {
                                                    for (int b = 0; b < z; b++)
                                                    {
                                                        for (int a = 0; a < z; a++)
                                                        {
                                                            richTextBox1.Text += x[j] + x[i] + x[h] + x[g] + x[f] + x[k] + x[d] + x[c] + x[b] + x[a] + "\n";
                                                            richTextBox1.SelectionStart = richTextBox1.TextLength;
                                                            richTextBox1.ScrollToCaret();
                                                            if (Parola == x[j] + x[i] + x[h] + x[g] + x[f] + x[k] + x[d] + x[c] + x[b] + x[a])
                                                            {
                                                                aa = x[j] + x[i] + x[h] + x[g] + x[f] + x[k] + x[d] + x[c] + x[b] + x[a];
                                                                watch.Stop();
                                                                t = 1;
                                                                textBox2.Text = aa;
                                                                label5.Text = "FOUND";
                                                                break;
                                                            }
                                                        }
                                                        if (t == 1)
                                                        {
                                                            break;
                                                        }
                                                    }
                                                    if (t == 1)
                                                    {
                                                        break;
                                                    }
                                                }
                                                if (t == 1)
                                                {
                                                    break;
                                                }
                                            }
                                            if (t == 1)
                                            {
                                                break;
                                            }
                                        }
                                        if (t == 1)
                                        {
                                            break;
                                        }
                                    }
                                    if (t == 1)
                                    {
                                        break;
                                    }
                                }
                                if (t == 1)
                                {
                                    break;
                                }
                            }
                            if (t == 1)
                            {
                                break;
                            }
                        }
                        if (t == 1)
                        {
                            break;
                        }
                    }
                }
                else
                {
                    label7.Text = "parola non più lunga di 10 caratteri";
                }
            }
            else
            {
                label7.Text = "errore: seleziona il tipo di password";
            }
            var elapsedMs = watch.ElapsedMilliseconds/1000;
            if(elapsedMs>60)
            {
                p = Convert.ToInt32(elapsedMs / 60);
                label9.Text = Convert.ToString(p) + "m " + elapsedMs % 60 + "s";
            }
            else
            {
                label9.Text = Convert.ToString(elapsedMs) + "s";
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
