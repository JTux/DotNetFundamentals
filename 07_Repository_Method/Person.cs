using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Repository_Method
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Show> Playlist { get; set; }
        public Person()
        {
            Playlist = new List<Show>();
        }
    }
}
