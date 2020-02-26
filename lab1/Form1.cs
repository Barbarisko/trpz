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
            listBox2.Items.Add(jukebox.albums[].Songs);// ??
            listBox3.Items.Add();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
