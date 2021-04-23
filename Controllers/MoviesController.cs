using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using EF_LAb.Helpers;
using EF_LAb.Manager.Interfaces;
using EF_LAb.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EF_LAb.Controllers
{
    public class MoviesController : Controller
    {
        private IMovieManager _movieManager;
        private ICountryManager _countryManager;
        private IDirectorManager _directorManager;
        private IActorManager _actorManager;
        private IGenreManager _genreManager;

        public MoviesController(IMovieManager movieManager, 
            ICountryManager countryManager, 
            IDirectorManager directorManager, 
            IActorManager actorManager,
            IGenreManager genreManager)
        {
            _movieManager = movieManager;
            _countryManager = countryManager;
            _directorManager = directorManager;
            _actorManager = actorManager;
            _genreManager = genreManager;
        }

        #region Index
        [HttpGet]
        public async Task<ViewResult> Index()
        {

            List<Movie> movies = await _movieManager.GetMoviesAll();


            return View(movies);
        }
        #endregion

        #region Search
        [HttpGet]
        public async Task<ViewResult> Search(string q, string target)
        {
            List<Movie> movies;

            if (target == "Name") {
               movies = await _movieManager.SearchMoviesByName(q);
            } else
            {
                movies = await _movieManager.SearchMoviesByYear(Int32.Parse(q));
            }
            
            return View(movies);
        }
        #endregion

        #region Show
        [HttpGet]
        public async Task<ViewResult> Show(int Id)
        {
            Movie movie = await _movieManager.GetMovie(Id);
            //System.Diagnostics.Debug.WriteLine("Actor: " + actor.ToString());
            return View(movie);
        }
        #endregion

        #region Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(Movie movie, string DirectorName, string CountryName)
        {
            // два одновременных таска (сделать позже)
            Country country = await _countryManager.GetCountryByName(CountryName);
            if (country == null)
            {
                country = await _countryManager.AddCountry(new Country { Name = CountryName });
            }

            Director director = await _directorManager.GetDirectorByName(DirectorName);
            if (director == null)
            {
                director = await _directorManager.AddDirector(new Director { Name = DirectorName });
            }

            movie.Country = country;
            movie.Director = director;

            Movie mv = await _movieManager.AddMovie(movie);

            return RedirectToAction("Show", "Movies", new { Id = mv.Id });

        }
        #endregion

        #region Update
        [HttpGet]
        public async Task<ViewResult> Update(int Id)
        {
            Movie movie = await _movieManager.GetMovie(Id);

            return View(movie);
        }

        [HttpPost]
        public async Task<ActionResult> Update(Movie movie, string CountryName, string DirectorName)
        {
            // два одновременных таска (сделать позже)
            Country country = await _countryManager.GetCountryByName(CountryName);
            if (country == null)
            {
                country = await _countryManager.AddCountry(new Country { Name = CountryName });
            }

            Director director = await _directorManager.GetDirectorByName(DirectorName);
            if (director == null)
            {
                director = await _directorManager.AddDirector(new Director { Name = DirectorName });
            }

            movie.Country = country;
            movie.Director = director;

            Movie mv = await _movieManager.EditMovie(movie);

            return RedirectToAction("Show", "Movies", new { Id = mv.Id });

        }
        #endregion

        #region Delete
        [HttpPost]
        public async Task<ActionResult> Delete(int Id)
        {
            Movie mv = await _movieManager.RemoveMovie(Id);

            return RedirectToAction("Index", "Movies");

        }
        #endregion

        
        #region AddActorToMovie
        [HttpPost]
        public async Task<ActionResult> AddActorToMovie(string ActorName, int MovieId)
        {
            Actor actor = await _actorManager.GetActorByName(ActorName);
            if(actor == null)
            {
                actor = await _actorManager.AddActor(new Actor { Name = ActorName });
            }

            Movie mv = await _movieManager.AddActorToMovie(actor, MovieId);

            return RedirectToAction("Show", "Movies", new { Id = mv.Id });

        }
        #endregion

        #region RemoveActorFromMovie
        [HttpPost]
        public async Task<ActionResult> RemoveActorFromMovie(int ActorId, int MovieId)
        {
            Movie mv = await _movieManager.RemoveActorFromMovie(ActorId, MovieId);

            return RedirectToAction("Show", "Movies", new { Id = mv.Id });

        }
        #endregion

        #region AddGenreToMovie
        [HttpPost]
        public async Task<ActionResult> AddGenreToMovie(string GenreName, int MovieId)
        {
            Genre genre = await _genreManager.GetGenreByName(GenreName);
            if (genre == null)
            {
                genre = await _genreManager.AddGenre(new Genre { Name = GenreName });
            }

            Movie mv = await _movieManager.AddGenreToMovie(genre, MovieId);

            return RedirectToAction("Show", "Movies", new { Id = mv.Id });

        }
        #endregion

        #region RemoveGenreFromMovie
        [HttpPost]
        public async Task<ActionResult> RemoveGenreFromMovie(int GenreId, int MovieId)
        {
            Movie mv = await _movieManager.RemoveGenreFromMovie(GenreId, MovieId);

            return RedirectToAction("Show", "Movies", new { Id = mv.Id });

        }
        #endregion
    }
}
