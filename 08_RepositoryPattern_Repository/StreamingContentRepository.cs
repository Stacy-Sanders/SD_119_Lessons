using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_RepositoryPattern_Repository
{
    // This is our fake database
    public class StreamingContentRepository
    {
        // private means only accessible in this class
        // protected is like private+ - it includes derived/child/inherited classes
        protected readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();

        // Create
        public bool AddContentToDirectory(StreamingContent content)
        {
            int startingCount = _contentDirectory.Count;
            _contentDirectory.Add(content);

            // we need to check to see if this works
            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }
        // Read
        public List<StreamingContent> GetAllContents()
        {
            return _contentDirectory;
        }
        public List<StreamingContent> GetAllContentByGenre(GenreType genreType)
        {
            // make a variable that will hold all of the "found" items
            List<StreamingContent> foundContent = new List<StreamingContent>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.TypeOfGenre == genreType)
                {
                    foundContent.Add(content);
                }
            }
            return foundContent;

            // return _contentDirectory.Where(cd => cd.TypeofGenre == genreType).ToList();
        }

        // CHALLENGE:
        // Make a GetFamilyFriendlyContents() method

        public List<StreamingContent> GetAllFamilyFriendlyContents()
        {
            List<StreamingContent> foundContent = new List<StreamingContent>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.IsFamilyFriendly == true)
                {
                    foundContent.Add(content);
                }
            }
            return foundContent;
        }



        // Andrew's answer

        public List<StreamingContent> GetFamilyFriendlyContents()
        {
            List<StreamingContent> familyFriendlyContents = new List<StreamingContent>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.IsFamilyFriendly)
                {
                    familyFriendlyContents.Add(content);
                }
            }
            return familyFriendlyContents;
        }








            // Read(unique identifier)
            // Helper method
            public StreamingContent GetContentByTitle(string title)
            {
                foreach (StreamingContent content in _contentDirectory)
                {
                    if (content.Title.ToLower() == title.ToLower())
                    {
                        return content;
                    }
                }
                // If it gets here and hasn't found anything...
                return null;

                // return _contentDirectory.FirstOrDefault(sc => sc.Title == title);
            }
            // Update
            public bool UpdateExistingContent(string originalTitle, StreamingContent content)
            {
                // find the old content...
                StreamingContent oldContent = GetContentByTitle(originalTitle);

                if (oldContent != null)
                {
                    oldContent.Title = content.Title;
                    oldContent.Description = content.Description;
                    oldContent.StarRating = content.StarRating;
                    oldContent.MaturityRating = content.MaturityRating;
                    oldContent.TypeOfGenre = content.TypeOfGenre;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            // Delete
            public bool DeleteExistingContent(StreamingContent existingContent)
            {
                bool deleteResult = _contentDirectory.Remove(existingContent);
                return deleteResult;
            }
    }
}





       
