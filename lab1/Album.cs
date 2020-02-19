using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Album

    {
        public string name;
        public List<Song> songs = new List<Song>();
        string releasedate;
        public decimal price;

        public Album(string _name, List<Song> _songs, string _releasedate, decimal _price)
        {
            name = _name;
            songs = _songs;
            releasedate = _releasedate;
            price = _price;
        }

        void addToSongs(string name, string genre, string singer, decimal duration)
        {
            songs.Add(new Song(name, genre, singer, duration));
        }
    }
}
