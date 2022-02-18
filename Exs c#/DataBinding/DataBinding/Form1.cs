using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace DataBinding
{
    public partial class Form1 : Form
    {
        List<Persona> persone;
        public Form1()
        {
            InitializeComponent();

            this.DataBindings.Add("Size", textBox4, "text", true, DataSourceUpdateMode.OnPropertyChanged);
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

            comboBox2.DataSource= persone ;
            comboBox2.DisplayMember = "Nomecompleto";

            BindingSource bindlist = new BindingSource
            {
                DataSource = persone,
                DataMember = "Id"
            };

            textBox3.DataBindings.Add(new Binding("Text",persone,"Id", true,DataSourceUpdateMode.OnPropertyChanged));
  
            label6.DataBindings.Add(new Binding("Text", persone, "Nome"));

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 next = new Form2();
            next.Show();
            Hide();
        }
    }
}
