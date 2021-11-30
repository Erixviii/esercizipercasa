using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace esercizio1
{
    public partial class Form1 : Form
    {
        private Cfrazione a;
        private Cfrazione b;
        private Cfrazione c;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            a = new Cfrazione(1, 36);
            b = new Cfrazione(22, 33);
            c = new Cfrazione();

            b.MinComMult(a, b);
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox This = sender as TextBox;

            if (!int.TryParse(This.Text, out int n) || n < 0 || 
               (This == textBox4 && n == 0) || //denominatore
               (This == textBox5 && n == 0) || //denominatore
               (This == textBox6 && n == 0) /*denominatore*/)  This.Text = "";

        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton This = sender as RadioButton;

            if (textBox1.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                Assegnamento(a, textBox1.Text, textBox4.Text);
                Assegnamento(b, textBox3.Text, textBox5.Text);

                switch (This.Text)
                {
                    case "Sum":
                        c = c.SommaFrazioni(a, b);
                        MessageBox.Show(c.Numeratore.ToString()+" "+ c.Denominatore.ToString());
                        break;
                    case "Difference":
                        c = c.SottrFrazioni(a, b);
                        break;
                    case "Moltiplication":
                        c = c.MoltFraz(a, b);
                        break;
                    case "Division":
                        c = c.DivFraz(a, b);
                        break;

                }
                Assegnamento(c, textBox2, textBox6);
            }
        }

        void Assegnamento(Cfrazione d, TextBox txt1, TextBox txt2)
        {

            txt1.Text = d.Numeratore.ToString();
            txt2.Text = d.Denominatore.ToString();
        }

        void Assegnamento(Cfrazione d, string txt1, string txt2)
        {

            d.Numeratore=int.Parse(txt1);
            d.Denominatore=int.Parse(txt2);
        }
    }

    public class Cfrazione
    {
        private int _numeratore;
        private int _denominatore;

        public Cfrazione()
        {
            Numeratore=0;
            Denominatore=0;
        }

        public Cfrazione(int numeratore, int denominatore)
        {
            Numeratore = numeratore;
            Denominatore = denominatore;
        }

        public void Semplifica(ref Cfrazione a) 
        {
            for (int i = 1; i < 10; i++)
            {
                if(a.Numeratore%i==0&& a.Denominatore % i == 0)
                {

                    a.Numeratore /= i;
                    a.Denominatore /= i;
                }
            }
        }

        public Cfrazione SommaFrazioni(Cfrazione a,Cfrazione b) 
        {
            Cfrazione res = new Cfrazione();

            res.Denominatore = a.Denominatore * b.Denominatore;
            res.Numeratore = a.Numeratore * (res.Denominatore / a.Denominatore) + b.Numeratore * (res.Denominatore / b.Denominatore);

            Semplifica(ref res);

            return res;
        }

        public Cfrazione SottrFrazioni(Cfrazione a, Cfrazione b)
        {
            Cfrazione res = new Cfrazione();

            res.Denominatore = a.Denominatore * b.Denominatore;
            res.Numeratore = a.Numeratore * (res.Denominatore / a.Denominatore) - b.Numeratore * (res.Denominatore / b.Denominatore);

            Semplifica(ref res);

            return res;
        }
        public Cfrazione MoltFraz(Cfrazione a, Cfrazione b)
        {
            Cfrazione res = new Cfrazione();

            res.Denominatore = a.Denominatore * b.Denominatore;
            res.Numeratore = a.Numeratore * b.Numeratore ;

            Semplifica(ref res);

            return res;
        }
        public Cfrazione DivFraz(Cfrazione a, Cfrazione b)
        {
            Cfrazione res = new Cfrazione();

            int bnum = b.Numeratore;
            b.Numeratore = b.Denominatore;
            b.Denominatore = bnum;

            res.Denominatore = a.Denominatore * b.Denominatore;
            res.Numeratore = a.Numeratore * b.Numeratore;

            Semplifica(ref res);

            return res;
        }
        public void MinComMult(Cfrazione a, Cfrazione b)
        {

            int[] fattoria = Fattorizzazione(a.Denominatore);
            int[] fattorib = Fattorizzazione(b.Denominatore);
            int[] fattoric = new int[5];

            int i = 0;
            foreach (int item in fattorib)
            {
                if (fattoria[i] != 0 && fattorib[i] != 0)
                {
                    if (fattoria[i] <= fattorib[i])
                    {
                        fattoric[i] = fattoria[i];
                    }
                    else
                    {
                        fattoric[i] = fattorib[i];
                    }
                }

                i++;
            }
        }

        int calcolopotenza(int b,int e)
        {
            int c = 1;

            for (int i = 0; i < e; i++)
            {
                c *= b;
            }

            return c;
        }

        private int[] Fattorizzazione(int num)
        {
            List<int> fattori= new List<int>();

            while (num % 2 == 0)
            {

                fattori.Add(2);
                num /= 2;
            }

            while (num % 3 == 0)
            {

                fattori.Add(3);
                num /= 3;
            }

            while (num % 5 == 0)
            {

                fattori.Add(5);
                num /= 5;
            }

            while (num % 7 == 0)
            {

                fattori.Add(7);
                num /= 7;
            }

            if (num != 1)
            {
                fattori.Add(num);
            }

            int esp2 = 0;
            int esp3 = 0;
            int esp5 = 0;
            int esp7 = 0;
            int continpiu = 0;

            foreach (int item in fattori)
            {
                if (item == 2) esp2++;
                if (item == 3) esp3++;
                if (item == 5) esp5++;
                if (item == 7) esp7++;
                if (item == num) continpiu=item;
            }

            return new int[] { esp2,esp3,esp5,esp7,continpiu };
        }
        public Cfrazione MassComDiv()
        {
            int[] fattoria = Fattorizzazione(a.Denominatore);
            int[] fattorib = Fattorizzazione(b.Denominatore);
            int[] fattoric = new int[5];

            int i = 0;
            foreach (int item in fattorib)
            {
                if (fattoria[i] != 0 && fattorib[i] != 0)
                {
                    if (fattoria[i] <= fattorib[i])
                    {
                        fattoric[i] = fattoria[i];
                    }
                    else
                    {
                        fattoric[i] = fattorib[i];
                    }
                }

                i++;
            }
            return null;
        }

        public int Numeratore { get => _numeratore; set => _numeratore = value; }
        public int Denominatore { get => _denominatore; set => _denominatore = value; }
    }
}
