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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            string Parola = textBox1.Text;
            int Lunghezzaparola = Parola.Length;
            bool result = int.TryParse(Parola, out i);
            if(i==0 && Lunghezzaparola<=6)
            {
                progressBar1.Value = 1;
                progressBar1.PerformStep();
                this.timer1.Start();
                label8.Text = "";
                string parolal = "";
                Lunghezzaparola = Parola.Length;
                char[] Lettereparola = Parola.ToCharArray();
                for (int x = 0; x < Lunghezzaparola; x++)
                {
                    string l = Convert.ToString(Convert.ToInt32(Lettereparola[x]) - 96);
                    parolal = parolal + l + " ";
                }
                textBox2.Text = parolal;

            }
            else
            {
                label8.Text = "Input errato(è possibile inserire solo lettere e massimo 6 caratteri)";
                textBox2.Text = "";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //progressBar1.Value = 1;
            string parola = textBox3.Text;
            string a = "";
            string y = "";
            int f;
            string z = "";
            string[] words = parola.Split(' ');
            foreach (var wordl in words)
            {
                y += wordl;
            }
            int i;
            string Parola = y;
            bool result = int.TryParse(Parola, out i);
            if(i!=0)
            {
                progressBar2.Value = 1;
                progressBar2.PerformStep();
                this.timer2.Start();
                label9.Text = "";
                foreach (var word in words)
                {
                    //progressBar2.Value += 99;
                    f = Convert.ToInt32(word) + 96;
                    z = Convert.ToString(char.ConvertFromUtf32(f));
                    a = a + z;
                }
                textBox4.Text = a;
            }
            else
            {
                label9.Text = "Input errato(è possibile inserire solo numeri)";
                textBox4.Text = "";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form7 x = new Form7();
            x.Show();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(500);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.progressBar2.Increment(500);
        }
    }
}
