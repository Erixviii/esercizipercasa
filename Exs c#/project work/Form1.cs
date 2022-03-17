using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using Newtonsoft.Json;


namespace project_work
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
    }
    class Utente
    {

        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Datadinascita { get; set; }
        public string Codicefiscale { get; set; }
        public string Cittàdiresidenza { get; set; }
        public string Ruolo { get; set; }
        public string Password { get; set; }
    }
    class Libro {

        public string ISBN { get; set; }
        public string Titolo { get; set; }
        public string Sottotitolo { get; set; }
        public string Descrizione { get; set; }
        public string Autori { get; set; }
        public string Anno { get; set; }
        public string Categorie { get; set; }
        public string Immagine { get; set; }
        public string Quantità { get; set; }
        public string Mediavoti { get; set; }
        public string Quantitàvoti { get; set; }
    }
    class Prestito
    {
        public string ISBNlibro{get;set;}
        public string Codicefiscaleutente { get; set; }
        public string Datainizioprestito { get; set; }
        public string Datafineprestito { get; set; }
        public string Rating { get; set; }
    }   
}
