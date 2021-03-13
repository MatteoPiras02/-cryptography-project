using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace crittografia
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 1;
            progressBar1.PerformStep();
            this.timer1.Start();
            string a="";
            var myMsg = textBox2.Text;
            var msgBytes =
           Encoding.ASCII.GetBytes(myMsg);
            var sha = new SHA256Managed();
            var hash = sha.ComputeHash(msgBytes);
            foreach (byte b in hash)
            {
                a = a+ (b.ToString("x2"));
                // write as hexadecimal
            }
            textBox1.Text = a;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form8 t = new Form8();
            t.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1000);
        }
    }
}
