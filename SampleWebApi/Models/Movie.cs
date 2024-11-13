namespace SampleWebApi.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required int Year { get; set; }
    }
}
