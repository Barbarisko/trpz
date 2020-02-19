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
            jukebox.addAlbums(getAlbumsFromFile());

        }
    }
}
