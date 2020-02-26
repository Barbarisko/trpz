using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Machine
    {
        public  List<Album> albums = new List<Album>();
     
        public void addAlbums()
        {
            albums.Add(new Album());

        }
        public void addAlbums(List<Album> _albums)
        {
            albums.AddRange(_albums);
        }

        //список песен подходящих по цене
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
                if (al.Price <= currentamount)
                {
                    if (albumname == null)
                    {
                        songs.AddRange(al.Songs);
                    }
                    else if(albumname == al.Name)
                    {
                        foreach (Song c in al.Songs)
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
                    if (c.Name != songname)
                    {
                        songs.Remove(c);
                    }
                }
            }

            if (genre != null)
            {
                foreach (Song c in songs)
                {
                    if (c.Genre != genre)
                    {
                        songs.Remove(c);
                    }
                }
            }

            if (singer != null)
            {
                foreach (Song c in songs)
                {
                    if (c.Singer != singer)
                    {
                        songs.Remove(c);
                    }
                }
            }


            return songs;
        }
        
        public void getSongs(Machine jukebox)
        {
            foreach (Album al in albums)
            {
                foreach( Song s in al.Songs)
                {

                }
            }
        }

    }
}
