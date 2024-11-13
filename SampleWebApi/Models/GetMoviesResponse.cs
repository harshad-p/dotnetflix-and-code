namespace SampleWebApi.Models
{
    public class GetMoviesResponse
    {
        public GetMoviesResponse()
        {
            GetMoviesResponses = new HashSet<GetMovieResponse>();
        }

        public GetMoviesResponse(IEnumerable<Movie> movies)
        {
            GetMoviesResponses = new HashSet<GetMovieResponse>();
            AddMovies(movies);
        }

        private void AddMovies(IEnumerable<Movie> movies)
        {
            foreach (var movie in movies)
            {
                GetMoviesResponses.Add(new GetMovieResponse(movie));
            }
        }

        public ICollection<GetMovieResponse> GetMoviesResponses { get; set; }
    }

    public class GetMovieResponse
    {
        public GetMovieResponse()
        {

        }

        public GetMovieResponse(Movie movie)
        {
            Id = movie.Id;
            Title = movie.Name;
            Year = movie.Year;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
    }
}
