using ASPNETCoreSamen.Domain;

namespace ASPNETCoreSamen.Database
{
	public class MovieSqlServerDatabase : IMovieDatabase
	{
        private MovieDbContext movieDbContext;

        public MovieSqlServerDatabase(MovieDbContext movieDbContext)
        {
            this.movieDbContext = movieDbContext;
        }

        public void Delete(int id)
        {
            Movie movie = GetMovie(id);
            if (movie != null)
            {
                movieDbContext.Movies.Remove(movie);
                movieDbContext.SaveChanges();
            }
        }

        public Movie GetMovie(int id)
        {
            return movieDbContext.Movies.FirstOrDefault(m => m.Id == id);
        }

        public IEnumerable<Movie> GetMovies()
        {
            return movieDbContext.Movies;
        }

        public Movie Insert(Movie movie)
        {
            movieDbContext.Movies.Add(movie);
            movieDbContext.SaveChanges();
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
            movieDbContext.SaveChanges();
        }
    }
}
