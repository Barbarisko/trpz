using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    [System.Runtime.Serialization.DataContract]

    class Machine
    {
        [System.Runtime.Serialization.DataMember]
        public List<Album> albums;
     

        public Machine()
        {
            albums = new List<Album>();
        }
        public void addAlbums(Album album)
        {
            albums.Add(album);
        }
        public void addAlbums(List<Album> _albums)
        {
            albums.AddRange(_albums);
        }

        //список песен подходящих по цене
        public List<Song> findSortedListOfSongs( string albumname, string singer, string genre, decimal currentamount)
        {
            List<Song> songs = new List<Song>();
            if (currentamount <= 0)
            {
                MessageBox.Show("input money");
                return null;
            }

            if (singer == "" && genre == "" && albumname == "")
            {
                foreach (Album al in albums)
                {
                    if (al.Price <= currentamount)
                    {
                        foreach( Song s in al.Songs) songs.Add(s);
                    }
                }
                return songs;

            }

            foreach (Album al in albums)
            {
                if (al.Price <= currentamount)
                {
                    if (albumname == "")
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

                if (genre != "")
                {
                    songs.RemoveAll(Song => Song.Genre != genre);
                }
                if (singer != "")
                {
                    songs.RemoveAll(Song => Song.Singer != singer);   
                }
            }
            
          return songs;
        }

        
        
       public Machine loadFromFile(string path)
        {
            SerializeJson serializeJson = new SerializeJson(typeof(Machine));
            return (Machine)serializeJson.Deserialize(path);

        }

        public Machine(string path)
        {
            albums = loadFromFile(path).albums;
        }

        public void saveToFile(string path)
        {
            SerializeJson serializeJson = new SerializeJson(typeof(Machine));
            serializeJson.Serialize(this , path);
        }

        ~Machine()
        {
            saveToFile(@"StandartSaveFile.txt");
        }
    }
}
