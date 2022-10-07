using ASPNETCoreSamen.Domain;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCoreSamen.Database
{
	public class MovieSqlServerDatabase : IMovieDatabase
	{
        private DbSet<Movie> movies;
        private MovieDbContext movieDbContext;

        public MovieSqlServerDatabase(MovieDbContext movieDbContext)
        {
            this.movieDbContext = movieDbContext;
            movies = movieDbContext.Movies;
        }

        public void Delete(int id)
        {
            Movie movie = GetMovie(id);
            if (movie != null)
            {
                movies.Remove(movie);
            }
        }

        public Movie GetMovie(int id)
        {
            return movies.FirstOrDefault(m => m.Id == id);
        }

        public IEnumerable<Movie> GetMovies()
        {
            return movies;
        }

        public Movie Insert(Movie movie)
        {
            movies.Add(movie);
            return movie;
        }

        public void Update(int id, Movie movie)
        {
            Movie movieToUpdate = GetMovie(id);
            if (movieToUpdate != null)
            {
                movieToUpdate.Title = movie.Title;
                movieToUpdate.Description = movie.Description;
                movieToUpdate.Genre = movie.Genre;
                movieToUpdate.Rating = movie.Rating;
            }
        }
    }
}
