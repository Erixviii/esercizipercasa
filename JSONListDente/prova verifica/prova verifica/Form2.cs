using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prova_verifica
{
    public partial class Form2 : Form
    {
        List<Cantante> LSTCantanti;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<Cantante> LSTCantanti= new List<Cantante>();
            LSTCantanti.Add(new Cantante("0", "Daniel", "Colla", "italiano"));
            LSTCantanti.Add(new Cantante("0", "Enrico", "FigBianc", "russo"));
            LSTCantanti.Add(new Cantante("0", "Mattia", "SixMattinter", "albanese"));
            LSTCantanti.Add(new Cantante("0", "Mattia", "SixMattinter", "italiano"));
            LSTCantanti.Add(new Cantante("0", "Eric", "Erixviii.", "americano"));
            LSTCantanti.Add(new Cantante("0", "Matteo", "MatGame04", "giapponese"));

            LSTCantanti[0].LSTCanzoni.Add(new Canzone("0", "italiano","20"));
            LSTCantanti[0].LSTCanzoni.Add(new Canzone("0", "russo","20"));
            LSTCantanti[1].LSTCanzoni.Add(new Canzone("0", "albanese","20"));
            LSTCantanti[1].LSTCanzoni.Add(new Canzone("0", "italiano","20"));
            LSTCantanti[2].LSTCanzoni.Add(new Canzone("0", "americano","20"));
            LSTCantanti[2].LSTCanzoni.Add(new Canzone("0", "giapponese","20"));

            BindingSource cantanti = new BindingSource
            {
                DataSource = LSTCantanti
            };

            comboBox1.DataSource = cantanti;
            comboBox1.DisplayMember="NomeCompleto";


            textBox1.DataBindings.Add(new Binding("Text", cantanti, "Nazionalità"));

            listBox1.DataSource = comboBox1.DataSource;
            listBox1.DisplayMember = "NomeCanzone";


            textBox2.DataBindings.Add(new Binding("Text", listBox1.DataSource , "AnnoProduzione"));

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
