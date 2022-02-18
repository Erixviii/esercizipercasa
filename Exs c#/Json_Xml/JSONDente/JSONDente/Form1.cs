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
using System.IO;

namespace JSONDente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Studente st1 = new Studente(1,"Gabriele",DateTime.Today,"Via Rovegiara");

            Studente st2 = new Studente( 2, "Daniel", DateTime.Today, "Via Bosco");

            textBox1.Text = JsonConvert.SerializeObject(st1) + "\n" + JsonConvert.SerializeObject(st2);

        }

        private void button2_Click(object sender, EventArgs e)
        {
        
            textBox2.Text = File.ReadAllText("C:\\Users\\4079753\\Documents\\GitHub\\esercizipercasa\\JSONDente.json");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            File.WriteAllText("C:\\Users\\4079753\\Documents\\GitHub\\esercizipercasa\\JSONDente.json", textBox3.Text);
        }
    }

    class Studente
    {
        public Studente(int id,string no,DateTime date, string dove)
        {

            IdPerson = id;
            Nome = no;
            DataNascita = date;
            Indirizzo = dove;
        }

        public int IdPerson { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascita { get; set; }
        public string Indirizzo { get; set; }
    }
}
