using ASPNETCoreSamen.Domain;

namespace ASPNETCoreSamen.Database
{
	public class MovieDatabase : IMovieDatabase
	{
		private int counter = 0;
		private List<Movie> movies;

		public MovieDatabase()
		{
			movies = new List<Movie>();

            Insert(new Movie
            {
                Title = "The Hunger Games",
                Description = "Battle royale copy",
                Genre = "Young Adult Fiction",
                Rating = 9
            });

            Insert(new Movie
            {
                Title = "Interstellar",
                Description = "HUH",
                Genre = "Science Fiction",
                Rating = 10
            });

            Insert(new Movie
            {
                Title = "The Avengers",
                Description = "Goeie cosplay",
                Genre = "Action",
                Rating = 8
            });
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
			movie.Id = ++counter;
			movies.Add(movie);
			return movie;
		}

		public void Update(int id, Movie movie)
		{
			//AUTOMAPPER D:
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
