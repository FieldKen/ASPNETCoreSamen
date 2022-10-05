using ASPNETCoreSamen.Domain;

namespace ASPNETCoreSamen.Services
{
    public interface IMovieService
    {
        void Insert(Movie movie);
        IEnumerable<Movie> GetMovies();
    }
}