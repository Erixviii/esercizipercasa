using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ePOSOne.btnProduct;

namespace Player_musicale
{
    public partial class Form1 : Form
    {
        Playlist playlist;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            playlist = new Playlist() ;
            MessageBox.Show(dataGridView1.Rows.Count.ToString());
            count = 0;
            length = 1;
        }
        
        private void button_WOC1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Song song = new Song(textBox1.Text, textBox2.Text, double.Parse(textBox3.Text), Image.FromFile(openFileDialog1.FileName));
            playlist.Songs.Enqueue(song);
            playlist.AllSongs.Add(song);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = playlist.Songs.ToList<Song>();
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void timer_tick(object sender, EventArgs e)
        {
            count++;

            if (count<=length && dataGridView1.Rows.Count!=0)
            {
                length = int.Parse(dataGridView1.Rows[0].Cells[2].Value.ToString());
                label6.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                label8.Text = "-   " + dataGridView1.Rows[0].Cells[1].Value.ToString();
                label7.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
                pictureBox1.BackgroundImage = (Image)dataGridView1.Rows[0].Cells[3].Value;
                if (label7.Text != "0") 
                {
                    label5.Left += 473 / length;
                    label7.Text = (length-count).ToString();
                }
            }
            else
            {
                if(playlist.Songs.Count>0) playlist.Songs.Dequeue();
                label5.Left = 81;
                count = 0;
                Refreshgrid(playlist.Songs.ToList<Song>());
                foreach (Control item in Controls)
                {
                    if (item.GetType() == typeof(TextBox))
                        item.Text = "";
                }
               
            }

            if (dataGridView1.Rows.Count == 0)
            {
                timer1.Stop();
                foreach (Control item in Controls)
                {
                    if (item.GetType() == typeof(TextBox))
                        item.Text = "";
                }
                pictureBox1.BackgroundImage = null;
                DialogResult hey = MessageBox.Show("Finito.","Finito... Vuoi riascoltare le tue canzoni?", MessageBoxButtons.YesNo);
                if (hey == DialogResult.Yes)
                {   
                    Refreshgrid(playlist.AllSongs);
                    List<Song> list = playlist.AllSongs;
                    playlist = new Playlist();
                    foreach (Song item in list)
                        playlist.Songs.Enqueue(item);
                }   
                else
                {
                    playlist = new Playlist();
                    playlist.AllSongs.Clear();
                    
                }
                
                MessageBox.Show(dataGridView1.Rows.Count.ToString());
                count = 0;
                length = 1;
                label6.Text = "Song";
                label8.Text = "-   Artist";
            } 
        }

        int count = 0;
        int length = 1;
        private void button_WOC2_Click(object sender, EventArgs e)
        {
            count = 0;
            timer1.Start();
        }
        private void Refreshgrid(List<Song> lista)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lista;
            dataGridView1.Refresh();
        }

    }
}
