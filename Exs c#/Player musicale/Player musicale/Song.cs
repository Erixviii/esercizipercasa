using System.Drawing;

namespace Player_musicale
{
    class Song
    {
        public Song(string nome, string artista, double length, Image photo=null)
        {
            Nome = nome;
            Artista = artista;
            Length = length;
            Photo = photo;
        }

        public string Nome { get; set; }
        public string Artista { get; set; }
        public double Length { get; set; }
        public Image Photo { get; set; }
    }
}
