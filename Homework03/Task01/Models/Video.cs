namespace Task01.Models
{
    public abstract class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }

        public Video(int id, string title, DateTime releaseDate)
        {
            Id = id;
            Title = title;
            ReleaseDate = releaseDate;
        }
    }
}
