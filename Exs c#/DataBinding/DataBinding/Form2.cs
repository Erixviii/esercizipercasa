using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBinding
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            Università un1 = new Università("UNIPD", "Università di Padova", "Padova");
            un1.Dipartimenti.Add(new Dipartimenti("Economia"));
            un1.Dipartimenti.Add(new Dipartimenti("Psicologia"));
            un1.Dipartimenti.Add(new Dipartimenti("Matematica"));
            Università un2 = new Università("UNIVR", "Università di Verona", "Verona");
            un2.Dipartimenti.Add(new Dipartimenti("Ingegneria Informatica"));
            un2.Dipartimenti.Add(new Dipartimenti("Informatica"));
            un2.Dipartimenti.Add(new Dipartimenti("Ingegneria Elettronica"));
            Università un3 = new Università("UNIVE", "Università Ca' Foscari di Venezia", "Venezia");
            un3.Dipartimenti.Add(new Dipartimenti("Lettere"));
            un3.Dipartimenti.Add(new Dipartimenti("Filosofia"));
            un3.Dipartimenti.Add(new Dipartimenti("Economia aziendale"));
            Università un4 = new Università("UNITN", "Università di Trento", "Trento");
            un4.Dipartimenti.Add(new Dipartimenti("Matematica"));
            un4.Dipartimenti.Add(new Dipartimenti("Informatica"));
            un4.Dipartimenti.Add(new Dipartimenti("Economia e Marketing"));
            Università[] Unis = new Università[]
            {
                un1, un2, un3, un4
            };

            BindingSource sorgUni = new BindingSource
            {
                DataSource = Unis
            };

            comboBox1.DataSource = sorgUni;
            comboBox1.DisplayMember = "Sigla";

            textBox1.DataBindings.Add("Text", sorgUni, "Nome");
            textBox2.DataBindings.Add("Text", sorgUni, "Indirizzo");


            BindingSource comboBoxSource = new BindingSource
            {
                DataSource = comboBox1.DataSource,
                DataMember = "Dipartimenti"
            };

            comboBox2.DataSource = comboBoxSource;
            comboBox2.DisplayMember = "Nome";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 next = new Form3();
            next.Show();
            Hide();
        }
    }
}
