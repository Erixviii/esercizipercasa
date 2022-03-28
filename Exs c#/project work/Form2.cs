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
        private BindingList<User> LSTusers;
        private BindingList<Book> LSTbooks;
        private List<User> newuser;
        private BindingSource SRCusers;
        private BindingSource SRCbooks;
        private Dictionary<int,Book> Library;
        private delegate void Delegaterefresh(object sender, ListChangedEventArgs e);
        Delegaterefresh Reloadjsons;
        public Form2(Form1 back)
        {
            InitializeComponent();
            LSTusers = back.LSTusers;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            LSTbooks = JsonConvert.DeserializeObject<BindingList<Book>>(File.ReadAllText(@"../../books1.json"));
            Library = new Dictionary<int, Book>();

            foreach (Book utn in LSTbooks)
                Library.Add(Library.Count, utn);

            FillCMBfilters();
            Bindingusers();
            Bindingbooks();
            EventHandling();
            Reloadjsons(this, null);
        }
        private void EventHandling()
        {
            Reloadjsons = new Delegaterefresh(Refreshusers);
            Reloadjsons += new Delegaterefresh(Refreshbooks);

            LSTusers.ListChanged += new ListChangedEventHandler(Refreshusers);
            LSTbooks.ListChanged += new ListChangedEventHandler(Refreshbooks);

            LBLisbn.Click += new EventHandler(TypingTXT);
            LBLtitle.Click += new EventHandler(TypingTXT);
            LBLauthors.Click += new EventHandler(TypingTXT);
            LBLsubtitle.Click += new EventHandler(TypingTXT);
            LBLcategories.Click += new EventHandler(TypingTXT);
            LBLpublished_year.Click += new EventHandler(TypingTXT);
            LBLaverage_rating.Click += new EventHandler(TypingTXT);
            LBLqta.Click += new EventHandler(TypingTXT);
            LBLpages.Click += new EventHandler(TypingTXT);
            LBLdescription.Click += new EventHandler(TypingTXT);
            IMGthumbnail.Click += new EventHandler(Loadimg);

            TXTdinamic.VisibleChanged += new EventHandler(TypingTXT2);
            SRCbooks.ListChanged += new ListChangedEventHandler(TypingTXT3);
        }

        private void TypingTXT(object sender, EventArgs e)
        {
            CMBfilters.Focus();

            try { TXTdinamic.DataBindings.RemoveAt(0); } catch { }

            TXTdinamic.Size = new Size(135, 22);
            TXTdinamic.ScrollBars = ScrollBars.None;
            TXTdinamic.Multiline = false;
            TXTdinamic.Height = 22;
            TXTdinamic.Visible = true;
            TXTdinamic.Left = (sender as Control).Left + (sender as Control).Width + 10;
            TXTdinamic.Top = (sender as Control).Top;

            if (sender as Label == LBLdescription)
            {
                LBLdescription.Visible = false; 
                TXTdinamic.Multiline = true;
                TXTdinamic.ScrollBars = ScrollBars.Both;
                TXTdinamic.Size = new Size(450,380);
                TXTdinamic.Location= LBLdescription.Location;
            }

            if (sender as PictureBox == IMGthumbnail)
            {
                IMGthumbnail.Visible = false;
                url = true;
                TXTdinamic.Location = IMGthumbnail.Location;
            }

            TXTdinamic.DataBindings.Add(new Binding("Text", SRCbooks, (sender as Control).DataBindings[0].BindingMemberInfo.BindingMember));
            TXTdinamic.Focus();
        }

        bool url;

        private void TypingTXT2(object sender, EventArgs e)
        {

            if (!TXTdinamic.Visible)
                TXTdinamic.Visible = false;

            LBLdescription.Visible=true;

            if (url)
            {
                IMGthumbnail.ImageLocation = TXTdinamic.Text;
                url = false;
            }  

            IMGthumbnail.Visible = true;
        }

        private void TypingTXT3(object sender, ListChangedEventArgs e)
        {
            TXTdinamic.Visible = false;
        }

        private void FillCMBfilters()
        {
            CMBfilters.Items.Add("isbn");
            CMBfilters.Items.Add("title");
            CMBfilters.Items.Add("authors");
            CMBfilters.Items.Add("subtitle");
            CMBfilters.Items.Add("categories");
        }

        private void Bindingbooks()
        {
            var filter = from l in LSTbooks
                         where Checkfilter(l)
                         select l;

            List<Book> LSTfiltered = filter.ToList();

            SRCbooks = new BindingSource()
            {
                DataSource = LSTfiltered
            };

            try { LBLisbn.DataBindings.RemoveAt(0);} catch {}
            try { LBLtitle.DataBindings.RemoveAt(0);}catch{}
            try { LBLauthors.DataBindings.RemoveAt(0);}catch{}
            try { LBLsubtitle.DataBindings.RemoveAt(0);}catch{}
            try { LBLcategories.DataBindings.RemoveAt(0);}catch{}
            try { LBLpublished_year.DataBindings.RemoveAt(0);}catch{}
            try { LBLaverage_rating.DataBindings.RemoveAt(0);}catch{}
            try { LBLqta.DataBindings.RemoveAt(0);}catch{}
            try { LBLpages.DataBindings.RemoveAt(0);}catch{}
            try { LBLdescription.DataBindings.RemoveAt(0);}catch{}
            try { IMGthumbnail.DataBindings.RemoveAt(0);} catch {}

            LBLisbn.DataBindings.Add(new Binding("Text", SRCbooks, "isbn"));
            LBLtitle.DataBindings.Add(new Binding("Text", SRCbooks, "title"));
            LBLauthors.DataBindings.Add(new Binding("Text", SRCbooks, "authors"));
            LBLsubtitle.DataBindings.Add(new Binding("Text", SRCbooks, "subtitle"));
            LBLcategories.DataBindings.Add(new Binding("Text", SRCbooks, "categories"));
            LBLpublished_year.DataBindings.Add(new Binding("Text", SRCbooks, "published_year"));
            LBLaverage_rating.DataBindings.Add(new Binding("Text", SRCbooks, "average_rating"));
            LBLqta.DataBindings.Add(new Binding("Text", SRCbooks, "qta"));
            LBLpages.DataBindings.Add(new Binding("Text", SRCbooks, "num_pages"));
            LBLdescription.DataBindings.Add(new Binding("Text", SRCbooks, "description"));
            IMGthumbnail.DataBindings.Add(new Binding("ImageLocation", SRCbooks, "thumbnail"));
        }

        private void Bindingusers()
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

            TXTname.DataBindings.Add(new Binding("Text",SRCusers,"first_name"));
            TXTsurname.DataBindings.Add(new Binding("Text",SRCusers,"last_name"));
            TXTemail.DataBindings.Add(new Binding("Text",SRCusers,"email"));
            TXTrole.DataBindings.Add(new Binding("Text",SRCusers,"role"));
            TXTcity.DataBindings.Add(new Binding("Text",SRCusers,"city"));
            TXTcode.DataBindings.Add(new Binding("Text",SRCusers,"code"));
            TXTpassword.DataBindings.Add(new Binding("Text",SRCusers,"password"));
            TXTbirth.DataBindings.Add(new Binding("Text",SRCusers,"birth_date"));

            button5.DataBindings.Add(new Binding("Visible", CKUserlist, "Checked"));
            listBox1.DataBindings.Add(new Binding("Visible", CKUserlist, "Checked"));
            GRPinfo.DataBindings.Add(new Binding("Visible", CKUserlist, "Checked"));

            dataGridView1.DataBindings.Add(new Binding("Visible", CKuseradd, "Checked"));
            button2.DataBindings.Add(new Binding("Visible", CKuseradd, "Checked"));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SRCusers.RemoveCurrent();
            Reloadjsons(this, null);
        }
        private void Refreshusers(object sender, ListChangedEventArgs e)
        {
            //var LSTbackup = JsonConvert.DeserializeObject<BindingList<User>>(File.ReadAllText(@"../../users1.json"));
            File.WriteAllText(@"../../users1.json", JsonConvert.SerializeObject(LSTusers));
            //LSTusers = LSTbackup;
        }
        private void Refreshbooks(object sender, ListChangedEventArgs e)
        {
            //var LSTbackup = JsonConvert.DeserializeObject<BindingList<User>>(File.ReadAllText(@"../../users1.json"));
            File.WriteAllText(@"../../books1.json", JsonConvert.SerializeObject(LSTbooks));
            //LSTusers = LSTbackup;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LSTusers.Insert(0, newuser[0]);

            newuser = new List<User>()
            {
                new User("","","","","","","","")
            };

            
            dataGridView1.DataSource = newuser;

            Reloadjsons(this, null);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            Bindingbooks();
        }

        private bool Checkfilter(Book word)
        {

            switch (CMBfilters.Text)
            {
                case "isbn":
                    return word.isbn.ToLower().Contains(TXTcerca.Text.ToLower());
                case "title":
                    return word.title.ToLower().Contains(TXTcerca.Text.ToLower());
                case "authors":
                    return word.authors.ToLower().Contains(TXTcerca.Text.ToLower());
                case "categories":
                    return word.categories.ToLower().Contains(TXTcerca.Text.ToLower());
                case "subtitle":
                    return word.subtitle.ToLower().Contains(TXTcerca.Text.ToLower());
                default:
                    return true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {
            if (SRCbooks.Position < SRCbooks.Count-1)
                SRCbooks.MoveNext();
            else
                SRCbooks.MoveFirst();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            if (SRCbooks.Position > 0)
                SRCbooks.MovePrevious();
            else
                SRCbooks.MoveLast();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Text == "Add")
            {
                SRCbooks.Add(new Book());
                SRCbooks.MoveLast();
            }
            else
                SRCbooks.RemoveCurrent();

            Reloadjsons(this, null);

        }
        private void Loadimg(object sender, EventArgs e)
        {
            DialogResult question = MessageBox.Show("From Url(Yes) or File(No)", "From?", MessageBoxButtons.YesNoCancel);
            if (question == DialogResult.Yes)
                TypingTXT(sender, null);
            else if(question == DialogResult.No)
            {
                OpenFileDialog search = new OpenFileDialog();
                search.FileOk += new CancelEventHandler(Searching);
                search.ShowDialog();
            }
        }

        private void Searching(object sender, CancelEventArgs e)
        {
            try { IMGthumbnail.Image = Image.FromFile((sender as OpenFileDialog).FileName); } catch { }
            IMGthumbnail.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            string lasttxt = button.Text;
            Color lastcolor = button.BackColor;

            button.Text = button6.Text;
            button.BackColor = button6.BackColor;
            button6.Text = lasttxt;
            button6.BackColor = lastcolor;
        }
    }
}
