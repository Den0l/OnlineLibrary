using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLibrary.Model
{
    class Title
    {
        public Title(string name, string type, int duration, string genre, bool cheked)
        {
            Name = name;
            Type = type;
            Duration = duration;
            Genre = genre;
            Cheked = cheked;
        }

        public string Name { get; set; }
        public string Type { get; set; }
        public int Duration { get; set; }
        public string Genre { get; set; }
        public bool Cheked { get; set; }

        public Title()
        {

        }

    }
}
