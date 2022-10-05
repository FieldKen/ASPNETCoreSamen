using ASPNETCoreSamen.Domain;

namespace ASPNETCoreSamen.Database
{
	public interface IMovieDatabase
	{
		Movie Insert(Movie movie);
		Movie GetMovie(int id);
		IEnumerable<Movie> GetMovies();
		void Update(int id, Movie movie);
		void Delete(int id);
	}
}
