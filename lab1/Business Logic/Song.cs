using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    [System.Runtime.Serialization.DataContract]
    class Song
    {
        [System.Runtime.Serialization.DataMember]
        private string name;
        [System.Runtime.Serialization.DataMember]
        private string genre;
        [System.Runtime.Serialization.DataMember]
        private string singer;
        [System.Runtime.Serialization.DataMember]
        private decimal duration;
    
        public string Name { get { return name; } set { name = value; } }
        public string Genre { get { return genre; } set { genre = value; } }
        public string Singer { get { return singer; } set { singer = value; } }
        public decimal Duration { get { return duration; } set { duration = value; } }

        public Song()
        {

        }
    }
}
