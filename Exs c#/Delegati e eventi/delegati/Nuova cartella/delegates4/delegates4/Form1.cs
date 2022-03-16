using System;
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
        //il descrittore public lo rende visibile anche fuori dalla unità di programma;
        //la parola chiave delegate è un particolare tipo di dato che lo contraddistingue come un delegato,
        //ovvero un metodo da associare a un corpo; il resto dei comandi specifica tipo nome e parametri del delegato
        DelegatoTest dt = new DelegatoTest(InviaMessaggio);
        //In questo caso si crea un oggetto (di tipo delegato) istanziato dall'omonimo costruttore,
        //il quale costruttore si aspetta come parametro il nome di un metodo (con corpo) da associare al nome del delegato.

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
            //è stato associato l’invocazione del delegato, ovvero la sua “attivazione”,
            //il momento in cui il delegato è chiamato ad agire e a porre in azione l’effetto richiesto
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
            //I delegati possono contenere una lista interna di delegati (chiamata invocation list) che contiene delegati aventi la stessa firma,
            //si parla in questi casi di delegati multicast. Quando un delegato di questo tipo viene invocato esso a sua volta invoca tutti i delegati presenti
            //nella sua invocation list.
            //E’ possibile aggiungere e rimuovere delegati da una invocation list utilizzando gli operatori di overload ++== e --=
            int n1, n2;
            n1 = Convert.ToInt32(textBox1.Text);
            n2 = Convert.ToInt32(textBox2.Text);

            deleg_1 += MediaDelegata;//richiama la funzione MediaDelegata
            double ris1 = deleg_1(n1, n2);
            MessageBox.Show(" il risultato finale è: " + ris1);//output: 1, risultato media

            deleg_1 += MassimoDelegato;//Accoda alla funzione precedente anche MassimoDelegato
            double ris2 = deleg_1(n1, n2);
            MessageBox.Show("il risultato finale è: " + ris2);//output: media  e il massimo

            deleg_1 += DistanzaDelegata;//accoda l'ultima funzione DistanzaDelegato
            double ris3 = deleg_1(n1, n2);
            MessageBox.Show("il risultato finale è: " + ris3);//restituisce in output: media, massimo più il risultato della radice quadrata delle somme di prodotto

            deleg_1 -= DistanzaDelegata;//ho eliminato dalla coda la funzione Distanza Delegata
            double ris4 = deleg_1(n1, n2);
            MessageBox.Show("il risultato finale è: " + ris4);//mi restituirà la funzione massimo

        }
    }
}
