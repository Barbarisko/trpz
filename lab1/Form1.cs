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
        public Form1()
        {
            InitializeComponent();
            jukebox = new Machine();
            InfoInput.getAlbums(jukebox);

            listBox1.Items.Add(jukebox.albums);

            foreach (Album al in jukebox.albums)
            {
                foreach (Song s in al.Songs)
                {

                    listBox2.Items.Add(s.Singer);

                    for (int i = 0; i < listBox2.Items.Count; i++)
                    {
                        for (int j = 1; j < listBox2.Items.Count; j++)
                        {

                            if (listBox2.Items[i].ToString() == listBox2.Items[j].ToString())
                            {
                                listBox2.Items.Remove(i);
                            }
                        }
                    }
                
                }

            }

            foreach (Album al in jukebox.albums)
            {
                foreach (Song s in al.Songs)
                {

                    listBox3.Items.Add(s.Genre);

                    for (int i = 0; i < listBox3.Items.Count; i++)
                    {
                        for (int j = 1; j < listBox3.Items.Count; j++)
                        {

                            if (listBox3.Items[i].ToString() == listBox3.Items[j].ToString())
                            {
                                listBox3.Items.Remove(i);
                            }
                        }
                    }

                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text;
            foreach (Album al in jukebox.albums)
            {
                foreach (Song s in al.Songs)
                {
                     text = Convert.ToString(jukebox.findSortedListOfSongs(s.Name, al.Name, s.Singer, s.Genre, Convert.ToDecimal(textBox1.Text)));
                    MessageBox.Show(text);
                }
            }

        }
    }
}
