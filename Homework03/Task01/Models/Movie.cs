namespace Task01.Models
{
    public class Movie : Video
    {
        public string Genre { get; set; }
        public TimeSpan Length { get; set; }

        public Movie(int id, string title, DateTime releaseDate, string genre, TimeSpan length)
            : base(id, title, releaseDate)
        {
            Genre = genre;
            Length = length;
        }
    }
}
