using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Repository_Method
{
    class ShowRepository
    {
        private List<Show> showList;

        public ShowRepository(Person person)
        {
            showList = person.Playlist;
        }

        public List<Show> GetShows()
        {
            return showList;
        }

        public void AddShowToList(Show show)
        {
            showList.Add(show);
        }
    }
}
