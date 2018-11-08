using System.Collections.Generic;

namespace _07_Repository_Method_Refactored
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<StreamContent> Playlist { get; set; }
        public User()
        {
            Playlist = new List<StreamContent>();
        }
    }
}