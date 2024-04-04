namespace Task01.Models
{
    public class PrintInConsole
    {
        public static string Print<T>(List<T> obj) where T : Video
        {
            string result = string.Empty;
            foreach (var item in obj)
            {
                result += $"{item.Title} - {item.ReleaseDate}\n";
            }
            return result;
        }

        public static List<T> PrintCollection<T>(List<T> list) where T : Video
        {
            List<T> result = list.Where(x => x.ReleaseDate.Year > DateTime.Parse("05/11/2000").Year).ToList();
            return result;
        }
    }
}
 