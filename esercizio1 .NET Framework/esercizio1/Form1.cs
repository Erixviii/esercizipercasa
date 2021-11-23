using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esercizio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cfrazione a = new Cfrazione(1,360);
            a.MinComMult(a,a);
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
            res.Numeratore = a.Numeratore * (res.Denominatore - a.Denominatore) + b.Numeratore * (res.Denominatore - b.Denominatore);

            Semplifica(ref res);

            return res;
        }

        public Cfrazione SottrFrazioni(Cfrazione a, Cfrazione b)
        {
            Cfrazione res = new Cfrazione();

            res.Denominatore = a.Denominatore * b.Denominatore;
            res.Numeratore = a.Numeratore * (res.Denominatore - a.Denominatore) - b.Numeratore * (res.Denominatore - b.Denominatore);

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
        public int MinComMult(Cfrazione a, Cfrazione b)
        {
            
            int[] fattoria= Fattorizzazione(a.Denominatore);
            int[] fattorib = Fattorizzazione(b.Denominatore);

            
            MessageBox.Show(calcolopotenza(3,2).ToString());
            return 0;
        }

        int calcolopotenza(int b,int e)
        {
            int c = 1;

            for (int i = 0; i < e; i++)
            {
                c = c * b;
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

            int cont2 = 0;
            int cont3 = 0;
            int cont5 = 0;
            int cont7 = 0;
            int continpiu = 0;

            foreach (int item in fattori)
            {
                if (item == 2) cont2++;
                if (item == 3) cont3++;
                if (item == 5) cont5++;
                if (item == 7) cont7++;
                if (item == num) continpiu=num;
            }

            return new int[] { cont2,cont3,cont5,cont7,continpiu };
        }
        public Cfrazione MassComDiv(){ return null;}

        public int Numeratore { get => _numeratore; set => _numeratore = value; }
        public int Denominatore { get => _denominatore; set => _denominatore = value; }
    }
}
