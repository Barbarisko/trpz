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
            string jsonpath = @"TestSong.json";

            jukebox = new Machine(jsonpath);


            //jukebox.addAlbums()
            fillListBoxes();

            jukebox.saveToFile(jsonpath);
        }

        private void fillListBoxes()
        {
            foreach (Album al in jukebox.albums)
            {
                listBox1.Items.Add(al.Name);

                foreach (Song s in al.Songs)
                {
                    if (!listBox2.Items.Contains(s.Singer))
                    {
                        listBox2.Items.Add(s.Singer);

                    }
                    if (!listBox3.Items.Contains(s.Genre))
                    {
                        listBox3.Items.Add(s.Genre);
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(numericUpDown1.Value <= 0)
            {
               MessageBox.Show("input money");
               return;
            }

           sorted = jukebox.findSortedListOfSongs(Convert.ToString(listBox1.SelectedItem), Convert.ToString(listBox2.SelectedItem), Convert.ToString(listBox3.SelectedItem), numericUpDown1.Value);

            listBox4.Items.Clear();
            foreach ( Song i in sorted)
           {
                listBox4.Items.Add(i.Name);
           }
            listBox1.SelectedIndex = -1;
            listBox2.SelectedIndex = -1;
            listBox3.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox4.SelectedIndex == -1) MessageBox.Show("zhepa? ty ne vibral song");
            else
            {
                Song selected = sorted[listBox4.SelectedIndex];
                foreach (Album al in jukebox.albums)
                {
                    if (al.Songs.Contains(selected))
                    {
                        numericUpDown1.Value -= numericUpDown1.Value - al.Price;
                    }
                }
                MessageBox.Show(selected.Name + " is now igraet");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
