namespace _07_Repository_Method_Example_01
{
    public class StreamingContent
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Rating { get; set; }
        public bool IsMature { get; set; }

        public StreamingContent(string title, string genre, int rating, bool isMature)
        {
            Title = title;
            Genre = genre;
            Rating = rating;
            IsMature = isMature;
        }

        public StreamingContent()
        {

        }
    }
}