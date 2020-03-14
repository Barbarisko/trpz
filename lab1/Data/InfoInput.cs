using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace lab1
{
    class InfoInput
    {
        public static void getAlbums(Machine jukebox, Album album)
        {
            string path = @"info.txt";
            string text = File.ReadAllText(path);
            string[] alArr = text.Split(' ', '\n');

            for (int i = 0; i <= alArr.Length - 1; i = i+6)
            {
                 album = new Album() { Name = alArr[i + 1], Songs = new List<Song>(), Price = Convert.ToDecimal(alArr[i + 3]), Releasedate = alArr[i + 5] };

                string pathToSongs = $"{album.Name}.txt";

                if (File.Exists(pathToSongs))
                {
                    using (StreamReader sr = new StreamReader(pathToSongs))
                    {
                        string[] songArr = sr.ReadToEnd().Split(' ');
                        for (int j = 0; j <= songArr.Length-1; j = j + 8)
                        {
                            album.Songs.Add(new Song() { Name = songArr[j + 1], Duration = Convert.ToDecimal(songArr[j + 3]), Genre = songArr[j + 5], Singer = songArr[j + 7] });

                        }
                    }
                }

                jukebox.addAlbums(album);
                
            }

            
        }


    }
}