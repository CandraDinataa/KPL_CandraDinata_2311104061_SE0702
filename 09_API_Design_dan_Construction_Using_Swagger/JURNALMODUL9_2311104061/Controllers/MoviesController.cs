using JURNALMODUL9_2311104061.Models;
using Microsoft.AspNetCore.Mvc;


namespace modul9_NIM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private static List<Movie> movies = new List<Movie>
        {
            new Movie
            {
                Title = "The Shawshank Redemption",
                Director = "Frank Darabont",
                Stars = new List<string> { "Tim Robbins", "Morgan Freeman", "Bob Gunton" },
                Description = "Two imprisoned men bond over a number of years."
            },
            new Movie
            {
                Title = "The Godfather",
                Director = "Francis Ford Coppola",
                Stars = new List<string> { "Marlon Brando", "Al Pacino", "James Caan" },
                Description = "The aging patriarch of an organized crime dynasty transfers control to his reluctant son."
            },
            new Movie
            {
                Title = "The Dark Knight",
                Director = "Christopher Nolan",
                Stars = new List<string> { "Christian Bale", "Heath Ledger", "Aaron Eckhart" },
                Description = "When the menace known as the Joker wreaks havoc, Batman must accept one of the greatest psychological and physical tests."
            }
        };

        // GET: api/Movies
        [HttpGet]
        public ActionResult<IEnumerable<Movie>> GetMovies()
        {
            return movies;
        }

        // GET: api/Movies/1
        [HttpGet("{id}")]
        public ActionResult<Movie> GetMovie(int id)
        {
            if (id < 0 || id >= movies.Count)
                return NotFound();

            return movies[id];
        }

        // POST: api/Movies
        [HttpPost]
        public ActionResult<Movie> PostMovie(Movie movie)
        {
            movies.Add(movie);
            return CreatedAtAction(nameof(GetMovie), new { id = movies.Count - 1 }, movie);
        }

        // DELETE: api/Movies/1
        [HttpDelete("{id}")]
        public IActionResult DeleteMovie(int id)
        {
            if (id < 0 || id >= movies.Count)
                return NotFound();

            movies.RemoveAt(id);
            return NoContent();
        }
    }
}
