using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Classes_Repository_Method
{
    enum ShowGenre { RomCom, Drama, Mystery}

    class Show
    {
        public string Title { get; set; }
        public int PlayTimeInMinutes { get; set; }
        public ShowGenre Genre { get; set; }

        public Show(string title, int playTime, ShowGenre genre)
        {
            Title = title;
            PlayTimeInMinutes = playTime;
            Genre = genre;
        }
        public Show() { }
    }
}
