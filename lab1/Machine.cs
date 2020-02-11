using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Machine
    {
        List<Disk> albums;
        Dictionary<string, string> SAPair = new Dictionary<string, string>();
        private int currenAmount;


        Dictionary<string, string> checkOnAlbum(string nameToSearch, float currentAmount)
        {
            foreach (Disk al in albums)
            {
                if (nameToSearch != "" && al.name == nameToSearch)
                {
                    if (currenAmount >= al.price)
                    {
                        currentAmount -= al.price;
                        foreach (Song c in al.songs)
                        {
                            SAPair.Add(c.name, al.name);
                            return SAPair;
                        }
                        
                    }
                    //else
                    //{
                    //    MessageBox.Show("You dont have enought money");
                    //}
                }
            }
            return SAPair;

        }

        public void addAlbums(string name, List<Song> songs, string releasedate, float price)
        {
            albums.Add(new Disk(name, songs, releasedate, price));

        }
    }
}
