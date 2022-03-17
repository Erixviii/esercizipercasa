using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Collections;

namespace Linq
{
    public partial class Form1 : Form
    {
        //Definisco string array 
        string[] nomi = { "Antonella Turso",
                              "Alberto Costa",
                              "Donatella Bertoletti",
                              "Paolo Brunelli",
                              "Fabrizio Lovison",
                              "Paolo De Rigo",
                              "Mattia Marziale",
                              "Salvatore Spinella",
                              "Chiara Perrotta",
                              "Giorgio Tagliapietra",
                              "Raffaella Borrelli"
                           };
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {


            foreach (var name in nomi)
            {
                textBox1.AppendText("\n" + name + "\n");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Linq query  
            IEnumerable<string> nomiInsegnanti = from nome in nomi
                                                 where nome.Length < 14
                                                 orderby nome descending
                                                 select nome;
            foreach (var name in nomiInsegnanti)
            {
                textBox2.AppendText(name + "\n");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var nomiCheInizianoConLaA = from n in nomi
                                        where n.StartsWith("A")
                                        orderby n ascending //dal  più piccolo al più grande
                                        select n;

            IEnumerable nomiC = nomi.Where(x => x.StartsWith("C")); //Ienumerable variante di var nomiC; operatore Lambda per filtrare al posto di Where

            foreach (var name in nomiCheInizianoConLaA)
            {
                textBox3.AppendText(name + "\n");
            }
            foreach (var name in nomiC)
            {
                textBox3.AppendText("\n" + name + "\n");
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            IEnumerable nomiC15 = nomi.Where(x => x.Length < 16 && !x.StartsWith("A")).OrderByDescending(x => x.Length);

            foreach (var name in nomiC15)
            {
                textBox4.AppendText("\n" + name + "\n");
            }
        }
    }
}
