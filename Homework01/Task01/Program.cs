using System.Net;
using Models.Classes;

namespace Task01
{
    internal class Program
    {
        #region Task 01

        /*
         Task 1
           
           Write a program to create an interface Searchable with a method Search(string word) that searches for a given keyword in a text document.
        Create two classes Document and WebPage that implement the Searchable interface and provide their own implementations of the Search() method.
        */

        #endregion
        static void Main(string[] args)
        {
            string lineToPrint = new string('-', 50);
            string inputWebPage = "";
            string webpage = "";
            string document = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." +
                              "In hac habitasse platea dictumst vestibulum rhoncus est pellentesque." +
                              "Tristique risus nec feugiat in fermentum posuere urna nec tincidunt." +
                              "Et netus et malesuada fames ac turpis egestas integer. Odio aenean sed adipiscing diam donec." +
                              "Pellentesque eu tincidunt tortor aliquam nulla facilisi cras. Accumsan sit amet nulla facilisi morbi tempus." +
                              "Tempor id eu nisl nunc mi ipsum. Penatibus et magnis dis parturient montes nascetur." +
                              "Viverra tellus in hac habitasse platea dictumst. Ac turpis egestas integer eget aliquet." +
                              "Sagittis eu volutpat odio facilisis mauris sit amet. Erat velit scelerisque in dictum non consectetur." +
                              "Ullamcorper morbi tincidunt ornare massa eget egestas purus viverra. Nibh sit amet commodo nulla." +
                              "Sollicitudin nibh sit amet commodo. Quis lectus nulla at volutpat diam ut venenatis." +
                              "Egestas pretium aenean pharetra magna.";
            while (true)
            {
                try
                {

                    Console.WriteLine("Enter webpage in form _______.com");
                    inputWebPage = $"https://{Console.ReadLine()}";

                    //https://stackoverflow.com/questions/924679/c-sharp-how-can-i-check-if-a-url-exists-is-valid
                    var request = WebRequest.Create(inputWebPage) as HttpWebRequest;
                    request.Method = "GET";
                    var response = (HttpWebResponse)request.GetResponse();

                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        request.Method = "GET";
                        var streamReader = new StreamReader(response.GetResponseStream());
                        webpage = streamReader.ReadToEnd();
                        streamReader.Close();
                        response.Close();
                        break;
                    }

                    throw new Exception("Error, try again.");

                }
                catch
                {
                    //Any exception will returns false.
                    Console.WriteLine("Wrong url provided!");
                }

            }
            Console.WriteLine("Enter word to search:");
            string word = Console.ReadLine();

            var webpage1 = new WebPage(webpage.ToLower());
            Console.WriteLine($"\n{lineToPrint}");
            Console.WriteLine($"Webpage to search: {inputWebPage}");
            Console.WriteLine($"{lineToPrint}\n");
            Console.WriteLine(webpage1.Search(word.ToLower()));

            var document1 = new Document(document.ToLower());
            Console.WriteLine($"\n{lineToPrint}");
            Console.WriteLine($"Document to search: {document}");
            Console.WriteLine($"{lineToPrint}\n");
            Console.WriteLine(document1.Search(word.ToLower()));

        }
    }
}
