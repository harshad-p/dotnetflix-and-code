using Microsoft.AspNetCore.Mvc;
using SampleWebApi.Models;
using SampleWebApi.Models.Request;

namespace SampleWebApi.Controllers
{
    [Route("api/movies")]
    [ApiController]
    public class MoviesApiController : ControllerBase
    {
        private static readonly HashSet<Movie> _movies = new HashSet<Movie>
        {
            new Movie{ Id = 1, Name = "Terminator", Year = 1984 },
            new Movie{ Id = 2, Name = "True Lies", Year = 1994 }
        };

        /// <summary>
        /// This is the HttpGet method which is intended to be accessed as: 
        /// ~/api/movies
        /// 
        /// If the name is just Get(), the request will be mapped correctly. 
        /// But if the name is different, then the route can be defiend by using the [HttpGet] attribute. 
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "GetAllTheMovies")]
        //[HttpGet]
        public IActionResult Get()
        {
            var getMoviesResponse = new GetMoviesResponse(_movies);

            return Ok(getMoviesResponse.GetMoviesResponses);
        }

        // Without this route, the api cannot differentiate between the 2 Get methods. 
        // Even if they are overloaded. 
        // You will get - AmbiguousMatchException: The request matched multiple endpoints. 
        // The name can be something out of convention. As long as the route that you defined, 
        // the request will be mapped correctly. 
        [HttpGet("{id}", Name = "GetById")]
        public IActionResult GetById(int id)
        {
            var movie = _movies.SingleOrDefault(x => x.Id == id);
            if (movie == null)
            {
                return NotFound("Movie does not exist.");
            }
            var getMovieResponse = new GetMovieResponse(movie);
            return Ok(getMovieResponse);
        }

        [HttpPost]
        public IActionResult AddMovie(AddMovieRequest addMovieRequest)
        {
            var id = _movies.Max(x => x.Id) + 1;
            var movie = addMovieRequest.ToMovie(id);
            _movies.Add(movie);
            return Created("/api/movies/", id);
        }


    }
}
