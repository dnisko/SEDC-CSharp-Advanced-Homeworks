using Task01.Models;

namespace Task01
{
    internal class Program
    {
        #region Task01

        /*
        Task 1
            Create class PrintInConsole that will have multiple methods to print in console.
        Print(), PrintCollection(). Make this methods to be valid for more than one type and reuse the implementation (hint: make them generic);
         */

        #endregion
        static void Main(string[] args)
        {
            var movie1 = new Movie(1, "The Matrix", new DateTime(1999, 03, 24), "Sci-Fi", new TimeSpan(2, 30, 0));
            var movie2 = new Movie(2, "The Godfather", new DateTime(1972, 03, 24), "Drama, Crime", new TimeSpan(2, 55, 0));
            var movies = new List<Movie> {movie1, movie2};

            var series1 = new Series(3, "3rd Rock From The Sun", new DateTime(1996, 01, 09), new DateTime(2001, 05, 22));
            var series2 = new Series(4, "Band of Brothers", new DateTime(2001, 09, 09), new DateTime(2001, 11, 04));
            var series = new List<Series> {series1, series2};

            Console.WriteLine("Printing movies from Print()");
            Console.WriteLine(PrintInConsole.Print(movies));
            Console.WriteLine("--------------------------");
            Console.WriteLine("Printing series from Print()");
            Console.WriteLine(PrintInConsole.Print(series));

            Console.WriteLine("--------------------------");

            var filteredMovies = PrintInConsole.PrintCollection(movies);
            Console.WriteLine("Printing movies from PrintCollection()");
            foreach (var movie in filteredMovies)
            {
                Console.WriteLine($"{movie.Id} - {movie.Title} ({movie.ReleaseDate})\n");
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine("Printing series from PrintCollection()");
            var filteredSeries = PrintInConsole.PrintCollection(series);
            foreach (var serie in filteredSeries)
            {
                Console.WriteLine($"{serie.Id} - {serie.Title} ({serie.ReleaseDate} - {serie.EndDate})\n");
            }
        }
    }
}
