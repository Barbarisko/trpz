using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Album

    {
        private string name;
        private List<Song> songs;
        private string releasedate;
        private decimal price;

        public string Name { get { return name; } set { name = value; } }
        public string Releasedate { get { return releasedate; } set { releasedate = value; } }
        public decimal Price { get { return price; } set { price = value; } }
        public List<Song> Songs { get { return songs; } set { songs = value; } }


        //public Album(string _name, List<Song> _songs, string _releasedate, decimal _price)
        //{
        //    name = _name;
        //    songs = _songs;
        //    releasedate = _releasedate;
        //    price = _price;
        //}

        //void addToSongs(string name, string genre, string singer, decimal duration)
        //{
        //    songs.Add(new Song(name, genre, singer, duration));
        //}
    }
}
