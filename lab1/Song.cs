﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Song
    {
        public string name;
        public string genre;
        public string singer;
        decimal duration;

        public Song(string _name, string _genre, string _singer, decimal _duration)
        {
            name = _name;
            genre = _genre;
            singer = _singer;
            duration = _duration;
        }
    }
}
