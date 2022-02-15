using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBinding
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            Dipartimenti d1 = new Dipartimenti("Economia");
            d1.Studenti.Add(new Studente("Turso Antonella", "Vicenza"));
            d1.Studenti.Add(new Studente("Anna Todescan", "Padova"));
            d1.Studenti.Add(new Studente("Maito Bababia", "Treviso"));

            Dipartimenti d2 = new Dipartimenti("Psicologia");
            d2.Studenti.Add(new Studente("Francesco Fantton", "Napoli"));
            d2.Studenti.Add(new Studente("Finello Riccardo", "Bologna"));
            d2.Studenti.Add(new Studente("Filippo Vigolo", "Parma"));

            Dipartimenti d3 = new Dipartimenti("Matematica");
            d3.Studenti.Add(new Studente("Salvatore Greco", "Napoli"));
            d3.Studenti.Add(new Studente("Brunelli Paolo", "Bologna"));
            d3.Studenti.Add(new Studente("Marletta Giuseppe", "Parma"));

            List<Dipartimenti> facolta = new List<Dipartimenti>();
            facolta.Add(d1);
            facolta.Add(d2);
            facolta.Add(d3);


            BindingSource comboBoxSource = new BindingSource
            {
                DataSource = facolta
            };

            comboBox1.DataSource = comboBoxSource;
            comboBox1.DisplayMember = "Nome";

            BindingSource listBoxSource = new BindingSource
            {
                DataSource = comboBox1.DataSource,
                DataMember = "Studenti"
            };

            listBox1.DataSource = listBoxSource;
            listBox1.DisplayMember = "Nome";
            textBox1.DataBindings.Add("Text", listBoxSource, "Indirizzo");

        }
    }
}
