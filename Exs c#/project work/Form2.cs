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
            BindingSource SRCusers = new BindingSource()
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
        }
    }
}
