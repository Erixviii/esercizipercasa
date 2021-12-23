using System.Collections.Generic;

namespace Player_musicale
{
    class Playlist
    {

        public Queue<Song> Songs;
        public List<Song> AllSongs;

        public Playlist()
        {
            Songs = new Queue<Song>();
            AllSongs = new List<Song>();
            foreach (Song song in Songs)
                AllSongs.Add(song);
        }
    }
}
