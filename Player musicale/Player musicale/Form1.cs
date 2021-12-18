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
            playlist = new Playlist();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            Song song = new Song(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text));
            playlist.Songs.Enqueue(song);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = playlist.Songs.ToList<Song>();
            dataGridView1.Refresh();
            dataGridView1.Columns.RemoveAt(3);
            dataGridView1.Columns.Add(new DataGridViewButtonColumn() { Text = "Play", Visible = true , Width=50, DefaultCellStyle= new DataGridViewCellStyle { Alignment= DataGridViewContentAlignment.MiddleCenter }  });
            
          
        }
    }

    class Song
    {
        public Song(string nome, string artista, int length, Image photo=null)
        {
            Nome = nome;
            Artista = artista;
            Length = length;
            Photo = photo;
        }

        public string Nome { get; set; }
        public string Artista { get; set; }
        public int Length { get; set; }
        public Image Photo { get; set; }
    }

    class Playlist
    {

        public Queue<Song> Songs;

        public Playlist()
        {
            Songs = new Queue<Song>();
        }
    }
}
