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
    public partial class Form2 : Form
    {
        public BindingList<User> LSTusers;
        private List<User> newuser;
        private BindingSource SRCusers;
        public Form2(Form1 back)
        {
            InitializeComponent();
            LSTusers = back.users;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SRCusers = new BindingSource()
            {
                DataSource = LSTusers
            };

            listBox1.DataSource = SRCusers;
            listBox1.DisplayMember = "first_name";

            newuser = new List<User>()
            {
                new User("","","","","","","","")
            };
            dataGridView1.DataSource = newuser;

            Bindings();
        }

        private void Bindings()
        {
            TXTname.DataBindings.Add(new Binding("Text",SRCusers,"first_name"));
            TXTsurname.DataBindings.Add(new Binding("Text",SRCusers,"last_name"));
            TXTemail.DataBindings.Add(new Binding("Text",SRCusers,"email"));
            TXTrole.DataBindings.Add(new Binding("Text",SRCusers,"role"));
            TXTcity.DataBindings.Add(new Binding("Text",SRCusers,"city"));
            TXTcode.DataBindings.Add(new Binding("Text",SRCusers,"code"));
            TXTpassword.DataBindings.Add(new Binding("Text",SRCusers,"password"));
            TXTbirth.DataBindings.Add(new Binding("Text",SRCusers,"birth_date"));

            button1.DataBindings.Add(new Binding("Visible", checkBox1, "Checked"));
            listBox1.DataBindings.Add(new Binding("Visible", checkBox1, "Checked"));
            GRPinfo.DataBindings.Add(new Binding("Visible", checkBox1, "Checked"));


            dataGridView1.DataBindings.Add(new Binding("Visible", checkBox2, "Checked"));
            button2.DataBindings.Add(new Binding("Visible", checkBox2, "Checked"));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LSTusers.RemoveAt(listBox1.SelectedIndex);
            Refreshusers();
        }
        void Refreshusers()
        {
            File.WriteAllText(@"../../users1.json", JsonConvert.SerializeObject(LSTusers));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LSTusers.Insert(0, newuser[0]);
            Refreshusers();

            newuser = new List<User>()
            {
                new User("","","","","","","","")
            };
            dataGridView1.DataSource = newuser;
        }
    }
}
