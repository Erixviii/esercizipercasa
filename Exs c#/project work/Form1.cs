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

        public BindingList<User> users;
        private string user;

        private void Form1_Load(object sender, EventArgs e)
        {
            user = null;
            users = JsonConvert.DeserializeObject<BindingList<User>>(File.ReadAllText(@"../../users1.json"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(User utn in users)
                if ( utn.password==textBox2.Text && utn.email == textBox3.Text)
                    user = utn.role;
            if (user!=null)
                Quit(user);
            else
                MessageBox.Show("wrong info!!");

            user = null;
        }

        public void Quit(string role)
        {
            if (role == "admin")
                new Form2(this).Show();
            else
                new Form3(this).Show();
        }
    }
    public class User
    {
        public User(string first_name, string last_name, string email, string role, string city, string code, string password, string birth_date)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.email = email;
            this.role = role;
            this.city = city;
            this.code = code;
            this.password = password;
            this.birth_date = birth_date;
        }

        public string first_name{get;set;}
        public string last_name{get;set;}
        public string email{get;set;}
        public string role{get;set;}
        public string city{get;set;}
        public string code{get;set;}
        public string password{get;set;}
        public string birth_date{get;set;}

    }
    public class Libro {

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
    public class Prestito
    {
        public string ISBNlibro{get;set;}
        public string Codicefiscaleutente { get; set; }
        public string Datainizioprestito { get; set; }
        public string Datafineprestito { get; set; }
        public string Rating { get; set; }
    }   
}
