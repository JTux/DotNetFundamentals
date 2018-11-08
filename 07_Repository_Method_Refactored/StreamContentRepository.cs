using System.Collections.Generic;

namespace _07_Repository_Method_Refactored
{
    public class StreamContentRepository
    {
        private List<StreamContent> _showList;

        public StreamContentRepository(User person)
        {
            _showList = person.Playlist;
        }

        public List<StreamContent> GetShows()
        {
            return _showList;
        }

        public void AddShowToList(StreamContent show)
        {
            _showList.Add(show);
        }
    }
}