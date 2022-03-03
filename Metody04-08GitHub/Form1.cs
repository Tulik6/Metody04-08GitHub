﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody04_08GitHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            MessageBox.Show("Mocnina je " + CelaCisla.Mocnina(x, y));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox3.Text);
            MessageBox.Show("Faktoriál je " + CelaCisla.Faktorial(x));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox4.Text);
            MessageBox.Show("Součet lichých cifer je " + CelaCisla.CifLichSoucet(x));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox5.Text);
            if (CelaCisla.JePrvocislo(x)) MessageBox.Show("Číslo " + x + " je prvočíslo");
            else MessageBox.Show("Číslo " + x + " není prvočíslo");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CelaCisla celCis = new CelaCisla();
            int x = int.Parse(textBox6.Text);
            MessageBox.Show("Počet sudých dělitelů je " + celCis.PocetSudDelitelu(x));
        }
    }
}
