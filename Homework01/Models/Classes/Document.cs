using System.Security.Cryptography.X509Certificates;
using Models.Interfaces;

namespace Models.Classes
{
    public class Document : ISearchable
    {
        public string DocumentToRead { get; set; }

        public Document(string documentToRead)
        {
            DocumentToRead = documentToRead;
        }
        public string Search(string word)
        {
            return DocumentToRead.Contains(word)
                ? $"The word {word} was found in the document."
                : $"The word {word} was not found in the document.";
        }
    }
}
