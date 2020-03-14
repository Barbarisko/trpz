using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    [System.Runtime.Serialization.DataContract]
    class Album
    {
        [System.Runtime.Serialization.DataMember]
        private string name;
        [System.Runtime.Serialization.DataMember]
        private List<Song> songs;
        [System.Runtime.Serialization.DataMember]

        private string releasedate;
        [System.Runtime.Serialization.DataMember]

        private decimal price;

        public string Name { get { return name; } set { name = value; } }
        public string Releasedate { get { return releasedate; } set { releasedate = value; } }
        public decimal Price { get { return price; } set { price = value; } }
        public List<Song> Songs { get { return songs; } set { songs = value; } }

    }
}
