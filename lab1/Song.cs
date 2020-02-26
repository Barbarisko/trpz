using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Song
    {
        private string name;
        private string genre;
        private string singer;
        private decimal duration;

        public string Name { get { return name; } set { name = value; } }
        public string Genre { get { return genre; } set { genre = value; } }
        public string Singer { get { return singer; } set { singer = value; } }
        public decimal Duration { get { return duration; } set { duration = value; } }

        //public Song(string _name, string _genre, string _singer, decimal _duration)
        //{
        //    name = _name;
        //    genre = _genre;
        //    singer = _singer;
        //    duration = _duration;
        //}
    }
}
