using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DataBinding
{
    public partial class Form1 : Form
    {
        List<Persona> persone;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            persone = new List<Persona>
            {
                new Persona(12, "enrico", "palatella"),
                new Persona(20, "eric", "dente"),
                new Persona(1, "mattia", "chimetto"),
                new Persona(18, "marchiani", "grigno")
            };

            textBox2.DataBindings.Add(new Binding("Text", textBox1, "Text"));
            label3.DataBindings.Add(new Binding("Text", textBox1, "Text"));

            comboBox1.DataSource = persone ;
            comboBox1.DisplayMember = "Cognome";

            comboBox2.DataBindings.Add(new Binding("Text", comboBox1, "Text"));
            comboBox2.DisplayMember = "Nomecompleto";

            BindingSource bindlist = new BindingSource
            {
                DataSource = persone,
                DataMember = "Id"
            };

            textBox3.DataBindings.Add(new Binding("Text",comboBox1,"Id", true,DataSourceUpdateMode.OnPropertyChanged));
  
            label6.DataBindings.Add(new Binding("Text", comboBox1, "Id", true, DataSourceUpdateMode.OnPropertyChanged));

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    class Studente
    {

    }

    class Università
    {

    }

    class Persona
    {
        public Persona(int id, string nome, string cognome)
        {
            Id = id;
            Nome = nome;
            Cognome = cognome;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Nomecompleto { get => $"{Nome} {Cognome}"; set => Nomecompleto = value; }
    }
}
