using System;
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
        public User userlogged;
        private bool access=true;

        private void Form1_Load(object sender, EventArgs e)
        {
            LSTusers = JsonConvert.DeserializeObject<BindingList<User>>(File.ReadAllText(@"../../users.json"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (User utn in LSTusers)
                if (utn.password == textBox2.Text && utn.Email == textBox3.Text) { 
                    access = true;
                }

            if (access)
                Quit(userlogged.role);
            else
                MessageBox.Show("wrong info!!");
        }

        public void Quit(string role)
        {
            Form2 frm2 = new Form2(this);
            
            if (role == "admin")
            {
                frm2.Text = $"Admin {userlogged.first_name}";
                frm2.isAdmin = true;
            }
            else
            {
                frm2.Text = $"User {userlogged.first_name}";
                frm2.isAdmin = false;
            }
                


            frm2.Show();
        }
    }
}
