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

        public BindingList<User> LSTusers;
        private string user;
        private string name;

        private void Form1_Load(object sender, EventArgs e)
        {
            name = "eric";
            user = null;
            LSTusers = JsonConvert.DeserializeObject<BindingList<User>>(File.ReadAllText(@"../../users1.json"));
            Form2 frm2= new Form2(this);
            frm2.Text = $"Admin {name}";
            frm2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (User utn in LSTusers)
                if (utn.password == textBox2.Text && utn.email == textBox3.Text) { 
                    user = utn.role;
                    name = utn.first_name; 
                }

            if (user!=null)
                Quit(user);
            else
                MessageBox.Show("wrong info!!");

            user = null;
        }

        public void Quit(string role)
        {
            if (role == "admin")
            {
                Form2 frm2 = new Form2(this);
                frm2.Text = $"Admin {name}";
                frm2.Show();
            }
            else
                new Form3(this).Show();
        }
    }

    public interface IsLoaned
    {
        bool IsLoaned { get;set; }
    }
    public class Prestito
    {
        public string Isbn{get;set;}
        public string Usercode { get; set; }
        public string Initialdate { get; set; }
        public string Enddate { get; set; }
        public string Rating { get; set; }
        public Dictionary<User,BindingList<Book>> Loans { get; set; }   
    }   
}
