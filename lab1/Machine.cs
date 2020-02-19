using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Machine
    {
        List<Album> albums = new List<Album>();
        //Dictionary<string, string> SAPair = new Dictionary<string, string>();
       

        public void addAlbums(string name, List<Song> songs, string releasedate, decimal price)
        {
            albums.Add(new Album(name, songs, releasedate, price));

        }
        public void addAlbums(List<Album> _albums)
        {
            albums.AddRange(_albums);
        }


        List<Song> findSortedListOfSongs(string songname, string albumname, string singer, string genre, decimal currentamount)
        {
            List<Song> songs = new List<Song>();
            if (currentamount < 0)
            {
                return songs;
            }
            if (songname== null && singer ==null && genre == null && albumname == null)
            {
                return songs;
            }
            foreach (Album al in albums)
            {
                if (al.price <= currentamount)
                {
                    if (albumname == null)
                    {
                        songs.AddRange(al.songs);
                    }
                    else if(albumname == al.name)
                    {
                        foreach (Song c in al.songs)
                        {
                            songs.Add(c);
                        }
                    }
                }
            
            }

            if (songname != null)
            {
                foreach (Song c in songs)
                {
                    if (c.name != songname)
                    {
                        songs.Remove(c);
                    }
                }
            }

            if (genre != null)
            {
                foreach (Song c in songs)
                {
                    if (c.genre != genre)
                    {
                        songs.Remove(c);
                    }
                }
            }

            if (singer != null)
            {
                foreach (Song c in songs)
                {
                    if (c.singer != singer)
                    {
                        songs.Remove(c);
                    }
                }
            }


            return songs;
        }
    }
}
