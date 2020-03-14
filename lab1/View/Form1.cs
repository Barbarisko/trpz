using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        Machine jukebox;
        List<Song> sorted;

        public Form1()
        {
            InitializeComponent();
            jukebox = new Machine();
            string jsonpath = @"TestSong.json";
            SerializeJson serializeJson = new SerializeJson(typeof(Machine));
            jukebox = (Machine)serializeJson.Deserialize(jsonpath);

            //jukebox.addAlbums()

            foreach (Album al in jukebox.albums)
            {
                listBox1.Items.Add(al.Name);

               foreach (Song s in al.Songs)
               {
                    
                    listBox2.Items.Add(s.Singer);
                    listBox3.Items.Add(s.Genre);

                    for (int i = 0; i < listBox2.Items.Count - 1; i++)
                    {
                        for (int j = 1; j < listBox2.Items.Count - 1; j++)
                        {
                            if (listBox2.Items[i].ToString() == listBox2.Items[j].ToString())
                            {
                                listBox2.Items.Remove(i);

                            }
                        }
                    }
                }

            }

            //serializeJson.Serialize(jukebox.albums[0].Songs[0], jsonpath);
            serializeJson.Serialize(jukebox, jsonpath);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(textBox1.Text == "")
            {
               MessageBox.Show("input money");
               return;
            }
           sorted = jukebox.findSortedListOfSongs(Convert.ToString(listBox1.SelectedItem), Convert.ToString(listBox2.SelectedItem), Convert.ToString(listBox3.SelectedItem), Convert.ToDecimal(textBox1.Text));

            listBox4.Items.Clear();
            foreach ( Song i in sorted)
           {
                listBox4.Items.Add(i.Name);
           }
            listBox1.SelectedIndex = -1;
            listBox2.SelectedIndex = -1;
            listBox3.SelectedIndex = -1;
        }
    }
}
