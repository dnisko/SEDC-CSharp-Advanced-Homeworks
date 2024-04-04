namespace Task01.Models
{
    public class Series : Video
    {
        public DateTime EndDate { get; set; }
        public Series(int id, string title, DateTime releaseDate, DateTime endDate)
            : base(id, title, releaseDate)
        {
            EndDate = endDate;
        }
    }
}
