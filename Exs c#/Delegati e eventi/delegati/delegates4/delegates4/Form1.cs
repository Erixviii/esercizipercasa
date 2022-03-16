﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace delegates4
{
    public partial class Form1 : Form
    {

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        static void InviaMessaggio(string s)
        {
            MessageBox.Show(s);
        }
        public delegate void DelegatoTest(string s);
        DelegatoTest dt = new DelegatoTest(InviaMessaggio);

        public delegate double DelegatoTest2(int a, int b);
        DelegatoTest2 dt2 = new DelegatoTest2(CalcolaMedia);

        public delegate double MioDelegato(double a, double b);
        static double CalcolaMedia(int a, int b)
        {
            return (a + b) / 2.0;
        }
        public double MediaDelegata(double a, double b)
        {

            return ((a + b) / 2.0);

        }
        public double MassimoDelegato(double a, double b)
        {

            if (a > b) return a;

            else return b;

        }
        public double DistanzaDelegata(double a, double b)
        {

            return Math.Sqrt(a * a + b * b);
        }
        MioDelegato deleg_1; //istanzio un oggetto di tipo delegato MioDelegato che a sua volta va a richiamare le tre funzioni create prima
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt("Benvenuto");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n1, n2;
            n1 = Convert.ToInt32(textBox1.Text);
            n2 = Convert.ToInt32(textBox2.Text);
            double ris = dt2(n1, n2);
            MessageBox.Show("" + ris);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n1, n2;
            n1 = Convert.ToInt32(textBox1.Text);
            n2 = Convert.ToInt32(textBox2.Text);

            deleg_1 += MediaDelegata;
            double ris1 = deleg_1(n1, n2);
            MessageBox.Show(" il risultato finale è: " + ris1);

            deleg_1 += MassimoDelegato;
            double ris2 = deleg_1(n1, n2);
            MessageBox.Show("il risultato finale è: " + ris2);

            deleg_1 += DistanzaDelegata;
            double ris3 = deleg_1(n1, n2);
            MessageBox.Show("il risultato finale è: " + ris3);

            deleg_1 -= DistanzaDelegata;
            double ris4 = deleg_1(n1, n2);
            MessageBox.Show("il risultato finale è: " + ris4);

        }
    }
}
