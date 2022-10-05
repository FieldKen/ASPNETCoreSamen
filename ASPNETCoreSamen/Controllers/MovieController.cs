﻿using ASPNETCoreSamen.Database;
using ASPNETCoreSamen.Domain;
using ASPNETCoreSamen.Models;
using ASPNETCoreSamen.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCoreSamen.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieService movieService;

        public MovieController(IMovieService movieService)
        {
            this.movieService = movieService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var vm = movieService.GetMovies().Select(m => new MovieListViewModel
            {
                Id = m.Id,
                Title = m.Title,
                Description = m.Description
            });

            return View(vm);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([FromForm] MovieCreateViewModel vm)
        {
            if (TryValidateModel(vm))
            {
                var movie = new Movie()
                {
                    Title = vm.Title,
                    Description = vm.Description,
                    Genre = vm.Genre,
                    Rating = vm.Rating
                };

                movieService.Insert(movie);
                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        [HttpGet]
        public IActionResult Detail([FromRoute] int id)
        {
            var movie = movieService.GetMovie(id);

            var vm = new MovieDetailViewModel
            {
                Title = movie.Title,
                Description = movie.Description,
                Genre = movie.Genre,
                Rating = movie.Rating
            };

            return View(vm);
        }
    }
}
