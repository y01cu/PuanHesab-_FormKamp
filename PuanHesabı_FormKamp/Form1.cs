using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuanHesabı_FormKamp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s1, s2, ort;
            s1 = Convert.ToDouble(textBox2.Text);
            s2 = Convert.ToDouble(textBox3.Text);
            ort = (s1 + s2) / 2;

            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(textBox3.Text);
            listBox4.Items.Add(ort.ToString());

            if (ort<50)
            {
                listBox5.Items.Add("Kaldı.");
            }
            else
            {
                listBox5.Items.Add("Geçti.");
            }

        }
    }
}
