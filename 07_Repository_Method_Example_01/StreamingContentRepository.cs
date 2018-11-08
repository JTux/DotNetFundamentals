using System.Collections.Generic;

namespace _07_Repository_Method_Example_01
{
    public class StreamingContentRepository
    {
        List<StreamingContent> _listOfContent = new List<StreamingContent>();

        public void AddContentToList(StreamingContent content)
        {
            _listOfContent.Add(content);
        }

        public List<StreamingContent> GetContentList()
        {
            return _listOfContent;
        }
    }
}