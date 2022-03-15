using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace prova_verifica
{
    public partial class Form1 : Form
    {
        List<GenereMusica> LSTGeneri;
        public Form1()
        {
            InitializeComponent();
            textBox6.DataBindings.Add(new Binding("Text", textBox4, "Text"));


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LSTGeneri = new List<GenereMusica>
            {
                new GenereMusica("HP", "Hip-pop"),
                new GenereMusica("RK", "Rock"),
                new GenereMusica("DL", "Drill")
            };

            LSTGeneri[0].LSTCantanti.Add(new Cantante("0", "Daniel", "Colla", "italiano"));
            LSTGeneri[0].LSTCantanti.Add(new Cantante("0", "Enrico", "FigBianc", "russo"));
            LSTGeneri[1].LSTCantanti.Add(new Cantante("0", "Mattia", "SixMattinter", "albanese"));
            LSTGeneri[1].LSTCantanti.Add(new Cantante("0", "Mattia", "SixMattinter", "italiano"));
            LSTGeneri[2].LSTCantanti.Add(new Cantante("0", "Eric", "Erixviii.", "americano"));
            LSTGeneri[2].LSTCantanti.Add(new Cantante("0", "Matteo", "MatGame04", "giapponese"));


            BindingSource source = new BindingSource
            {
                DataSource = LSTGeneri
            };

            comboBox1.DataSource = source;
            comboBox1.DisplayMember = "Sigla";
            
            textBox1.DataBindings.Add(new Binding("Text", source, "NomeGenere"));

            BindingSource internsource = new BindingSource
            {
                DataSource = source,
                DataMember = "LSTCantanti"
            };

            comboBox2.DataSource = internsource;
            comboBox2.DisplayMember = "NomeCompleto";

            textBox2.DataBindings.Add("Text",internsource,"NomeArte");
            textBox3.DataBindings.Add("Text", internsource, "Nazionalità");

            textBox5.Text = JsonConvert.SerializeObject(LSTGeneri);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
