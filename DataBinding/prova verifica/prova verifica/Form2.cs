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
            LSTCantanti.Add(new Cantante("01", "Daniel", "Colla", "italiano"));
            LSTCantanti.Add(new Cantante("02", "Enrico", "FigBianc", "russo"));
            LSTCantanti.Add(new Cantante("03", "Mattia", "SixMattinter", "albanese"));
            LSTCantanti.Add(new Cantante("04", "Matteo", "MatGame04", "giapponese"));

            LSTCantanti[0].LSTCanzoni.Add(new Canzone("10", "song1","2000"));
            LSTCantanti[0].LSTCanzoni.Add(new Canzone("11", "song1", "2001"));
            LSTCantanti[1].LSTCanzoni.Add(new Canzone("20", "song2", "2001"));
            LSTCantanti[1].LSTCanzoni.Add(new Canzone("21", "song2", "2002"));
            LSTCantanti[2].LSTCanzoni.Add(new Canzone("30", "song3", "2002"));
            LSTCantanti[2].LSTCanzoni.Add(new Canzone("31", "song3", "2003"));
            LSTCantanti[3].LSTCanzoni.Add(new Canzone("40", "song3", "2002"));
            LSTCantanti[3].LSTCanzoni.Add(new Canzone("41", "song3", "2003"));

            BindingSource cantanti = new BindingSource
            {
                DataSource = LSTCantanti
            };

            comboBox1.DataSource = cantanti;
            comboBox1.DisplayMember="NomeCompleto";


            textBox1.DataBindings.Add(new Binding("Text", cantanti, "Nazionalità"));

            BindingSource canzoni = new BindingSource
            {
                DataSource = comboBox1.DataSource,
                DataMember = "LSTCanzoni"
            };

            listBox1.DataSource = canzoni;
            listBox1.DisplayMember = "NomeCanzone";


            textBox2.DataBindings.Add(new Binding("Text", canzoni , "AnnoProduzione"));

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
