using ASPNETCoreSamen.Database;
using ASPNETCoreSamen.Domain;

namespace ASPNETCoreSamen.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieDatabase movieDatabase;

        public MovieService(IMovieDatabase movieDatabase)
        {
            this.movieDatabase = movieDatabase;
        }

        public void Insert(Movie movie)
        {
            movieDatabase.Insert(movie);
        }

        public Movie GetMovie(int id)
        {
            return movieDatabase.GetMovie(id);
        }

        public IEnumerable<Movie> GetMovies()
        {
            return movieDatabase.GetMovies();
        }
    }
}
