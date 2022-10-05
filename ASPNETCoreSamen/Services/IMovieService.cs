using ASPNETCoreSamen.Domain;

namespace ASPNETCoreSamen.Services
{
    public interface IMovieService
    {
        void Insert(Movie movie);
        Movie GetMovie(int id);
        IEnumerable<Movie> GetMovies();
    }
}