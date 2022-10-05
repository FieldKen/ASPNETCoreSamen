using ASPNETCoreSamen.Database;
using ASPNETCoreSamen.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCoreSamen.Controllers
{
	public class MovieController : Controller
	{
		private readonly IMovieDatabase movieDatabase;

		public MovieController(IMovieDatabase movieDatabase)
		{
			this.movieDatabase = movieDatabase;	
		}

		public IActionResult Index()
		{
			var vm = movieDatabase.GetMovies().Select(m => new MovieListViewModel
			{
				Id = m.Id,
				Title = m.Title,
				Description = m.Description
			});

			return View(vm);
		}
	}
}
