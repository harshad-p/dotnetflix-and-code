namespace SampleWebApi.Models.Request
{
    public class AddMovieRequest
    {
        public string Title { get; set; }
        public int Year { get; set; }

        public Movie ToMovie()
        {
            return new Movie { Name = Title, Year = Year };
        }

        public Movie ToMovie(int id)
        {
            return new Movie { Id = id, Name = Title, Year = Year };
        }

    }
}