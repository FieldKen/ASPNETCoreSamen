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

        public Movie Insert(Movie movie)
        {
            return movieDatabase.Insert(movie);
        }

        public Movie GetMovie(int id)
        {
            return movieDatabase.GetMovie(id);
        }

        public IEnumerable<Movie> GetMovies()
        {
            return movieDatabase.GetMovies();
        }

        public void Update(int id, Movie movie)
        {
            movieDatabase.Update(id, movie);
        }

        public void Delete(int id)
        {
            movieDatabase.Delete(id);
        }
    }
}
