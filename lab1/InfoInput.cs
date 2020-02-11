using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace lab1
{
    class InfoInput
    {
        Machine machine = new Machine();

        public static void getAlbums(Machine machine)
        {
            string path = @"info.txt";
            string text = File.ReadAllText(path);
            string[] alArr = text.Split(',');
            foreach (string i in alArr)
            {
                machine.addAlbums(i);
            }
        }
    }
}