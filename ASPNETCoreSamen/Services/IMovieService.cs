using ASPNETCoreSamen.Domain;

namespace ASPNETCoreSamen.Services
{
    public interface IMovieService
    {
        Movie Insert(Movie movie);
        Movie GetMovie(int id);
        IEnumerable<Movie> GetMovies();
        void Update(int id, Movie movie);
        void Delete(int id);
    }
}