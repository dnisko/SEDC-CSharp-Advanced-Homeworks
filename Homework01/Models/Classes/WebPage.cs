using Models.Interfaces;

namespace Models.Classes
{
    public class WebPage : ISearchable
    {
        public string Webpage { get; set; }

        public WebPage(string webpage)
        {
            Webpage = webpage;
        }
        public string Search(string word)
        {
            return Webpage.Contains(word) ? $"The word {word} was found in the webpage." : $"The word {word} was not found in the webpage.";
        }
    }
}
