using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Classes_Repository_Method
{
    class ShowRepository
    {
        private List<Show> showList;

        public ShowRepository()
        {
            PopulateList();
        }

        public void AddShowToList(Show show)
        {
            showList.Add(show);
        }

        public void RemoveShowFromList(Show show)
        {
            showList.Remove(show);
        }

        public List<Show> GetShowsByGenre(ShowGenre genre)
        {
            List<Show> genreShows = new List<Show>();
            foreach(Show show in showList)
            {
                if(show.Genre == genre)
                {
                    genreShows.Add(show);
                }
            }
            return genreShows;
        }

        public List<Show> GetShows()
        {
            return showList;
        }

        private void PopulateList()
        {
            showList = new List<Show>
            {
                new Show { Title = "The SketchBook", Genre = ShowGenre.Drama, PlayTimeInMinutes = 130 },
                new Show { Title = "Saving Wales", Genre = ShowGenre.Mystery, PlayTimeInMinutes = 435 },
                new Show { Title = "Teddy", Genre = ShowGenre.RomCom, PlayTimeInMinutes = 30 }
            };
        }
    }
}
