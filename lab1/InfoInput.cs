using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace lab1
{
    class InfoInput
    {


        public static void getAlbums(Machine jukebox)
        {
            string path = @"info.txt";
            string text = File.ReadAllText(path);
            string[] alArr = text.Split(' ', '\n');

            for (int i= 0; i< alArr.Length; i++)
            {
                Album album = new Album() { Name = alArr[i + 1], Songs = new List<Song>(), Price = Convert.ToDecimal(alArr[i + 3]), Releasedate = alArr[i + 5] };
                string pathToSongs = $"{album.Name}.txt";

                if (File.Exists(pathToSongs))
                {
                    using (StreamReader sr = new StreamReader(pathToSongs))
                    {
                        string[] songArr = sr.ReadToEnd().Split(' ', '\n');
                        for(int j = 0; j< songArr.Length; j++)
                        {
                            album.Songs.Add(new Song() {Name = songArr[i+1], Duration = Convert.ToDecimal(songArr[i+3]), Genre = songArr[i+5], Singer = songArr[i+7] });
                            j = j + 8;
                        }
                    }
                }
                jukebox.addAlbums();
                i = 1 + 6;
            }
        }


    }
}